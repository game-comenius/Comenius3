using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomentoInteracaoFeedback : MonoBehaviour
{
    public void UpdateAluno(bool goodAnswer)
    {
        Debug.Log("Acertou: " + goodAnswer);
    }
}
