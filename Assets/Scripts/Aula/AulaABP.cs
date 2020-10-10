using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AulaABP : Aula
{
    // É possível definir as mídias selecionadas para a aula ABP em outra cena, são propriedades estáticas
    public static NomeDeMidia PrimeiraMidia;
    public static NomeDeMidia SegundaMidia;

    [Header("Quizzes")]
    [SerializeField] QuizDeMidia quizDeMidia1;
    [SerializeField] QuizDeMidia quizDeMidia2;
    [SerializeField] QuizMetodologiaABP quizMetodologiaABP;
    [SerializeField] QuizPerfilDaTurma quizPerfilDaTurma;
    // Após o início da cena/aula, os quizzes serão aplicados depois deste delay
    [SerializeField] [Range(0, 30)] float delayParaAplicarQuizzes;
    [SerializeField] [Range(0, 30)] float tempoEntreQuizzes;
    [SerializeField] [Range(0, 30)] float tempoPosQuizzes;
    private Quiz[] quizzes;

    [Header("Fim da Aula")]
    [SerializeField] PaginaResultadoDaAula paginaResultadoDaAula;
    [SerializeField] TrocadorDeCena trocadorDeCenaCreditos;

    [Header("Alunos")]
    public GameObject AlunosJovens;
    public GameObject AlunosCriancas;

    [Header("UI Aula")]
    [SerializeField] Image iconePersonagemUI;


    protected override IEnumerator Start()
    {
        yield return base.Start();

        // Inicializar UI da aula
        var spriteIconePersonagemSelecionada = EstadoDoJogo.Instance.SpriteIconePersonagem;
        if (spriteIconePersonagemSelecionada) iconePersonagemUI.sprite = spriteIconePersonagemSelecionada;

        var quizzes = ObterQuizzesConfigurados();
        yield return StartCoroutine(AplicarQuizzes(quizzes, delayParaAplicarQuizzes, tempoEntreQuizzes));

        // Esperar um tempo entre o último quiz e o resultado da aula
        yield return new WaitForSeconds(tempoPosQuizzes);
        StartCoroutine(ApresentarResultadoDaAula());
    }

    private Quiz[] ObterQuizzesConfigurados()
    {
        // Definir mídias padrão caso nenhuma tenha sido escolhida
        // Útil no desenvolvimento quando estivermos testando diretamente a cena AulaABP
        if (PrimeiraMidia == NomeDeMidia.Nenhuma && SegundaMidia == NomeDeMidia.Nenhuma)
        {
            PrimeiraMidia = NomeDeMidia.Jogos;
            SegundaMidia = NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas;
        }
        // O primeiro quiz será um quiz de mídia sobre aquela que jogador escolheu primeiro
        quizDeMidia1.ConfigurarQuiz(PrimeiraMidia);
        // O segundo quiz será um quiz de mídia sobre aquela que o jogador escolheu por segundo
        quizDeMidia2.ConfigurarQuiz(SegundaMidia);
        // O terceiro quiz será um quiz sobre a metodologia escolhida e não precisa ser configurado
        // ...
        // O quarto quiz será sobre o perfil da turma definido no início do jogo
        var nivelDeEnsino = EstadoDoJogo.Instance.NivelDeEnsinoSelecionado;
        var inteligencias = EstadoDoJogo.Instance.InteligenciasSelecionadas;
        quizPerfilDaTurma.ConfigurarQuiz(nivelDeEnsino, inteligencias);

        // Ordenar os quizzes
        Quiz[] localQuizzes =
        {
            quizDeMidia1,
            quizDeMidia2,
            quizMetodologiaABP,
            quizPerfilDaTurma
        };
        return quizzes = localQuizzes;
    }

    private IEnumerator AplicarQuizzes(Quiz[] quizzes, float delayParaComecar, float tempoEntreQuizzes)
    {
        yield return new WaitForSeconds(delayParaComecar);

        for (int i = 0; i < quizzes.Length; i++)
        {
            // Executar quiz e esperar o jogador responder ele completamente
            yield return StartCoroutine(AplicarQuiz(quizzes[i]));
            // Aplicar tempo entre os quizzes (if para evitar espera após último quiz)
            if (i < quizzes.Length - 1) yield return new WaitForSeconds(tempoEntreQuizzes);
        }
    }

    protected override IEnumerator AplicarQuiz(Quiz quiz)
    {
        yield return StartCoroutine(quiz.Executar());
    }

    protected override IEnumerator ApresentarResultadoDaAula()
    {
        paginaResultadoDaAula.Mostrar();
        paginaResultadoDaAula.Atualizar(quizzes);

        yield return new WaitWhile(() => paginaResultadoDaAula.EmUso);

        TerminarAula();
    }

    private void TerminarAula()
    {
        trocadorDeCenaCreditos.TrocarCena();
    }
}

