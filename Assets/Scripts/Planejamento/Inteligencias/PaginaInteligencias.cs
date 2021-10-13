using UnityEngine;
using UnityEngine.UI;

public class PaginaInteligencias : Pagina
{
    [SerializeField] private string nomePadrao;
    [SerializeField] private IconManager iconManager;
    [SerializeField] private Text nomeDoSelecionado;
    [SerializeField] private Text descricaoDoSelecionado;
    [SerializeField] private Button botaoConfirmar;
    [SerializeField] private Image anelDeSelecao;
    [SerializeField] [TextArea] private string descricaoPadrao;

    private IconeInteligencias iconeSelecionado;

    private void Start()
    {
        anelDeSelecao.enabled = false;
        botaoConfirmar.interactable = false;
    
        nomeDoSelecionado.text = nomePadrao;
        descricaoDoSelecionado.text = descricaoPadrao;
    }

    public void Selecao(IconeInteligencias icone)
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

    public void HoverEnter(IconeInteligencias icone)
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

    public void atualizarTexto(IconeInteligencias icone)
    {
        nomeDoSelecionado.text = icone.inteligencia.nome;
        descricaoDoSelecionado.text = icone.inteligencia.descricao;
    }

    public void resetarTexto()
    {
        nomeDoSelecionado.text = nomePadrao;
        descricaoDoSelecionado.text = descricaoPadrao;
    }

    public void atualizarEstadoDeJogo(IconeInteligencias icone)
    {
        // Altera o sprite do pequeno guia da página para o sprite do selecionado
        iconManager.SetIcon(3, icone.GetComponent<Image>().sprite);

        // Grava o nível de ensino selecionado
        EstadoDoJogo.Instance.InteligenciasSelecionadas = icone.inteligencia;
        EstadoDoJogo.Instance.InteligenciasSelecionadas.sprite = icone.GetComponent<Image>().sprite;

        // Ativar o botão de confirmar agora que há uma seleção
        botaoConfirmar.interactable = true;
    }

    public void resetarEstadoDeJogo()
    {
        iconManager.ResetIcon(3);

        // Reseta a escolha
        EstadoDoJogo.Instance.InteligenciasSelecionadas = null;
        EstadoDoJogo.Instance.InteligenciasSelecionadas.sprite = null;

        botaoConfirmar.interactable = false;
    }
}
