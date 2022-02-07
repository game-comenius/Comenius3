using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Events;

public class ControladorFeedbackAulaInvertida : MonoBehaviour
{

    public UnityEvent OnUpdate;

    [Header("GameObjects dos previews")]
    [SerializeField] GameObject feedbackAulaInvertidaLurdinhaTexto;
    [SerializeField] GameObject feedbackAulaInvertidaAlunoTexto;
    [SerializeField] GameObject feedbackAulaInvertidaAlunoNome;

    [Header("Retratos dos alunos")]
    [SerializeField] GameObject retratoAluno;
    [SerializeField] Sprite retratoMenino1;
    [SerializeField] Sprite retratoMenino2;
    [SerializeField] Sprite retratoMenina1;
    [SerializeField] Sprite retratoMenina2;


    // Boa parte do código foi copiado do PaginaResultadoDaAula, vou ver se faço herança depois pra diminuir o código repetido.
    // Boa parte do código vai ser apagada.

    private void DefinirRetratoAluno(string assinatura)
    {
        System.Random rnd = new System.Random();
        int indexRetrato = rnd.Next(2);
        //Debug.Log(indexRetrato);

        //Se for menino.
        if (assinatura == "Natan - Ensino Superior" || assinatura == "Alexis - Ensino Médio" ||
            assinatura == "Fábio - Ensino Fundamental" || assinatura == "Ricardo - Educação Infantil")
        {

            switch (indexRetrato)
            {
                case 0:
                    retratoAluno.GetComponent<Image>().sprite = retratoMenino1;
                    break;

                default:
                    retratoAluno.GetComponent<Image>().sprite = retratoMenino2;
                    break;
            }

        }
        else //Se for menina.
        {

            switch (indexRetrato)
            {
                case 0:
                    retratoAluno.GetComponent<Image>().sprite = retratoMenina1;
                    break;

                default:
                    retratoAluno.GetComponent<Image>().sprite = retratoMenina2;
                    break;
            }

        }

    }

    private void AtualizarFeedbackDosAlunos()
    {

        var (feedbackDoAluno, assinatura) = FeedbackDosAlunos.ObterFeedback(EstadoDoJogo.Instance);

        // Colocar àspas ao redor do feedback do aluno
        feedbackDoAluno = $"\"{feedbackDoAluno}\"";
        feedbackAulaInvertidaAlunoTexto.GetComponent<Text>().text = feedbackDoAluno;

        if (assinatura != null)
        {
            feedbackAulaInvertidaAlunoNome.SetActive(true);
            feedbackAulaInvertidaAlunoNome.GetComponent<Text>().text = assinatura;
            DefinirRetratoAluno(assinatura);
        }
        else
        {
            // Se ninguém assinou, esconder o GameObject da assinatura e do retrato.
            feedbackAulaInvertidaAlunoNome.SetActive(false);
            retratoAluno.SetActive(false);
        }

    }

    public void Atualizar()
    {
        AtualizarFeedbackDosAlunos();
        OnUpdate.Invoke();
    }
}