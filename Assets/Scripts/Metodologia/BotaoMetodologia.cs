using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BotaoMetodologia : MonoBehaviour, IPointerClickHandler
{
    public bool Selecionado { get; set; }

    public GrupoDeBotoesMetodologia grupo;

    [SerializeField] int valorMetodologia = Metodologia.ABJ.valor;
    public Metodologia Valor
    {
        get { return Metodologia.Get(valorMetodologia); }
    }

    [SerializeField] public Sprite SpriteGrande;


    private Image imageComponent;
    public Image ImageComponent => imageComponent ? imageComponent : imageComponent = GetComponentInChildren<Image>();

    private void Start()
    {
        if (!grupo) grupo = GetComponentInParent<GrupoDeBotoesMetodologia>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!Selecionado && grupo && grupo.Selecionar(this))
        {
            AudioManager.instance.TocarSFX("clique");
            return;
        }

        Selecionado = !Selecionado;

        AudioManager.instance.TocarSFX("clique");
    }
}
