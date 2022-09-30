using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textoIntro : MonoBehaviour
{
    public Text texto;
    void Start()
    {
        texto.text = "Os estudantes irão reagir à sua escolha de mídia\nBoa Sorte!\r\n O tema da aula é: " + EstadoDoJogo.Instance.Tema;
     }

}
