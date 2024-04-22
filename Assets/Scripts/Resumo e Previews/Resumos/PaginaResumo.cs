using UnityEngine;
using UnityEngine.UI;

public class PaginaResumo : PaginaPlanejamento
{
    [SerializeField] private Image iconeNivelDeEnsino;
    [SerializeField] private Image iconeAreaDeConhecimento;
    [SerializeField] private Image iconeInteligencia;
    [SerializeField] private Text texto;
    [SerializeField] private Sprite icone;
    [SerializeField] private Image iconeGo;
    protected override void OnEnable()
    {
        AtualizarTextos();
        fundo.sprite = spriteFundo;
        textoAjuda.text = ajuda;

        iconManager.HideIcon(0);
        iconManager.HideIcon(1);
        iconManager.HideIcon(2);
        iconManager.HideIcon(3);
        iconeGo.sprite = icone;

        iconeNivelDeEnsino.sprite = EstadoDoJogo.Instance.NivelDeEnsino.sprite;
        iconeAreaDeConhecimento.sprite = EstadoDoJogo.Instance.AreaDeConhecimento.sprite;
        iconeInteligencia.sprite = EstadoDoJogo.Instance.Inteligencias.sprite;

        BuildText();
    }


    // O argumento deveria ser um enum, porém por conveniência no editor foi usado um string
    public void BuildText(string highlightedChoice = "")
    {
        string preposition = EstadoDoJogo.Instance.NivelDeEnsino == NivelDeEnsino.EducacaoInfantil ? "da" : "do";

        string levelPart, areaPart, inteligencePart;

        levelPart = $"Você irá jogar uma aula {preposition} {EstadoDoJogo.Instance.NivelDeEnsino.nome} ";
        areaPart = $"sobre {EstadoDoJogo.Instance.AreaDeConhecimento.nome} ";
        inteligencePart = $"com uma turma de perfil {EstadoDoJogo.Instance.Inteligencias.nome}.";

        switch (highlightedChoice)
        {
            case "Nivel":
                levelPart = $"Você irá jogar uma aula {preposition} " +
                            $"<i><color=orange>{EstadoDoJogo.Instance.NivelDeEnsino.nome}</color></i> ";
                break;
            case "Area":
                areaPart = "sobre " +
                           $"<i><color=orange>{EstadoDoJogo.Instance.AreaDeConhecimento.nome}</color></i> ";
                break;
            case "Inteligencia":
                inteligencePart = "com uma turma de perfil " +
                                  $"<i><color=orange>{EstadoDoJogo.Instance.Inteligencias.nome}</color></i>.";
                break;
            default:
                break;
        }

        texto.text = levelPart + areaPart + inteligencePart;
    }
}
