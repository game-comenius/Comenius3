using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjetoSelecionavel : MonoBehaviour, IPointerClickHandler
{
    public UnityEngine.Events.UnityEvent OnClick;

    //Chama quando o objeto é clicado
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        //Output to console the clicked GameObject's name and the following message. You can replace this with your own actions for when clicking the GameObject.
        Debug.Log(name + " Game Object Clicked!");
        OnClick.Invoke();
    }
}