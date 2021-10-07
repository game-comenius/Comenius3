using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class IconePersonagem : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public PaginaEscolhaDaPersonagem pagina;
    public Sprite SpriteCorpo;
    public Sprite SpriteCabelo;
    public Sprite SpriteRoupa;

    [HideInInspector]
    public bool Selecionado;

    private bool hovering;

    private void Start()
    {
        Selecionado = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        pagina.HoverEnter(this);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        pagina.HoverExit();
    }
}
