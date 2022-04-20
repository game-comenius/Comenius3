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

    protected override void OnEnable()
    {
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
    }

    public void UpdateHelpText()
    {
        textoAjuda.text = EstadoDoJogo.Instance.Tema == "" ? initialHelp : ajuda;
    }
}
