//using System.ComponentModel.DataAnnotations.Schema;
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

    [SerializeField]
    EstadoDeAulaInvertida controladorJogo;

    void OnEnable()
    {
        UpdateDisplay();
        controladorJogo.OnMidiaChange.AddListener(UpdateDisplay);
    }

    void OnDisable() 
    {
        controladorJogo.OnMidiaChange.RemoveListener(UpdateDisplay);
    }

    public void UpdateDisplay() 
    {
        Agrupamento agrupamento = controladorJogo.midiaAtual.agrupamento;
        Individual.SetActive(false);
        Duplas.SetActive(false);
        PequenosGrupos.SetActive(false);
        GrandesGrupos.SetActive(false);
        SalaInteira.SetActive(false);

        switch (agrupamento)
        {
            case Agrupamento.FormatoU:
                SalaInteira.SetActive(true);
                break;
            case Agrupamento.Individual:
                Individual.SetActive(true);
                break;
            case Agrupamento.Duplas:
                Duplas.SetActive(true);
                break;
            case Agrupamento.PequenosGrupos:
                PequenosGrupos.SetActive(true);
                break;
            case Agrupamento.GrandesGrupos:
                GrandesGrupos.SetActive(true);
                break;
        }
        
    }
}
