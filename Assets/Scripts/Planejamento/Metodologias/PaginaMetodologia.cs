using UnityEngine;
using UnityEngine.UI;

public class PaginaMetodologia : Pagina
{
    [SerializeField] private string nomePadrao;
    [SerializeField] private IconManager iconManager;
    [SerializeField] private Text nomeDoSelecionado;
    [SerializeField] private Text descricaoDoSelecionado;
    [SerializeField] private Button botaoConfirmar;
    [SerializeField] private Image anelDeSelecao;
    [SerializeField] [TextArea] private string descricaoPadrao;
    [SerializeField] [TextArea] private string ajuda;
    [SerializeField] private Text textoAjuda;

    private IconeMetodologia iconeSelecionado;

    private void Start()
    {
        anelDeSelecao.enabled = false;
        botaoConfirmar.interactable = false;
    
        nomeDoSelecionado.text = nomePadrao;
        descricaoDoSelecionado.text = descricaoPadrao;
    }

    private void OnEnable()
    {
        textoAjuda.text = ajuda;

        if (iconeSelecionado)
        {
            iconManager.SetIcon(0, iconeSelecionado.GetComponent<Image>().sprite);
        }

        iconManager.HideIcon(1);
        iconManager.HideIcon(2);
        iconManager.HideIcon(3);
    }

    private void OnDisable()
    {
        iconManager.ShowIcon(1);
        iconManager.ShowIcon(2);
        iconManager.ShowIcon(3);
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

            atualizarTexto(icone);
            atualizarEstadoDeJogo(icone);
        }
        else  // Cancela a seleção do ícone caso o jogador clique nele de novo
        {
            // Redefine a seleção
            iconeSelecionado = null;
            anelDeSelecao.enabled = false;

            resetarTexto();
            resetarEstadoDeJogo();
        }

        icone.selecionado = !icone.selecionado;  // Inverte o estado de seleção
    }

    public void HoverEnter(IconeMetodologia icone)
    {
        if (!iconeSelecionado)
        {
            atualizarTexto(icone);
        }
    }

    public void HoverExit()
    {
        if (!iconeSelecionado)
        {
            resetarTexto();
        }
    }

    public void atualizarTexto(IconeMetodologia icone)
    {
        nomeDoSelecionado.text = icone.metodologia.nome;
        descricaoDoSelecionado.text = icone.metodologia.descricao;
    }

    public void resetarTexto()
    {
        nomeDoSelecionado.text = nomePadrao;
        descricaoDoSelecionado.text = descricaoPadrao;
    }

    public void atualizarEstadoDeJogo(IconeMetodologia icone)
    {
        // Altera o sprite do pequeno guia da página para o sprite do selecionado
        iconManager.SetIcon(0, icone.GetComponent<Image>().sprite);

        // Grava o nível de ensino selecionado
        EstadoDoJogo.Instance.MetodologiaSelecionada = icone.metodologia;
        EstadoDoJogo.Instance.MetodologiaSelecionada.sprite = icone.GetComponent<Image>().sprite;

        // Ativar o botão de confirmar agora que há uma seleção
        botaoConfirmar.interactable = true;
    }

    public void resetarEstadoDeJogo()
    {
        iconManager.ResetIcon(0);

        // Reseta a escolha
        EstadoDoJogo.Instance.MetodologiaSelecionada = null;
        EstadoDoJogo.Instance.MetodologiaSelecionada.sprite = null;

        botaoConfirmar.interactable = false;
    }
}
