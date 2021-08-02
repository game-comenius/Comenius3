using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreviewNomeMidia : MonoBehaviour
{

    [SerializeField] Text midiaSala1Nome;
    [SerializeField] Text midiaSala2Nome;

    // Start is called before the first frame update
    void Start()
    {

        var midiaSala1 = EstadoDoJogo.Instance.MidiasSelecionadas[2].NomeApresentavel;
        var midiaSala2 = EstadoDoJogo.Instance.MidiasSelecionadas[3].NomeApresentavel;

        midiaSala1Nome.text = midiaSala1;
        midiaSala2Nome.text = midiaSala2;

    }

}
