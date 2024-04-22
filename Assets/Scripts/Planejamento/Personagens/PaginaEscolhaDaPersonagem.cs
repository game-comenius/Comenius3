using UnityEngine;
using UnityEngine.UI;

public class PaginaEscolhaDaPersonagem : PaginaPlanejamento
{
    [SerializeField] private Image corpoPersonagemSelecionada;
    [SerializeField] private Image cabeloPersonagemSelecionada;
    [SerializeField] private Image roupaPersonagemSelecionada;
    [SerializeField] private Button botaoConfirmar;
    [SerializeField] private Image anelDeSelecao;

    private IconePersonagem iconeSelecionado;

    private void Start()
    {
        botaoConfirmar.interactable = false;
        anelDeSelecao.enabled = false;  // Desabilita a imagem do anel de seleção
    }

    protected override void OnEnable()
    {
        AtualizarTextos();
        fundo.sprite = spriteFundo;

        textoAjuda.text = ajuda;

        iconManager.ShowIcon(0);
        iconManager.ShowIcon(1);
        iconManager.ShowIcon(2);
        iconManager.ShowIcon(3);

        if (iconeSelecionado != null)
        {
            iconManager.SetIcon(0, iconeSelecionado.GetComponent<Image>().sprite);
        }
    }

    public void Selecao(IconePersonagem icone)
    {
        AudioManager.instance.TocarSFX("clique");

        if (!icone.selecionado)  // O ícone foi selecionado
        {
            // Marca o último ícone selecionado como falso
            if (iconeSelecionado != null)
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

    public void HoverEnter(IconePersonagem icone)
    {
        if (iconeSelecionado == null)
        {
            atualizar(icone);
        }
    }

    public void HoverExit()
    {
        if (iconeSelecionado == null)
        {
            resetar();
        }
    }

    private void atualizar(IconePersonagem icone)
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

    private void resetar()
    {
        corpoPersonagemSelecionada.gameObject.SetActive(false);
        cabeloPersonagemSelecionada.gameObject.SetActive(false);
        roupaPersonagemSelecionada.gameObject.SetActive(false);
    }

    private void atualizarEstadoDeJogo(IconePersonagem icone)
    {
        // Altera o sprite do pequeno guia da página para o sprite do selecionado
        iconManager.SetIcon(0, icone.GetComponent<Image>().sprite);

        // Grava no estado do jogo as características da personagem selecionada
        var estadoDoJogo = EstadoDoJogo.Instance;
        estadoDoJogo.SpriteCorpoPersonagem = icone.SpriteCorpo;
        estadoDoJogo.SpriteCabeloPersonagem = icone.SpriteCabelo;
        estadoDoJogo.SpriteRoupaPersonagem = icone.SpriteRoupa;
        estadoDoJogo.SpriteCorpoPersonagemSentado = icone.SpriteCorpoSentado;
        estadoDoJogo.SpriteCabeloPersonagemSentado = icone.SpriteCabeloSentado;
        estadoDoJogo.SpriteRoupaPersonagemSentado = icone.SpriteRoupaSentado;
        estadoDoJogo.SpriteIconePersonagem = icone.GetComponent<Image>().sprite;

        // Ativar o botão de confirmar agora que há uma seleção
        botaoConfirmar.interactable = true;
    }

    private void resetarEstadoDeJogo()
    {
        iconManager.ResetIcon(0);

        // Reseta a escolha
        var estadoDoJogo = EstadoDoJogo.Instance;
        estadoDoJogo.SpriteCorpoPersonagem = null;
        estadoDoJogo.SpriteCabeloPersonagem = null;
        estadoDoJogo.SpriteRoupaPersonagem = null;
        estadoDoJogo.SpriteCorpoPersonagemSentado = null;
        estadoDoJogo.SpriteCabeloPersonagemSentado = null;
        estadoDoJogo.SpriteRoupaPersonagemSentado = null;
        estadoDoJogo.SpriteIconePersonagem = null;

        botaoConfirmar.interactable = false;
    }
}
