using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPreviews : MonoBehaviour
{

    [SerializeField] private GameObject Infantil;
    [SerializeField] private GameObject Fundamental;
    [SerializeField] private GameObject Medio;
    [SerializeField] private GameObject Superior;

    // Start is called before the first frame update
    void Start()
    {

        Infantil.SetActive(false);
        Fundamental.SetActive(false);
        Medio.SetActive(false);
        Superior.SetActive(false);

        int indiceNivelDeEnsino = EstadoDoJogo.Instance.NivelDeEnsinoSelecionado.valor;

        //Ativa o gameObject correspondente ao selecionado
        switch (indiceNivelDeEnsino)
        {
            case 0: //Educação Infantil
                Infantil.SetActive(true);
                break;
            case 1: //Ensino Fundamental
                Fundamental.SetActive(true);
                break;
            case 2: //Ensino Medio
                Medio.SetActive(true);
                break;
            default: //Ensino Superior
                Superior.SetActive(true);
                break;
        }

    }

}
