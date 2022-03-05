using UnityEngine;

[CreateAssetMenu(fileName = "EstadoDeAula", menuName = "Comenius3/EstadoDeAula", order = 0)]
[System.Serializable]
public class State : ScriptableObject
{
    public string stateName { get { return this.stateName; } }
}
