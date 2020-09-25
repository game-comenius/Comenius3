using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AfirmacaoQuizMultiplaEscolha : AfirmacaoQuiz
{
    public event Action<AfirmacaoQuizMultiplaEscolha> FuiClicadaEvent;

    [SerializeField] Sprite spriteSelecionada;
    [SerializeField] Sprite spriteNaoSelecionada;

    private bool selecionada = false;
    public bool Selecionada
    {
        get => selecionada;
        set
        {
            selecionada = value;
            image.sprite = (selecionada) ? spriteSelecionada : spriteNaoSelecionada;
        }
    }

    private Image image;
    private FormatoDeQuiz meuQuiz;

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    private void Start()
    {
        meuQuiz = GetComponentInParent<FormatoDeQuiz>();
    }

    public override void OnPointerClick(PointerEventData eventData)
    {
        // Ignorar se o jogador já respondeu o quiz ou tenta selecionar novamente
        if (meuQuiz.RespostaConfirmada || Selecionada) return;

        FuiClicadaEvent?.Invoke(this);
    }
}
