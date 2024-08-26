using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PaginaNivelDeEnsino : PaginaPlanejamento
{
    [SerializeField] private TextMeshProUGUI description;
    [SerializeField] private Button botaoConfirmar;
    [SerializeField] private Image anelDeSelecao;
    [SerializeField] [TextArea] private string descricaoPadrao;
    [SerializeField][TextArea] private string descricaoEua;
    [SerializeField][TextArea] private string descricaoEspanhol;
    private IconeNivelDeEnsino iconeSelecionado;

    private void Start()
    {
        anelDeSelecao.enabled = false;
        botaoConfirmar.interactable = false;


        switch (Textos.GetIdiomaSelecionado())
        {
            case Idiomas.INGLES:
                description.text = descricaoEua;
                break;
            case Idiomas.PORTUGUES:
                description.text = descricaoPadrao;
                break;
            case Idiomas.ESPANHOL:
                description.text = descricaoEspanhol;
                break;
            default:
                break;
        }
   
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
            iconManager.SetIcon(1, iconeSelecionado.GetComponent<Image>().sprite);
        }
        resetar();
    }

    public void Selecao(IconeNivelDeEnsino icone)
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

    public void HoverEnter(IconeNivelDeEnsino icone)
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

    private void atualizar(IconeNivelDeEnsino icone)
    {
        NivelDeEnsino.AtualizarTextosLinguas();
        description.text = icone.nivelDeEnsino.descricao;
    }

    private void resetar()
    {
        switch (Textos.GetIdiomaSelecionado())
        {
            case Idiomas.INGLES:
                description.text = descricaoEua;
                break;
            case Idiomas.PORTUGUES:
                description.text = descricaoPadrao;
                break;
            case Idiomas.ESPANHOL:
                description.text = descricaoEspanhol;
                break;
            default:
                break;
        }
    }

    private void atualizarEstadoDeJogo(IconeNivelDeEnsino icone)
    {
        // Altera o sprite do pequeno guia da página para o sprite do selecionado
        iconManager.SetIcon(1, icone.GetComponent<Image>().sprite);

        // Grava o nível de ensino selecionado
        EstadoDoJogo.Instance.NivelDeEnsino = icone.nivelDeEnsino;
        EstadoDoJogo.Instance.NivelDeEnsino.sprite = icone.GetComponent<Image>().sprite;

        // Ativar o botão de confirmar agora que há uma seleção
        botaoConfirmar.interactable = true;
    }

    private void resetarEstadoDeJogo()
    {
        iconManager.ResetIcon(1);

        // Reseta a escolha
        EstadoDoJogo.Instance.NivelDeEnsino.sprite = null;
        EstadoDoJogo.Instance.NivelDeEnsino = null;

        botaoConfirmar.interactable = false;
    }
}
