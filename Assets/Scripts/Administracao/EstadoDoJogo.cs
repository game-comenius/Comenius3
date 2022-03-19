using System.Collections.Generic;
using UnityEngine;

public class EstadoDoJogo : Singleton<EstadoDoJogo>
{
    // Propriedades definidas pelo criador de um jogo
    private NivelDeEnsino nivelDeEnsinoSelecionado;
    public NivelDeEnsino NivelDeEnsinoSelecionado
    {
        get
        {
            if (nivelDeEnsinoSelecionado == null)
                nivelDeEnsinoSelecionado = NivelDeEnsino.EnsinoSuperior;
            return nivelDeEnsinoSelecionado;
        }

        set => nivelDeEnsinoSelecionado = value;
    }

    private AreaDeConhecimento areaDeConhecimentoSelecionada;
    public AreaDeConhecimento AreaDeConhecimentoSelecionada
    {
        get
        {
            if (areaDeConhecimentoSelecionada == null)
                areaDeConhecimentoSelecionada = AreaDeConhecimento.CienciasHumanas;
            return areaDeConhecimentoSelecionada;
        }

        set => areaDeConhecimentoSelecionada = value;
    }

    private Inteligencias inteligenciasSelecionadas;
    public Inteligencias InteligenciasSelecionadas
    {
        get
        {
            if (inteligenciasSelecionadas == null)
                inteligenciasSelecionadas = Inteligencias.LinguisticaComLogicoMatematica;
            return inteligenciasSelecionadas;
        }

        set => inteligenciasSelecionadas = value;
    }

    private Metodologia metodologiaSelecionada;
    public Metodologia MetodologiaSelecionada
    {
        get
        {
            if (metodologiaSelecionada == null)
                metodologiaSelecionada = Metodologia.ABP;
            return metodologiaSelecionada;
        }

        set => metodologiaSelecionada = value;
    }

    // Array de midias selecionadas pelo jogador na hora do planejamento.
    // Cada metodologia pode precisar de um número diferente de mídias, por
    // isso midiasSelecionadas é um array. O momento aula será responsável por
    // selecionar as x primeiras mídias do array, onde x é o número de mídias
    // que a metodologia escolhida pelo jogador precisa para funcionar bem.
    private Midia[] midiasSelecionadas;
    public Midia[] MidiasSelecionadas
    {
        get
        {
            if (midiasSelecionadas == null)
                midiasSelecionadas = new Midia[]
                {
                    new Midia(NomeDeMidia.Lousa),
                    new Midia(NomeDeMidia.LivroDidatico),
                    new Midia(NomeDeMidia.LivrosJornaisERevistas),
                    new Midia(NomeDeMidia.CadernosECartazes)
                };
            return midiasSelecionadas;
        }

        set => midiasSelecionadas = value;
    }

    // Características da personagem selecionada, observar se estes valores != null
    public Sprite spriteCorpoPersonagem { get; set; }
    public Sprite spriteCabeloPersonagem { get; set; }
    public Sprite spriteRoupaPersonagem { get; set; }
    public Sprite spriteIconePersonagem { get; set; }

    public Sprite spriteCorpoPersonagemSentado { get; set; }
    public Sprite spriteCabeloPersonagemSentado { get; set; }
    public Sprite spriteRoupaPersonagemSentado { get; set; }

    [HideInInspector] public List<FlagDeEstadoDeJogo> flags;  // Não utilizado
}
