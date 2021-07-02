using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EstadoDeAula", menuName = "Comenius3/EstadoDeAula", order = 0)]
[System.Serializable]
public class EstadoDeAula : ScriptableObject
{
    public string nome { get { return this.name; } }
}
