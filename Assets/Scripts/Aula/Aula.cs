using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Aula : MonoBehaviour
{
    [Header("Prefabs Salas de Aula")]
    public SalaDeAula SalaDeAulaPadrao;
    public SalaDeAulaInfantil SalaDeAulaInfantil;

    protected abstract IEnumerator AplicarQuiz(Quiz quiz);

    protected abstract IEnumerator ApresentarResultadoDaAula();

    protected virtual IEnumerator Start()
    {
        var nivelDeEnsino = EstadoDoJogo.Instance.NivelDeEnsinoSelecionado;
        var salaDeAulaQueSeraUsada = (nivelDeEnsino == NivelDeEnsino.EducacaoInfantil) ? SalaDeAulaInfantil : SalaDeAulaPadrao;
        yield return StartCoroutine(salaDeAulaQueSeraUsada.Mostrar());
    }
}
