using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Arrastavel))]
public class AfirmacaoQuizOrdenar : AfirmacaoQuiz, IDropHandler
{
    public RectTransform RTransform { get; private set; }

    public Arrastavel ComponenteArrastavel { get; private set; }

    private FormatoDeQuizOrdenar quizOrdenar;

    private void Awake()
    {
        RTransform = GetComponent<RectTransform>();
        ComponenteArrastavel = GetComponent<Arrastavel>();
        quizOrdenar = GetComponentInParent<FormatoDeQuizOrdenar>();
    }

    private void Start()
    {
        ComponenteArrastavel.devoVoltarParaAnchoredPositionInicialAposSerArrastado = true;
    }

    public override void OnPointerClick(PointerEventData eventData) { return; }

    public void OnDrop(PointerEventData eventData)
    {
        var objetoArrastadoAteAqui = eventData.pointerDrag.GetComponent<AfirmacaoQuizOrdenar>();
        // Ignorar se o objeto arrastado até aqui não for outra afirmação como esta
        if (!objetoArrastadoAteAqui) return;

        quizOrdenar.TrocarPosicaoDasAfirmacoes(
            this, this.RTransform.anchoredPosition,
            objetoArrastadoAteAqui, objetoArrastadoAteAqui.ComponenteArrastavel.anchoredPositionInicial);

        // Como o objeto arrastado até aqui foi colocado no lugar correto,
        // ele não deve voltar para a posição inicial dele
        objetoArrastadoAteAqui.ComponenteArrastavel.devoVoltarParaAnchoredPositionInicialAposSerArrastado = false;
        // Porém, após esta ação de arrastar e soltar, o jogador pode arrastar o
        // objeto arrastado até aqui para um lugar inválido e portanto ele deve
        // voltar ao comportamento padrão, que é voltar ao seu lugar original
        objetoArrastadoAteAqui.ComponenteArrastavel.OnEndDragEvent +=
            (arrastavel) => arrastavel.devoVoltarParaAnchoredPositionInicialAposSerArrastado = true;
    }
}
