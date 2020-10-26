using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class FormatoDeQuizVF : FormatoDeQuiz
{
    // Representam as etiquetas/faixas/botões com as afirmações na UI
    [SerializeField] AfirmacaoQuizVF[] afirmacoesQuizVF;

    // Pelo menos uma das afirmações deve ser verdadeira
    public override void DefinirAfirmacoes(Afirmacao[] afirmacoes)
    {
        var existeAfirmacaoVerdadeira = afirmacoes.Where(a => a.Verdadeira).Any();
        if (!existeAfirmacaoVerdadeira)
        {
            Debug.LogError("O quiz VF exige pelo menos 1 afirmação verdadeira.");
            return;
        }

        // Se receber + que o número limite de afirmações deste objeto, que é
        // igual a afirmacoesQuizVF.Length, não tentar adicionar + que o limite
        var quantidade = (afirmacoes.Length <= afirmacoesQuizVF.Length) ? afirmacoes.Length : afirmacoesQuizVF.Length;

        // Embaralhar as afirmações usando algoritmo Fisher–Yates Shuffle, O(n)
        for (int i = quantidade - 1; i > 0; i--)
        {
            var randomIndex = UnityEngine.Random.Range(0, i + 1);
            var temp = afirmacoes[randomIndex];
            afirmacoes[randomIndex] = afirmacoes[i];
            afirmacoes[i] = temp;
        }

        for (var i = 0; i < quantidade; i++)
            afirmacoesQuizVF[i].Afirmacao = afirmacoes[i];
    }

    protected override void ConfirmarResposta()
    {
        // Se a resposta do jogador já foi confirmada, ignorar
        if (RespostaConfirmada) return;

        var acertosDoJogador = 0;
        var errosDoJogador = 0;

        // As afirmações selecionadas pelo jogador serão marcadas visualmente como acerto/erro do jogador
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

        // Se o jogador não conseguiu gabaritar o quiz, as afirmações que não
        // foram selecionadas são marcadas como erros do jogador
        // independentemente se ela é verdadeira ou falsa
        // A ideia é mostrar ao jogador que a sua resposta não foi perfeita mas
        // sem entregar quais eram as respostas corretas
        if (TaxaDeAcerto < 1)
        {
            foreach (var afirmacaoNaoSelecionada in afirmacoesQuizVF.Except(afirmacoesSelecionadas))
                afirmacaoNaoSelecionada.DefinirComoErroDoJogador();
        }

        RespostaConfirmada = true;
    }
}
