using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayOpenPop : MonoBehaviour
{
    public GameObject delayOpenPop;
    void Start()
    {
        Invoke("OpenPop", 1);
    }

    // Update is called once per frame
    private void OpenPop()
    {
        delayOpenPop.SetActive(true);
    }
}
