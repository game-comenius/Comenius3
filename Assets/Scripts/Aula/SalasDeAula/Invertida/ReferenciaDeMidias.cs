using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenciaDeMidias : MonoBehaviour
{
    public Midia midia1;
    public Midia midia2;
    // Start is called before the first frame update
    void Start()
    {
        midia1 = EstadoDoJogo.Instance.MidiasSelecionadas[2];
        midia2 = EstadoDoJogo.Instance.MidiasSelecionadas[3];
        Debug.Log(midia1.NomeMidia);
        Debug.Log(midia2.NomeMidia);
    }

    // Update is called once per frame
    void Update()
    {

    }// Start is called before the first frame update
    
}
