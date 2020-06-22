using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizDeMidia : Quiz
{
    public void ConfigurarQuiz()
    {
        return;
    }

    public override IEnumerator Executar()
    {
        Debug.Log("Executando quiz de mídia...");
        yield return new WaitForSeconds(3);
        Debug.Log("Terminando a execução do quiz de mídia...");
    }
}
