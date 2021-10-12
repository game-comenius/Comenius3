using UnityEngine;
using UnityEngine.UI;

public class PaginaNivelDeEnsino : Pagina
{
    [SerializeField] private string nomePadrao;
    [SerializeField] private IconManager iconManager;
    [SerializeField] private Text nomeDoSelecionado;
    [SerializeField] private Text descricaoDoSelecionado;
    [SerializeField] private Button botaoConfirmar;
    [SerializeField] private Image anelDeSelecao;
    [TextArea] private string descricaoPadrao;

    private IconeNivelDeEnsino ultimoSelecionado;

    private void Start()
    {
        anelDeSelecao.enabled = false;
        botaoConfirmar.interactable = false;
    
        nomeDoSelecionado.text = nomePadrao;
        descricaoDoSelecionado.text = descricaoPadrao;
    }

    public void Selecao(IconeNivelDeEnsino icone)
    {
        AudioManager.instance.TocarSFX("clique");

        if (!icone.selecionado)  // O ícone foi selecionado
        {
            // Marca o último ícone selecionado como falso
            if (ultimoSelecionado)
            {
                ultimoSelecionado.selecionado = false;
            }

            ultimoSelecionado = icone;  // Agora esse ícone será o último selecionado

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
            ultimoSelecionado = null;
            anelDeSelecao.enabled = false;

            resetarTexto();
            resetarEstadoDeJogo();
        }

        icone.selecionado = !icone.selecionado;  // Inverte o estado de seleção
    }

    public void HoverEnter(IconeNivelDeEnsino icone)
    {
        if (!ultimoSelecionado)
        {
            atualizarTexto(icone);
        }
    }

    public void HoverExit()
    {
        if (!ultimoSelecionado)
        {
            resetarTexto();
        }
    }

    public void atualizarTexto(IconeNivelDeEnsino icone)
    {
        nomeDoSelecionado.text = icone.nivelDeEnsino.nome;
        descricaoDoSelecionado.text = icone.nivelDeEnsino.Descricao;
    }

    public void resetarTexto()
    {
        nomeDoSelecionado.text = nomePadrao;
        descricaoDoSelecionado.text = descricaoPadrao;
    }

    public void atualizarEstadoDeJogo(IconeNivelDeEnsino icone)
    {
        // Altera o sprite do pequeno guia da página para o sprite do selecionado
        iconManager.SetIcon(1, icone.GetComponent<Image>().sprite);

        // Grava o nível de ensino selecionado
        EstadoDoJogo.Instance.NivelDeEnsinoSelecionado = icone.nivelDeEnsino;
        EstadoDoJogo.Instance.NivelDeEnsinoSelecionado.Sprite = icone.GetComponent<Image>().sprite;

        // Ativar o botão de confirmar agora que há uma seleção
        botaoConfirmar.interactable = true;
    }

    public void resetarEstadoDeJogo()
    {
        iconManager.ResetIcon(1);

        // Reseta a escolha
        EstadoDoJogo.Instance.NivelDeEnsinoSelecionado = null;
        EstadoDoJogo.Instance.NivelDeEnsinoSelecionado.Sprite = null;

        botaoConfirmar.interactable = false;
    }
}
