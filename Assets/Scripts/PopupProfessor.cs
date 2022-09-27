using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PopupProfessor : MonoBehaviour
{
    public GameObject midiaEscolhida;

    void Start()
    {
        EstadoDoJogo gameState = EstadoDoJogo.Instance;
        //
        midiaEscolhida.GetComponent<Image>().sprite = gameState.Midias[0].sprite;

    }

}
