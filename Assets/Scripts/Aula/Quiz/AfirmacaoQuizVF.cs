using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Representa uma afirmação de Quiz VF na interface
public class AfirmacaoQuizVF : AfirmacaoQuiz
{
    [SerializeField] Sprite spriteNaoSelecionada;
    [SerializeField] Sprite spriteSelecionada;

    public bool Selecionada { get; set; }

    private FormatoDeQuizVF meuQuizVF;


    private void Start()
    {
        meuQuizVF = GetComponentInParent<FormatoDeQuizVF>();
    }

    public override void OnPointerClick(PointerEventData eventData)
    {
        // Ignorar se o jogador já respondeu o quiz
        if (meuQuizVF.RespostaConfirmada) return;

        Selecionada = !Selecionada;

        GetComponent<Image>().sprite = (Selecionada) ? spriteSelecionada : spriteNaoSelecionada;
    }
}
