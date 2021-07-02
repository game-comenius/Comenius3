using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AvaliadorDeFlag : MonoBehaviour
{
    public FlagDeEstadoDeJogo flag;
    public UnityEvent OnTrue;
    public UnityEvent OnFalse;

    public void Avaliar()
    {
        if(flag.value)
            OnTrue.Invoke();
        else
            OnFalse.Invoke();
    }
}
