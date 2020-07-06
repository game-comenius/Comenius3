using System;
using UnityEngine;

[Serializable]
public sealed class NivelDeEnsino
{
    public static readonly NivelDeEnsino EducacaoInfantil = new NivelDeEnsino
    (
        valor: 0,
        nome: "Educação Infantil",
        descricao: "É a primeira etapa da Educação Básica tendo os princípios de educar e cuidar como indissociáveis buscando o objetivo de ampliar o universo de experiências, conhecimentos e habilidades de bebês e crianças através da parceria com a família. É oferecida em creches para crianças de até 3 anos de idade em pré-escolas para crianças de 4 a 5 anos (sendo esta obrigatória a matrícula). Tem como eixos estruturantes das práticas pedagógicas as interações e a brincadeira por meio de intencionalidade educativa e a garantia de seis direitos de aprendizagem e desenvolvimento que permeiam cinco campos de experiências tendo como finalidade o desenvolvimento integral da criança até 5 anos.",
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
        descricao: "Etapa obrigatória com duração de 9 anos (dos 6 aos 14 anos), tendo como objetivo a formação básica do cidadão. É dividido em duas fases: Anos Iniciais (1º ao 5º ano) e Anos Finais (6º ao 9º ano), que inicia-se em torno dos interesses manifestados pelas crianças até desafios de maior complexidade. Sendo importante buscar o fortalecimento da autonomia dos estudantes nesse nível de ensino, desenvolvendo sua capacidade de aprendizagem tendo em vista a aquisição de conhecimentos e habilidades e a formação de atitudes e valores que se fundamentam a sociedade.",
        areasDeConhecimento: new int[]
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
        valor: 2,
        nome: "Ensino Médio",
        descricao: "Etapa final da Educação Básica tem como finalidades o aprofundamento dos conhecimentos adquiridos anteriormente, a preparação básica para o trabalho e a cidadania, a formação ética e o aprimoramento do pensamento crítico através da compreensão dos fundamentos científico-tecnológicos dos processos produtivos, relacionando a teoria com a prática através de 4 grandes áreas do conhecimento produzindo múltiplas culturas juvenis promovendo uma educação integral no que concerne os aspectos físicos, cognitivos e socioemocionais.",
        areasDeConhecimento: new int[]
        {
            AreaDeConhecimento.Matematica.valor,
            AreaDeConhecimento.CienciasDaNatureza.valor,
            AreaDeConhecimento.CienciasHumanas.valor,
            AreaDeConhecimento.LinguisticaLetrasArtes.valor,
        }
    );

    public static readonly NivelDeEnsino EnsinoSuperior = new NivelDeEnsino
    (
        valor: 3,
        nome: "Ensino Superior",
        descricao: "É o nível que busca o desejo de aperfeiçoamento cultural e profissional estimulando o conhecimento dos problemas do mundo presente, buscando prestar serviços especializados à comunidade através da pesquisa científica e tecnológica. Além de buscar o aprimoramento da educação básica mediante a formação e a capacitação de profissionais através de pesquisas pedagógicas e o desenvolvimento de atividades de extensão em prol do desenvolvimento da sociedade brasileira.",
        areasDeConhecimento: new int[]
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
    public readonly string Descricao;
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