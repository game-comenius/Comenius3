using UnityEngine;
using System.Linq;
using System;
using UnityEngine.UI;

public class GrupoDeIconesInteligencias : MonoBehaviour
{
    [SerializeField] Image AnelDeSelecao;
    [SerializeField] IconeInteligencias[] iconesInteligencias;

    public IconeInteligencias IconeSelecionado
    {
        get { return iconesInteligencias.Where((i) => i.Selecionado).FirstOrDefault(); }
    }

    public event Action<IconeInteligencias> QuandoUmElementoForSelecionadoEvent;

    private void Start()
    {
        // Cadastrar os botões passados pelo Inspector neste grupo
        foreach (var botao in iconesInteligencias) botao.grupo = this;

        // Esconder anel de seleção pois não há botões selecionados
        AnelDeSelecao.enabled = false;
    }

    public bool Selecionar(IconeInteligencias icone)
    {
        // Se botão não faz parte do grupo, ignorar
        if (!iconesInteligencias.Contains(icone)) return false;

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

        // Gravar no estado do jogo que este é o par de inteligências selecionado
        EstadoDoJogo.Instance.InteligenciasSelecionadas = icone.Valor;
        EstadoDoJogo.Instance.InteligenciasSelecionadas.SpriteGrande = icone.SpriteGrande;

        return true;
    }
}
