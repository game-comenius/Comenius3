using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class QuizMetodologiaSalaInvertida : Quiz
{
    // Quiz sobre a metodologia ABP pode ter 2 formatos: ordenar e múltipla escolha
    // Apenas um dos prefabs será instanciado por vez
    [Header("Formatos de Quiz")]
    [SerializeField] FormatoDeQuizOrdenar prefabQuizOrdenar;
    [SerializeField] FormatoDeQuizMultiplaEscolha prefabQuizMultiplaEscolha;
    private FormatoDeQuiz formatoDoQuiz;
    [SerializeField] PlanilhaDoGoogle planilhaDoQuizz;

    [SerializeField] Sprite spriteDoIconeDoQuiz;

    public override float TaxaDeAcerto
    {
        get { return (estado == EstadoDeQuiz.Executado) ? formatoDoQuiz.TaxaDeAcerto : 0; }
    }

    public override IEnumerator Executar()
    {
        GerarQuiz();

        estado = EstadoDeQuiz.EmExecucao;

        formatoDoQuiz.Mostrar();

        yield return new WaitUntil(() => formatoDoQuiz.RespostaConfirmada);

        // Mostrar se o jogador acertou ou errou nas suas escolhas
        StartCoroutine(PassarTempoParaAvaliarResposta());
        yield return new WaitUntil(() => formatoDoQuiz.JogadorPediuParaFechar || tempoParaAvaliarRespostaPassou);

        formatoDoQuiz.Esconder();

        estado = EstadoDeQuiz.Executado;
        OnQuizzExit.Invoke(TaxaDeAcerto);
    }

    private void GerarQuiz()
    {
        // As informações sobre os enunciados e afirmações dos quizzes desta
        // metodologia foram retirados deste documento do drive
        // https://docs.google.com/document/d/1VQRlVu3IrM3_BZZWHb9cD6qSskkU-3zsUSs_m1YI9lY/edit

        int quantidadeDeQuizzesDisponiveis = 3;
        var quizSorteado = Random.Range(0, quantidadeDeQuizzesDisponiveis);

        // Gerar apenas o quiz sorteado
        if (quizSorteado == 1)
        {
            var quizMultiplaEscolha = Instantiate(prefabQuizMultiplaEscolha, canvas.transform);

            quizMultiplaEscolha.TextoDoEnunciado = planilhaDoQuizz.GetDataAt(2, 1);
            Afirmacao[] afirmacoes =
            {
                new Afirmacao(false, planilhaDoQuizz.GetDataAt(2, 2)),
                new Afirmacao(false, planilhaDoQuizz.GetDataAt(2, 3)),
                new Afirmacao(false, planilhaDoQuizz.GetDataAt(2, 4)),
                new Afirmacao(true, planilhaDoQuizz.GetDataAt(2, 5)),
            };
            formatoDoQuiz = quizMultiplaEscolha;
            quizMultiplaEscolha.DefinirAfirmacoes(afirmacoes);
        }
        else if (quizSorteado == 2)
        {
            var quizMultiplaEscolha = Instantiate(prefabQuizMultiplaEscolha, canvas.transform);

            quizMultiplaEscolha.TextoDoEnunciado = planilhaDoQuizz.GetDataAt(3, 1);
            Afirmacao[] afirmacoes =
            {
                new Afirmacao(false, planilhaDoQuizz.GetDataAt(3, 2)),
                new Afirmacao(false, planilhaDoQuizz.GetDataAt(3, 3)),
                new Afirmacao(false, planilhaDoQuizz.GetDataAt(3, 4)),
                new Afirmacao(true, planilhaDoQuizz.GetDataAt(3, 5)),
            };
            formatoDoQuiz = quizMultiplaEscolha;
            quizMultiplaEscolha.DefinirAfirmacoes(afirmacoes);
        }
        else // quizSorteado == 0
        {
            var quizOrdenar = Instantiate(prefabQuizOrdenar, canvas.transform);

            quizOrdenar.TextoDoEnunciado = planilhaDoQuizz.GetDataAt(1, 1);
            Afirmacao[] afirmacoesNaOrdemCorreta =
            {
                new Afirmacao(true, planilhaDoQuizz.GetDataAt(1, 2)),
                new Afirmacao(false, planilhaDoQuizz.GetDataAt(1, 3)),
                new Afirmacao(false, planilhaDoQuizz.GetDataAt(1, 4)),
            };

            formatoDoQuiz = quizOrdenar;
            quizOrdenar.DefinirAfirmacoes(afirmacoesNaOrdemCorreta);
        }

        formatoDoQuiz.IconeDoQuiz.sprite = spriteDoIconeDoQuiz;
    }
}