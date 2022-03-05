using UnityEngine;


public class DisplayDeAluno : MonoBehaviour
{
    [SerializeField] ListaDeAlunos alunos;
    [SerializeField] bool atualizaOnStart;
    [SerializeField] GameObject icone;
    public bool estaFeliz;
    [SerializeField] bool usaOutroDeReferencia;
    [SerializeField] DisplayDeAluno outroDisplayRefencia;

    [HideInInspector]
    public Aluno aluno;

    private void Start()
    {
        if (atualizaOnStart)
        {
            AtualizarAluno();
        }
    }

    public void AtualizarAluno()
    {
        if (!usaOutroDeReferencia)
            aluno = alunos.GetAluno();
        else
            aluno = outroDisplayRefencia.aluno;
        AtualizarDisplay();
    }

    public void AtualizarDisplay()
    {
        icone.GetComponent<SpriteRenderer>().sprite = estaFeliz ? aluno.alunoFeliz : aluno.alunoTriste;
    }
}
