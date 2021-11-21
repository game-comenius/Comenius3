﻿using UnityEngine;
using UnityEngine.UI;

public class PaginaResumoDoPlanejamento : PaginaPlanejamento
{
    [Header("Ícones")]
    [SerializeField] Image IconeMidia1;
    [SerializeField] Image IconeMidia2;
    [SerializeField] Image IconeMidia3;
    [SerializeField] Image IconeMidia4;

    [Header("Previews")]
    [SerializeField] Image PreviewQuarto1;
    [SerializeField] Image PreviewQuarto2;

    [Header("Textos")]
    [SerializeField] Text NomeDaMetodologia;
    [SerializeField] Text NomeDaMidiaQuarto1;
    [SerializeField] Text NomeDaMidiaQuarto2;
    [SerializeField] Text NomeDaMidiaEAgrupamentoSala1;
    [SerializeField] Text NomeDaMidiaEAgrupamentoSala2;

    [Header("Ícones Laterais")]
    [SerializeField] private Sprite primeiroIcone;
    [SerializeField] private Sprite segundoIcone;

    // Start is called before the first frame update
    protected override void OnEnable()
    {

        iconManager.ShowIcon(1);
        iconManager.SetIcon(0, primeiroIcone);
        iconManager.SetIcon(1, segundoIcone);

        var estadoDoJogo = EstadoDoJogo.Instance;

        if (estadoDoJogo.MetodologiaSelecionada == Metodologia.Invertida)
        {
            NomeDaMetodologia.text = estadoDoJogo.MetodologiaSelecionada.nome;
            NomeDaMidiaQuarto1.text = estadoDoJogo.MidiasSelecionadas[0].nome;
            NomeDaMidiaQuarto2.text = estadoDoJogo.MidiasSelecionadas[1].nome;
            NomeDaMidiaEAgrupamentoSala1.text = estadoDoJogo.MidiasSelecionadas[2].nome + " + " + estadoDoJogo.MidiasSelecionadas[2].agrupamento;//"Agrupamento 1";
            NomeDaMidiaEAgrupamentoSala2.text = estadoDoJogo.MidiasSelecionadas[3].nome + " + " + estadoDoJogo.MidiasSelecionadas[3].agrupamento;//"Agrupamento 2";

            IconeMidia1.sprite = estadoDoJogo.MidiasSelecionadas[0].sprite;
            IconeMidia2.sprite = estadoDoJogo.MidiasSelecionadas[1].sprite;
            IconeMidia3.sprite = estadoDoJogo.MidiasSelecionadas[2].sprite;
            IconeMidia4.sprite = estadoDoJogo.MidiasSelecionadas[3].sprite;

            PreviewQuarto1.sprite = estadoDoJogo.NivelDeEnsinoSelecionado.sprite;
            PreviewQuarto2.sprite = estadoDoJogo.NivelDeEnsinoSelecionado.sprite;
        }
    }

    private void OnDisable()
    {
        iconManager.HideIcon(1);
        iconManager.ResetIcon(0);
        iconManager.ResetIcon(1);
    }
}
