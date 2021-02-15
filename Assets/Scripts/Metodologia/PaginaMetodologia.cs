using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using TMPro;

public class PaginaMetodologia : Pagina
{
    [SerializeField] Image iconeGrandeEmDestaque;
    [SerializeField] Text NomeDoSelecionado;
    [SerializeField] ScrollRect DescricaoDoSelecionado;
    [SerializeField] TextMeshProUGUI TextoExpandido;
    [SerializeField] GrupoDeBotoesMetodologia grupoDeBotoes;

    private void Start()
    {
        // Limpar nome do selecionado, descrição do selecionado e esconder
        // icone em destaque pois não há seleção ainda
        NomeDoSelecionado.text = string.Empty;

        //Esconde descrição e ícone grande no início
        //DescricaoDoSelecionado.GetComponentInChildren<TextMeshProUGUI>().text = string.Empty;
        //iconeGrandeEmDestaque.enabled = false;

        //Setar a descrição expandida inicial
        var descricaoExpandida = TextoExpandido;
        descricaoExpandida.text = "";

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
            textoDaDescricaoDoSelecionado.text = botaoSelecionado.Valor.descricao;
            // Retornar/resetar scrollbar para o topo
            var scrollbar = DescricaoDoSelecionado.GetComponentInChildren<Scrollbar>();
            if (scrollbar) scrollbar.value = 1;

            //Atualizar descrição expandida para o nível de ensino selecionado
            descricaoExpandida.text = botaoSelecionado.Valor.expansao;

        };
    }

    public override bool Validar()
    {
        return (grupoDeBotoes.BotaoSelecionado != null);
    }
}
