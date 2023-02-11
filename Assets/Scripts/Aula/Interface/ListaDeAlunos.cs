using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ListaDeAlunos : ScriptableObject
{
    public List<Aluno> alunos;
    public List<Aluno> alunosRepitidos;
    public int alunoSorteado;
    public Aluno GetAluno()
    {
        alunoSorteado = Random.Range(0, alunos.Count);
        if(alunosRepitidos.Count > 0)
        {
            for (int i = 0; i < alunosRepitidos.Count; i++)
            {
                if (alunoSorteado == i)
                {
                    alunoSorteado = Random.Range(0, alunos.Count);
                }
            }
        }
 
        alunosRepitidos.Add(alunos[alunoSorteado]);
        return alunos[alunoSorteado];
    }
    /*
    public void RemoverAluno()
    {
       
    }
    private IEnumerator RemoveAluno(Aluno alunoRemovido)
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);
            alunos.Remove(alunos[alunoParaRemover]);
        }
    }
    */
}

[System.Serializable]
public class Aluno
{
    public Sprite alunoFeliz;
    public Sprite alunoTriste;
}