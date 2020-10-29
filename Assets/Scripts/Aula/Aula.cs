using System;
using System.Collections;
using UnityEngine;

public abstract class Aula : MonoBehaviour
{
    [Header("Prefabs Salas de Aula")]
    public SalaDeAula SalaDeAulaPadrao;
    public SalaDeAulaInfantil SalaDeAulaInfantil;
    public SalaDeAula SalaDeAulaEscolhida { get; private set; }

    public Metodologia MetodologiaDaAula { get; protected set; }

    public abstract float ObterPontuacaoDaAula();

    // Executar uma função sempre que um quiz for aplicado e finalizado com sucesso
    public event Action<Quiz> UmQuizFoiAplicadoComSucessoEvent;

    public Quiz[] Quizzes { get; set; }

    protected virtual IEnumerator AplicarQuiz(Quiz quiz)
    {
        yield return StartCoroutine(quiz.Executar());
        UmQuizFoiAplicadoComSucessoEvent?.Invoke(quiz);
    }

    protected abstract IEnumerator ApresentarResultadoDaAula();

    protected virtual IEnumerator Start()
    {
        var nivelDeEnsino = EstadoDoJogo.Instance.NivelDeEnsinoSelecionado;
        SalaDeAulaEscolhida = (nivelDeEnsino == NivelDeEnsino.EducacaoInfantil) ? SalaDeAulaInfantil : SalaDeAulaPadrao;
        yield return StartCoroutine(SalaDeAulaEscolhida.Mostrar());

        var baloesDosAlunos = SalaDeAulaEscolhida.baloesDosAlunos;
        if (baloesDosAlunos)
        {
            var inteligencias = EstadoDoJogo.Instance.InteligenciasSelecionadas;
            yield return new WaitForSeconds(1);
            StartCoroutine(baloesDosAlunos.ExecutarAnimacao(inteligencias));
        }
    }
}
