using UnityEngine;


public class GameStateMethodCaller : MonoBehaviour
{
    public GameObject finalHistoria;
    public GameObject finalAvulso;
    public TrocadorDeCena trocadorDeCena;
    public TrocadorDeCena trocadorDeCenaCreditos;
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
          
            if (EstadoDoJogo.Instance.FaseAtual == 2)
            {
                trocadorDeCenaCreditos.TrocarCena();
            }
            else
            {
                finalHistoria.SetActive(true);
            }
        }
        else
        {
            finalAvulso.SetActive(true);
        }

    }
}
