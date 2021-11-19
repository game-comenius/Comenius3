using UnityEngine;
using UnityEngine.UI;

public class PaginaResumoABP : PaginaPlanejamento
{
    [SerializeField] private Text texto;

    protected override void OnEnable() {
        texto.text = "Sua aula será feita no laboratório utilizando a metodologia Aprendizagem Baseada em Problemas (ABP) com as mídias " +
                    $"<b>{EstadoDoJogo.Instance.MidiasSelecionadas[0].nome}</b> e <b>{EstadoDoJogo.Instance.MidiasSelecionadas[1].nome}</b>.";
    }
}
