using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextoDePlanilha : MonoBehaviour
{
    public CelulaReference celula;
    public Text texto;

    private void OnEnable()
    {
        if (texto == null)
            texto = GetComponent<Text>();
    }

    [ContextMenu("Start()")]
    private void Start()
    {
        if (texto == null)
            texto = GetComponent<Text>();

        texto.text = celula.Valor;
    }
}
