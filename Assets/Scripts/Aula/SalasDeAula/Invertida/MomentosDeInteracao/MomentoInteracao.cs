using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "MomentoInteracao", menuName = "Comenius3/MomentoInteracao", order = 0)]
public class MomentoInteracao : ScriptableObject
{
    public PaginaInteracao[] paginas;
    public CelulaReference opcoesDeEscolha;

    public static List<MomentoInteracao> momentos { get; private set; }

    public static MomentoInteracao GetRamdomMomentoFromArquives()
    {

        if(momentos == null)
        {
            momentos = new List<MomentoInteracao>(Resources.LoadAll<MomentoInteracao>("MomentosInteracao/GeradosPelaPlanilha"));
            if (momentos == null)
                Debug.LogError("Gere os momentos denovo no menu Ferramentas/GerarMomentosDaPlanilha");
        }

        //Pega um momento gerado pela da planilha
        return momentos[Random.Range(0, momentos.Count)];
    }
}

[System.Serializable]
public class PaginaInteracao 
{
    [HideInInspector]public string titulo {
        get {
            if(professorFalando)
                return "Professor";
            else
                return "Aluno";
        }
    }

    public CelulaReference texto;

    public bool professorFalando; //Se for falso o aluno esta falando
}