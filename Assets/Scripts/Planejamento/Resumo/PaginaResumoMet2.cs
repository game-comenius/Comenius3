using UnityEngine;
using UnityEngine.UI;

public class PaginaResumoMet2 : PaginaPlanejamento
{
    [SerializeField] private Image iconePrimeiraMidiaDoQuarto;
    [SerializeField] private Image iconeSegundaMidiaDoQuarto;
    [SerializeField] private Image iconePrimeiraMidiaDaSala;
    [SerializeField] private Image iconeSegundaMidiaDaSala;

    protected override void OnEnable()
    {
        textoAjuda.text = ajuda;

        iconePrimeiraMidiaDoQuarto.sprite = EstadoDoJogo.Instance.MidiasSelecionadas[0].sprite;
        iconeSegundaMidiaDoQuarto.sprite = EstadoDoJogo.Instance.MidiasSelecionadas[1].sprite;
        iconePrimeiraMidiaDaSala.sprite = EstadoDoJogo.Instance.MidiasSelecionadas[2].sprite;
        iconeSegundaMidiaDaSala.sprite = EstadoDoJogo.Instance.MidiasSelecionadas[3].sprite;
    }
}
