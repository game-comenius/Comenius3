using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplaySalaDeAulaInvertida : MonoBehaviour
{
    [SerializeField]
    GameObject salaNormal;
    [SerializeField]
    GameObject salaInfantil;
    [SerializeField]

    MomentoAulaInvertida controladorJogo;
    void OnEnable()
    {
        UpdateDisplay();
        controladorJogo.OnStateChange.AddListener(UpdateDisplay);
    }

    void OnDisable() 
    {
        controladorJogo.OnStateChange.RemoveListener(UpdateDisplay);
    }

    public void UpdateDisplay()
    {
        NivelDeEnsino nivelDeEnsino = EstadoDoJogo.Instance.NivelDeEnsinoSelecionado;

        salaNormal.SetActive(false);
        salaInfantil.SetActive(false);

        if(nivelDeEnsino == NivelDeEnsino.EducacaoInfantil)
            salaInfantil.SetActive(true);
        else
            salaNormal.SetActive(true);
    }
}
