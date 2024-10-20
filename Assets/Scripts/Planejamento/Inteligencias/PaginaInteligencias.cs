﻿using UnityEngine;
using UnityEngine.UI;

public class PaginaInteligencias : PaginaPlanejamento
{
    [SerializeField] private Text descricaoDoSelecionado;
    [SerializeField] private Button botaoConfirmar;
    [SerializeField] private Image anelDeSelecao;
    [SerializeField] [TextArea] private string descricaoPadrao;
    [SerializeField][TextArea] private string descricaoEua;
    [SerializeField][TextArea] private string descricaoEspanhol;
    private IconeInteligencias iconeSelecionado;

    private void Start()
    {
        anelDeSelecao.enabled = false;
        botaoConfirmar.interactable = false;

        switch (Textos.GetIdiomaSelecionado())
        {
            case Idiomas.INGLES:
                descricaoPadrao = descricaoEua;
                break;
            case Idiomas.PORTUGUES:

                break;
            case Idiomas.ESPANHOL:
                descricaoPadrao = descricaoEspanhol;
                break;
            default:
                break;

        }
        resetar();
    }

    protected override void OnEnable()
    {
        AtualizarTextos();
        fundo.sprite = spriteFundo;

        switch (Textos.GetIdiomaSelecionado())
        {
            case Idiomas.INGLES:
                descricaoPadrao = descricaoEua;
                break;
            case Idiomas.PORTUGUES:

                break;
            case Idiomas.ESPANHOL:
                descricaoPadrao = descricaoEspanhol;
                break;
            default:
                break;
        }
        textoAjuda.text = ajuda;

        iconManager.ShowIcon(0);
        iconManager.ShowIcon(1);
        iconManager.ShowIcon(2);
        iconManager.ShowIcon(3);

        if (iconeSelecionado != null)
        {
            iconManager.SetIcon(3, iconeSelecionado.GetComponent<Image>().sprite);
        }
        resetar();
    }

    public void Selecao(IconeInteligencias icone)
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

    public void HoverEnter(IconeInteligencias icone)
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

    private void atualizar(IconeInteligencias icone)
    {
        descricaoDoSelecionado.text = icone.inteligencia.descricao;
    }

    private void resetar()
    {
        Inteligencias.AtualizarTextosLinguas();
        descricaoDoSelecionado.text = descricaoPadrao;

    }

    private void atualizarEstadoDeJogo(IconeInteligencias icone)
    {
        // Altera o sprite do pequeno guia da página para o sprite do selecionado
        iconManager.SetIcon(3, icone.GetComponent<Image>().sprite);

        // Grava o nível de ensino selecionado
        EstadoDoJogo.Instance.Inteligencias = icone.inteligencia;
        EstadoDoJogo.Instance.Inteligencias.sprite = icone.GetComponent<Image>().sprite;

        // Ativar o botão de confirmar agora que há uma seleção
        botaoConfirmar.interactable = true;
    }

    private void resetarEstadoDeJogo()
    {
        iconManager.ResetIcon(3);

        // Reseta a escolha
        EstadoDoJogo.Instance.Inteligencias.sprite = null;
        EstadoDoJogo.Instance.Inteligencias = null;

        botaoConfirmar.interactable = false;
    }
}
