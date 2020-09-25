using UnityEngine;

public class FormatoDeQuizMultiplaEscolha : FormatoDeQuiz
{
    // Representam as etiquetas/faixas/botões com as afirmações na UI
    [SerializeField] AfirmacaoQuizMultiplaEscolha[] afirmacoesQuizMultiplaEscolha;

    protected override void Start()
    {
        base.Start();

        // Esconder o botão confirmar até que o jogador selecione uma afirmação
        BotaoConfirmar.gameObject.SetActive(false);
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

    protected override void ConfirmarResposta()
    {
        Debug.Log("Resposta Confirmada");
    }
}
