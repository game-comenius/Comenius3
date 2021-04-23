using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomentoAulaInvertida : MonoBehaviour
{ 
    [SerializeField]EstadoDeAulaInvertida messenger;

    [ContextMenu("Start")]
    public void Awake()
    {
        messenger.estadoAtual = EstadoDeAula.Quizz3;
        AvancarEstado();//Inicia o no primeiro estado e da a chamada de evento
        messenger.midiaAtual = EstadoDoJogo.Instance.MidiasSelecionadas[2];
    }

[ContextMenu("Avançar Estado")]
    public void AvancarEstado()
    {
        messenger.AvancarEstado();
    }
}
