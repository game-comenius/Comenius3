using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using TMPro;

public class PaginaMidia : Pagina
{
    [SerializeField] Image iconePequenoGuia;
    [SerializeField] Image iconeGrandeEmDestaque;
    [SerializeField] Text NomeDoSelecionado;
    [SerializeField] ScrollRect DescricaoDoSelecionado;
    [SerializeField] GrupoDeBotoesMidia grupoDeBotoes;

    private void Start()
    {
        NomeDoSelecionado.text = string.Empty;
        iconeGrandeEmDestaque.enabled = false;

        grupoDeBotoes.QuandoUmNovoBotaoForSelecionadoEvent += (botaoSelecionado) =>
        {
            iconeGrandeEmDestaque.sprite = botaoSelecionado.SpriteGrande;
            iconeGrandeEmDestaque.enabled = true;

            //NomeDoSelecionado.text = botaoSelecionado.
        };
    }
}
