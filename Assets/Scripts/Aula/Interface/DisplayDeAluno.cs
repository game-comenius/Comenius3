using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Image))]
public class DisplayDeAluno : MonoBehaviour
{
    public bool estaFeliz;

    [HideInInspector] public Aluno aluno;

    [SerializeField] private ListaDeAlunos alunos;
    [SerializeField] private bool atualizaOnStart;
    [SerializeField] private bool usaOutroDeReferencia;
    [SerializeField] private DisplayDeAluno outroDisplayRefencia;

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
        GetComponent<Image>().sprite = estaFeliz ? aluno.alunoFeliz : aluno.alunoTriste;
    }
}
