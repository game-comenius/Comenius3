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

        if (estadoDoJogo.MetodologiaSelecionada == Metodologia.Invertida)
        {
            PaginaResumoCriador.SetActive(false);
            PaginaResumoPlanejamento.SetActive(true);
        }
        else
        {
            PaginaResumoCriador.SetActive(true);
            PaginaResumoPlanejamento.SetActive(false);
        }

    }

}