using UnityEngine;
using UnityEngine.EventSystems;

public class IconeNivelDeEnsino : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public NivelDeEnsino nivelDeEnsino
    {
        get { return NivelDeEnsino.Get(valorNivelDeEnsino); }
    }
    public PaginaNivelDeEnsino pagina;

    [HideInInspector] public int valorNivelDeEnsino;
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
