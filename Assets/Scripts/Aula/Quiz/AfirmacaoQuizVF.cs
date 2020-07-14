using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Representa uma afirmação de Quiz VF na interface
public class AfirmacaoQuizVF : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] Text textoAfirmacao;

    [SerializeField] Sprite spriteNaoSelecionada;
    [SerializeField] Sprite spriteSelecionada;
    [SerializeField] Sprite spriteCorreta;
    [SerializeField] Sprite spriteErrada;

    private Afirmacao afirmacao;
    public Afirmacao Afirmacao
    {
        get { return afirmacao; }
        set
        {
            afirmacao = value;
            Texto = afirmacao.Texto;
        }
    }

    public string Texto
    {
        get { return textoAfirmacao.text; }
        set { textoAfirmacao.text = value;}
    }

    public bool Selecionada { get; set; }

    private FormatoDeQuizVF meuQuizVF;

    private void Start()
    {
        meuQuizVF = GetComponentInParent<FormatoDeQuizVF>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // Ignorar se o jogador já respondeu o quiz
        if (meuQuizVF.RespostaConfirmada) return;

        Selecionada = !Selecionada;

        GetComponent<Image>().sprite = (Selecionada) ? spriteSelecionada : spriteNaoSelecionada;
    }

    public void DefinirComoAcertoDoJogador() { GetComponent<Image>().sprite = spriteCorreta; }

    public void DefinirComoErroDoJogador() { GetComponent<Image>().sprite = spriteErrada; }
}
