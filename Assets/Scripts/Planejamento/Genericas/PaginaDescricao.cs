using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaginaDescricao : PaginaPlanejamento
{
    [SerializeField] private Sprite iconePadrao;
    [SerializeField] private int indiceDoIcone;

    protected override void OnEnable()
    {
        textoAjuda.text = ajuda;
        iconManager.SetIcon(indiceDoIcone, iconePadrao);
    }

    private void OnDisable()
    {
        iconManager.ResetIcon(indiceDoIcone);
    }
}
