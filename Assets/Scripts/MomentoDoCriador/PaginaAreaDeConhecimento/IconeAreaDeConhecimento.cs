using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class IconeAreaDeConhecimento : MonoBehaviour, IPointerClickHandler
{
    public bool Selecionado { get; set; }

    public GrupoDeIconesAreaDeConhecimento grupo;

    [SerializeField] int valorAreaDeConhecimento = NivelDeEnsino.EnsinoSuperior.AreasDeConhecimento[0].valor;
    public AreaDeConhecimento Valor
    {
        get { return AreaDeConhecimento.Get(valorAreaDeConhecimento); }
    }

    [SerializeField] public Sprite SpriteGrande;

    private Image imageComponent;
    public Image ImageComponent => imageComponent ? imageComponent : imageComponent = GetComponentInChildren<Image>();

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!Selecionado && grupo && grupo.Selecionar(this))
        {
            AudioManager.instance.TocarSFX("clique");
            return;
        }


        Selecionado = !Selecionado;

        AudioManager.instance.TocarSFX("clique");
    }
}
