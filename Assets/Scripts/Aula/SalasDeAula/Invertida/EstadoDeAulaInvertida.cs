using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "EstadoDeAulaInvertida", menuName = "Comenius3/EstadoDeAulaInvertida", order = 0)]
public class EstadoDeAulaInvertida : ScriptableObject 
{
    public Midia midiaAtual;
    public EstadoDeAula estadoAtual;
    public UnityEngine.Events.UnityEvent OnStateChange;
}

    public enum EstadoDeAula{
        Quizz1,
        Interacao1,
        Quizz2,
        Interacao2,
        Quizz3,
    }
