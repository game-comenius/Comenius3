
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AddMetodologiaSprite : MonoBehaviour
{
    public Image metolodologiaIcon;
    void Start()
    {
        metolodologiaIcon.sprite =  EstadoDoJogo.Instance.Metodologia.sprite;
    }

}
