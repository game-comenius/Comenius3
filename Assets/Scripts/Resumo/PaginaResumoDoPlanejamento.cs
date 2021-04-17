using UnityEngine;
using UnityEngine.UI;

public class PaginaResumoDoPlanejamento : Pagina
{
    // Start is called before the first frame update
    void Start()
    {
        var estadoDoJogo = EstadoDoJogo.Instance;
        Debug.Log(estadoDoJogo.MidiasSelecionadas[0]);
        /*
        if (estadoDoJogo.NivelDeEnsinoSelecionado.Sprite)
            iconeNivelDeEnsinoEscolhido.sprite = estadoDoJogo.NivelDeEnsinoSelecionado.Sprite;
            nomeDoNivelDeEnsinoEscolhido.text = estadoDoJogo.NivelDeEnsinoSelecionado.nome;

        if (estadoDoJogo.AreaDeConhecimentoSelecionada.Sprite)
            iconeAreaDeConhecimentoEscolhida.sprite = estadoDoJogo.AreaDeConhecimentoSelecionada.Sprite;
            nomeDaAreaDeConhecimentoEscolhida.text = estadoDoJogo.AreaDeConhecimentoSelecionada.nome;

        if (estadoDoJogo.InteligenciasSelecionadas.SpriteGrande)
            iconeInteligenciasEscolhidas.sprite = estadoDoJogo.InteligenciasSelecionadas.SpriteGrande;
            nomeDasInteligenciasSelecionadas.text = estadoDoJogo.InteligenciasSelecionadas.Nome;
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
