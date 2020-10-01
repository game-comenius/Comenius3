using UnityEngine;
using System.Linq;

public class FormatoDeQuizMultiplaEscolha : FormatoDeQuiz
{
    // Representam as etiquetas/faixas/botões com as afirmações na UI
    [SerializeField] AfirmacaoQuizMultiplaEscolha[] afirmacoesQuizMultiplaEscolha;

    protected override void Start()
    {
        base.Start();

        // Esconder o botão confirmar até que o jogador selecione uma afirmação
        BotaoConfirmar.gameObject.SetActive(false);

        // Definir função que será chamada sempre que uma afirmação for clicada
        foreach (var afirmacao in afirmacoesQuizMultiplaEscolha)
            afirmacao.FuiClicadaEvent += SelecionarAfirmacao;
    }

    public override void DefinirAfirmacoes(Afirmacao[] afirmacoes)
    {
        var busca = afirmacoes.Where(afirmacao => afirmacao.Verdadeira);
        // Ignorar se houver mais de 1 afirmação verdadeira
        if (busca.Count() != 1) return;

        var afirmacaoVerdadeira = busca.Single();
        var afirmacoesFalsas = afirmacoes.Except(busca).ToArray();

        DefinirAfirmacoes(afirmacaoVerdadeira, afirmacoesFalsas);
    }

    public void DefinirAfirmacoes(Afirmacao afirmacaoVerdadeira, Afirmacao[] afirmacoesFalsas)
    {
        // Ignorar se não houver "slots" disponíveis pra encaixar as afirmações
        if (afirmacoesQuizMultiplaEscolha.Length == 0) return;

        // Se receber + que o número limite de afirmações deste objeto, que é
        // igual a afirmacoesQuizMultiplaEscolha.Length, não tentar adicionar + que o limite
        var quantidade = (afirmacoesFalsas.Length + 1 <= afirmacoesQuizMultiplaEscolha.Length) ? (afirmacoesFalsas.Length + 1) : afirmacoesQuizMultiplaEscolha.Length;

        // Juntar afirmação verdadeira e afirmações falsas em um único array
        var afirmacoes = new Afirmacao[quantidade];
        afirmacoes[0] = afirmacaoVerdadeira;
        for (int i = 1; i < quantidade; i++)
            afirmacoes[i] = afirmacoesFalsas[i - 1];

        // Embaralhar as afirmações usando algoritmo Fisher–Yates Shuffle, O(n)
        for (int i = quantidade - 1; i > 0; i--)
        {
            var randomIndex = Random.Range(0, i + 1);
            var temp = afirmacoes[randomIndex];
            afirmacoes[randomIndex] = afirmacoes[i];
            afirmacoes[i] = temp;
        }

        for (var i = 0; i < quantidade; i++)
            afirmacoesQuizMultiplaEscolha[i].Afirmacao = afirmacoes[i];
    }

    private void SelecionarAfirmacao(AfirmacaoQuizMultiplaEscolha afirmacaoQueFoiClicada)
    {
        foreach (var afirmacao in afirmacoesQuizMultiplaEscolha)
            afirmacao.Selecionada = (afirmacao == afirmacaoQueFoiClicada);

        // Se existe uma afirmação selecionada, o botão confirmar fica disponível
        BotaoConfirmar.gameObject.SetActive(true);
    }

    protected override void ConfirmarResposta()
    {
        // Se a resposta do jogador já foi confirmada, ignorar
        if (RespostaConfirmada) return;

        var respostaSelecionada = afirmacoesQuizMultiplaEscolha.Where(afirmacaoQuizME => afirmacaoQuizME.Selecionada).Single();
        var respostaVerdadeira = afirmacoesQuizMultiplaEscolha.Where(afirmacaoQuizME => afirmacaoQuizME.Afirmacao.Verdadeira).Single();
        var acertou = (respostaSelecionada == respostaVerdadeira);
        
        if (acertou)
        {
            respostaVerdadeira.DefinirComoAcertoDoJogador();

            TaxaDeAcerto = 1;
        }
        else
        {
            // Mostrar que a afirmação selecionada estava errada
            respostaSelecionada.DefinirComoErroDoJogador();
            // Mostrar qual era a resposta correta
            respostaVerdadeira.DefinirComoAcertoDoJogador();

            TaxaDeAcerto = 0;
        }

        RespostaConfirmada = true;
    }
}
