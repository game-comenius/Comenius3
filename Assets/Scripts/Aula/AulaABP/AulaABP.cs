using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaABP : Aula
{
    // É possível definir as mídias selecionadas para a aula ABP em outra cena, são propriedades estáticas
    public static NomeMidias PrimeiraMidia;
    public static NomeMidias SegundaMidia;

    [Header("Quizzes")]
    [SerializeField] QuizDeMidia quizDeMidia1;
    [SerializeField] QuizDeMidia quizDeMidia2;
    // Após o início da cena/aula, os quizzes serão aplicados depois deste delay
    [SerializeField] [Range(0, 30)] float delayParaAplicarQuizzes;
    [SerializeField] [Range(0, 30)] float tempoEntreQuizzes;
    [SerializeField] [Range(0, 30)] float tempoPosQuizzes;
    private Quiz[] quizzes;

    [Header("Fim da Aula")]
    [SerializeField] PaginaResultadoDaAula paginaResultadoDaAula;
    [SerializeField] TrocadorDeCena trocadorDeCenaCreditos;

    [Header("Sprites da Sala De Aula")]
    public SpriteRenderer SalaSpriteRenderer;
    public Sprite SpriteLaboratorioBiologia;
    public Sprite SpriteLaboratorioFisica;
    public Sprite SpriteLaboratorioInformatica;
    public Sprite SpriteLaboratorioQuimica;
    public Sprite SpriteSalaInfantil;

    [Header("Alunos")]
    public GameObject AlunosJovens;
    public GameObject AlunosCriancas;


    private IEnumerator Start()
    {
        // Definir a sala de aula que será usada
        Dictionary<AreaDeConhecimento, Sprite> spritesPorAreaDeConhecimento = ConstruirRelacaoSpritesPorAreaDeConhecimento();
        var spriteDoLaboratorio = spritesPorAreaDeConhecimento[EstadoDoJogo.Instance.AreaDeConhecimentoSelecionada];
        SalaSpriteRenderer.sprite = spriteDoLaboratorio ? spriteDoLaboratorio : SpriteLaboratorioQuimica;

        // Temporário, deletar + tarde
        PrimeiraMidia = NomeMidias.Jogos;
        SegundaMidia = NomeMidias.EditoresDeTextoEPlanilhasEletronicas;

        var quizzes = ObterQuizzesConfigurados();
        yield return StartCoroutine(AplicarQuizzes(quizzes, delayParaAplicarQuizzes, tempoEntreQuizzes));

        // Esperar um tempo entre o último quiz e o resultado da aula
        yield return new WaitForSeconds(tempoPosQuizzes);
        StartCoroutine(ApresentarResultadoDaAula());
    }

    

    private Quiz[] ObterQuizzesConfigurados()
    {
        // O primeiro quiz de mídia será sobre a que jogador escolheu primeiro
        quizDeMidia1.ConfigurarQuiz(PrimeiraMidia);
        // O segundo quiz de mídia será sobre a que o jogador escolheu por segundo
        quizDeMidia2.ConfigurarQuiz(SegundaMidia);

        // Ordenar os quizzes
        Quiz[] localQuizzes =
        {
            quizDeMidia1,
            quizDeMidia2
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

    private Dictionary<AreaDeConhecimento, Sprite> ConstruirRelacaoSpritesPorAreaDeConhecimento()
    {
        return new Dictionary<AreaDeConhecimento, Sprite>
        {
            // Ensino Infantil
            { AreaDeConhecimento.EuOutroNos, SpriteSalaInfantil },
            { AreaDeConhecimento.CorpoGestosMovimentos, SpriteSalaInfantil },
            { AreaDeConhecimento.TracosSonsCoresFormas, SpriteSalaInfantil },
            { AreaDeConhecimento.EscutaFalaPensamentoImaginacao, SpriteSalaInfantil },
            { AreaDeConhecimento.EspacosTemposQuantidadesRelacoesTransformacoes, SpriteSalaInfantil },

            // Ensino Fundamental
            { AreaDeConhecimento.Linguagens, SpriteLaboratorioInformatica },
            { AreaDeConhecimento.Matematica, SpriteLaboratorioFisica },
            { AreaDeConhecimento.CienciasDaNatureza, SpriteLaboratorioBiologia },
            { AreaDeConhecimento.CienciasHumanas, SpriteLaboratorioInformatica },
            { AreaDeConhecimento.EnsinoReligioso, SpriteLaboratorioInformatica },

            // Ensino Médio
            { AreaDeConhecimento.LinguagensESuasTecnologias, SpriteLaboratorioInformatica },
            { AreaDeConhecimento.MatematicaESuasTecnologias, SpriteLaboratorioFisica },
            { AreaDeConhecimento.CienciasDaNaturezaESuasTecnologias, SpriteLaboratorioQuimica },
            { AreaDeConhecimento.CienciasHumanasESociaisAplicadas, SpriteLaboratorioInformatica },

            // Ensino Superior
            { AreaDeConhecimento.CienciasAgrarias, SpriteLaboratorioBiologia },
            { AreaDeConhecimento.CienciasBiologicas, SpriteLaboratorioBiologia },
            { AreaDeConhecimento.CienciasExatasDaTerra, SpriteLaboratorioFisica },
            { AreaDeConhecimento.CienciasHumanasSuperior, SpriteLaboratorioInformatica },
            { AreaDeConhecimento.CienciasDaSaude, SpriteLaboratorioQuimica },
            { AreaDeConhecimento.CienciasSociaisAplicadas, SpriteLaboratorioInformatica },
            { AreaDeConhecimento.Engenharias, SpriteLaboratorioFisica },
            { AreaDeConhecimento.LinguisticaLetrasArtes, SpriteLaboratorioInformatica },
        };
    }
}

