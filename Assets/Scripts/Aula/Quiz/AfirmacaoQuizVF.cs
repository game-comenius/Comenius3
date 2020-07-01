using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AfirmacaoQuizVF : MonoBehaviour
{
    [SerializeField] Text textoAfirmacao;

    public string Texto
    {
        get { return textoAfirmacao.text; }
        set { textoAfirmacao.text = value;}
    }
}
