using UnityEngine;
using UnityEngine.EventSystems;

public class IconePersonagem : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Sprite SpriteCorpo;
    public Sprite SpriteCabelo;
    public Sprite SpriteRoupa;

    [HideInInspector] public bool selecionado;

    [SerializeField] private PaginaEscolhaDaPersonagem pagina;

    private void Start()
    {
        selecionado = false;
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
