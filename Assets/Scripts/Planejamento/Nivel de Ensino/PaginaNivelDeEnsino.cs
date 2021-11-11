using UnityEngine;
using UnityEngine.UI;

public class PaginaNivelDeEnsino : PaginaPlanejamento
{
    [SerializeField] private string nomePadrao;
    [SerializeField] private Text nomeDoSelecionado;
    [SerializeField] private Text descricaoDoSelecionado;
    [SerializeField] private Button botaoConfirmar;
    [SerializeField] private Image anelDeSelecao;
    [SerializeField] [TextArea] private string descricaoPadrao;
    private IconeNivelDeEnsino iconeSelecionado;

    private void Start()
    {
        anelDeSelecao.enabled = false;
        botaoConfirmar.interactable = false;
    
        nomeDoSelecionado.text = nomePadrao;
        descricaoDoSelecionado.text = descricaoPadrao;
    }

    protected override void OnEnable()
    {
        textoAjuda.text = ajuda;

        if (iconeSelecionado)
        {
            iconManager.SetIcon(1, iconeSelecionado.GetComponent<Image>().sprite);
        }
    }

    public void Selecao(IconeNivelDeEnsino icone)
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

    public void HoverEnter(IconeNivelDeEnsino icone)
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

    private void atualizar(IconeNivelDeEnsino icone)
    {
        nomeDoSelecionado.text = icone.nivelDeEnsino.nome;
        descricaoDoSelecionado.text = icone.nivelDeEnsino.descricao;
    }

    private void resetar()
    {
        nomeDoSelecionado.text = nomePadrao;
        descricaoDoSelecionado.text = descricaoPadrao;
    }

    private void atualizarEstadoDeJogo(IconeNivelDeEnsino icone)
    {
        // Altera o sprite do pequeno guia da página para o sprite do selecionado
        iconManager.SetIcon(1, icone.GetComponent<Image>().sprite);

        // Grava o nível de ensino selecionado
        EstadoDoJogo.Instance.NivelDeEnsinoSelecionado = icone.nivelDeEnsino;
        EstadoDoJogo.Instance.NivelDeEnsinoSelecionado.sprite = icone.GetComponent<Image>().sprite;

        // Ativar o botão de confirmar agora que há uma seleção
        botaoConfirmar.interactable = true;
    }

    private void resetarEstadoDeJogo()
    {
        iconManager.ResetIcon(1);

        // Reseta a escolha
        EstadoDoJogo.Instance.NivelDeEnsinoSelecionado.sprite = null;
        EstadoDoJogo.Instance.NivelDeEnsinoSelecionado = null;

        botaoConfirmar.interactable = false;
    }
}
