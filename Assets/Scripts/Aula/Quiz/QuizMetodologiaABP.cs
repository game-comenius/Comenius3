using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class QuizMetodologiaABP : Quiz
{
    // Quiz sobre a metodologia ABP pode ter 2 formatos: ordenar e múltipla escolha
    // Apenas um dos prefabs será instanciado por vez
    [Header("Formatos de Quiz")]
    [SerializeField] FormatoDeQuizOrdenar prefabQuizOrdenar;
    [SerializeField] FormatoDeQuizMultiplaEscolha prefabQuizMultiplaEscolha;
    private FormatoDeQuiz formatoDoQuiz;

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
    }

    private void GerarQuiz()
    {
        int quantidadeDeQuizzesDisponiveis = 4;
        // Trocar de 1 para 0 quando o formato de quiz ORDENAR estiver pronto
        var quizSorteado = Random.Range(1, quantidadeDeQuizzesDisponiveis);

        // Gerar apenas o quiz sorteado
        if (quizSorteado == 1)
        {
            var quizMultiplaEscolha = Instantiate(prefabQuizMultiplaEscolha, canvas.transform);

            quizMultiplaEscolha.TextoDoEnunciado = "Sobre os papéis do aluno e do professor em ABP é correto afirmar:";
            Afirmacao[] afirmacoes =
            {
            new Afirmacao(true, "O docente organiza seu planejamento em etapas, partindo do entendimento do problema proposto, até a apresentação do trabalho e análises dos resultados."),
            new Afirmacao(false, "O professor deve ser simples e objetivo, para permitir que o grupo não fique atento no assunto o tempo todo."),
            new Afirmacao(false, "Os alunos devem selecionar as hipóteses mais adequadas a partir das instruções apresentadas pelo professor."),
            new Afirmacao(false, "É importante que os alunos se mantenham curiosos sobre o conteúdo, então o professor deve manter as respostas em segredo até a avaliação dos resultados."),
            };
            formatoDoQuiz = quizMultiplaEscolha;
            quizMultiplaEscolha.DefinirAfirmacoes(afirmacoes);
        }
        else if (quizSorteado == 2)
        {
            var quizMultiplaEscolha = Instantiate(prefabQuizMultiplaEscolha, canvas.transform);

            quizMultiplaEscolha.TextoDoEnunciado = "Sobre ABP é correto afirmar:";
            Afirmacao[] afirmacoes =
            {
            new Afirmacao(true, "O problema deve estar relacionado com uma situação bem prática."),
            new Afirmacao(false, "Deve ser criado um enigma que exija muito trabalho para ser identificado pelos alunos."),
            new Afirmacao(false, "O problema precisa ser real, um caso que tenha ocorrido em situação verídica."),
            new Afirmacao(false, "Os alunos se deparam com um problema e precisam encontrar a solução correta."),
            };
            formatoDoQuiz = quizMultiplaEscolha;
            quizMultiplaEscolha.DefinirAfirmacoes(afirmacoes);
        }
        else if (quizSorteado == 3)
        {
            var quizMultiplaEscolha = Instantiate(prefabQuizMultiplaEscolha, canvas.transform);

            quizMultiplaEscolha.TextoDoEnunciado = "Quais as características que um problema deve ter?";
            Afirmacao[] afirmacoes =
            {
            new Afirmacao(true, "Apresentar tema e nível de complexidade compatíveis com o conhecimento prévio dos alunos."),
            new Afirmacao(false, "Apresentar uma  situação totalmente nova e desconhecida pelos alunos."),
            new Afirmacao(false, "Para não inviabilizar as discussões em grupo, é melhor que poucos alunos relatem suas experiências prévias com o problema."),
            new Afirmacao(false, "Um enunciado completo e complexo para permitir a visualização da questão principal como um todo."),
            };
            formatoDoQuiz = quizMultiplaEscolha;
            quizMultiplaEscolha.DefinirAfirmacoes(afirmacoes);
        }
        else // quizSorteado == 0
        {
            return;
        }
    }
}
