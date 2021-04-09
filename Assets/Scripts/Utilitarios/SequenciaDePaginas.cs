using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SequenciaDePaginas : MonoBehaviour
{
    [SerializeField] Pagina[] paginas;

    [SerializeField] Button botaoPaginaAnterior;
    [SerializeField] Button botaoProximaPagina;

    //Variáveis para corrigir a seleção de personagens.
    [SerializeField] Image AnelDeSelecao;
    bool jaMudou = false;

    private LinkedList<Pagina> sequenciaDePaginas;
    private LinkedListNode<Pagina> nodoPaginaAtual;
    
    void Start()
    {
        sequenciaDePaginas = new LinkedList<Pagina>(paginas);

        // Esconder todas as páginas
        foreach (var pagina in sequenciaDePaginas) pagina.Esconder();

        // Mostrar apenas a primeira página
        nodoPaginaAtual = sequenciaDePaginas.First;
        Mostrar(nodoPaginaAtual);
    }

    public void MostrarPaginaAnterior()
    {
        var nodoPaginaAnterior = nodoPaginaAtual.Previous;
        if (nodoPaginaAnterior == null)
        {
            Debug.LogWarning("Não há página anterior, esta é a primeira página de uma sequência de páginas.");
            return;
        }
        Mostrar(nodoPaginaAnterior);

        //Correção na seleção de personagens.
        try
        {
            if (AnelDeSelecao.enabled == true) {
                AnelDeSelecao.enabled = false;
                jaMudou = true;
            } else {
                if (jaMudou == true) {
                    AnelDeSelecao.enabled = true;
                }
            }
        }
        catch {

        }
    }

    public void MostrarProximaPagina()
    {
        if (!nodoPaginaAtual.Value.Validar())
        {
            Debug.LogWarning("Não é possível mostrar a próxima página porque a página atual não foi validada, i.e., ainda há detalhes que precisam ser preenchidos.");
            return;
        }
        var proximoNodoPagina = nodoPaginaAtual.Next;
        if (proximoNodoPagina == null)
        {
            Debug.LogWarning("Não há próxima página, esta é a última página de uma sequência de páginas.");
            return;
        }
        Mostrar(proximoNodoPagina);

        //Correção na seleção de personagens.
        try
        {
            if (AnelDeSelecao.enabled == true) {
                AnelDeSelecao.enabled = false;
                jaMudou = true;
            } else {
                if (jaMudou == true) {
                    AnelDeSelecao.enabled = true;
                }
            }
        }
        catch {

        }
    }

    private void Mostrar(LinkedListNode<Pagina> nodoPagina)
    {
        // Esconder página atual
        nodoPaginaAtual.Value.Esconder();
        // Mostrar página alvo
        nodoPaginaAtual = nodoPagina;
        nodoPaginaAtual.Value.Mostrar();

        AdministrarBotoesDeNavegacao();
    }

    private void AdministrarBotoesDeNavegacao()
    {
        // Definir se o botão de página anterior vai ficar desabilitado ou não
        if (nodoPaginaAtual == sequenciaDePaginas.First)
            DefinirEstadoDoBotaoPaginaAnterior(false);
        else
            DefinirEstadoDoBotaoPaginaAnterior(true);

        // Definir se o botão de próxima página vai ficar desabilitado ou não
        DefinirEstadoDoBotaoProximaPagina(false);
        if (nodoPaginaAtual != sequenciaDePaginas.Last)
            StartCoroutine(LiberarMostrarProximaPaginaQuandoPaginaAtualFicarValida());
    }

    private IEnumerator LiberarMostrarProximaPaginaQuandoPaginaAtualFicarValida()
    {   
        yield return new WaitUntil(() => nodoPaginaAtual.Value.Validar());
        DefinirEstadoDoBotaoProximaPagina(true);
        StartCoroutine(BloquearMostrarProximaPaginaSePaginaAtualPerderValidade());
    }

    private IEnumerator BloquearMostrarProximaPaginaSePaginaAtualPerderValidade()
    {
        yield return new WaitWhile(() => nodoPaginaAtual.Value.Validar());
        DefinirEstadoDoBotaoProximaPagina(false);
        StartCoroutine(LiberarMostrarProximaPaginaQuandoPaginaAtualFicarValida());
    }

    private void DefinirEstadoDoBotaoProximaPagina(bool habilitado)
    {
        botaoProximaPagina.interactable = habilitado;
    }

    private void DefinirEstadoDoBotaoPaginaAnterior(bool habilitado)
    {
        botaoPaginaAnterior.interactable = habilitado;
    }
}
