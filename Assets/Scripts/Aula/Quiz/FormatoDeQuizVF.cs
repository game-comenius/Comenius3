using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class FormatoDeQuizVF : FormatoDeQuiz
{
    // Representam as etiquetas/faixas/botões com as afirmações na UI
    [SerializeField] AfirmacaoQuizVF[] afirmacoesQuizVF;

    public void DefinirAfirmacoes(Afirmacao[] afirmacoes)
    {
        // Se receber + que o número limite de afirmações deste objeto, que é
        // igual a afirmacoesQuizVF.Length, não tentar adicionar + que o limite
        var quantidade = (afirmacoes.Length <= afirmacoesQuizVF.Length) ? afirmacoes.Length : afirmacoesQuizVF.Length;
        for (var i = 0; i < quantidade; i++)
            afirmacoesQuizVF[i].Afirmacao = afirmacoes[i];
    }

    protected override void ConfirmarResposta()
    {
        // Se a resposta do jogador já foi confirmada, ignorar
        if (RespostaConfirmada) return;

        var acertosDoJogador = 0;
        var errosDoJogador = 0;

        // Apenas afirmações selecionadas pelo jogador serão marcadas como
        // verdadeiras/falsas mesmo que outras afirmações sejam verdadeiras/falsas
        // Estas últimas ficarão como um suspense para o jogador
        var afirmacoesSelecionadas = afirmacoesQuizVF.Where((a) => a.Selecionada);
        foreach (var afirmacaoSelecionada in afirmacoesSelecionadas)
        {
            if (afirmacaoSelecionada.Afirmacao.Verdadeira)
            {
                acertosDoJogador++;
                afirmacaoSelecionada.DefinirComoAcertoDoJogador();
            }
            else
            {
                errosDoJogador++;
                afirmacaoSelecionada.DefinirComoErroDoJogador();
            }
        }

        // Definir taxa de acerto do quiz VF
        var afirmacoesVerdadeiras = afirmacoesQuizVF.Where((a) => a.Afirmacao.Verdadeira).Count();
        var pontuacao = acertosDoJogador - errosDoJogador;

        if (afirmacoesVerdadeiras != 0)
        {
            TaxaDeAcerto = (float)pontuacao / afirmacoesVerdadeiras;
            // Taxas de acerto menores que 0 não fazem sentido, por enquanto
            if (TaxaDeAcerto < 0) TaxaDeAcerto = 0;
        }
        else
        {
            // Caso especial para quando todas as afirmações são falsas
            // Basta o jogador não responder nenhuma errada para ganhar nota máxima
            TaxaDeAcerto = errosDoJogador == 0 ? 1 : 0;
        }

        RespostaConfirmada = true;
    }
}
