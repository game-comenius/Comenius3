using UnityEngine;
using UnityEngine.EventSystems;

public class IconeNivelDeEnsino : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public PaginaNivelDeEnsino pagina;

    [SerializeField] int valorNivelDeEnsino = NivelDeEnsino.EnsinoSuperior.valor;
    public NivelDeEnsino Valor
    {
        get { return NivelDeEnsino.Get(valorNivelDeEnsino); }
    }

    [HideInInspector]
    public bool selecionado;

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
