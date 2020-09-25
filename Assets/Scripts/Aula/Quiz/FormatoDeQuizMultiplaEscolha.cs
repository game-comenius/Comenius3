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
        // Se receber + que o número limite de afirmações deste objeto, que é
        // igual a afirmacoesQuizMultiplaEscolha.Length, não tentar adicionar + que o limite
        var quantidade = (afirmacoes.Length <= afirmacoesQuizMultiplaEscolha.Length) ? afirmacoes.Length : afirmacoesQuizMultiplaEscolha.Length;

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

        // Buscar por resposta selecionada e ao mesmo tempo verdadeira usando System.Linq
        var busca = afirmacoesQuizMultiplaEscolha.Where(afirmacaoQuizME =>
            afirmacaoQuizME.Selecionada && afirmacaoQuizME.Afirmacao.Verdadeira);
        // Se uma afirmação satisfez às exigências da busca, o jogador acertou
        var acertou = (busca.SingleOrDefault() != null);
        // Definir taxa de acerto do quiz
        TaxaDeAcerto = (acertou)? 1 : 0;

        RespostaConfirmada = true;
    }
}
