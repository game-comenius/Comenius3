using UnityEngine;
using UnityEngine.UI;

public class PaginaResumoABP : PaginaPlanejamento
{
    [SerializeField] private Text texto;
    [SerializeField] private Sprite primeiroIcone;
    [SerializeField] private Sprite segundoIcone;
    [SerializeField] private Image iconePrimeiraMidia;
    [SerializeField] private Image iconeSegundaMidia;

    protected override void OnEnable()
    {
        AtualizarTextos();
        fundo.sprite = spriteFundo;

        textoAjuda.text = ajuda;

        iconManager.ShowIcon(0);
        iconManager.ShowIcon(1);
        iconManager.HideIcon(2);
        iconManager.HideIcon(3);

        iconManager.SetIcon(0, primeiroIcone);
        iconManager.SetIcon(1, segundoIcone);

        iconePrimeiraMidia.sprite = EstadoDoJogo.Instance.Midias[0].sprite;
        iconeSegundaMidia.sprite = EstadoDoJogo.Instance.Midias[1].sprite;

        texto.text = "Sua aula será feita no <b>Laboratório utilizando a metodologia Aprendizagem Baseada em Problemas (ABP)</b> com as mídias " +
                    $"<b>{EstadoDoJogo.Instance.Midias[0].nome}</b> e <b>{EstadoDoJogo.Instance.Midias[1].nome}</b>.";
    }

    private void OnDisable()
    {
        iconManager.ResetIcon(0);
        iconManager.ResetIcon(1);
    }
}
