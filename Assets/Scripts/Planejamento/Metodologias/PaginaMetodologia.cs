using UnityEngine;
using UnityEngine.UI;

public class PaginaMetodologia : PaginaPlanejamento
{
    [SerializeField] private Text descricaoDoSelecionado;
    [SerializeField] private Button botaoConfirmar;
    [SerializeField] private UIManager uiManager;
    [SerializeField] private GameObject introABP;
    [SerializeField] private GameObject introSAI;
    [SerializeField] private Image anelDeSelecao;
    [SerializeField] [TextArea] private string descricaoPadrao;

    private IconeMetodologia iconeSelecionado;

    private void Start()
    {
        anelDeSelecao.enabled = false;
        botaoConfirmar.interactable = false;

        descricaoDoSelecionado.text = descricaoPadrao;
    }

    protected override void OnEnable()
    {
        fundo.sprite = spriteFundo;

        textoAjuda.text = ajuda;

        iconManager.ShowIcon(0);
        iconManager.HideIcon(1);
        iconManager.HideIcon(2);
        iconManager.HideIcon(3);

        if (iconeSelecionado)
        {
            iconManager.SetIcon(0, iconeSelecionado.GetComponent<Image>().sprite);
        }
    }

    private void OnDisable()
    {
        iconManager.ResetIcon(0);
    }

    public void Selecao(IconeMetodologia icone)
    {
        AudioManager.instance.TocarSFX("clique");

        if (!icone.selecionado)  // O ícone foi selecionado
        {
            // Marca o último ícone selecionado como falso
            if (iconeSelecionado)
            {
                iconeSelecionado.selecionado = false;
            }

            iconeSelecionado = icone;  // Agora esse ícone será o último selecionado

            // Posiciona o anel de seleção sobre o botão selecionado
            anelDeSelecao.enabled = true;
            var posicaoDoIcone = icone.GetComponent<RectTransform>().anchoredPosition;
            anelDeSelecao.rectTransform.anchoredPosition = posicaoDoIcone;

            atualizar(icone);
            atualizarEstadoDeJogo(icone);
        }
        else  // Cancela a seleção do ícone caso o jogador clique nele de novo
        {
            // Redefine a seleção
            iconeSelecionado = null;
            anelDeSelecao.enabled = false;

            resetar();
            resetarEstadoDeJogo();
        }
        icone.selecionado = !icone.selecionado;  // Inverte o estado de seleção
    }

    public void HoverEnter(IconeMetodologia icone)
    {
        if (!iconeSelecionado)
        {
            atualizar(icone);
        }
    }

    public void HoverExit()
    {
        if (!iconeSelecionado)
        {
            resetar();
        }
    }

    private void atualizar(IconeMetodologia icone)
    {
        descricaoDoSelecionado.text = icone.metodologia.descricao;
    }

    private void resetar()
    {
        descricaoDoSelecionado.text = descricaoPadrao;
    }

    private void atualizarEstadoDeJogo(IconeMetodologia icone)
    {
        // Altera o sprite do pequeno guia da página para o sprite do selecionado
        iconManager.SetIcon(0, icone.GetComponent<Image>().sprite);

        // Grava o nível de ensino selecionado
        EstadoDoJogo.Instance.MetodologiaSelecionada = icone.metodologia;
        EstadoDoJogo.Instance.MetodologiaSelecionada.sprite = icone.GetComponent<Image>().sprite;

        botaoConfirmar.interactable = true;
    }

    private void resetarEstadoDeJogo()
    {
        iconManager.ResetIcon(0);

        // Reseta a escolha
        EstadoDoJogo.Instance.MetodologiaSelecionada = null;

        botaoConfirmar.interactable = false;
    }

    public void Confirmar()
    {
        switch (EstadoDoJogo.Instance.MetodologiaSelecionada.nome)
        {
            case "Aprendizagem Baseada em Problemas":
                uiManager.ChangePanel(introABP);
                break;
            case "Sala de Aula Invertida":
                uiManager.ChangePanel(introSAI);
                break;
            default:
                break;
        }
    }
}
