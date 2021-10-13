using UnityEngine;
using UnityEngine.EventSystems;

public class IconeInteligencias : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Inteligencias inteligencia
    {
        get { return Inteligencias.Get(valorInteligencias); }
    }
    public PaginaInteligencias pagina;

    [HideInInspector] public int valorInteligencias;
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
