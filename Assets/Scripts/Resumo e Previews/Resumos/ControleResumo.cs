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

        bool isInvertida = estadoDoJogo.MetodologiaSelecionada == Metodologia.Invertida;

        PaginaResumoCriador.SetActive(!isInvertida);
        PaginaResumoPlanejamento.SetActive(isInvertida);
    }

}