using UnityEngine;
using UnityEngine.UI;

public class PaginaResumo : MonoBehaviour
{
    [SerializeField] private IconManager iconManager;
    [SerializeField] private Image iconeNivelDeEnsino;
    [SerializeField] private Image iconeAreaDeConhecimento;
    [SerializeField] private Image iconeInteligencia;
    [SerializeField] private Text texto;
    [SerializeField] private Sprite icone;
    [SerializeField] [TextArea] private string ajuda;
    [SerializeField] private Text textoAjuda;
    [SerializeField] private Sprite backgroundSprite;
    [SerializeField] private Image background;
    private Sprite tempBackground;

    private void OnEnable()
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

        texto.text = $"Você irá jogar uma aula do {EstadoDoJogo.Instance.NivelDeEnsinoSelecionado.nome} " +
                     $"sobre {EstadoDoJogo.Instance.AreaDeConhecimentoSelecionada.nome} " +
                     $"com uma turma de perfil {EstadoDoJogo.Instance.InteligenciasSelecionadas.nome}.";
    }

    private void OnDisable()
    {
        background.sprite = tempBackground;

        iconManager.ResetIcon(0);

        iconManager.ShowIcon(1);
        iconManager.ShowIcon(2);
        iconManager.ShowIcon(3);
    }
}
