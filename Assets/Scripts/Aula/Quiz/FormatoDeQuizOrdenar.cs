using UnityEngine;
using System.Linq;
using System;

public class FormatoDeQuizOrdenar : FormatoDeQuiz
{
    // Representam as etiquetas/faixas/botões com as afirmações na UI
    [SerializeField] AfirmacaoQuiz[] afirmacoesQuiz;

    private Afirmacao[] afirmacoesNaOrdemCorreta;

    public override void DefinirAfirmacoes(Afirmacao[] afirmacoesNaOrdemCorreta)
    {
        // Ignorar se não houver "slots" disponíveis pra encaixar as afirmações
        if (afirmacoesQuiz.Length == 0) return;

        // Não tentar adicionar + que o limite de slots disponíveis
        var quantidade = (afirmacoesQuiz.Length <= afirmacoesNaOrdemCorreta.Length) ? afirmacoesQuiz.Length : afirmacoesNaOrdemCorreta.Length;

        // Salvar ordem correta, copiar para campo array da instância
        this.afirmacoesNaOrdemCorreta = new Afirmacao[quantidade];
        for (int i = 0; i < quantidade; i++)
            this.afirmacoesNaOrdemCorreta[i] = afirmacoesNaOrdemCorreta[i];

        // Embaralhar as afirmações usando algoritmo Fisher–Yates Shuffle, O(n)
        for (int i = quantidade - 1; i > 0; i--)
        {
            var randomIndex = UnityEngine.Random.Range(0, i + 1);
            var temp = afirmacoesNaOrdemCorreta[randomIndex];
            afirmacoesNaOrdemCorreta[randomIndex] = afirmacoesNaOrdemCorreta[i];
            afirmacoesNaOrdemCorreta[i] = temp;
        }

        for (var i = 0; i < quantidade; i++)
            afirmacoesQuiz[i].Afirmacao = afirmacoesNaOrdemCorreta[i];
    }

    public void TrocarPosicaoDasAfirmacoes(AfirmacaoQuizOrdenar afirmacao1, Vector2 posicaoAfirmacao1, AfirmacaoQuizOrdenar afirmacao2, Vector2 posicaoAfirmacao2)
    {
        // Ignorar se as duas afirmações não fizerem parte deste quiz
        if (!afirmacoesQuiz.Contains(afirmacao1) && !afirmacoesQuiz.Contains(afirmacao2)) return;

        // Trocar de lugar na UI
        afirmacao1.RTransform.anchoredPosition = posicaoAfirmacao2;
        afirmacao2.RTransform.anchoredPosition = posicaoAfirmacao1;

        // Trocar de lugar no array afirmacoesQuiz
        var indiceAfirmacao1 = Array.IndexOf(afirmacoesQuiz, afirmacao1);
        var indiceAfirmacao2 = Array.IndexOf(afirmacoesQuiz, afirmacao2);
        var temp = afirmacoesQuiz[indiceAfirmacao1];
        afirmacoesQuiz[indiceAfirmacao1] = afirmacoesQuiz[indiceAfirmacao2];
        afirmacoesQuiz[indiceAfirmacao2] = temp;
    }

    protected override void ConfirmarResposta()
    {
        bool acertou = true;
        for (int i = 0; i < afirmacoesQuiz.Length; i++)
        {
            if (afirmacoesQuiz[i].Afirmacao != afirmacoesNaOrdemCorreta[i])
            {
                acertou = false;
                break;
            }
        }

        // Definir taxa de acerto e mostrar sucesso/fracasso
        // Taxa de acerto = 1 a não ser que o jogador erre a ordem correta
        if (acertou)
        {
            TaxaDeAcerto = 1;
            foreach (var afirmacaoQuiz in afirmacoesQuiz)
                afirmacaoQuiz.DefinirComoAcertoDoJogador();
        }
        else
        {
            TaxaDeAcerto = 0;
            foreach (var afirmacaoQuiz in afirmacoesQuiz)
                afirmacaoQuiz.DefinirComoErroDoJogador();
        }

        RespostaConfirmada = true;
    }
}
