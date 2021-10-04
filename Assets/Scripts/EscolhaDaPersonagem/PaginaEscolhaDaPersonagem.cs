using UnityEngine;
using UnityEngine.UI;

public class PaginaEscolhaDaPersonagem : Pagina
{
    [SerializeField] Image iconePequenoGuia;

    [SerializeField] GrupoDeIconesPersonagem grupoDeIconesPersonagem;

    [SerializeField] Image corpoPersonagemSelecionada;
    [SerializeField] Image cabeloPersonagemSelecionada;
    [SerializeField] Image roupaPersonagemSelecionada;

    [SerializeField] Button botaoConfirmar;

    private Sprite iconePequenoPadrao;

    private void Start() {
        iconePequenoPadrao = iconePequenoGuia.sprite;
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

    public void atualizarEstadoDeJogo(IconePersonagem icone)
    {
        // Alterar sprite do pequeno guia da página para o sprite do selecionado
        iconePequenoGuia.sprite = icone.ImageComponent.sprite;

        // Gravar no estado do jogo as características da personagem selecionada
        var estadoDoJogo = EstadoDoJogo.Instance;
        estadoDoJogo.SpriteCorpoPersonagem = icone.SpriteCorpo;
        estadoDoJogo.SpriteCabeloPersonagem = icone.SpriteCabelo;
        estadoDoJogo.SpriteRoupaPersonagem = icone.SpriteRoupa;

        estadoDoJogo.SpriteIconePersonagem = icone.ImageComponent.sprite;

        // Ativar o botão de confirmar agora que há uma seleção
        botaoConfirmar.gameObject.SetActive(true);
    }

    public void resetarSprites()
    {
        corpoPersonagemSelecionada.gameObject.SetActive(false);
        cabeloPersonagemSelecionada.gameObject.SetActive(false);
        roupaPersonagemSelecionada.gameObject.SetActive(false);
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
