using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpManager : MonoBehaviour
{

    public GameObject InfoCanvas;

    public void OpenPanel()
    {
        if(InfoCanvas != null)
        {
            InfoCanvas.SetActive(true);
        }
    }

    public void QuitPanel()
    {
        Debug.Log("Fechou");
        InfoCanvas.SetActive(false);
    }
}
