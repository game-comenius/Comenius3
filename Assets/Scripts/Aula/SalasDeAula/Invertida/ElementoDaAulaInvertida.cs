using UnityEngine;
using UnityEngine.Events;

public class ElementoDaAulaInvertida : MonoBehaviour
{
    [SerializeField] private EstadoDeAulaInvertida controladorDaAula;
    [SerializeField] private EstadoDeAula[] estadosNoQualChama;
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
        foreach (EstadoDeAula estado in estadosNoQualChama)
        {
            if (controladorDaAula.estadoAtual == estado)
            {
                OnSelectedStates.Invoke();
                return;
            }
        }
        OnNotSelectedStates.Invoke();
    }
}