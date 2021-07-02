using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ElementoDaAulaInvertida : MonoBehaviour
{
    
    [SerializeField] EstadoDeAulaInvertida controladorDaAula;
    [SerializeField] EstadoDeAula[] estadosNoQualChama;
    [SerializeField] UnityEvent OnSelectedStates;
    [SerializeField] UnityEvent OnNotSelectedStates;

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
        foreach(EstadoDeAula estado in estadosNoQualChama)
        {
            if(controladorDaAula.estadoAtual == estado)
            {
                OnSelectedStates.Invoke();
                return;
            }
        }
        OnNotSelectedStates.Invoke();
    }
}