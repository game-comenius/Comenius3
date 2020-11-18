using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocadorDeCenaLoading : MonoBehaviour
{

    static bool controleTrocaCena = false;

    private void Awake()
    {
        if(controleTrocaCena == false)
        {
            SceneManager.LoadScene("Loading");
            controleTrocaCena = true;
        }
    }

}
