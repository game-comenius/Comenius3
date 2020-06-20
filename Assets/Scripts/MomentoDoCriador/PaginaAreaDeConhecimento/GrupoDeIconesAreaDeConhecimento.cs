using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrupoDeIconesAreaDeConhecimento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Esconder();
    }

    public void Mostrar()
    {
        this.gameObject.SetActive(true);
    }

    public void Esconder()
    {
        this.gameObject.SetActive(false);
    }
}
