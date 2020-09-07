using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GrupoDeIconesPersonagem : MonoBehaviour
{
    [SerializeField] Image AnelDeSelecao;
    [SerializeField] IconePersonagem[] iconesPersonagem;

    public IconePersonagem IconeSelecionado
    {
        get { return iconesPersonagem.Where((i) => i.Selecionado).FirstOrDefault(); }
    }

    public event Action<IconePersonagem> QuandoUmElementoForSelecionadoEvent;

    private void Start()
    {
        // Cadastrar os botões passados pelo Inspector neste grupo
        foreach (var botao in iconesPersonagem) botao.grupo = this;

        // Esconder anel de seleção pois não há botões selecionados
        AnelDeSelecao.enabled = false;
    }

    public bool Selecionar(IconePersonagem icone)
    {
        // Se botão não faz parte do grupo, ignorar
        if (!iconesPersonagem.Contains(icone)) return false;

        var iconeQueEstavaSelecionado = IconeSelecionado;
        if (iconeQueEstavaSelecionado)
        {
            // Se o botão que foi selecionado já estava selecionado, ignorar
            if (iconeQueEstavaSelecionado == icone) return true;

            iconeQueEstavaSelecionado.Selecionado = false;
        }

        icone.Selecionado = true;

        // Posicionar anel de seleção sobre o botão selecionado
        AnelDeSelecao.enabled = true;
        var posicaoDoBotao = icone.GetComponent<RectTransform>().anchoredPosition;
        AnelDeSelecao.rectTransform.anchoredPosition = posicaoDoBotao;

        // Avisar observadores qual é o novo botão selecionado
        QuandoUmElementoForSelecionadoEvent?.Invoke(icone);

        // Gravar no estado do jogo as características da personagem selecionada
        var estadoDoJogo = EstadoDoJogo.Instance;
        estadoDoJogo.SpriteCorpoPersonagem = icone.SpriteCorpo;
        estadoDoJogo.SpriteCabeloPersonagem = icone.SpriteCabelo;
        estadoDoJogo.SpriteRoupaPersonagem = icone.SpriteRoupa;

        estadoDoJogo.SpriteIconePersonagem = icone.ImageComponent.sprite;

        return true;
    }
}
