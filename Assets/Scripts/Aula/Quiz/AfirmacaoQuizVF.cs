using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AfirmacaoQuizVF : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] Text textoAfirmacao;

    [SerializeField] Sprite spriteNaoSelecionada;
    [SerializeField] Sprite spriteSelecionada;
    [SerializeField] Sprite spriteCorreta;
    [SerializeField] Sprite spriteErrada;

    public string Texto
    {
        get { return textoAfirmacao.text; }
        set { textoAfirmacao.text = value;}
    }

    public bool Selecionada { get; set; }

    public void OnPointerClick(PointerEventData eventData)
    {
        Selecionada = !Selecionada;

        GetComponent<Image>().sprite = (Selecionada) ? spriteSelecionada : spriteNaoSelecionada;
    }
}
