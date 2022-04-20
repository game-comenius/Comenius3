using UnityEngine;

public class ChangeLevel : MonoBehaviour
{
    public void changeLevel(int newLevel)
    {
        EstadoDoJogo.Instance.FaseAtual = newLevel;
    }

}
