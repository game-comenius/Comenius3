using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaginaPreviewDaSala : Pagina
{
    [SerializeField] SalaDeAula salaABP;
    [SerializeField] SalaDeAula salaInfantil;

    private void Start()
    {
        var salaEscolhida = SelecionarSalaQueSeraUsada();
        StartCoroutine(salaEscolhida.Mostrar());
        Debug.Log(salaEscolhida);
    }

    private SalaDeAula SelecionarSalaQueSeraUsada()
    {
        // Sala padrão é a sala da metodologia ABP
        var sala = salaABP;
        var nivelDeEnsino = EstadoDoJogo.Instance.NivelDeEnsinoSelecionado;
        var metodologiaSelecionada = EstadoDoJogo.Instance.MetodologiaSelecionada;

        if (nivelDeEnsino == NivelDeEnsino.EducacaoInfantil)
        {
            sala = salaInfantil;
        }
        else
        {
            if (metodologiaSelecionada == Metodologia.ABP)
                sala = salaABP;
        }
        return sala;
    }
}
