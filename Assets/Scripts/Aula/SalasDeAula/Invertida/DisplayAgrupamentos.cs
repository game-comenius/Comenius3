using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayAgrupamentos : MonoBehaviour
{   
    [Header("Agrupamentos")]

    [SerializeField]
    GameObject Individual;
     [SerializeField]
    GameObject Duplas;
     [SerializeField]
    GameObject PequenosGrupos;
     [SerializeField]
    GameObject GrandesGrupos;
     [SerializeField]
    GameObject SalaInteira;

    void Start()
    {
        MostrarAgrupamento();
    }

    public void MostrarAgrupamento() 
    {
        int agrupamento = EstadoDoJogo.Instance.Agrupamento;

        Individual.SetActive(false);
        Duplas.SetActive(false);
        PequenosGrupos.SetActive(false);
        GrandesGrupos.SetActive(false);
        SalaInteira.SetActive(false);

        switch (agrupamento)
        {
            case (int)Agrupamento.FormatoU:
                SalaInteira.SetActive(true);
                break;
            case (int)Agrupamento.Individual:
                Individual.SetActive(true);
                break;
            case (int)Agrupamento.Duplas:
                Duplas.SetActive(true);
                break;
            case (int)Agrupamento.PequenosGrupos:
                PequenosGrupos.SetActive(true);
                break;
            case (int)Agrupamento.GrandesGrupos:
                GrandesGrupos.SetActive(true);
                break;
        }
        
    }
}
