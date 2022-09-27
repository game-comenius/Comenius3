using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PaginaResumoABProj : PaginaPlanejamento
{
    [Header("Ícones")]
    [SerializeField] Image IconeMidia1;
    [SerializeField] Image IconeMidia2;
    [SerializeField] Image IconeMidia3;

    [Header("BG Branca")]
    public Image bgBranca;
    public Sprite bg;
    public Sprite old;
    [Header("Ícones Laterais")]
    [SerializeField] private Sprite primeiroIcone;
    [SerializeField] private Sprite segundoIcone;
    [SerializeField] private Sprite terceiroIcone;
    protected override void OnEnable()
    {
        if(SceneManager.GetActiveScene().name == "Mídias Pós Sala 1.1")
        {
            bgBranca.sprite = bg;
        
        }
        textoAjuda.text = ajuda;
        fundo.sprite = spriteFundo;

        iconManager.ShowIcon(0);
        iconManager.ShowIcon(1);
        iconManager.ShowIcon(2);
        iconManager.HideIcon(2);
        iconManager.HideIcon(3);

        iconManager.SetIcon(0, primeiroIcone);
        iconManager.SetIcon(1, segundoIcone);

        var estadoDoJogo = EstadoDoJogo.Instance;

        if (estadoDoJogo.Metodologia == Metodologia.ABProj || true)
        {
            IconeMidia1.sprite = estadoDoJogo.Midias[0].sprite;
            IconeMidia2.sprite = estadoDoJogo.Midias[1].sprite;
            IconeMidia3.sprite = estadoDoJogo.Midias[2].sprite;
        }
    }

    private void OnDisable()
    {
        iconManager.ResetIcon(0);
        iconManager.ResetIcon(1);
        bgBranca.sprite = old;
    }
}
