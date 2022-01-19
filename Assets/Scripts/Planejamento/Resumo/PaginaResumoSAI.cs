using UnityEngine;
using UnityEngine.UI;

public class PaginaResumoSAI : PaginaPlanejamento
{
    [Header("Ícones")]
    [SerializeField] Image IconeMidia1;
    [SerializeField] Image IconeMidia2;
    [SerializeField] Image IconeMidia3;
    [SerializeField] Image IconeMidia4;

    [Header("Ícones Laterais")]
    [SerializeField] private Sprite primeiroIcone;
    [SerializeField] private Sprite segundoIcone;

    protected override void OnEnable()
    {
        fundo.sprite = spriteFundo;

        iconManager.ShowIcon(0);
        iconManager.ShowIcon(1);
        iconManager.HideIcon(2);
        iconManager.HideIcon(3);

        iconManager.SetIcon(0, primeiroIcone);
        iconManager.SetIcon(1, segundoIcone);

        var estadoDoJogo = EstadoDoJogo.Instance;

        if (estadoDoJogo.MetodologiaSelecionada == Metodologia.Invertida)
        {
            IconeMidia1.sprite = estadoDoJogo.MidiasSelecionadas[0].sprite;
            IconeMidia2.sprite = estadoDoJogo.MidiasSelecionadas[1].sprite;
            IconeMidia3.sprite = estadoDoJogo.MidiasSelecionadas[2].sprite;
            IconeMidia4.sprite = estadoDoJogo.MidiasSelecionadas[3].sprite;
        }
    }

    private void OnDisable()
    {
        iconManager.ResetIcon(0);
        iconManager.ResetIcon(1);
    }
}
