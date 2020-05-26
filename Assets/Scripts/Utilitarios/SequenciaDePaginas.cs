using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenciaDePaginas : MonoBehaviour
{
    [SerializeField] Pagina[] paginas;

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

    private void Mostrar(LinkedListNode<Pagina> nodoPagina)
    {
        // Esconder página atual
        nodoPaginaAtual.Value.Esconder();
        // Mostrar página alvo
        nodoPaginaAtual = nodoPagina;
        nodoPaginaAtual.Value.Mostrar();
    }

    public void MostrarProximaPagina()
    {
        var proximoNodoPagina = nodoPaginaAtual.Next;
        if (proximoNodoPagina != null) Mostrar(proximoNodoPagina);
    }
}
