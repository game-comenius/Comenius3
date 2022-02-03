using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedbackMomentoDeInteracao : MonoBehaviour
{
    [SerializeField] GameObject feedback;
    [SerializeField] DisplayDeAluno alunoRenderer;
    private void Start()
    {
        feedback.SetActive(false);
    }
    public void MostrarFeedback(bool acerto)
    {
        if(acerto)
            alunoRenderer.estaFeliz = true;
        else
            alunoRenderer.estaFeliz = false;

        alunoRenderer.AtualizarAluno();

        feedback.SetActive(true);
    }
}
