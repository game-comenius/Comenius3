using System.Collections;
using UnityEngine;

public abstract class SalaDeAula : MonoBehaviour
{
    public MidiasNaSalaDeAula MidiasNaSalaDeAula;
    public BaloesDosAlunos baloesDosAlunos;

    private void Awake()
    {
        
        this.gameObject.SetActive(false);
        Debug.Log("Escondi o objeto ");
    }

    public virtual IEnumerator Mostrar()
    {
        this.gameObject.SetActive(true);
        Debug.Log("Mostrei o objeto " + gameObject.name);
        yield break;
    }
}
