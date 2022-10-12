using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganizadorListas : MonoBehaviour
{
    [SerializeField] private List<int> opcoesDeRespostaCidade = new List<int>();
    [SerializeField] private List<int> opcoesDemidia = new List<int>();
    public static OrganizadorListas instance;
    private int midia;
    private int listaCidade;

    private void Awake()
    {
        instance = this;
    }

    public int ObterNumeroListaCidade()
    {
        int random1 = opcoesDeRespostaCidade[Random.Range(0, opcoesDeRespostaCidade.Count)];
        StartCoroutine(RemoverListaCidade(random1));
        return random1;
   
    }

    public int ObterOpcoesMidia()
    {
        int random1 = 0;
        if (opcoesDemidia.Count > 0)
        {
            random1 = opcoesDemidia[Random.Range(0, opcoesDemidia.Count)];
            StartCoroutine(RemoverMidia(random1));
        }
       
        return random1;

    }

    public int ConsultarQuantidadeMidias()
    {
        return opcoesDemidia.Count;
    }
    IEnumerator RemoverMidia( int valor)
    {
        yield return new WaitForSeconds(0.5f);
        opcoesDemidia.Remove(valor);
    }

    IEnumerator RemoverListaCidade(int valor)
    {
        yield return new WaitForSeconds(0.5f);
        opcoesDeRespostaCidade.Remove(valor);
    }
}
