using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EstadoDoJogo : Singleton<EstadoDoJogo>
{
    // Propriedades definidas pelo criador de um jogo
    private NivelDeEnsino nivelDeEnsino;

    public float score;
    public bool pVez;

    public void AtualizarScore(float s)
    {
        score +=s;
        Debug.Log("att score" + score);
    }
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
                    new Midia(NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas),
                      new Midia(NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas),
                        new Midia(NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas)
                };
            return midias;
        }

        set => midias = value;
    }

    private string tema;
    public string Tema
    {
        get
        {
            if (tema == null)
                tema = "";
            return tema;
        }

        set => tema = value;
    }

    private LocationChecker.Location lugar;
    public LocationChecker.Location Lugar { get; set; }

    // Características da personagem selecionada, observar se estes valores != null
    public Sprite SpriteCorpoPersonagem { get; set; }
    public Sprite SpriteCabeloPersonagem { get; set; }
    public Sprite SpriteRoupaPersonagem { get; set; }
    public Sprite SpriteIconePersonagem { get; set; }

    public Sprite SpriteCorpoPersonagemSentado { get; set; }
    public Sprite SpriteCabeloPersonagemSentado { get; set; }
    public Sprite SpriteRoupaPersonagemSentado { get; set; }

    public int FaseAtual { get; set; }

    // Dados de cada fase
    public RegisteredState[] RegisteredStates;

    // Esta estrutura é um container para armazenar dados de cada fase. Os dados serão reacessados para a consulta no
    // futuro
    public struct RegisteredState
    {
        public NivelDeEnsino NivelDeEnsino { get; set; }
        public AreaDeConhecimento AreaDeConhecimento { get; set; }
        public Inteligencias Inteligencias { get; set; }
        public Metodologia Metodologia { get; set; }
        public Midia[] Midias { get; set; }
        public Sprite SpriteIconePersonagem { get; set; }
        public string Tema { get; set; }
    }

    public void SaveState()
    {
        if (RegisteredStates == null)
            RegisteredStates = new RegisteredState[3];

        RegisteredStates[FaseAtual].NivelDeEnsino = nivelDeEnsino;
        RegisteredStates[FaseAtual].AreaDeConhecimento = areaDeConhecimento;
        RegisteredStates[FaseAtual].Inteligencias = inteligencias;
        RegisteredStates[FaseAtual].Metodologia = metodologia;
        RegisteredStates[FaseAtual].Midias = midias;
        RegisteredStates[FaseAtual].SpriteIconePersonagem = SpriteIconePersonagem;
        RegisteredStates[FaseAtual].Tema = tema;
    }

    public void AdvanceLevel()
    {
        FaseAtual++;
        midias = null;
        Tema = "";
    }

    // TODO: Adicionar o reset geral no final dos créditos
    public void Reset()
    {
        NivelDeEnsino = null;
        AreaDeConhecimento = null;
        Inteligencias = null;
        Metodologia = null;
        Midias = null;
        Tema = null;
        FaseAtual = 0;
        RegisteredStates = null;
    }

    [HideInInspector] public List<FlagDeEstadoDeJogo> flags;  // Não utilizado
}
