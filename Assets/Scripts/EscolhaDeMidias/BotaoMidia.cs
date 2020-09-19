using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BotaoMidia : MonoBehaviour
{
    [SerializeField]
    private NomeMidias midia;

    [SerializeField]
    private GameObject manager; //objeto com script SelecaoMidia.cs

    public void SelecionarEssaMidia()
    {
        if (manager != null)
        {
            manager.GetComponent<SelecaoMidia>().SelecionarMidia(midia);
            //Debug.Log("midia selecionada: " + midia);
        }
        else
        {
            Debug.Log("Botão de seleção de mídia sem referência ao manager");
        }
    }
}
