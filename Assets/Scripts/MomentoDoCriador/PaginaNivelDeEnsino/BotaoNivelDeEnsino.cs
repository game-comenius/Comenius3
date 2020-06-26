using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BotaoNivelDeEnsino : MonoBehaviour, IPointerClickHandler
{
    public bool Selecionado { get; set; }

    public GrupoDeBotoesNivelDeEnsino grupo;

    [SerializeField] int valorNivelDeEnsino = NivelDeEnsino.EnsinoSuperior.valor;
    public NivelDeEnsino Valor
    {
        get { return NivelDeEnsino.Get(valorNivelDeEnsino); }
    }

    [SerializeField] public Sprite SpriteGrande;


    private Image imageComponent;
    public Image ImageComponent => imageComponent ? imageComponent : imageComponent = GetComponentInChildren<Image>();

    private void Start()
    {
        if (!grupo) grupo = GetComponentInParent<GrupoDeBotoesNivelDeEnsino>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!Selecionado && grupo && grupo.Selecionar(this)) return;

        Selecionado = !Selecionado;
    }
}
