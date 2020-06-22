using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BotaoNivelDeEnsino : MonoBehaviour, IPointerClickHandler
{
    private bool selecionado;
    public bool Selecionado
    {
        get { return selecionado; }
        set
        {
            selecionado = value;
            ImageComponent.color = selecionado ? (originalColor * 0.7f) : originalColor;
        }
    }

    public GrupoDeBotoesNivelDeEnsino grupo;

    [SerializeField] int valorNivelDeEnsino = NivelDeEnsino.EnsinoSuperior.valor;
    public NivelDeEnsino Valor
    {
        get { return NivelDeEnsino.Get(valorNivelDeEnsino); }
    }

    [SerializeField] public Sprite SpriteGrande;


    private Image imageComponent;
    public Image ImageComponent => imageComponent ? imageComponent : imageComponent = GetComponentInChildren<Image>();

    private Color originalColor;

    private void Awake()
    {
        originalColor = ImageComponent.color;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!Selecionado && grupo && grupo.Selecionar(this)) return;

        Selecionado = !Selecionado;
    }
}
