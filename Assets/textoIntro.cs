using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textoIntro : MonoBehaviour
{
    public Text texto;
    void Start()
    {
        texto.text = "Agora os estudantes v�o reagir ao seu tema de aula!\nBoa Sorte!\r\n O tema da aula �: " + EstadoDoJogo.Instance.Tema;
     }

}
