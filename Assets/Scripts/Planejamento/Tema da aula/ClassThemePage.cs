using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClassThemePage : PaginaPlanejamento
{
    [SerializeField] private TMP_InputField themeInput;
    [SerializeField] private Sprite methodologyIcon;
    [SerializeField] private int iconIndex;
    [SerializeField] private Image teachingLevelIcon;
    [SerializeField] private Image knowledgeAreaIcon;
    [SerializeField] private Image intelligenceIcon;
    [SerializeField] private OnHoverPopUp teachingLevelHoverController;
    [SerializeField] private OnHoverPopUp knowledgeAreaHoverController;
    [SerializeField] private OnHoverPopUp intelligenceHoverController;
    [SerializeField] private Button okButton;
    [SerializeField] [TextArea] private string initialHelp;
    [SerializeField][TextArea] private string initialHelpPt;
    [SerializeField][TextArea] private string initialHelpEua;
    [SerializeField][TextArea] private string initialHelpEsp;

    protected override void OnEnable()
    {
        AtualizarTextos();
        fundo.sprite = spriteFundo;

        UpdateHelpText();

        iconManager.ShowIcon(0);
        iconManager.HideIcon(1);
        iconManager.HideIcon(2);
        iconManager.HideIcon(3);

        iconManager.SetIcon(iconIndex, methodologyIcon);

        teachingLevelIcon.sprite = EstadoDoJogo.Instance.NivelDeEnsino.sprite;
        knowledgeAreaIcon.sprite = EstadoDoJogo.Instance.AreaDeConhecimento.sprite;
        intelligenceIcon.sprite = EstadoDoJogo.Instance.Inteligencias.sprite;

        teachingLevelHoverController.Content = EstadoDoJogo.Instance.NivelDeEnsino.nome;
        knowledgeAreaHoverController.Content = EstadoDoJogo.Instance.AreaDeConhecimento.nome;
        intelligenceHoverController.Content = EstadoDoJogo.Instance.Inteligencias.nome;
    }

    private void OnDisable()
    {
        iconManager.ResetIcon(iconIndex);
    }

    public void CheckTheme(string theme)
    {
        okButton.interactable = theme != "";
    }

    public void ConfirmClassTheme()
    {
        EstadoDoJogo.Instance.Tema = themeInput.text;
        EstadoDoJogo.Instance.SaveState();  // Salva o estado de jogo atual para consultas futuras
    }

    public void UpdateHelpText()
    {
        AtualizarTextos();
        AtualizarTextosInicial();

    }
     void AtualizarTextosInicial()
    {
        switch (Textos.GetIdiomaSelecionado())
        {
            case Idiomas.INGLES:
                textoAjuda.text = EstadoDoJogo.Instance.Tema == "" ? initialHelpEua : ajuda;
                break;
            case Idiomas.PORTUGUES:
                textoAjuda.text = EstadoDoJogo.Instance.Tema == "" ? initialHelpPt : ajuda;
                break;
            case Idiomas.ESPANHOL:
                textoAjuda.text = EstadoDoJogo.Instance.Tema == "" ? initialHelpEsp : ajuda;
                break;
            default:
                break;
        }
    }
}
