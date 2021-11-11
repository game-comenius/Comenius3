using UnityEngine;
using UnityEngine.UI;

public class PaginaResumo : PaginaPlanejamento
{
    [SerializeField] private Image iconeNivelDeEnsino;
    [SerializeField] private Image iconeAreaDeConhecimento;
    [SerializeField] private Image iconeInteligencia;
    [SerializeField] private Text texto;
    [SerializeField] private Sprite icone;
    [SerializeField] private Sprite backgroundSprite;
    [SerializeField] private Image background;
    private Sprite tempBackground;

    protected override void OnEnable()
    {
        tempBackground = background.sprite;
        background.sprite = backgroundSprite;
        textoAjuda.text = ajuda;

        iconManager.SetIcon(0, icone);

        iconManager.HideIcon(1);
        iconManager.HideIcon(2);
        iconManager.HideIcon(3);

        iconeNivelDeEnsino.sprite = EstadoDoJogo.Instance.NivelDeEnsinoSelecionado.sprite;
        iconeAreaDeConhecimento.sprite = EstadoDoJogo.Instance.AreaDeConhecimentoSelecionada.sprite;
        iconeInteligencia.sprite = EstadoDoJogo.Instance.InteligenciasSelecionadas.sprite;

        BuildText();
    }

    private void OnDisable()
    {
        background.sprite = tempBackground;

        iconManager.ResetIcon(0);

        iconManager.ShowIcon(1);
        iconManager.ShowIcon(2);
        iconManager.ShowIcon(3);
    }

    // O argumento deveria ser um enum, porém por conveniência no editor foi usado um string
    public void BuildText(string highlightedChoice = "")
    {
        string preposition = "do";

        string levelPart, areaPart, inteligencePart;

        if (EstadoDoJogo.Instance.NivelDeEnsinoSelecionado == NivelDeEnsino.EducacaoInfantil)
        {
            preposition = "da";
        }

        levelPart = $"Você irá jogar uma aula {preposition} {EstadoDoJogo.Instance.NivelDeEnsinoSelecionado.nome} ";
        areaPart = $"sobre {EstadoDoJogo.Instance.AreaDeConhecimentoSelecionada.nome} ";
        inteligencePart = $"com uma turma de perfil {EstadoDoJogo.Instance.InteligenciasSelecionadas.nome}.";

        switch (highlightedChoice)
        {
            case "Nivel":
                levelPart = $"Você irá jogar uma aula {preposition} " +
                            $"<i><color=orange>{EstadoDoJogo.Instance.NivelDeEnsinoSelecionado.nome}</color></i> ";
                break;
            case "Area":
                areaPart = "sobre " +
                           $"<i><color=orange>{EstadoDoJogo.Instance.AreaDeConhecimentoSelecionada.nome}</color></i> ";
                break;
            case "Inteligencia":
                inteligencePart = "com uma turma de perfil " +
                                  $"<i><color=orange>{EstadoDoJogo.Instance.InteligenciasSelecionadas.nome}</color></i>.";
                break;
            default:
                break;
        }

        texto.text = levelPart + areaPart + inteligencePart;
    }
}
