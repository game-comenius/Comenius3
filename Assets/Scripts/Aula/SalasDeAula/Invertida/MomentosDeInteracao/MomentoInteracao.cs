using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "MomentoInteracao", menuName = "Comenius3/MomentoInteracao", order = 0)]
public class MomentoInteracao : ScriptableObject
{
    public PaginaInteracao[] paginas;
    public CelulaReference opcoesDeEscolha;

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