using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textoIntro : MonoBehaviour
{
    public Text texto;
    void Start()
    {
        texto.text = "Os estudantes ir�o reagir � sua escolha de m�dia\nBoa Sorte!\r\n O tema da aula �: " + EstadoDoJogo.Instance.Tema;
     }

}
