using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public enum EstadoDeAula{
        Quizz1,
        Interacao1,
        Quizz2,
        Interacao2,
        Quizz3,
    }

public class MomentoAulaInvertida : MonoBehaviour
{
    [System.Serializable]
    public class StateChangeEvent : UnityEngine.Events.UnityEvent<MomentoAulaInvertida> {}   
    public StateChangeEvent OnStateChange;

    private EstadoDeAula estadoAtual;
    public EstadoDeAula EstadoAtual{get {return estadoAtual;} private set {estadoAtual = value;}}

    private Midia midiaAtual;
    public Midia MidiaAtual {get {return midiaAtual;} private set {midiaAtual = value;}}

    private void Start()
    {
        estadoAtual = EstadoDeAula.Quizz3;
        AvancarEstado();//Inicia o no primeiro estado e da a chamada de evento
        midiaAtual = EstadoDoJogo.Instance.MidiasSelecionadas[2];
    }

[ContextMenu("Avançar Estado")]
    public void AvancarEstado()
    {
        estadoAtual = estadoAtual + 1;
        if(estadoAtual > EstadoDeAula.Quizz3)//O Momento Aula Acabou
            estadoAtual = 0;

        if(estadoAtual > EstadoDeAula.Quizz2)
            midiaAtual = EstadoDoJogo.Instance.MidiasSelecionadas[3];
        else
            midiaAtual = EstadoDoJogo.Instance.MidiasSelecionadas[2];

        OnStateChange.Invoke(this);
    }
}
