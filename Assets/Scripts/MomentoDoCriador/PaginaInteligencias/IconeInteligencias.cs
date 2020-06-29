using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class IconeInteligencias : MonoBehaviour, IPointerClickHandler
{
    public bool Selecionado { get; set; }

    public GrupoDeIconesInteligencias grupo;

    [SerializeField] int valorInteligencias;
    public Inteligencias Valor
    {
        get { return Inteligencias.Get(valorInteligencias); }
    }

    [SerializeField] public Sprite SpriteGrande;

    private Image imageComponent;
    public Image ImageComponent => imageComponent ? imageComponent : imageComponent = GetComponentInChildren<Image>();

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!Selecionado && grupo && grupo.Selecionar(this)) return;

        Selecionado = !Selecionado;
    }
}
