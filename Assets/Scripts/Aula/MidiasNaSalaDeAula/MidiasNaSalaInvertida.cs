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
    EstadoDeAulaInvertida controladorJogo;

    void OnEnable()
    {
        UpdateDisplay();
        controladorJogo.OnMidiaChange.AddListener(UpdateDisplay);
    }
    void OnDisable() 
    {
        controladorJogo.OnMidiaChange.RemoveListener(UpdateDisplay);
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
        Esconder();
        NomeDeMidia midiaParaMostrar = controladorJogo.midiaAtual.nomeMidia;
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
