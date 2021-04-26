using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPreviewSalas : MonoBehaviour
{

    [Header("Salas")]
    [SerializeField] private GameObject SalaInfantil;
    [SerializeField] private GameObject SalaDeAula;

    //[Header("Laboratórios")]
    //[SerializeField] private GameObject LabInformatica;
    //[SerializeField] private GameObject LabFisica;
    //[SerializeField] private GameObject LabBiologia;
    //[SerializeField] private GameObject LabQuimica;

    // Start is called before the first frame update
    void Start()
    {
        
        SalaInfantil.SetActive(false);
        SalaDeAula.SetActive(false);
        //LabInformatica.SetActive(false);
        //LabFisica.SetActive(false);
        //LabBiologia.SetActive(false);
        //LabQuimica.SetActive(false);
        
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
