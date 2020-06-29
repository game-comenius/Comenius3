using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaginaInteligencias : Pagina
{
    [SerializeField] Image iconePequenoGuia;

    [SerializeField] Image iconeGrandeEmDestaque;
    [SerializeField] Text NomeDoSelecionado;

    [SerializeField] GrupoDeIconesInteligencias grupoDeIconesInteligencias;

    private void Start()
    {
        // Limpar nome do selecionado e esconder icone em destaque pois não há seleção ainda
        NomeDoSelecionado.text = string.Empty;
        iconeGrandeEmDestaque.enabled = false;

        // Toda vez que o grupo de botões disser que um novo botão foi
        // selecionado, a página irá atualizar o ícone grande em destaque,
        // o nome do botão selecionado e o ícone pequeno na lateral esquerda
        grupoDeIconesInteligencias.QuandoUmElementoForSelecionadoEvent += (iconeSelecionado) =>
        {
            iconeGrandeEmDestaque.sprite = iconeSelecionado.SpriteGrande;
            iconeGrandeEmDestaque.enabled = true;

            NomeDoSelecionado.text = iconeSelecionado.Valor.Nome;

            var spritePequeno = iconeSelecionado.ImageComponent.sprite;
            iconePequenoGuia.sprite = spritePequeno;
        };
    }

    public override bool Validar()
    {
        return true;
    }
}
