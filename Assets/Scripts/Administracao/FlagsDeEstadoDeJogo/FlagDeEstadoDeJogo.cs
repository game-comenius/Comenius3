using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "FlagDeJogo", menuName = "Comenius3/FlagDeEstadoDeJogo", order = 0)]
public class FlagDeEstadoDeJogo : ScriptableObject
{
    public bool value;

    public void SetFlag(bool value)
    {
        this.value = value;
    }
}
