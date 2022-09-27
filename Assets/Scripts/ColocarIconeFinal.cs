using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColocarIconeFinal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GetComponent<Image>())
        {
            GetComponent<Image>().sprite = EstadoDoJogo.Instance.Midias[2].sprite;
        }
        else
        {
            //
            GetComponent<SpriteRenderer>().sprite = EstadoDoJogo.Instance.Midias[2].sprite;
        }

    }

}
