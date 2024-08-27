using UnityEngine;
using UnityEngine.Events;

public class StateMachineListener : MonoBehaviour
{
    [SerializeField] private StateMachine controladorDaAula;
    [SerializeField] private State[] estadosNoQualChama;
    [SerializeField] private UnityEvent OnSelectedStates;
    [SerializeField] private UnityEvent OnNotSelectedStates;

    void Awake()
    {
        controladorDaAula.OnStateChange.AddListener(OnStateChange);
    }

    void OnDestroy()
    {
        controladorDaAula.OnStateChange.RemoveListener(OnStateChange);
    }

    void OnStateChange()
    {
        foreach (State estado in estadosNoQualChama)
        {
            if (controladorDaAula.currentState == estado)
            {
                Debug.Log(estado.ToString());
                OnSelectedStates.Invoke();
                return;
            }
        }
        OnNotSelectedStates.Invoke();
    }
}