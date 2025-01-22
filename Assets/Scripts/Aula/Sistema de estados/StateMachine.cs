using System;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : ScriptableObject
{
    public Midia currentMedia;

    private int currentStateIndex;

    public UnityEngine.Events.UnityEvent OnStateChange;
    public UnityEngine.Events.UnityEvent OnMediaChange;

    [SerializeField] private List<State> states;
    [SerializeField] private int secondMediaIndex;

    public State currentState
    {
        get
        {
            return states[currentStateIndex];
        }
    }

    public void Init()
    {
        currentStateIndex = states.Count - 1;
        AdvanceState();
    }

    public void AdvanceState()
    {
        currentStateIndex++;

        if (currentStateIndex >= states.Count)
        {
            currentStateIndex = 0;
        }
        for (int i = 0; i < EstadoDoJogo.Instance.Midias.Length; i++) {
            Debug.Log(EstadoDoJogo.Instance.Midias[i].nomeMidia);

        }
        Debug.Log(EstadoDoJogo.Instance.Metodologia.nome);

        // Atualiza a midia conforme o momento de aula
        // TODO: Adaptar para a ABProj
        if (currentStateIndex > secondMediaIndex)
        {
            if (EstadoDoJogo.Instance.Metodologia.nome == Metodologia.ABP.nome)
                currentMedia = EstadoDoJogo.Instance.Midias[1];
            else
                currentMedia = EstadoDoJogo.Instance.Midias[3];

            OnMediaChange.Invoke();
        }
        else
         
            if (EstadoDoJogo.Instance.Metodologia.nome == Metodologia.ABP.nome)
                currentMedia = EstadoDoJogo.Instance.Midias[0];
            else
                currentMedia = EstadoDoJogo.Instance.Midias[2];

        OnStateChange.Invoke();
    }
}
