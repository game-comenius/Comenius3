using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenciaDePaginas : MonoBehaviour
{
    [SerializeField] Pagina[] paginas;

    [SerializeField] GameObject botaoProximaPagina;

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
        DefinirEstadoDoBotaoProximaPagina(false);
        StartCoroutine(LiberarMostrarProximaPaginaQuandoPaginaAtualFicarValida());
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
    }

    private void Mostrar(LinkedListNode<Pagina> nodoPagina)
    {
        // Esconder página atual
        nodoPaginaAtual.Value.Esconder();
        // Mostrar página alvo
        nodoPaginaAtual = nodoPagina;
        nodoPaginaAtual.Value.Mostrar();
        // Administrar botão de próxima página
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
        botaoProximaPagina.SetActive(habilitado);
    }
}
