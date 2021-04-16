using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidiasNaSalaInvertida : MonoBehaviour
{
    [System.Serializable]
    protected struct ParMidia 
    {
       public NomeDeMidia nome;
       public GameObject obj;
    }

    [SerializeField]
    private ParMidia[] midiasNaSala;

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

    void Esconder()
    {
        foreach (ParMidia midia in midiasNaSala)
        {
            midia.obj.SetActive(false);
        }
    }

    public void UpdateDisplay()
    {
        NomeDeMidia midiaParaMostrar = controladorJogo.MidiaAtual.NomeMidia;
        foreach (ParMidia midia in midiasNaSala)
        {
            if(midia.nome == midiaParaMostrar)
            {
                midia.obj.SetActive(true);
                return;
            }
        }
    }
}
