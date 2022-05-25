using UnityEngine;

public class GameStateMethodCaller : MonoBehaviour
{
    public void AdvanceLevel()
    {
        EstadoDoJogo.Instance.AdvanceLevel();
    }

    public void Reset()
    {
        EstadoDoJogo.Instance.Reset();
    }
}
