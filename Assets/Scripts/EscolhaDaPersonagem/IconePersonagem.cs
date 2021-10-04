using UnityEngine;
using UnityEngine.UI;

public class IconePersonagem : MonoBehaviour
{
    public Sprite SpriteCorpo;
    public Sprite SpriteCabelo;
    public Sprite SpriteRoupa;

    public bool Selecionado { get; set; }

    [HideInInspector] public GrupoDeIconesPersonagem grupo;

    private Image imageComponent;
    public Image ImageComponent => imageComponent ? imageComponent : imageComponent = GetComponentInChildren<Image>();

    private void Start()
    {
        Selecionado = false;
    }
}
