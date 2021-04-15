using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomentoAulaInvertida : MonoBehaviour
{
    public enum EstadoDeAula{
        Quizz1,
        Interacao1,
        Quizz2,
        Interacao2,
        Quizz3,
    }

    public UnityEngine.Events.UnityEvent OnStateChange;

    private EstadoDeAula estadoAtual;

    private void Start()
    {
        estadoAtual = EstadoDeAula.Quizz1;
    }

[ContextMenu("Avançar Estado")]
    public void AvancarEstado()
    {
        estadoAtual = estadoAtual + 1;
        if(estadoAtual > EstadoDeAula.Quizz3)//O Momento Aula Acabou
            estadoAtual = 0;
        OnStateChange.Invoke();
    }

    public EstadoDeAula GetEstadoAtualdaAula()
    {
        return estadoAtual;
    }
}
