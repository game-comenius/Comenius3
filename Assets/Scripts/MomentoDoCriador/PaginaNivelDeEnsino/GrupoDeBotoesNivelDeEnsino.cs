using UnityEngine;
using System.Linq;
using System;
using UnityEngine.UI;

public class GrupoDeBotoesNivelDeEnsino : MonoBehaviour
{
    [SerializeField] Image AnelDeSelecao;
    [SerializeField] BotaoNivelDeEnsino[] botoesNivelDeEnsino;

    public BotaoNivelDeEnsino BotaoSelecionado
    {
        get { return botoesNivelDeEnsino.Where((b) => b.Selecionado).FirstOrDefault(); }
    }

    // 
    public event Action<BotaoNivelDeEnsino> QuandoUmBotaoForSelecionadoEvent;

    private void Start()
    {
        // Cadastrar os botões passados pelo Inspector neste grupo
        foreach (var botao in botoesNivelDeEnsino) botao.grupo = this;

        // Esconder anel de seleção pois não há botões selecionados
        AnelDeSelecao.enabled = false;
    }

    public bool Selecionar(BotaoNivelDeEnsino botao)
    {
        // Se botão não faz parte do grupo, ignorar
        if (!botoesNivelDeEnsino.Contains(botao)) return false;

        var botaoQueEstavaSelecionado = BotaoSelecionado;
        if (botaoQueEstavaSelecionado)
        {
            // Se o botão que foi selecionado já estava selecionado, ignorar
            if (botaoQueEstavaSelecionado == botao) return true;
            
            botaoQueEstavaSelecionado.Selecionado = false;
        }

        botao.Selecionado = true;

        // Posicionar anel de seleção sobre o botão selecionado
        AnelDeSelecao.enabled = true;
        var posicaoDoBotao = botao.GetComponent<RectTransform>().anchoredPosition;
        AnelDeSelecao.rectTransform.anchoredPosition = posicaoDoBotao;

        // Avisar observadores qual é o novo botão selecionado
        QuandoUmBotaoForSelecionadoEvent?.Invoke(botao);

        // Gravar no estado do jogo que este é o nível de ensino selecionado
        EstadoDoJogo.Instance.NivelDeEnsinoSelecionado = botao.Valor;

        return true;
    }
}
