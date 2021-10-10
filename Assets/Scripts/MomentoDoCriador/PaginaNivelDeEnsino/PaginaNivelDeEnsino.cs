using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using TMPro;

public class PaginaNivelDeEnsino : Pagina
{
    public IconManager iconManager;

    [SerializeField] Text nomeDoSelecionado;
    [SerializeField] Text descricaoDoSelecionado;
    [SerializeField] PaginaAreaDeConhecimento paginaAreaDeConhecimento;
    [SerializeField] Button botaoConfirmar;
    [SerializeField] Image anelDeSelecao;

    public string nomePadrao;

    [TextArea]
    public string descricaoPadrao;

    private IconeNivelDeEnsino ultimoSelecionado;

    private void Start()
    {
        anelDeSelecao.enabled = false;
        botaoConfirmar.interactable = false;
    
        // Limpar nome do selecionado e descrição
        nomeDoSelecionado.text = nomePadrao;
        descricaoDoSelecionado.text = descricaoPadrao;
    }

    public void Selecao(IconeNivelDeEnsino icone)
    {
        AudioManager.instance.TocarSFX("clique");
        // paginaAreaDeConhecimento.DesfazerEscolha();

        if (!icone.selecionado)
        {
            if (ultimoSelecionado)
            {
                ultimoSelecionado.selecionado = false;
            }

            ultimoSelecionado = icone;

            anelDeSelecao.enabled = true;
            var posicaoDoIcone = icone.GetComponent<RectTransform>().anchoredPosition;
            anelDeSelecao.rectTransform.anchoredPosition = posicaoDoIcone;

            atualizarTexto(icone);
            atualizarEstadoDeJogo(icone);
        }
        else
        {
            ultimoSelecionado = null;
            anelDeSelecao.enabled = false;

            resetarTexto();
            resetarEstadoDeJogo();
        }

        icone.selecionado = !icone.selecionado;
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
        nomeDoSelecionado.text = icone.Valor.nome;
        descricaoDoSelecionado.text = icone.Valor.Descricao;
    }

    public void resetarTexto()
    {
        anelDeSelecao.enabled = false;
        botaoConfirmar.interactable = false;

        nomeDoSelecionado.text = nomePadrao;
        descricaoDoSelecionado.text = descricaoPadrao;
    }

    public void atualizarEstadoDeJogo(IconeNivelDeEnsino icone)
    {
        iconManager.SetIcon(1, icone.GetComponent<Image>().sprite);

        EstadoDoJogo.Instance.NivelDeEnsinoSelecionado = icone.Valor;
        EstadoDoJogo.Instance.NivelDeEnsinoSelecionado.Sprite = icone.GetComponent<Image>().sprite;

        botaoConfirmar.interactable = true;
    }

    public void resetarEstadoDeJogo()
    {
        iconManager.ResetIcon(1);

        EstadoDoJogo.Instance.NivelDeEnsinoSelecionado = null;
        EstadoDoJogo.Instance.NivelDeEnsinoSelecionado.Sprite = null;

        botaoConfirmar.interactable = false;
    }
}
