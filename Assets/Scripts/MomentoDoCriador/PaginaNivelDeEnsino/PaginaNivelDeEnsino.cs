using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class PaginaNivelDeEnsino : Pagina
{
    [SerializeField] GrupoDeBotoesNivelDeEnsino grupoDeBotoes;
    [SerializeField] Image iconePequenoGuia;
    [SerializeField] Image iconeGrandeEmDestaque;
    [SerializeField] Text NomeDoSelecionado;

    private void Start()
    {
        // Esconder ícone grande pois nada foi selecionado ainda
        iconeGrandeEmDestaque.enabled = false;
        // Toda vez que o grupo de botões disser que um novo botão foi
        // selecionado, a página irá atualizar o ícone grande em destaque,
        // o nome do botão selecionado e o ícone pequeno na lateral esquerda
        grupoDeBotoes.QuandoUmBotaoForSelecionadoEvent += (botaoSelecionado) =>
        {
            iconeGrandeEmDestaque.sprite = botaoSelecionado.SpriteGrande;
            iconeGrandeEmDestaque.enabled = true;

            NomeDoSelecionado.text = botaoSelecionado.Valor.nome;

            var spritePequeno = botaoSelecionado.ImageComponent.sprite;
            iconePequenoGuia.sprite = spritePequeno;
        };
    }

    public override bool Validar()
    {
        return (grupoDeBotoes.BotaoSelecionado != null);
    }
}
