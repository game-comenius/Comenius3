using UnityEngine;
using UnityEngine.UI;

public class PaginaResumoDoPlanejamento : Pagina
{
    [Header("Ícones")]
    [SerializeField] Image IconeMidia1;
    [SerializeField] Image IconeMidia2;
    [SerializeField] Image IconeMidia3;
    [SerializeField] Image IconeMidia4;

    [Header("Textos")]
    [SerializeField] Text NomeDaMetodologia;
    [SerializeField] Text NomeDasMidias;
    [SerializeField] Text NomeDoAgrupamento;

    // Start is called before the first frame update
    void Start()
    {
        var estadoDoJogo = EstadoDoJogo.Instance;
        Debug.Log(estadoDoJogo.MidiasSelecionadas[0].NomeMidia);

        NomeDaMetodologia.text = estadoDoJogo.MetodologiaSelecionada.nome;
        NomeDasMidias.text = estadoDoJogo.MidiasSelecionadas[0].NomeApresentavel + ", " + estadoDoJogo.MidiasSelecionadas[1].NomeApresentavel +
            ", " + estadoDoJogo.MidiasSelecionadas[2].NomeApresentavel + ", " + estadoDoJogo.MidiasSelecionadas[3].NomeApresentavel;

        IconeMidia1.sprite = estadoDoJogo.MidiasSelecionadas[0].SpriteIcone;
        IconeMidia2.sprite = estadoDoJogo.MidiasSelecionadas[1].SpriteIcone;
        IconeMidia3.sprite = estadoDoJogo.MidiasSelecionadas[2].SpriteIcone;
        IconeMidia4.sprite = estadoDoJogo.MidiasSelecionadas[3].SpriteIcone;
    }

}
