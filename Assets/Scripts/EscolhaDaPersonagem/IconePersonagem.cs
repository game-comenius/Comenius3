using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class IconePersonagem : MonoBehaviour, IPointerClickHandler
{
    public Sprite SpriteCorpo;
    public Sprite SpriteCabelo;
    public Sprite SpriteRoupa;

    public bool Selecionado { get; set; }

    [HideInInspector] public GrupoDeIconesPersonagem grupo;

    private Image imageComponent;
    public Image ImageComponent => imageComponent ? imageComponent : imageComponent = GetComponentInChildren<Image>();

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!Selecionado && grupo && grupo.Selecionar(this)) return;

        Selecionado = !Selecionado;
    }
}
