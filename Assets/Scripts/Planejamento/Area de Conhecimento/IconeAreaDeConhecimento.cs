using UnityEngine;
using UnityEngine.EventSystems;

public class IconeAreaDeConhecimento : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public AreaDeConhecimento areaDeConhecimento
    {
        get { return AreaDeConhecimento.Get(valorAreaDeConhecimento); }
    }
    public PaginaAreaDeConhecimento pagina;

    [HideInInspector] public int valorAreaDeConhecimento = NivelDeEnsino.EnsinoSuperior.AreasDeConhecimento[0].valor;
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
