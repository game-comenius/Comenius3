using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AvaliadorDeFlag : MonoBehaviour
{
    [SerializeField] string nomeDaFlag;
    public UnityEvent OnTrue;
    public UnityEvent OnFalse;

    public void Avaliar()
    {
        foreach(FlagDeEstadoDeJogo flag in EstadoDoJogo.Instance.flags)
        {
            if(flag.nome == nomeDaFlag)
            {
                if(flag.valor)
                    OnTrue.Invoke();
                else
                    OnFalse.Invoke();

                return;
            }
        }
        OnFalse.Invoke();
    }
}
