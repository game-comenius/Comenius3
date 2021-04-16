using System.Collections.Generic;
using UnityEngine;

public abstract class MidiasNaSalaDeAula : MonoBehaviour
{
    protected List<GameObject> midiasVisiveis;

    protected virtual void Awake()
    {
        midiasVisiveis = new List<GameObject>();
    }

    protected void Mostrar()
    {
        foreach (GameObject midia in midiasVisiveis)
        {
            midia.SetActive(true);
        }
    }

    public void EsconderMidiasNaSalaDeAula()
    {
        foreach (var midia in midiasVisiveis) midia.SetActive(false);
        midiasVisiveis.Clear();
    }

    public abstract bool MostrarMidiasNaSalaDeAula(NomeDeMidia nomeDeMidia);
    public abstract bool MostrarMidiasNaSalaDeAula(NomeDeMidia[] nomeDeMidia);
}
