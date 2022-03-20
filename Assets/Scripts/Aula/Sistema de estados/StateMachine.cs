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
        // TODO: Adaptar para a ABProj
        if (currentStateIndex > secondMediaIndex)
        {
            if (EstadoDoJogo.Instance.Metodologia.nome == "Aprendizagem Baseada em Problemas")
                currentMedia = EstadoDoJogo.Instance.Midias[1];
            else
                currentMedia = EstadoDoJogo.Instance.Midias[3];

            OnMediaChange.Invoke();
        }
        else

            if (EstadoDoJogo.Instance.Metodologia.nome == "Aprendizagem Baseada em Problemas")
                currentMedia = EstadoDoJogo.Instance.Midias[0];
            else
                currentMedia = EstadoDoJogo.Instance.Midias[2];

        OnStateChange.Invoke();
    }
}
