using UnityEngine;
using System.Linq;
using System;
using UnityEngine.UI;

public class GrupoDeBotoesMetodologia : MonoBehaviour
{
    [SerializeField] Image AnelDeSelecao;
    [SerializeField] BotaoMetodologia[] botoesMetodologia;
    [SerializeField] TrocadorDeCena TrocadorDeCena;
    [SerializeField] int[] indiceDeCenaPorBotão;

    public BotaoMetodologia BotaoSelecionado
    {
        get { return botoesMetodologia.Where((b) => b.Selecionado).FirstOrDefault(); }
    }

    public event Action<BotaoMetodologia> QuandoUmNovoBotaoForSelecionadoEvent;

    private void Start()
    {
        // Cadastrar os botões passados pelo Inspector neste grupo
        //foreach (var botao in botoesMetodologia) botao.grupo = this;

        // Esconder anel de seleção pois não há botões selecionados
        AnelDeSelecao.enabled = false;
    }

    public bool Selecionar(BotaoMetodologia botao)
    {
        // Se botão não faz parte do grupo, ignorar
        if (!botoesMetodologia.Contains(botao)) {
            return false;
        }
            

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
        QuandoUmNovoBotaoForSelecionadoEvent?.Invoke(botao);

        // Gravar no estado do jogo que este é o nível de ensino selecionado
        EstadoDoJogo.Instance.MetodologiaSelecionada = botao.Valor;
        EstadoDoJogo.Instance.MetodologiaSelecionada.Sprite = botao.ImageComponent.sprite;

        // Configurar a cena corretamente
        int indiceDoBotão = 0;
        for (int i = 0; i < botoesMetodologia.Length ; i++) {
            if(botoesMetodologia[i] == botao)
                indiceDoBotão = i;
        } 
        //// Pega o indice correspondente na lista de indices
        indiceDoBotão = indiceDeCenaPorBotão[indiceDoBotão];
        TrocadorDeCena.IndiceDaCenaAlvo = indiceDoBotão;

        return true;
    }
}
