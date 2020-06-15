using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UrlOpener : MonoBehaviour {

    public void Open(string url)
    {
        Application.OpenURL(url);
    }
}
