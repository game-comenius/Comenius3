using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DisplaySlider : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool highLighted = false;
    
    // Se o cursor estiver sobre a imagem deste objeto, highlighted é verdadeiro.
    public void OnPointerEnter(PointerEventData eventData)
    {
        highLighted = true;
    } 
    // Se o cursor SAIR de cima da imagem do objeto, highlighted volta a ser false.
    public void OnPointerExit(PointerEventData eventData)
    {
        highLighted = false;
    }
}
