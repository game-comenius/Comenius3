﻿using UnityEngine;
using UnityEngine.UI;

public class PaginaResumoDoPlanejamento : Pagina
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

    // Start is called before the first frame update
    void Start()
    {
        var estadoDoJogo = EstadoDoJogo.Instance;

        if (estadoDoJogo.MetodologiaSelecionada == Metodologia.Invertida)
        {
            NomeDaMetodologia.text = estadoDoJogo.MetodologiaSelecionada.nome;
            NomeDaMidiaQuarto1.text = estadoDoJogo.MidiasSelecionadas[0].NomeApresentavel;
            NomeDaMidiaQuarto2.text = estadoDoJogo.MidiasSelecionadas[1].NomeApresentavel;
            NomeDaMidiaEAgrupamentoSala1.text = estadoDoJogo.MidiasSelecionadas[2].NomeApresentavel + " + " + estadoDoJogo.MidiasSelecionadas[2].agrupamento;//"Agrupamento 1";
            NomeDaMidiaEAgrupamentoSala2.text = estadoDoJogo.MidiasSelecionadas[3].NomeApresentavel + " + " + estadoDoJogo.MidiasSelecionadas[3].agrupamento;//"Agrupamento 2";

            IconeMidia1.sprite = estadoDoJogo.MidiasSelecionadas[0].SpriteIcone;
            IconeMidia2.sprite = estadoDoJogo.MidiasSelecionadas[1].SpriteIcone;
            IconeMidia3.sprite = estadoDoJogo.MidiasSelecionadas[2].SpriteIcone;
            IconeMidia4.sprite = estadoDoJogo.MidiasSelecionadas[3].SpriteIcone;

            PreviewQuarto1.sprite = estadoDoJogo.NivelDeEnsinoSelecionado.Sprite;
            PreviewQuarto2.sprite = estadoDoJogo.NivelDeEnsinoSelecionado.Sprite;
        }
    }

}
