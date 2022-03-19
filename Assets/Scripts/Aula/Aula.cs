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
