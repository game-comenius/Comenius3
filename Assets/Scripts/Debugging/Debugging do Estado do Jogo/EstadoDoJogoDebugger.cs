using UnityEngine;

public class EstadoDoJogoDebugger : MonoBehaviour
{
    [SerializeField] private NivelDeEnsino nivelDeEnsinoSelecionado;
    [SerializeField] private AreaDeConhecimento areaDeConhecimentoSelecionada;
    [SerializeField] private Inteligencias inteligenciasSelecionadas;
    [SerializeField] private Metodologia metodologiaSelecionada;
    [SerializeField] private Midia[] midiasSelecionadas;

    public void OnEnable()
    {
        UpdateData();
    }

    public void UpdateData()
    {
        EstadoDoJogo jogo = EstadoDoJogo.Instance;
        nivelDeEnsinoSelecionado = jogo.NivelDeEnsinoSelecionado;
        areaDeConhecimentoSelecionada = jogo.AreaDeConhecimentoSelecionada;
        inteligenciasSelecionadas = jogo.InteligenciasSelecionadas;
        metodologiaSelecionada = jogo.MetodologiaSelecionada;
        midiasSelecionadas = jogo.MidiasSelecionadas;
    }
}
