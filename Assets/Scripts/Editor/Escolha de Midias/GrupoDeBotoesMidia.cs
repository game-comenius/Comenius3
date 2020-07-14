using UnityEngine;
using System.Linq;
using System;
using UnityEngine.UI;

//baseado em GrupoDeBotoesNivelDeEnsino.cs
public class GrupoDeBotoesMidia : MonoBehaviour
{
    [SerializeField] Image AnelDeSelecao;
    [SerializeField] BotaoMidia[] botoesMidia;

    public BotaoMidia BotaoSelecionado
    {
        get { return botoesMidia.Where((b) => b.Selecionado).FirstOrDefault(); }
    }

    public event Action<BotaoMidia> QuandoUmNovoBotaoForSelecionadoEvent;

    private void Start()
    {
        foreach (var botao in botoesMidia) botao.grupo = this;
        AnelDeSelecao.enabled = false;
    }

    public bool Selecionar(BotaoMidia botao)
    {
        if (!botoesMidia.Contains(botao)) return false;

        var botaoQueEstavaSelecionado = BotaoSelecionado;
        if (botaoQueEstavaSelecionado)
        {
            if (botaoQueEstavaSelecionado == botao) return true;

            botaoQueEstavaSelecionado.Selecionado = false;
        }

        botao.Selecionado = true;

        AnelDeSelecao.enabled = true;
        var posicaoDoBotao = botao.GetComponent<RectTransform>().anchoredPosition;
        AnelDeSelecao.rectTransform.anchoredPosition = posicaoDoBotao;

        QuandoUmNovoBotaoForSelecionadoEvent?.Invoke(botao);

        //TODO: gravar estado do jogo que esta é uma das mídias selecionadas

        return true;
    }
}
