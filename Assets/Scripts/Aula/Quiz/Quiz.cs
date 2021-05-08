using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public abstract class Quiz : MonoBehaviour
{
    [SerializeField] protected Canvas canvas;

    public UnityEngine.Events.UnityEvent OnQuizzExit;

    // Faz sentido que seja chamado apenas após a execução deste quiz
    // Deve retornar um número entre 0 e 1
    public abstract float TaxaDeAcerto { get; }

    protected enum EstadoDeQuiz { NaoFoiExecutado, EmExecucao, Executado }
    protected EstadoDeQuiz estado = EstadoDeQuiz.NaoFoiExecutado;

    [Range(0, 60)][SerializeField] protected float tempoParaAvaliarResposta;
    protected bool tempoParaAvaliarRespostaPassou;

    protected IEnumerator PassarTempoParaAvaliarResposta()
    {
        yield return new WaitForSeconds(tempoParaAvaliarResposta);
        tempoParaAvaliarRespostaPassou = true;
    }

    // Deve ser chamado como uma coroutine pelo StartCoroutine
    // Deve retornar quando o jogador responder o quiz completamente
    public abstract IEnumerator Executar();
}

