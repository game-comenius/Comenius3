using UnityEngine;
using System.Linq;
using System;
using UnityEngine.UI;

public class GrupoDeIconesAreaDeConhecimento : MonoBehaviour
{
    [SerializeField] Image AnelDeSelecao;
    [SerializeField] IconeAreaDeConhecimento[] iconesAreaDeConhecimento;

    public IconeAreaDeConhecimento iconeSelecionado
    {
        get { return iconesAreaDeConhecimento.Where((b) => b.Selecionado).FirstOrDefault(); }
    }

    public event Action<IconeAreaDeConhecimento> QuandoUmElementoForSelecionadoEvent;

    private void Start()
    {
        // Cadastrar os botões passados pelo Inspector neste grupo
        foreach (var botao in iconesAreaDeConhecimento) botao.grupo = this;

        // Esconder anel de seleção pois não há botões selecionados
        AnelDeSelecao.enabled = false;
    }

    public bool Selecionar(IconeAreaDeConhecimento botao)
    {
        // Se botão não faz parte do grupo, ignorar
        if (!iconesAreaDeConhecimento.Contains(botao)) return false;

        var botaoQueEstavaSelecionado = iconeSelecionado;
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
        QuandoUmElementoForSelecionadoEvent?.Invoke(botao);

        // Gravar no estado do jogo que este é o nível de ensino selecionado
        EstadoDoJogo.Instance.AreaDeConhecimentoSelecionada = botao.Valor;

        return true;
    }

    public void DesfazerSelecao()
    {
        if (iconeSelecionado) iconeSelecionado.Selecionado = false;
        AnelDeSelecao.enabled = false;
    }

    public void Mostrar()
    {
        this.gameObject.SetActive(true);
    }

    public void Esconder()
    {
        this.gameObject.SetActive(false);
    }
}
