using UnityEngine;
using UnityEngine.UI;

public class PaginaResumoDoCriador : Pagina
{
    [SerializeField] Button botaoParaCenaAnterior;

    [Header("Ícones")]
    [SerializeField] Image iconeNivelDeEnsinoEscolhido;
    [SerializeField] Image iconeAreaDeConhecimentoEscolhida;
    [SerializeField] Image iconeInteligenciasEscolhidas;

    [Header("Textos")]
    [SerializeField] Text nomeDoNivelDeEnsinoEscolhido;
    [SerializeField] Text nomeDaAreaDeConhecimentoEscolhida;
    [SerializeField] Text nomeDasInteligenciasSelecionadas;

    private void Start()
    {
        var estadoDoJogo = EstadoDoJogo.Instance;

        if (estadoDoJogo.NivelDeEnsinoSelecionado.Sprite)
            iconeNivelDeEnsinoEscolhido.sprite = estadoDoJogo.NivelDeEnsinoSelecionado.Sprite;
        nomeDoNivelDeEnsinoEscolhido.text = estadoDoJogo.NivelDeEnsinoSelecionado.nome;

        if (estadoDoJogo.AreaDeConhecimentoSelecionada.Sprite)
            iconeAreaDeConhecimentoEscolhida.sprite = estadoDoJogo.AreaDeConhecimentoSelecionada.Sprite;
        nomeDaAreaDeConhecimentoEscolhida.text = estadoDoJogo.AreaDeConhecimentoSelecionada.nome;

        if (estadoDoJogo.InteligenciasSelecionadas.SpriteGrande)
            iconeInteligenciasEscolhidas.sprite = estadoDoJogo.InteligenciasSelecionadas.SpriteGrande;
        nomeDasInteligenciasSelecionadas.text = estadoDoJogo.InteligenciasSelecionadas.Nome;

        // Garantir que o botão para voltar à cena anterior apareça
        if (botaoParaCenaAnterior != null) botaoParaCenaAnterior.gameObject.SetActive(true);
    }
}
