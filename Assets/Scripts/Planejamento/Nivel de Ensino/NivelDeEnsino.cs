using System;
using UnityEngine;

[Serializable]
public sealed class NivelDeEnsino
{
    public static readonly NivelDeEnsino EducacaoInfantil = new NivelDeEnsino
    (
        valor: 0,
        nome: "Educação Infantil",
        descricao: "<b>Educação Infantil</b>\n\nÉ a primeira etapa da Educação Básica, tendo os princípios de educar e cuidar como indissociáveis. " +
                   "Tem o objetivo de ampliar o universo de experiências, conhecimentos e habilidades de bebês e crianças por meio da parceria com a " +
                   "família. É oferecida em creches para crianças de até 3 anos de idade, em pré-escolas para crianças de 4 a 5 anos (sendo esta obrigatória " +
                   "a matrícula). Tem como eixos estruturantes das práticas pedagógicas as interações e a brincadeira, tendo como finalidade o desenvolvimento " +
                   "integral da criança até 5 anos.",
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
        descricao: "<b>Ensino Fundamental</b>\n\nEtapa obrigatória com duração de 9 anos (dos 6 aos 14 anos), tendo como objetivo a formação básica do cidadão. " +
                   "É dividido em duas fases: Anos Iniciais (1º ao 5º ano) e Anos Finais (6º ao 9º ano), que inicia-se em torno dos interesses manifestados pelas " +
                   "crianças até desafios de maior complexidade. Sendo importante buscar o fortalecimento da autonomia dos estudantes, desenvolvendo sua capacidade " +
                   "de aprendizagem tendo em vista a aquisição de conhecimentos e habilidades e a formação de atitudes e valores que se fundamentam a sociedade.",
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
        descricao: "<b>Ensino Médio</b>\n\nA etapa final da Educação Básica tem como finalidade o aprofundamento dos conhecimentos adquiridos anteriormente, " +
                   "a preparação básica para o trabalho e a cidadania, a formação ética e o aprimoramento do pensamento crítico. Isso se dá através da compreensão " +
                   "dos fundamentos científico-tecnológicos dos processos produtivos, relacionando a teoria com a prática através de quatro grandes áreas do " +
                   "conhecimento. Dessa forma, produzindo múltiplas culturas juvenis e promovendo uma educação integral.",
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
        descricao: "<b>Ensino Superior</b>\n\nÉ o nível que busca o desejo de aperfeiçoamento cultural e profissional, estimulando o conhecimento dos problemas " +
                   "do mundo presente. Busca prestar serviços especializados à comunidade através da pesquisa científica e tecnológica. Além de buscar o " +
                   "aprimoramento da educação básica mediante a formação e a capacitação de profissionais, por meio de pesquisas pedagógicas e o desenvolvimento " +
                   "de atividades de extensão, em prol do desenvolvimento da sociedade brasileira.",
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
    public readonly string descricao;
    // Quando o jogador seleciona este quando aperta sobre o ícone que
    // representa ele, o ícone salva seu sprite nesta propriedade
    // para que o jogo possa apresentá-la depois em outras cenas
    public Sprite sprite;

    private NivelDeEnsino(int valor, string nome, string descricao, int[] areasDeConhecimento)
    {
        this.valor = valor;
        this.nome = nome;
        this.descricao = descricao;
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
