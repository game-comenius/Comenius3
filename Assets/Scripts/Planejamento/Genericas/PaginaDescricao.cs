using UnityEngine;

public class PaginaDescricao : PaginaPlanejamento
{
    [SerializeField] private Sprite iconePadrao;
    [SerializeField] private int indiceDoIcone;

    protected override void OnEnable()
    {
        AtualizarTextos();
        fundo.sprite = spriteFundo;
        textoAjuda.text = ajuda;

        iconManager.ShowIcon(0);
        iconManager.HideIcon(1);
        iconManager.HideIcon(2);
        iconManager.HideIcon(3);

        iconManager.SetIcon(indiceDoIcone, iconePadrao);
    }

    private void OnDisable()
    {
        iconManager.ResetIcon(indiceDoIcone);
    }
}
