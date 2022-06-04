using UnityEngine;

public class StagePage : PaginaPlanejamento
{
    [SerializeField] private Methodology methodology;
    [SerializeField] private Sprite methodologySprite;
    [SerializeField] private Animator iconAnimator;

    private enum Methodology
    {
        ABP,
        SAI,
        ABProj
    }

    protected override void OnEnable()
    {
        fundo.sprite = spriteFundo;
        textoAjuda.text = ajuda;

        iconManager.ShowIcon(0);
        iconManager.HideIcon(1);
        iconManager.HideIcon(2);
        iconManager.HideIcon(3);

        iconManager.SetIcon(0, methodologySprite);
    }

    private void OnDisable()
    {
        iconManager.ResetIcon(0);
    }

    private void Start()
    {
        switch (methodology)
        {
            case Methodology.ABP:
                EstadoDoJogo.Instance.Metodologia = Metodologia.Get(0);
                break;
            case Methodology.SAI:
                EstadoDoJogo.Instance.Metodologia = Metodologia.Get(1);
                break;
            case Methodology.ABProj:
                EstadoDoJogo.Instance.Metodologia = Metodologia.Get(2);
                break;
            default:
                Debug.LogError("Erro na definição da metodologia");
                break;
        }

        EstadoDoJogo.Instance.Metodologia.sprite = methodologySprite;
    }
}
