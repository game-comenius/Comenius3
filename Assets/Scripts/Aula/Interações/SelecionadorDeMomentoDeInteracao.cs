﻿using System;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ControladorDisplayMomentoInteracao))]
public class SelecionadorDeMomentoDeInteracao : MonoBehaviour
{
    [SerializeField] private List<MomentoInteracao> imprevistos;
    [SerializeField] private List<MomentoInteracao> feedbacksInfantil;
    [SerializeField] private List<MomentoInteracao> feedbacksFundamental;
    [SerializeField] private List<MomentoInteracao> feedbacksMedio;
    [SerializeField] private List<MomentoInteracao> feedbacksSuperior;
    [SerializeField] private ControladorDisplayMomentoInteracao controlador;
    [SerializeField] private EstadoDeAulaInvertida controladorDaAula;

    private int indiceMidiaAtual;

    public void AtualizarMidiaAtual(int indiceMidia)
    {
        indiceMidiaAtual = indiceMidia;
    }

    public void SelecionarImprevisto()
    {
        controlador.Momento = imprevistos[UnityEngine.Random.Range(0, imprevistos.Count)];
    }

    public void SelecionarFeedback()
    {
        // (Switch não usado pois o nível de ensino não é constante)

        List<MomentoInteracao> feedbacks;

        if (EstadoDoJogo.Instance.NivelDeEnsinoSelecionado == NivelDeEnsino.EducacaoInfantil)
            feedbacks = feedbacksInfantil;
        else if (EstadoDoJogo.Instance.NivelDeEnsinoSelecionado == NivelDeEnsino.EnsinoFundamental)
            feedbacks = feedbacksFundamental;
        else if (EstadoDoJogo.Instance.NivelDeEnsinoSelecionado == NivelDeEnsino.EnsinoMedio)
            feedbacks = feedbacksFundamental;
        else
            feedbacks = feedbacksSuperior;

        bool positivo = ComboChecker.Combo.Arriscada != ComboChecker.CalcularCombo();

        for(int i = 0; i < feedbacks.Count; i++)
        {
            if (feedbacks[i].midias[0] == EstadoDoJogo.Instance.MidiasSelecionadas[indiceMidiaAtual].nomeMidia &&
                positivo == feedbacks[i].alunoFeliz)
            {
                controlador.Momento = feedbacks[i];
            }
        }
    }
}
