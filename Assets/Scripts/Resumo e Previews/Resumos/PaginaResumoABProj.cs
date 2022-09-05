using UnityEngine;
using UnityEngine.UI;

public class PaginaResumoABProj : PaginaPlanejamento
{
    [Header("Ícones")]
    [SerializeField] Image IconeMidia1;
    [SerializeField] Image IconeMidia2;

    [Header("Ícones Laterais")]
    [SerializeField] private Sprite primeiroIcone;
    [SerializeField] private Sprite segundoIcone;

    protected override void OnEnable()
    {
        textoAjuda.text = ajuda;
        fundo.sprite = spriteFundo;

        iconManager.ShowIcon(0);
        iconManager.ShowIcon(1);
        iconManager.HideIcon(2);
        iconManager.HideIcon(3);

        iconManager.SetIcon(0, primeiroIcone);
        iconManager.SetIcon(1, segundoIcone);

        var estadoDoJogo = EstadoDoJogo.Instance;

        if (estadoDoJogo.Metodologia == Metodologia.ABProj || true)
        {
            IconeMidia1.sprite = estadoDoJogo.Midias[0].sprite;
            IconeMidia2.sprite = estadoDoJogo.Midias[1].sprite;
        }
    }

    private void OnDisable()
    {
        iconManager.ResetIcon(0);
        iconManager.ResetIcon(1);
    }
}
