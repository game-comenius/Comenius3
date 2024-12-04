using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class textoIntro : MonoBehaviour
{
    public Text texto;
    void Start()
    {

        switch (Textos.GetIdiomaSelecionado())
        {
            case Idiomas._chaveInicial:
                break;
            case Idiomas.INGLES:
                texto.text = "Now the students will react to your class topic\r\nGood Luck!\r\n The class topic is: " + EstadoDoJogo.Instance.Tema;
                break;
            case Idiomas.PORTUGUES:
                texto.text = "Agora os estudantes vão reagir ao seu tema de aula!\nBoa Sorte!\r\n O tema da aula é: " + EstadoDoJogo.Instance.Tema;
                break;
            case Idiomas.ESPANHOL:
                texto.text = "Ahora los estudiantes reaccionarán a su tema de clase\r\n¡Buena suerte!\r\n El tema de clase es: " + EstadoDoJogo.Instance.Tema;
                break;
        }
    }

}
