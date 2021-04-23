using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "EstadoDeAulaInvertida", menuName = "Comenius3/EstadoDeAulaInvertida", order = 0)]
public class EstadoDeAulaInvertida : ScriptableObject 
{
    public Midia midiaAtual;
    public EstadoDeAula estadoAtual;
    public UnityEngine.Events.UnityEvent OnStateChange;

    public UnityEngine.Events.UnityEvent OnMidiaChange;

    public UnityEngine.Events.UnityEvent OnStateQuizz1;
    public UnityEngine.Events.UnityEvent OnStateInteracao1;
    public UnityEngine.Events.UnityEvent OnStateQuizz2;
    public UnityEngine.Events.UnityEvent OnStateInteracao2;
    public UnityEngine.Events.UnityEvent OnStateQuizz3;


    public void AvancarEstado()
    {
        EstadoDeAula estadoAnterior = estadoAtual;
        estadoAtual = estadoAtual + 1;

        switch (estadoAtual)
        {
            case EstadoDeAula.Quizz1:
                OnStateQuizz1.Invoke();
                break;
            case EstadoDeAula.Interacao1:
                OnStateInteracao1.Invoke();
                break;
            case EstadoDeAula.Quizz2:
                OnStateQuizz2.Invoke();
                break;
            case EstadoDeAula.Interacao2:
                OnStateInteracao2.Invoke();
                break;
            case EstadoDeAula.Quizz3:
                OnStateQuizz3.Invoke();
                break;
            default://Fim do momento aula
                estadoAtual = EstadoDeAula.Quizz1;
                break;
        }

        //Atualiza a midia conforme o momento de aula
        if(estadoAtual > EstadoDeAula.Quizz2)
        {
            midiaAtual = EstadoDoJogo.Instance.MidiasSelecionadas[3];
            OnMidiaChange.Invoke();
        } else
            midiaAtual = EstadoDoJogo.Instance.MidiasSelecionadas[2];

        OnStateChange.Invoke();
    }
}

    public enum EstadoDeAula{
        Quizz1,
        Interacao1,
        Quizz2,
        Interacao2,
        Quizz3,
    }
