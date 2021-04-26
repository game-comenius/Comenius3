using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPreviewQuartos : MonoBehaviour
{
    [Header("Quartos")]
    [SerializeField] private GameObject QuartoInfantil;
    [SerializeField] private GameObject QuartoFundamental;
    [SerializeField] private GameObject QuartoMedio;
    [SerializeField] private GameObject QuartoSuperior;

    // Start is called before the first frame update
    void Start()
    {

        QuartoInfantil.SetActive(false);
        QuartoFundamental.SetActive(false);
        QuartoMedio.SetActive(false);
        QuartoSuperior.SetActive(false);

        int indiceNivelDeEnsino = EstadoDoJogo.Instance.NivelDeEnsinoSelecionado.valor;

        //Ativa o gameObject correspondente ao selecionado
        switch (indiceNivelDeEnsino)
        {
            case 0: //Educação Infantil
                QuartoInfantil.SetActive(true);
                break;
            case 1: //Ensino Fundamental
                QuartoFundamental.SetActive(true);
                break;
            case 2: //Ensino Medio
                QuartoMedio.SetActive(true);
                break;
            default: //Ensino Superior
                QuartoSuperior.SetActive(true);
                break;
        }

    }

}
