using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetMidiaEscolhidaPegarMidias : MonoBehaviour
{
    public Image imagemTrocar;
    void Start()
    {
        imagemTrocar.sprite = EstadoDoJogo.Instance.Midias[1].sprite;
    }

}
