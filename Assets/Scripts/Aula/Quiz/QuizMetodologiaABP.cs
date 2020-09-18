using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizMetodologiaABP : Quiz
{
    // Quiz sobre a metodologia ABP pode ter 2 formatos: ordenar e múltipla escolha
    // Apenas um dos prefabs será instanciado por vez
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
        Debug.Log("Executando quiz de metodologia abp...");

        formatoDoQuiz.Mostrar();

        yield return new WaitUntil(() => formatoDoQuiz.RespostaConfirmada);

        // Mostrar se o jogador acertou ou errou nas suas escolhas
        yield return new WaitForSeconds(5f);

        formatoDoQuiz.Esconder();

        Debug.Log("Terminando a execução do quiz de metodologia abp...");
        estado = EstadoDeQuiz.Executado;
    }

    private void GerarQuiz()
    {
        int quantidadeDeQuizzesDisponiveis = 4;
        // Trocar de 1 para 0 quando o formato de quiz ORDENAR estiver pronto
        var quizSorteado = Random.Range(1, quantidadeDeQuizzesDisponiveis);

        // Gerar apenas o quiz sorteado
        switch (quizSorteado)
        {
            default:
                break;
            case 1:
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
                break;
            case 2:
                break;
            case 3:
                break;
        }
    }
}
