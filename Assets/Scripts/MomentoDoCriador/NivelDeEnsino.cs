using System;
using UnityEngine;

[Serializable]
public sealed class NivelDeEnsino
{
    public static readonly NivelDeEnsino EducacaoInfantil = new NivelDeEnsino
    (
        0,
        "Educação Infantil",
        new int[]
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
        1,
        "Ensino Fundamental",
        new int[]
        {
            AreaDeConhecimento.Matematica.valor,
            AreaDeConhecimento.CienciasDaNatureza.valor,
            AreaDeConhecimento.CienciasHumanas.valor,
            AreaDeConhecimento.EnsinoReligioso.valor,
            AreaDeConhecimento.LinguisticaLetrasArtes.valor
        }
    );

    public static readonly NivelDeEnsino EnsinoMedio = new NivelDeEnsino
    (
        2,
        "Ensino Médio",
        new int[]
        {
            AreaDeConhecimento.Matematica.valor,
            AreaDeConhecimento.CienciasDaNatureza.valor,
            AreaDeConhecimento.CienciasHumanas.valor,
            AreaDeConhecimento.LinguisticaLetrasArtes.valor,
        }
    );

    public static readonly NivelDeEnsino EnsinoSuperior = new NivelDeEnsino
    (
        3,
        "Ensino Superior",
        new int[]
        {
            AreaDeConhecimento.CienciasSociaisAplicadas.valor,
            AreaDeConhecimento.CienciasDaSaude.valor,
            AreaDeConhecimento.CienciasBiologicas.valor,
            AreaDeConhecimento.Engenharias.valor,
            AreaDeConhecimento.CienciasExatasDaTerra.valor,
            AreaDeConhecimento.CienciasAgrarias.valor,
            AreaDeConhecimento.CienciasHumanas.valor,
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
    // Quando o jogador seleciona este quando aperta sobre o ícone que
    // representa ele, o ícone salva seu sprite nesta propriedade
    // para que o jogo possa apresentá-la depois em outras cenas
    public Sprite Sprite;

    private NivelDeEnsino(int valor, string nome, int[] areasDeConhecimento)
    {
        this.valor = valor;
        this.nome = nome;
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