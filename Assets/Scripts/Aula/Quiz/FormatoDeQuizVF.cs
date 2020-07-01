using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormatoDeQuizVF : FormatoDeQuiz
{
    // Representam as etiquetas/faixas/botões com as afirmações na UI
    [SerializeField] AfirmacaoQuizVF[] afirmacoesQuizVF;

    // Representam os textos, as afirmações verdadeiras ou falsas de fato
    private Afirmacao[] afirmacoes;

    public void DefinirAfirmacoes(Afirmacao[] afirmacoes)
    {
        this.afirmacoes = afirmacoes;

        // Se receber + que o número limite de afirmações deste objeto, que é
        // igual a afirmacoesQuizVF.Length, não tentar adicionar + que o limite
        var quantidade = (afirmacoes.Length <= afirmacoesQuizVF.Length) ? afirmacoes.Length : afirmacoesQuizVF.Length;
        for (var i = 0; i < quantidade; i++)
        {
            afirmacoesQuizVF[i].Texto = afirmacoes[i].Texto;
        }
    }
}
