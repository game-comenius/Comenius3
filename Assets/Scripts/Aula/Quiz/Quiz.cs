using System.Collections;
using UnityEngine;

public abstract class Quiz : MonoBehaviour
{
    [SerializeField] protected Canvas canvas;

    // Faz sentido que seja chamado apenas após a execução deste quiz
    // Deve retornar um número entre 0 e 1
    public abstract float TaxaDeAcerto { get; }

    protected enum EstadoDeQuiz { NaoFoiExecutado, EmExecucao, Executado }
    protected EstadoDeQuiz estado = EstadoDeQuiz.NaoFoiExecutado;

    [Range(0, 15)][SerializeField] protected float tempoParaAvaliarResposta;

    // Deve ser chamado como uma coroutine pelo StartCoroutine
    // Deve retornar quando o jogador responder o quiz completamente
    public abstract IEnumerator Executar();
}

