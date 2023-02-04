using UnityEngine;


public class GameStateMethodCaller : MonoBehaviour
{
    public GameObject finalHistoria;
    public GameObject finalAvulso;
    public void AdvanceLevel()
    {
        EstadoDoJogo.Instance.AdvanceLevel();
    }

    public void TelaSelecao()
    {
        EstadoDoJogo.Instance.TelaSelecao();
    }

    public void JogarNovamente()
    {
        EstadoDoJogo.Instance.JogarNovamente();
    }

    public void VoltarMenu()
    {
        EstadoDoJogo.Instance.MenuGame();
    }
    public void Reset()
    {
        EstadoDoJogo.Instance.Reset();
    }
    public void DecidirQualFimAbrir()
    {
        if (EstadoDoJogo.Instance.ModoDeJogoEscolhido())
        {
            finalHistoria.SetActive(true);
        }
        else
        {
            finalHistoria.SetActive(true);
        }
    }
}
