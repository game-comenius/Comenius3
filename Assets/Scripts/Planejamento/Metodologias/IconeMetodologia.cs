using UnityEngine;
using UnityEngine.EventSystems;

public class IconeMetodologia : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Metodologia metodologia
    {
        get { return Metodologia.Get(valorMetodologia); }
    }
    public PaginaMetodologia pagina;

    [HideInInspector] public int valorMetodologia;
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
