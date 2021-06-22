using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedbackMomentoDeInteracao : MonoBehaviour
{
    [SerializeField] GameObject feedback;
    [SerializeField] SpriteRenderer alunoRenderer;
    [SerializeField] Sprite alunoFeliz;
    [SerializeField] Sprite alunoTriste;
    private void Start()
    {
        feedback.SetActive(false);
    }
    public void MostrarFeedback(bool acerto)
    {
        if(acerto)
            alunoRenderer.sprite = alunoFeliz;
        else
            alunoRenderer.sprite = alunoTriste;

        feedback.SetActive(true);
    }
}
