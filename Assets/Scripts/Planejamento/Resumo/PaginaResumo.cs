using UnityEngine;
using UnityEngine.UI;

public class PaginaResumo : PaginaPlanejamento
{
    [SerializeField] private Image iconeNivelDeEnsino;
    [SerializeField] private Image iconeAreaDeConhecimento;
    [SerializeField] private Image iconeInteligencia;
    [SerializeField] private Text texto;
    [SerializeField] private Sprite icone;

    // bom dia mundo 
    protected override void OnEnable()
    {
        fundo.sprite = spriteFundo;
        textoAjuda.text = ajuda;

        iconManager.ShowIcon(0);
        iconManager.HideIcon(1);
        iconManager.HideIcon(2);
        iconManager.HideIcon(3);

        iconManager.SetIcon(0, icone);

        iconeNivelDeEnsino.sprite = EstadoDoJogo.Instance.NivelDeEnsinoSelecionado.sprite;
        iconeAreaDeConhecimento.sprite = EstadoDoJogo.Instance.AreaDeConhecimentoSelecionada.sprite;
        iconeInteligencia.sprite = EstadoDoJogo.Instance.InteligenciasSelecionadas.sprite;

        BuildText();
    }

    private void OnDisable()
    {
        iconManager.ResetIcon(0);
    }

    // O argumento deveria ser um enum, porém por conveniência no editor foi usado um string
    public void BuildText(string highlightedChoice = "")
    {
        string preposition = EstadoDoJogo.Instance.NivelDeEnsinoSelecionado == NivelDeEnsino.EducacaoInfantil ? "da" : "do";

        string levelPart, areaPart, inteligencePart;

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
