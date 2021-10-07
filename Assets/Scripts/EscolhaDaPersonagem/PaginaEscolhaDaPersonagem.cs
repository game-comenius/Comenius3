using UnityEngine;
using UnityEngine.UI;

public class PaginaEscolhaDaPersonagem : Pagina
{
    [SerializeField] Image iconePequenoGuia;
    [SerializeField] Image corpoPersonagemSelecionada;
    [SerializeField] Image cabeloPersonagemSelecionada;
    [SerializeField] Image roupaPersonagemSelecionada;
    [SerializeField] Button botaoConfirmar;
    [SerializeField] Image anelDeSelecao;

    private Sprite iconePequenoPadrao;
    private IconePersonagem ultimoSelecionado;

    private void Start()
    {
        iconePequenoPadrao = iconePequenoGuia.sprite;
        anelDeSelecao.enabled = false;
    }

    public void Selecao(IconePersonagem icone)
    {
        AudioManager.instance.TocarSFX("clique");

        if (!icone.Selecionado)
        {
            if (ultimoSelecionado)
            {
                ultimoSelecionado.Selecionado = false;
            }

            ultimoSelecionado = icone;

            // Posicionar anel de seleção sobre o botão selecionado
            anelDeSelecao.enabled = true;
            var posicaoDoBotao = icone.GetComponent<RectTransform>().anchoredPosition;
            anelDeSelecao.rectTransform.anchoredPosition = posicaoDoBotao;

            atualizarSprites(icone);
            atualizarEstadoDeJogo(icone);
        }
        else
        {
            ultimoSelecionado = null;

            anelDeSelecao.enabled = false;

            resetarSprites();
            resetarEstadoDeJogo();
        }

        icone.Selecionado = !icone.Selecionado;
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
        iconePequenoGuia.sprite = icone.GetComponent<Image>().sprite;

        // Gravar no estado do jogo as características da personagem selecionada
        var estadoDoJogo = EstadoDoJogo.Instance;
        estadoDoJogo.SpriteCorpoPersonagem = icone.SpriteCorpo;
        estadoDoJogo.SpriteCabeloPersonagem = icone.SpriteCabelo;
        estadoDoJogo.SpriteRoupaPersonagem = icone.SpriteRoupa;

        estadoDoJogo.SpriteIconePersonagem = icone.GetComponent<Image>().sprite; ;

        // Ativar o botão de confirmar agora que há uma seleção
        botaoConfirmar.gameObject.SetActive(true);
    }

    public void resetarEstadoDeJogo()
    {
        iconePequenoGuia.sprite = iconePequenoPadrao;

        // Gravar no estado do jogo as características da personagem selecionada
        var estadoDoJogo = EstadoDoJogo.Instance;
        estadoDoJogo.SpriteCorpoPersonagem = null;
        estadoDoJogo.SpriteCabeloPersonagem = null;
        estadoDoJogo.SpriteRoupaPersonagem = null;

        estadoDoJogo.SpriteIconePersonagem = null;

        botaoConfirmar.gameObject.SetActive(false);
    }
}
