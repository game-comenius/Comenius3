
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaginaPreviewDaSalaInvertida : Pagina
{
    [SerializeField] SalaDeAula salaInvertida;
    [SerializeField] SalaDeAula salaInfantil;
    [SerializeField] Text midiaSala1Nome;
    [SerializeField] Text midiaSala2Nome;

    private void Start()
    {

        var midiaSala1 = EstadoDoJogo.Instance.MidiasSelecionadas[2].NomeApresentavel;
        var midiaSala2 = EstadoDoJogo.Instance.MidiasSelecionadas[3].NomeApresentavel;

        var salaEscolhida = SelecionarSalaQueSeraUsada();
        StartCoroutine(salaEscolhida.Mostrar());
        midiaSala1Nome.text = midiaSala1;
        midiaSala2Nome.text = midiaSala2;

    }

    private SalaDeAula SelecionarSalaQueSeraUsada()
    {
        // Sala padrão é a sala da metodologia ABP
        var sala = salaInvertida;
        var nivelDeEnsino = EstadoDoJogo.Instance.NivelDeEnsinoSelecionado;
        var metodologiaSelecionada = EstadoDoJogo.Instance.MetodologiaSelecionada;

        if (nivelDeEnsino == NivelDeEnsino.EducacaoInfantil)
        {
            sala = salaInfantil;
        }
        else
        {
            if (metodologiaSelecionada == Metodologia.ABP || metodologiaSelecionada == Metodologia.Invertida)
                sala = salaInvertida;
        }
        return sala;
    }


}
