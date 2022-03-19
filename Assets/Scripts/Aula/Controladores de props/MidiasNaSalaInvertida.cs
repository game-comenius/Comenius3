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
    StateMachine controladorJogo;

    void OnEnable()
    {
        UpdateDisplay();
        controladorJogo.OnMediaChange.AddListener(UpdateDisplay);
    }

    void OnDisable()
    {
        controladorJogo.OnMediaChange.RemoveListener(UpdateDisplay);
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
        NomeDeMidia midiaParaMostrar = controladorJogo.currentMedia.nomeMidia;
        foreach (ParMidia midia in midiasNaSala)
        {
            if (midia.nome == midiaParaMostrar)
            {
                midia.obj.SetActive(true);
                return;
            }
        }
    }
}
