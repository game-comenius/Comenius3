using System.Collections.Generic;
using UnityEngine;

public class StateMachine : ScriptableObject
{
    [HideInInspector] public Midia currentMedia;

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

        // Atualiza a midia conforme o momento de aula
        if (currentStateIndex > secondMediaIndex)
        {
            currentMedia = EstadoDoJogo.Instance.MidiasSelecionadas[3];
            OnMediaChange.Invoke();
        }
        else
            currentMedia = EstadoDoJogo.Instance.MidiasSelecionadas[2];

        OnStateChange.Invoke();
    }
}
