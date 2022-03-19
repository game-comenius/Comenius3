using UnityEngine;
using UnityEngine.EventSystems;

public class IconePersonagem : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // TODO: Corrigir os nomes das variáveis para camelCase
    public Sprite SpriteCorpo;
    public Sprite SpriteCabelo;
    public Sprite SpriteRoupa;
    public Sprite SpriteCorpoSentado;
    public Sprite SpriteCabeloSentado;
    public Sprite SpriteRoupaSentado;

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
