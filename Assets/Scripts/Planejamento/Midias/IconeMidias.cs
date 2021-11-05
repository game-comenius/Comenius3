using UnityEngine;
using UnityEngine.EventSystems;

public class IconeMidias : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Midia midia
    {
        get {return new Midia(nomeMidia); }
    }
    public PaginaMidias pagina;
    public NomeDeMidia nomeMidia;

    [HideInInspector] public bool selecionado;

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
