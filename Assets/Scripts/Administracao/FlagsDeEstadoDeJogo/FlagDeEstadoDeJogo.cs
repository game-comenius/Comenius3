using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "FlagDeJogo", menuName = "Comenius3/FlagDeEstadoDeJogo", order = 0)]

public class FlagDeEstadoDeJogo : ScriptableObject
{
    [System.NonSerialized] bool value;


    public void SetFlagValue(bool value)
    {
        this.value = value;
    }

    public bool GetFlagValue()
    {
        return value;
    }
}
