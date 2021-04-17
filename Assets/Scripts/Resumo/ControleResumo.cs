using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleResumo : MonoBehaviour
{

    [SerializeField] GameObject PaginaResumoCriador;
    [SerializeField] GameObject PaginaResumoPlanejamento;

    // Start is called before the first frame update
    void Start()
    {
        var estadoDoJogo = EstadoDoJogo.Instance;

        if (estadoDoJogo.MetodologiaSelecionada == Metodologia.ABP)
        {
            PaginaResumoCriador.SetActive(true);
            PaginaResumoPlanejamento.SetActive(false);
        }
        else
        {
            PaginaResumoCriador.SetActive(false);
            PaginaResumoPlanejamento.SetActive(true);
        }

    }

}