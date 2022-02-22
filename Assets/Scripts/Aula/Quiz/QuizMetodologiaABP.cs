using System.Collections;
using UnityEngine;

public class QuizMetodologiaABP : Quiz
{
    // Quiz sobre a metodologia ABP pode ter 2 formatos: ordenar e múltipla escolha
    // Apenas um dos prefabs será instanciado por vez
    [Header("Formatos de Quiz")]
    [SerializeField] FormatoDeQuizOrdenar prefabQuizOrdenar;
    [SerializeField] FormatoDeQuizMultiplaEscolha prefabQuizMultiplaEscolha;
    private FormatoDeQuiz formatoDoQuiz;

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

        OnQuizzExit.Invoke(TaxaDeAcerto);
        formatoDoQuiz.Esconder();

        estado = EstadoDeQuiz.Executado;
    }

    private void GerarQuiz()
    {
        // As informações sobre os enunciados e afirmações dos quizzes desta
        // metodologia foram retirados deste documento do drive
        // https://docs.google.com/document/d/1VQRlVu3IrM3_BZZWHb9cD6qSskkU-3zsUSs_m1YI9lY/edit

        int quantidadeDeQuizzesDisponiveis = 4;
        var quizSorteado = Random.Range(0, quantidadeDeQuizzesDisponiveis);

        // Gerar apenas o quiz sorteado
        if (quizSorteado == 1)
        {
            var quizMultiplaEscolha = Instantiate(prefabQuizMultiplaEscolha, canvas.transform);

            quizMultiplaEscolha.TextoDoEnunciado = "Sobre os papéis do estudante e do docente na Aprendizagem Baseada em Problemas (ABP) é correto afirmar:";
            Afirmacao[] afirmacoes =
            {
                new Afirmacao(true, "O docente organiza seu planejamento em etapas, partindo do entendimento do problema proposto, até a apresentação do trabalho e análises dos resultados."),
                new Afirmacao(false, "O docente deve ser simples e objetivo, para que o grupo não fique atento no assunto."),
                new Afirmacao(false, "Os estudantes devem selecionar as hipóteses mais adequadas a partir das instruções apresentadas pelo docente."),
                new Afirmacao(false, "Para manter os estudantes curiosos sobre o assunto o docente deve manter as respostas em segredo."),
            };
            formatoDoQuiz = quizMultiplaEscolha;
            quizMultiplaEscolha.DefinirAfirmacoes(afirmacoes);
        }
        else if (quizSorteado == 2)
        {
            var quizMultiplaEscolha = Instantiate(prefabQuizMultiplaEscolha, canvas.transform);

            quizMultiplaEscolha.TextoDoEnunciado = "Sobre a Aprendizagem Baseada em Problemas (ABP) é correto afirmar:";
            Afirmacao[] afirmacoes =
            {
                new Afirmacao(true, "O problema deve estar relacionado com uma situação bem prática."),
                new Afirmacao(false, "Deve ser criado um enigma que exija muito trabalho para ser identificado pelos estudantes."),
                new Afirmacao(false, "O problema precisa ser real, um caso que tenha ocorrido em situação verídica."),
                new Afirmacao(false, "Os estudantes se deparam com um problema e precisam encontrar a solução correta."),
            };
            formatoDoQuiz = quizMultiplaEscolha;
            quizMultiplaEscolha.DefinirAfirmacoes(afirmacoes);
        }
        else if (quizSorteado == 3)
        {
            var quizMultiplaEscolha = Instantiate(prefabQuizMultiplaEscolha, canvas.transform);

            quizMultiplaEscolha.TextoDoEnunciado = "Na metodologia Aprendizagem Baseada em Problemas (ABP), assinale a alternativa que mostra quais devem ser as características do problema apresentado aos estudantes?";
            Afirmacao[] afirmacoes =
            {
                new Afirmacao(true, "Apresentar tema e nível de complexidade compatíveis com o conhecimento prévio."),
                new Afirmacao(false, "Apresentar uma situação totalmente nova e desconhecida."),
                new Afirmacao(false, "É melhor que poucos estudantes relatem suas experiências prévias com o problema."),
                new Afirmacao(false, "Um enunciado completo e complexo para permitir a visualização da questão principal."),
            };
            formatoDoQuiz = quizMultiplaEscolha;
            quizMultiplaEscolha.DefinirAfirmacoes(afirmacoes);
        }
        else // quizSorteado == 0
        {
            var quizOrdenar = Instantiate(prefabQuizOrdenar, canvas.transform);

            quizOrdenar.TextoDoEnunciado = "Clique e arraste as etapas da metodologia Aprendizagem Baseada em Problemas (ABP) para formar a ordem correta da sequncia didática:";
            Afirmacao[] afirmacoesNaOrdemCorreta = //Talvez eu tenha invertido a ordem das respostas, não tenho certeza. (10/01/2022)
            {
                new Afirmacao(true, "Apresentar o problema e levantar os conhecimentos sobre o assunto."),
                new Afirmacao(true, "Analisar as variáveis do problema e propor possíveis soluções."),
                new Afirmacao(true, "Buscar novas referências para qualificar as propostas, debater e buscar consenso sobre as possíveis soluções."),
                new Afirmacao(true, "Apresentar as respostas e avaliar os resultados."),
            };

            formatoDoQuiz = quizOrdenar;
            quizOrdenar.DefinirAfirmacoes(afirmacoesNaOrdemCorreta);
        }

        formatoDoQuiz.IconeDoQuiz.sprite = spriteDoIconeDoQuiz;
    }
}
