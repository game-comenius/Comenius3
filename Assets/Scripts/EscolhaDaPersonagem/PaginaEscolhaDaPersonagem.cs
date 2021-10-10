using UnityEngine;
using UnityEngine.UI;

public class PaginaEscolhaDaPersonagem : Pagina
{
    public IconManager iconManager;

    [SerializeField] Image corpoPersonagemSelecionada;
    [SerializeField] Image cabeloPersonagemSelecionada;
    [SerializeField] Image roupaPersonagemSelecionada;
    [SerializeField] Button botaoConfirmar;
    [SerializeField] Image anelDeSelecao;

    private IconePersonagem ultimoSelecionado;

    private void Start()
    {
        botaoConfirmar.interactable = false;
        anelDeSelecao.enabled = false;  // Desabilita a imagem do anel de seleção
    }

    public void Selecao(IconePersonagem icone)
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

            // Posicionar anel de seleção sobre o botão selecionado
            anelDeSelecao.enabled = true;
            var posicaoDoIcone = icone.GetComponent<RectTransform>().anchoredPosition;
            anelDeSelecao.rectTransform.anchoredPosition = posicaoDoIcone;

            atualizarSprites(icone);
            atualizarEstadoDeJogo(icone);
        }
        else  // Cancela a seleção do ícone caso o jogador clique nele de novo
        {
            // Redefine a seleção
            ultimoSelecionado = null;
            anelDeSelecao.enabled = false;

            resetarSprites();
            resetarEstadoDeJogo();
        }

        icone.selecionado = !icone.selecionado;  // Inverte o estado de seleção
    }

    public void HoverEnter(IconePersonagem icone)
    {
        if (!ultimoSelecionado)
        {
            atualizarSprites(icone);
        }
    }

    public void HoverExit()
    {
        if (!ultimoSelecionado)
        {
            resetarSprites();
        }
    }

    public void atualizarSprites(IconePersonagem icone)
    {
        // Ativar sprites do preview
        corpoPersonagemSelecionada.gameObject.SetActive(true);
        cabeloPersonagemSelecionada.gameObject.SetActive(true);
        roupaPersonagemSelecionada.gameObject.SetActive(true);

        // Alterar o preview da personagem selecionada
        corpoPersonagemSelecionada.sprite = icone.SpriteCorpo;
        cabeloPersonagemSelecionada.sprite = icone.SpriteCabelo;
        roupaPersonagemSelecionada.sprite = icone.SpriteRoupa;
    }

    public void resetarSprites()
    {
        corpoPersonagemSelecionada.gameObject.SetActive(false);
        cabeloPersonagemSelecionada.gameObject.SetActive(false);
        roupaPersonagemSelecionada.gameObject.SetActive(false);
    }

    public void atualizarEstadoDeJogo(IconePersonagem icone)
    {
        // Alterar sprite do pequeno guia da página para o sprite do selecionado
        iconManager.SetIcon(0, icone.GetComponent<Image>().sprite);

        // Gravar no estado do jogo as características da personagem selecionada
        var estadoDoJogo = EstadoDoJogo.Instance;
        estadoDoJogo.SpriteCorpoPersonagem = icone.SpriteCorpo;
        estadoDoJogo.SpriteCabeloPersonagem = icone.SpriteCabelo;
        estadoDoJogo.SpriteRoupaPersonagem = icone.SpriteRoupa;
        estadoDoJogo.SpriteIconePersonagem = icone.GetComponent<Image>().sprite; ;

        // Ativar o botão de confirmar agora que há uma seleção
        botaoConfirmar.interactable = true;
    }

    public void resetarEstadoDeJogo()
    {
        iconManager.ResetIcon(0);

        // Gravar no estado do jogo as características da personagem selecionada
        var estadoDoJogo = EstadoDoJogo.Instance;
        estadoDoJogo.SpriteCorpoPersonagem = null;
        estadoDoJogo.SpriteCabeloPersonagem = null;
        estadoDoJogo.SpriteRoupaPersonagem = null;
        estadoDoJogo.SpriteIconePersonagem = null;

        // Desativa o botão de confirmar
        botaoConfirmar.interactable = false;
    }
}
