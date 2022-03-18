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

    private Image image;

    private void OnValidate()
    {
        image = GetComponent<Image>();
    }

    private void Start()
    {
        image = GetComponent<Image>();

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
        image.sprite = estaFeliz ? aluno.alunoFeliz : aluno.alunoTriste;
    }
}
