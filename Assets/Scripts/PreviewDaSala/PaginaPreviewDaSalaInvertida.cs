
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaginaPreviewDaSalaInvertida : Pagina
{
    [SerializeField] SalaDeAula salaInvertida;
    [SerializeField] SalaDeAula salaInfantil;

    private void Start()
    {

        var salaEscolhida = SelecionarSalaQueSeraUsada();
        StartCoroutine(salaEscolhida.Mostrar());

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
