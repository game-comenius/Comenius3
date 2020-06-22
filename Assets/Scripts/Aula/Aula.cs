using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Aula : MonoBehaviour
{
    protected abstract IEnumerator AplicarQuiz(Quiz quiz);
}
