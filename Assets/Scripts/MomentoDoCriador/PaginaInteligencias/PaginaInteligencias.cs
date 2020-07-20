using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PaginaInteligencias : Pagina
{
    [SerializeField] Image iconePequenoGuia;

    [SerializeField] Image iconeGrandeEmDestaque;
    [SerializeField] Text NomeDoSelecionado;
    [SerializeField] ScrollRect DescricaoDoSelecionado;

    [SerializeField] GrupoDeIconesInteligencias grupoDeIconesInteligencias;

    [SerializeField] Button botaoConfirmar;

    private void Start()
    {
        // Limpar nome do selecionado, descrição do selecionado e esconder
        // icone em destaque pois não há seleção ainda
        NomeDoSelecionado.text = string.Empty;
        DescricaoDoSelecionado.GetComponentInChildren<TextMeshProUGUI>().text = string.Empty;
        iconeGrandeEmDestaque.enabled = false;

        // Esconder botão confirmar até que uma escolha seja feita
        botaoConfirmar.gameObject.SetActive(false);

        // Toda vez que o grupo de botões disser que um novo botão foi
        // selecionado, a página irá atualizar o ícone grande em destaque,
        // o nome do botão selecionado e o ícone pequeno na lateral esquerda
        grupoDeIconesInteligencias.QuandoUmElementoForSelecionadoEvent += (iconeSelecionado) =>
        {
            iconeGrandeEmDestaque.sprite = iconeSelecionado.SpriteGrande;
            iconeGrandeEmDestaque.enabled = true;

            NomeDoSelecionado.text = iconeSelecionado.Valor.Nome;

            // Atualizar descrição para o nível de ensino selecionado
            var textoDaDescricaoDoSelecionado = DescricaoDoSelecionado.GetComponentInChildren<TextMeshProUGUI>();
            textoDaDescricaoDoSelecionado.text = iconeSelecionado.Valor.Descricao;
            // Retornar/resetar scrollbar para o topo
            var scrollbar = DescricaoDoSelecionado.GetComponentInChildren<Scrollbar>();
            if (scrollbar) scrollbar.value = 1;

            var spritePequeno = iconeSelecionado.ImageComponent.sprite;
            iconePequenoGuia.sprite = spritePequeno;

            botaoConfirmar.gameObject.SetActive(true);
        };
    }

    public override bool Validar()
    {
        return (grupoDeIconesInteligencias.IconeSelecionado != null);
    }
}
