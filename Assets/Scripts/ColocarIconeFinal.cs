using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColocarIconeFinal : MonoBehaviour
{
    public Sprite bosta;
    void Start()
    {
        if (GetComponent<Image>())
        {
            GetComponent<Image>().sprite = EstadoDoJogo.Instance.Midias[2].sprite;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = EstadoDoJogo.Instance.Midias[2].sprite;
           

        }

    }

}
