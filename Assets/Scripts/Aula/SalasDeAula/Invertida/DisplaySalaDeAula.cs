using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplaySalaDeAula : MonoBehaviour
{
    [SerializeField]
    GameObject salaNormal;
    [SerializeField]
    GameObject salaInfantil;

    public UnityEngine.Events.UnityEvent Display;

    void Start() 
    {
        MostrarSala();
    }

    void MostrarSala()
    {
        NivelDeEnsino nivelDeEnsino = EstadoDoJogo.Instance.NivelDeEnsinoSelecionado;

        salaNormal.SetActive(false);
        salaInfantil.SetActive(false);

        if(nivelDeEnsino == NivelDeEnsino.EducacaoInfantil)
            salaInfantil.SetActive(true);
        else
            salaNormal.SetActive(true);

        Display.Invoke();
    }
}
