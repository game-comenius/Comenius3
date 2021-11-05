using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorPreviewQuartoNoPlanejamento : MonoBehaviour
{

    [SerializeField] Sprite quartoInfantil;
    [SerializeField] Sprite quartoFundamental;
    [SerializeField] Sprite quartoMedio;
    [SerializeField] Sprite quartoSuperior;

    [SerializeField] Image previewQuarto;

    // Start is called before the first frame update
    void Start()
    {

        int indiceNivelDeEnsino = EstadoDoJogo.Instance.NivelDeEnsinoSelecionado.valor;

        switch (indiceNivelDeEnsino)
        {
            case 0: //Educação Infantil
                previewQuarto.sprite = quartoInfantil;
                break;
            case 1: //Ensino Fundamental
                previewQuarto.sprite = quartoFundamental;
                break;
            case 2: //Ensino Médio
                previewQuarto.sprite = quartoMedio;
                break;
            default: //Ensino Superior
                previewQuarto.sprite = quartoSuperior;
                break;
        }

    }

}
