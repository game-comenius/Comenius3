using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPreviewSalas : MonoBehaviour
{

    [Header("Salas")]
    [SerializeField] private GameObject SalaInfantil;
    [SerializeField] private GameObject SalaDeAula;

    // Start is called before the first frame update
    void Start()
    {
        
        SalaInfantil.SetActive(false);
        SalaDeAula.SetActive(false);
        
        int indiceNivelDeEnsino = EstadoDoJogo.Instance.NivelDeEnsinoSelecionado.valor;
        
        //Ativa o gameObject correspondente ao selecionado
        switch (indiceNivelDeEnsino)
        {
            case 0: //Educação Infantil
                SalaInfantil.SetActive(true);
                break;
            default: //Resto
                SalaDeAula.SetActive(true);
                break;
        }
        
    }


}
