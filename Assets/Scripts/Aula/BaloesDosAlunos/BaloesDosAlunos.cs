using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class BaloesDosAlunos : MonoBehaviour
{
    private enum TipoDeIconeDeBalao { NivelDeEnsino, AreaDeConhecimento, Inteligencias, Metodologia, Midia, TamanhoDoEnum }

    [Header("Controle")]
    [SerializeField][Range(0, 5)] float TempoEmSegundosDeUmBalao = 2f;
    [SerializeField][Range(0, 5)] float TempoEmSegundosEntreBaloes = .8f;

    [Header("Conjunto de Balões")]
    [SerializeField] GameObject BaloesCorporalCinestesicaComNaturalista;
    [SerializeField] GameObject BaloesIntrapessoalComEspacialVisual;
    [SerializeField] GameObject BaloesInterpessoalComMusical;
    [SerializeField] GameObject BaloesLinguisticaComLogicoMatematica;

    [Header("'Fallback' Sprites")]
    [SerializeField] Sprite nivelDeEnsinoFallbackSprite;
    [SerializeField] Sprite areaDeConhecimentoFallbackSprite;
    [SerializeField] Sprite inteligenciasFallbackSprite;
    [SerializeField] Sprite metodologiaFallbackSprite;
    [SerializeField] Sprite midiaFallbackSprite;

    private Dictionary<Inteligencias, GameObject> baloesPorInteligencias;
    private GameObject conjuntoDeBaloesAtivo;

    void Start()
    {
        baloesPorInteligencias = new Dictionary<Inteligencias, GameObject>
        {
            { Inteligencias.CorporalCinestesicaComNaturalista, BaloesCorporalCinestesicaComNaturalista },
            { Inteligencias.IntrapessoalComEspacialVisual, BaloesIntrapessoalComEspacialVisual },
            { Inteligencias.InterpessoalComMusical, BaloesInterpessoalComMusical },
            { Inteligencias.LinguisticaComLogicoMatematica, BaloesLinguisticaComLogicoMatematica }
        };

        // No início, esconder todos os balões
        foreach (var baloes in baloesPorInteligencias.Values) baloes.SetActive(false);
    }

    public IEnumerator ExecutarAnimacao(Inteligencias inteligenciasSelecionadas)
    {
        // Mostrar apenas os balões que correspondem ao par de inteligências selecionadas
        conjuntoDeBaloesAtivo = baloesPorInteligencias[inteligenciasSelecionadas];
        conjuntoDeBaloesAtivo.SetActive(true);

        var transformDoConjunto = conjuntoDeBaloesAtivo.transform;
        var quantidadeDeBaloes = transformDoConjunto.childCount;

        // Esconder todos os balões deste conjunto
        for (var i = 0; i < quantidadeDeBaloes; i++)
            transformDoConjunto.GetChild(i).gameObject.SetActive(false);

        // Definir as variáveis usadas dentro do while
        int indiceAleatorio;
        GameObject balaoEscolhido;
        EstadoDoJogo jogo = EstadoDoJogo.Instance;
        Sprite spriteDoIconeDoBalao;
        Image imageDoIconeDoBalao;
        Image imageDoIconeDoBalao2; // Caso especial para inteligências interpessoal + musical
        bool InteligenciasInterpessoalComMusicalForamEscolhidas = (inteligenciasSelecionadas == Inteligencias.InterpessoalComMusical);
        // Mostrar um balão do conjunto de cada vez
        while (true)
        {
            // Sortear um balão aleatório do conjunto
            indiceAleatorio = Random.Range(0, quantidadeDeBaloes);
            balaoEscolhido = transformDoConjunto.GetChild(indiceAleatorio).gameObject;

            // Sortear uma categoria de ícone aleatória para estar no balão
            indiceAleatorio = Random.Range(0, (int)TipoDeIconeDeBalao.TamanhoDoEnum);
            // Puxar o sprite correto de acordo com a categoria de ícone sorteada
            switch (indiceAleatorio)
            {
                case (int)TipoDeIconeDeBalao.NivelDeEnsino:
                    spriteDoIconeDoBalao = jogo.NivelDeEnsinoSelecionado.sprite ? jogo.NivelDeEnsinoSelecionado.sprite : nivelDeEnsinoFallbackSprite;
                    break;
                case (int)TipoDeIconeDeBalao.AreaDeConhecimento:
                    spriteDoIconeDoBalao = jogo.AreaDeConhecimentoSelecionada.sprite ? jogo.AreaDeConhecimentoSelecionada.sprite : areaDeConhecimentoFallbackSprite;
                    break;
                case (int)TipoDeIconeDeBalao.Inteligencias:
                    spriteDoIconeDoBalao = jogo.InteligenciasSelecionadas.sprite ? jogo.InteligenciasSelecionadas.sprite : inteligenciasFallbackSprite;
                    break;
                case (int)TipoDeIconeDeBalao.Metodologia:
                    spriteDoIconeDoBalao = jogo.MetodologiaSelecionada.sprite ? jogo.MetodologiaSelecionada.sprite : metodologiaFallbackSprite;
                    break;
                case (int)TipoDeIconeDeBalao.Midia:
                    // O jogador pode ter escolhido várias mídias para serem usadas na aula,
                    // portanto, escolher o sprite do ícone de uma delas aleatoriamente
                    indiceAleatorio = Random.Range(0, jogo.MidiasSelecionadas.Length);
                    var midia = jogo.MidiasSelecionadas[indiceAleatorio];
                    spriteDoIconeDoBalao = midia.SpriteIcone ? midia.SpriteIcone : midiaFallbackSprite;
                    break;
                default:
                    spriteDoIconeDoBalao = null; break;
            }

            // Definir o sprite do ícone do balão
            // Caso especial para quando o jogador seleciona inteligências interpessoal + musical
            // Um balão na verdade é uma dupla de balões, os alunos conversam entre si e o
            // sprite do ícone estará apenas no segundo balão, que fica na frente
            if (InteligenciasInterpessoalComMusicalForamEscolhidas)
            {
                imageDoIconeDoBalao2 = balaoEscolhido.transform.GetChild(1).GetChild(0).GetComponent<Image>();
                imageDoIconeDoBalao2.sprite = spriteDoIconeDoBalao;
            }
            else
            {
                imageDoIconeDoBalao = balaoEscolhido.transform.GetChild(0).GetComponent<Image>();
                imageDoIconeDoBalao.sprite = spriteDoIconeDoBalao;
            }

            balaoEscolhido.SetActive(true);
            yield return new WaitForSeconds(TempoEmSegundosDeUmBalao);
            balaoEscolhido.SetActive(false);
            yield return new WaitForSeconds(TempoEmSegundosEntreBaloes);
        }
    }

    // Destruir a coroutine ExecutarAnimacao pois ela é infinita
    private void OnDestroy() { StopAllCoroutines(); }
}
