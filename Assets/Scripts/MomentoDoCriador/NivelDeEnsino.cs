using System;
using UnityEngine;

[Serializable]
public sealed class NivelDeEnsino
{
    public static readonly NivelDeEnsino EducacaoInfantil = new NivelDeEnsino
    (
        valor: 0,
        nome: "Educação Infantil",
        descricao: "É a primeira etapa da Educação Básica tendo os princípios de educar e cuidar...",
        areasDeConhecimento: new int[]
        {
            AreaDeConhecimento.EuOutroNos.valor,
            AreaDeConhecimento.CorpoGestosMovimentos.valor,
            AreaDeConhecimento.TracosSonsCoresFormas.valor,
            AreaDeConhecimento.EscutaFalaPensamentoImaginacao.valor,
            AreaDeConhecimento.EspacosTemposQuantidadesRelacoesTransformacoes.valor
        }
    );

    public static readonly NivelDeEnsino EnsinoFundamental = new NivelDeEnsino
    (
        valor: 1,
        nome: "Ensino Fundamental",
        descricao: "Etapa obrigatória com duração de 9 anos (dos 6 aos 14 anos), tendo como objetivo a formação básica...",
        areasDeConhecimento: new int[]
        {
            AreaDeConhecimento.Linguagens.valor,
            AreaDeConhecimento.Matematica.valor,
            AreaDeConhecimento.CienciasDaNatureza.valor,
            AreaDeConhecimento.CienciasHumanas.valor,
            AreaDeConhecimento.EnsinoReligioso.valor,
            
        }
    );

    public static readonly NivelDeEnsino EnsinoMedio = new NivelDeEnsino
    (
        valor: 2,
        nome: "Ensino Médio",
        descricao: "Etapa final da Educação Básica tem como finalidades o aprofundamento dos conhecimentos...",
        areasDeConhecimento: new int[]
        {
            AreaDeConhecimento.LinguagensESuasTecnologias.valor,
            AreaDeConhecimento.MatematicaESuasTecnologias.valor,
            AreaDeConhecimento.CienciasDaNaturezaESuasTecnologias.valor,
            AreaDeConhecimento.CienciasHumanasESociaisAplicadas.valor,
        }
    );

    public static readonly NivelDeEnsino EnsinoSuperior = new NivelDeEnsino
    (
        valor: 3,
        nome: "Ensino Superior",
        descricao: "É o nível que busca o desejo de aperfeiçoamento cultural e profissional estimulando o conhecimento...",
        areasDeConhecimento: new int[]
        {
            AreaDeConhecimento.CienciasAgrarias.valor,
            AreaDeConhecimento.CienciasBiologicas.valor,
            AreaDeConhecimento.CienciasExatasDaTerra.valor,
            AreaDeConhecimento.CienciasHumanasSuperior.valor,
            AreaDeConhecimento.CienciasDaSaude.valor,
            AreaDeConhecimento.CienciasSociaisAplicadas.valor,
            AreaDeConhecimento.Engenharias.valor,
            AreaDeConhecimento.LinguisticaLetrasArtes.valor,
        }
    );

    public readonly int valor;
    public readonly string nome;
    private readonly int[] areasDeConhecimento;
    public AreaDeConhecimento[] AreasDeConhecimento
    {
        get
        {
            var length = areasDeConhecimento.Length;
            var returnValues = new AreaDeConhecimento[length];
            for (int i = 0; i < length; i++)
            {
                returnValues[i] = AreaDeConhecimento.Get(areasDeConhecimento[i]);
            }
            return returnValues;
        }
    }
    public readonly string Descricao;
    public readonly string Expansao;
    // Quando o jogador seleciona este quando aperta sobre o ícone que
    // representa ele, o ícone salva seu sprite nesta propriedade
    // para que o jogo possa apresentá-la depois em outras cenas
    public Sprite Sprite;

    private NivelDeEnsino(int valor, string nome, string descricao, int[] areasDeConhecimento)
    {
        this.valor = valor;
        this.nome = nome;
        this.Descricao = descricao;
        this.areasDeConhecimento = areasDeConhecimento;
    }

    public static NivelDeEnsino[] TodosOsNiveisDeEnsino()
    {
        NivelDeEnsino[] todosOsNiveisDeEnsino =
        {
            EducacaoInfantil,
            EnsinoFundamental,
            EnsinoMedio,
            EnsinoSuperior
        };
        return todosOsNiveisDeEnsino;
    }

    public static NivelDeEnsino Get(int valor)
    {
        foreach (var nivelDeEnsino in TodosOsNiveisDeEnsino())
        {
            if (valor == nivelDeEnsino.valor)
                return nivelDeEnsino;
        }
        return null;
    }

    public static NivelDeEnsino Get(string nome)
    {
        foreach (var nivelDeEnsino in TodosOsNiveisDeEnsino())
        {
            if (nome.Equals(nivelDeEnsino.nome))
                return nivelDeEnsino;
        }
        return null;
    }

    public override string ToString()
    {
        return nome;
    }
}