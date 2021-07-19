using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "FlagDeJogo", menuName = "Comenius3/FlagDeEstadoDeJogo", order = 0)]

public class FlagDeEstadoDeJogo : ScriptableObject
{
    private bool value;


    public void SetFlagValue(bool value)
    {
        this.value = value;
        Debug.Log(value);
    }

    public bool GetFlagValue()
    {
        Debug.Log(value);
        return value;
    }
}
