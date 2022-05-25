using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResumoGlobal : MonoBehaviour
{
    [SerializeField] private Image iconePersonagem;
    [SerializeField] private Image iconeNivelDeEnsino;
    [SerializeField] private Image iconeAreaDeConhecimento;
    [SerializeField] private Image iconeInteligenciasMultiplas;
    [SerializeField] private TextMeshProUGUI tema;
    [SerializeField] private TextMeshProUGUI texto;
    [SerializeField] private Button backButton;
    [SerializeField] private Button nextButton;

    private int pageIndex;

    private void OnEnable()
    {
        EstadoDoJogo gameState = EstadoDoJogo.Instance;
        pageIndex = gameState.FaseAtual;

        UpdateButtons();
        UpdatePage();
    }

    public void Next()
    {
        pageIndex++;

        UpdateButtons();
        UpdatePage();
    }

    public void Back()
    {
        pageIndex--;

        UpdateButtons();
        UpdatePage();
    }

    private void UpdatePage()
    {
        EstadoDoJogo gameState = EstadoDoJogo.Instance;

        if (pageIndex == EstadoDoJogo.Instance.FaseAtual)
        {
            iconePersonagem.sprite = gameState.SpriteIconePersonagem;
            iconeNivelDeEnsino.sprite = gameState.NivelDeEnsino.sprite;
            iconeAreaDeConhecimento.sprite = gameState.AreaDeConhecimento.sprite;
            iconeInteligenciasMultiplas.sprite = gameState.Inteligencias.sprite;

            string fase;

            if (gameState.FaseAtual == 0)
                fase = "primeira";
            else if (gameState.FaseAtual == 1)
                fase = "segunda";
            else
                fase = "terceira";

            if (gameState.Tema != null && gameState.Tema != "")
                tema.text = $"Este é o tema da sua <b>{fase}</b> aula:\n<color=#b45f06><b>{gameState.Tema}</b>";
            else
                tema.text = "";

            string preposition = gameState.NivelDeEnsino == NivelDeEnsino.EducacaoInfantil ? "da" : "do";

            texto.text = $"Você irá jogar uma aula {preposition} {gameState.NivelDeEnsino.nome} " +
                        $"sobre {gameState.AreaDeConhecimento.nome} " +
                        $"com uma turma de perfil {gameState.Inteligencias.nome}.";
        }
        else
        {
            iconePersonagem.sprite = gameState.RegisteredStates[pageIndex].SpriteIconePersonagem;
            iconeNivelDeEnsino.sprite = gameState.RegisteredStates[pageIndex].NivelDeEnsino.sprite;
            iconeAreaDeConhecimento.sprite = gameState.RegisteredStates[pageIndex].AreaDeConhecimento.sprite;
            iconeInteligenciasMultiplas.sprite = gameState.RegisteredStates[pageIndex].Inteligencias.sprite;

            string fase;

            if (pageIndex == 0)
                fase = "primeira";
            else if (pageIndex == 1)
                fase = "segunda";
            else
                fase = "terceira";

            tema.text = $"Este é o tema da sua <b>{fase}</b> aula:\n<color=#b45f06><b>{gameState.RegisteredStates[pageIndex].Tema}</b>";

            string preposition = gameState.RegisteredStates[pageIndex].NivelDeEnsino == NivelDeEnsino.EducacaoInfantil ? "da" : "do";

            texto.text = $"Você irá jogar uma aula {preposition} {gameState.RegisteredStates[pageIndex].NivelDeEnsino.nome} " +
                         $"sobre {gameState.RegisteredStates[pageIndex].AreaDeConhecimento.nome} " +
                         $"com uma turma de perfil {gameState.RegisteredStates[pageIndex].Inteligencias.nome}.";
        }
    }

    private void UpdateButtons()
    {
        EstadoDoJogo gameState = EstadoDoJogo.Instance;

        backButton.interactable = pageIndex > 0;
        nextButton.interactable = pageIndex < gameState.FaseAtual;
    }
}
