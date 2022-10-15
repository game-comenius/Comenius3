using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textoIntro : MonoBehaviour
{
    public Text texto;
    void Start()
    {
        texto.text = "Agora os estudantes vão reagir ao seu tema de aula!\nBoa Sorte!\r\n O tema da aula é: " + EstadoDoJogo.Instance.Tema;
     }

}
