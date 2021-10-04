using UnityEngine;
using UnityEngine.EventSystems;

public class OnHoverShowCharacter : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [HideInInspector] public GrupoDeIconesPersonagem group;

    private IconePersonagem icon;

    private bool hovering;

    private void Start()
    {
        icon = GetComponent<IconePersonagem>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        group.HoverEnter(icon);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        group.HoverExit();
    }
}
