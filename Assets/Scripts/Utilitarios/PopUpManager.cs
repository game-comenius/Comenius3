using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpManager : MonoBehaviour
{

    public GameObject infoCanvas;

    private void OpenPanel()
    {
        if (infoCanvas != null)
        {
            infoCanvas.SetActive(true);

        }
    }

    private void QuitPanel()
    {
        if (infoCanvas != null)
        {
            infoCanvas.SetActive(false);
        }
    }

    public void FuncaoDupla()
    {
        if (infoCanvas != null && infoCanvas.activeInHierarchy == false)
        {
            OpenPanel();
        }
        else
        {
            QuitPanel();
        }
    }

}
