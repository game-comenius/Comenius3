using UnityEngine;

public class FeedbackMomentoDeInteracao : MonoBehaviour
{
    [SerializeField] GameObject feedback;
    [SerializeField] DisplayDeAluno alunoRenderer;

    private void Start()
    {
        feedback.SetActive(false);
    }

    public void MostrarFeedback(bool acertou)
    {
        if (acertou)
            alunoRenderer.estaFeliz = true;
        else
            alunoRenderer.estaFeliz = false;

        alunoRenderer.AtualizarAluno();

        feedback.SetActive(true);
    }
}
