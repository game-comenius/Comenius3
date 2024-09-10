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
        switch (Textos.GetIdiomaSelecionado())  
        {
            case Idiomas.INGLES:
                preposition = "";
                levelPart = $"You will play a class  {preposition} {EstadoDoJogo.Instance.NivelDeEnsino.nome} ";
                areaPart = $"about {EstadoDoJogo.Instance.AreaDeConhecimento.nome} ";
                inteligencePart = $"with a profile class {EstadoDoJogo.Instance.Inteligencias.nome}.";
                break;
            case Idiomas.PORTUGUES:
                levelPart = $"Você irá jogar uma aula {preposition} {EstadoDoJogo.Instance.NivelDeEnsino.nome} ";
                areaPart = $"sobre {EstadoDoJogo.Instance.AreaDeConhecimento.nome} ";
                inteligencePart = $"com uma turma de perfil {EstadoDoJogo.Instance.Inteligencias.nome}.";
                break;
            case Idiomas.ESPANHOL:
                preposition = "";
                levelPart = $"Jugarás una clase {preposition} {EstadoDoJogo.Instance.NivelDeEnsino.nome} ";
                areaPart = $"acerca de {EstadoDoJogo.Instance.AreaDeConhecimento.nome} ";
                inteligencePart = $"con una clase de perfil {EstadoDoJogo.Instance.Inteligencias.nome}.";
                break;

            default:
                levelPart = $"Você irá jogar uma aula {preposition} {EstadoDoJogo.Instance.NivelDeEnsino.nome} ";
                areaPart = $"sobre {EstadoDoJogo.Instance.AreaDeConhecimento.nome} ";
                inteligencePart = $"com uma turma de perfil {EstadoDoJogo.Instance.Inteligencias.nome}.";

                break;
        }


        switch (highlightedChoice)
        {
            case "Nivel":
                levelPart = GetLinguageTextLevel();
                break;
            case "Area":
                areaPart = GetLinguageTextArea();
                break;
            case "Inteligencia":
                inteligencePart = GetLinguageTextInteligencia();
                break;
            default:
                break;
        }

        string GetLinguageTextLevel()
        {
            var text = "tex";
            switch (Textos.GetIdiomaSelecionado())
            {
                case Idiomas.INGLES:
                    return text = $"You will play a class{preposition} " +
        $"<i><color=orange>{EstadoDoJogo.Instance.NivelDeEnsino.nome}</color></i> ";
                    break;
                case Idiomas.PORTUGUES:
                    return text = $"Você irá jogar uma aula{preposition} " +
                            $"<i><color=orange>{EstadoDoJogo.Instance.NivelDeEnsino.nome}</color></i> ";
                    break;
                case Idiomas.ESPANHOL:
                    return text = $"Jugarás una clase{preposition} " +
        $"<i><color=orange>{EstadoDoJogo.Instance.NivelDeEnsino.nome}</color></i> ";
                    break;
                default:
                    return text = $"Você irá jogar uma aula{preposition} " +
                     $"<i><color=orange>{EstadoDoJogo.Instance.NivelDeEnsino.nome}</color></i> ";
                    break;
            }
        }
        string GetLinguageTextArea()
        {
            var text = "tex";
            switch (Textos.GetIdiomaSelecionado())
            {
                case Idiomas.INGLES:
                    return text = $"About{preposition} " +
            $"<i><color=orange>{EstadoDoJogo.Instance.AreaDeConhecimento.nome}</color></i> ";
                    break;
                case Idiomas.PORTUGUES:
                    return text = $"Sobre{preposition} " +
                                $"<i><color=orange>{EstadoDoJogo.Instance.AreaDeConhecimento.nome}</color></i> ";
                    break;
                case Idiomas.ESPANHOL:
                    return text = $"Acerca de{preposition} " +
            $"<i><color=orange>{EstadoDoJogo.Instance.AreaDeConhecimento.nome}</color></i> ";
                    break;
                default:
                    break;
            }
            return text;
        }

        string GetLinguageTextInteligencia()
        {
            var text = "tex";
            switch (Textos.GetIdiomaSelecionado())
            {
                case Idiomas.INGLES:
                    return text = $"With a profile class{preposition} " +
            $"<i><color=orange>{EstadoDoJogo.Instance.Inteligencias.nome}</color></i> ";
                    break;
                case Idiomas.PORTUGUES:
                    return text = $"com uma turma de perfil{preposition} " +
                                $"<i><color=orange>{EstadoDoJogo.Instance.Inteligencias.nome}</color></i> ";
                    break;
                case Idiomas.ESPANHOL:
                    return text = $"con una clase de perfil{preposition} " +
            $"<i><color=orange>{EstadoDoJogo.Instance.Inteligencias.nome}</color></i> ";
                    break;
                default:
                    break;
            }
            return text;
        }


        texto.text = levelPart + areaPart + inteligencePart;
    }
}
