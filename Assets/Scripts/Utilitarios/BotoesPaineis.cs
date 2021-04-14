using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotoesPaineis : MonoBehaviour
{
    public GameObject painel;

    public void AbrirPainel()
    {
        if(painel != null)
        {
            //Debug.Log("Abriu");
            painel.SetActive(true);
        }
    }

    public void FecharPainel()
    {
        if(painel != null)
        {
            painel.SetActive(false);
        }
    }

}
