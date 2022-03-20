using System.Collections.Generic;
using UnityEngine;

public class EstadoDoJogo : Singleton<EstadoDoJogo>
{
    // Propriedades definidas pelo criador de um jogo
    private NivelDeEnsino nivelDeEnsino;
    public NivelDeEnsino NivelDeEnsino
    {
        get
        {
            if (nivelDeEnsino == null)
                nivelDeEnsino = NivelDeEnsino.EnsinoSuperior;
            return nivelDeEnsino;
        }

        set => nivelDeEnsino = value;
    }

    private AreaDeConhecimento areaDeConhecimento;
    public AreaDeConhecimento AreaDeConhecimento
    {
        get
        {
            if (areaDeConhecimento == null)
                areaDeConhecimento = AreaDeConhecimento.CienciasHumanas;
            return areaDeConhecimento;
        }

        set => areaDeConhecimento = value;
    }

    private Inteligencias inteligencias;
    public Inteligencias Inteligencias
    {
        get
        {
            if (inteligencias == null)
                inteligencias = Inteligencias.LinguisticaComLogicoMatematica;
            return inteligencias;
        }

        set => inteligencias = value;
    }

    private Metodologia metodologia;
    public Metodologia Metodologia
    {
        get
        {
            if (metodologia == null)
                metodologia = Metodologia.ABP;
            return metodologia;
        }

        set => metodologia = value;
    }

    // Array de midias selecionadas pelo jogador na hora do planejamento.
    // Cada metodologia pode precisar de um número diferente de mídias, por
    // isso midiasSelecionadas é um array. O momento aula será responsável por
    // selecionar as x primeiras mídias do array, onde x é o número de mídias
    // que a metodologia escolhida pelo jogador precisa para funcionar bem.
    private Midia[] midias;
    public Midia[] Midias
    {
        get
        {
            if (midias == null)
                midias = new Midia[]
                {
                    new Midia(NomeDeMidia.LivroDidatico),
                    new Midia(NomeDeMidia.ProjetorMultimidia),
                    new Midia(NomeDeMidia.Lousa),
                    new Midia(NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas)
                };
            return midias;
        }

        set => midias = value;
    }

    // Características da personagem selecionada, observar se estes valores != null
    public Sprite SpriteCorpoPersonagem { get; set; }
    public Sprite SpriteCabeloPersonagem { get; set; }
    public Sprite SpriteRoupaPersonagem { get; set; }
    public Sprite SpriteIconePersonagem { get; set; }

    public Sprite SpriteCorpoPersonagemSentado { get; set; }
    public Sprite SpriteCabeloPersonagemSentado { get; set; }
    public Sprite SpriteRoupaPersonagemSentado { get; set; }

    public int FaseAtual { get; set; }

    // Temas de cada fase
    public string TemaFase1 { get; set; }
    public string TemaFase2 { get; set; }
    public string TemaFase3 { get; set; }

    // Dados de cada fase
    public RegisteredState Fase1 { get; set; }
    public RegisteredState Fase2 { get; set; }
    public RegisteredState Fase3 { get; set; }

    // Esta estrutura é um container para armazenar dados de cada fase. Os dados serão reacessados para a consulta no
    // futuro
    public struct RegisteredState
    {
        public NivelDeEnsino NivelDeEnsino { get; set; }
        public AreaDeConhecimento AreaDeConhecimento { get; set; }
        public Inteligencias Inteligencias { get; set; }
        public Metodologia metodologia { get; set; }
        public Midia[] midias { get; set; }
        public Sprite SpriteIconePersonagem { get; set; }
        public string Tema { get; set; }
    }

    [HideInInspector] public List<FlagDeEstadoDeJogo> flags;  // Não utilizado
}
