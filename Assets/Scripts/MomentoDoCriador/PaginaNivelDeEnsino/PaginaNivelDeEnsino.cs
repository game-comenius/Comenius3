using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using TMPro;

public class PaginaNivelDeEnsino : Pagina
{
    [SerializeField] Image iconePequenoGuia;
    [SerializeField] Image iconeGrandeEmDestaque;
    [SerializeField] Text NomeDoSelecionado;
    [SerializeField] ScrollRect DescricaoDoSelecionado;
    [SerializeField] GrupoDeBotoesNivelDeEnsino grupoDeBotoes;
    [SerializeField] PaginaAreaDeConhecimento paginaAreaDeConhecimento;

    private void Start()
    {
        // Limpar nome do selecionado, descrição do selecionado e esconder
        // icone em destaque pois não há seleção ainda
        NomeDoSelecionado.text = string.Empty;

        //Esconde descrição e ícone grande no início
        //DescricaoDoSelecionado.GetComponentInChildren<TextMeshProUGUI>().text = string.Empty;
        //iconeGrandeEmDestaque.enabled = false;

        // Toda vez que o grupo de botões disser que um novo botão foi
        // selecionado, a página irá atualizar o ícone grande em destaque,
        // o nome do botão selecionado e o ícone pequeno na lateral esquerda
        grupoDeBotoes.QuandoUmNovoBotaoForSelecionadoEvent += (botaoSelecionado) =>
        {
            iconeGrandeEmDestaque.sprite = botaoSelecionado.SpriteGrande;
            iconeGrandeEmDestaque.enabled = true;

            NomeDoSelecionado.text = botaoSelecionado.Valor.nome;

            // Atualizar descrição para o nível de ensino selecionado
            var textoDaDescricaoDoSelecionado = DescricaoDoSelecionado.GetComponentInChildren<TextMeshProUGUI>();
            textoDaDescricaoDoSelecionado.text = botaoSelecionado.Valor.Descricao;
            // Retornar/resetar scrollbar para o topo
            var scrollbar = DescricaoDoSelecionado.GetComponentInChildren<Scrollbar>();
            if (scrollbar) scrollbar.value = 1;

            var spritePequeno = botaoSelecionado.ImageComponent.sprite;
            iconePequenoGuia.sprite = spritePequeno;

            paginaAreaDeConhecimento.DesfazerEscolha();
        };
    }

    public override bool Validar()
    {
        return (grupoDeBotoes.BotaoSelecionado != null);
    }
}
