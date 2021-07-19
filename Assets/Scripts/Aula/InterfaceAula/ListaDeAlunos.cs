using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName = "ListaAlunos", menuName = "Comenius3/ListaDeAlunos", order = 0)]
public class ListaDeAlunos : ScriptableObject
{
    public List<Aluno> alunos;

    public Aluno GetAluno()
    {
        return alunos[Random.Range(0, alunos.Count)];
    }
}

[System.Serializable]
public class Aluno
{
    public Sprite alunoFeliz;
    public Sprite alunoTriste;
}