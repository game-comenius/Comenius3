using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MomentoInteracao", menuName = "Comenius3/MomentoInteracao", order = 0)]
public class MomentoInteracao : ScriptableObject
{
    public List<NomeDeMidia> midias;
    public PaginaInteracao[] paginas;
    public CelulaReference opcoesDeEscolha;
    public int paginaDoDropdown = -1;
    public bool alunoFeliz;
    public string reacaoPositiva;
    public string reacaoNegativa;

    [Header("Usado apenas na ABProj")]
    public LocationChecker.Location lugar;

    public static List<MomentoInteracao> momentos { get; private set; }

    public static MomentoInteracao GetMomentFromArchives()
    {
        if (momentos == null)
        {
            momentos = new List<MomentoInteracao>(Resources.LoadAll<MomentoInteracao>("MomentosInteracao/GeradosPelaPlanilha"));
            if (momentos == null)
                Debug.LogError("Gere os momentos de novo no menu Ferramentas/GerarMomentosDaPlanilha");
        }

        // Pega um momento gerado pela da planilha
        return momentos[Random.Range(0, momentos.Count)];
    }

    public static MomentoInteracao GetMomentFromArchives(NomeDeMidia midia)
    {
        if (momentos == null)
        {
            momentos = new List<MomentoInteracao>(Resources.LoadAll<MomentoInteracao>("MomentosInteracao/GeradosPelaPlanilha"));
            if (momentos == null)
                Debug.LogError("Gere os momentos denovo no menu Ferramentas/GerarMomentosDaPlanilha");
        }

        foreach (MomentoInteracao momento in momentos)
        {
            foreach (NomeDeMidia _midia in momento.midias)
            {
                if (_midia == midia)
                    return momento;
            }
        }
        return GetMomentFromArchives();
    }
}

[System.Serializable]
public class PaginaInteracao
{
    [HideInInspector]
    public string titulo
    {
        get
        {
            if (professorFalando)
                return "Professor";
            else
                return "Estudante";
        }
    }

    public CelulaReference texto;

    public bool professorFalando;  // Se for falso o aluno esta falando
}