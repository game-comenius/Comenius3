using UnityEngine;

[CreateAssetMenu(fileName = "State", menuName = "Comenius3/State", order = 0)]
[System.Serializable]
public class State : ScriptableObject
{
    public string stateName { get { return this.stateName; } }
}
