using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public sealed class NivelDeEnsino
{
    private static string educacaoInfantilDescricao;
    private static string educacaoInfantilDescricaoPtBr = "<style=\"title\">Educação Infantil</style>\n\nÉ a primeira etapa da Educação Básica, tendo os princípios" +
                   " de educar e cuidar como indissociáveis. Tem o objetivo de ampliar o universo de experiências, con" +
                   "hecimentos e habilidades de bebês e crianças por meio da parceria com a família. É oferecida em cr" +
                   "eches para crianças de até 3 anos de idade, em pré-escolas para crianças de 4 a 5 anos (sendo esta" +
                   " obrigatória a matrícula). Tem como eixos estruturantes das práticas pedagógicas as interações e a" +
                   " brincadeira, tendo como finalidade o desenvolvimento integral da criança até 5 anos.";
    private static string educacaoInfantilDescricaoEua = "<style=\"title\">Early Childhood Education</style>\n\nIt is the first stage of Basic Education, having the principles" +
                   " to educate and care as inseparable. It aims to expand the universe of experiences, with" +
                   "knowledge and skills of babies and children through partnership with the family. It is offered in cr" +
                   "eches for children up to 3 years of age, in preschools for children aged 4 to 5 years (this being " +
                   "registration is mandatory). The structuring axes of pedagogical practices are interactions and" +
                   "play, aimed at the integral development of the child up to 5 years old.";
    private static string educacaoInfantilDescricaoEspanhol = "<style=\"title\">Educación Infantil</style>\n\nEs la primera etapa de la Educación Básica, teniendo los principios" +
                   "Educar y cuidar como inseparables. Pretende ampliar el universo de experiencias, con" +
                   "conocimientos y habilidades de bebés y niños a través de la colaboración con la familia. Se ofrece en cr" +
                   "eches para niños de hasta 3 años de edad, en preescolar para niños de 4 a 5 años (siendo este " +
                   "la inscripción es obligatoria). Los ejes estructurantes de las prácticas pedagógicas son las interacciones y" +
                   "juego, dirigido al desarrollo integral del niño hasta los 5 años.";

    private static string AtualizarTextosLinguas()
    {
        switch (Textos.GetIdiomaSelecionado())
        {
            case Idiomas.INGLES:
                educacaoInfantilDescricao = educacaoInfantilDescricaoEua;
                break;
            case Idiomas.PORTUGUES:
                educacaoInfantilDescricao = educacaoInfantilDescricaoPtBr;
                break;
            case Idiomas.ESPANHOL:
                educacaoInfantilDescricao = educacaoInfantilDescricaoEspanhol;
                break;
        }
        return educacaoInfantilDescricao;
    }

    public static readonly NivelDeEnsino EducacaoInfantil = new NivelDeEnsino
    (
        valor: 0,
        nome: "Educação Infantil",
        descricao: "<style=\"title\">Educação Infantil</style>\n\nÉ a primeira etapa da Educação Básica, tendo os princípios" +
                   " de educar e cuidar como indissociáveis. Tem o objetivo de ampliar o universo de experiências, con" +
                   "hecimentos e habilidades de bebês e crianças por meio da parceria com a família. É oferecida em cr" +
                   "eches para crianças de até 3 anos de idade, em pré-escolas para crianças de 4 a 5 anos (sendo esta" +
                   " obrigatória a matrícula). Tem como eixos estruturantes das práticas pedagógicas as interações e a" +
                   " brincadeira, tendo como finalidade o desenvolvimento integral da criança até 5 anos.",
        areasDeConhecimento: new int[]
        {
            AreaDeConhecimento.EuOutroNos.valor,
            AreaDeConhecimento.CorpoGestosMovimentos.valor,
            AreaDeConhecimento.TracosSonsCoresFormas.valor,
            AreaDeConhecimento.EscutaFalaPensamentoImaginacao.valor,
            AreaDeConhecimento.EspacosTemposQuantidadesRelacoesTransformacoes.valor
        }
    );

    public static NivelDeEnsino EnsinoFundamental()
    {
        return new NivelDeEnsino(
            valor: 1,
            nome: "Ensino Fundamental",
            descricao: "<style=\"title\">Ensino Fundamental</style>\n\nEtapa obrigatória com duração de 9 anos (dos 6 aos 14 anos), tendo como objetivo a formação básica do cidadão. É dividido em duas fases: Anos Iniciais (1 º ao 5º ano) e Anos Finais (6º ao 9º ano), que inicia-se em torno dos interesses manifestados pelas crianças até desafios de maior complexidade. Sendo importante busca o aprimoramento. da autonomia dos estudantes, desenvolvendo sua capacidade de aprendizagem tendo em vista a aquisição de conhecimentos e habilidades e a formação de atitudes e valores que se fundamentam a sociedade.",
            areasDeConhecimento: new int[]
            { AreaDeConhecimento.Linguagens.valor,
                AreaDeConhecimento.Matematica.valor,
                AreaDeConhecimento.CienciasDaNatureza.valor,
                AreaDeConhecimento.CienciasHumanas.valor,
                AreaDeConhecimento.EnsinoReligioso.valor
            }
            );
    }


    //public static readonly NivelDeEnsino EnsinoFundamental = new NivelDeEnsino
    //(
    //    valor: 1,
    //    nome: "Ensino Fundamental",
    //    descricao: "<style=\"title\">Ensino Fundamental</style>\n\nEtapa obrigatória com duração de 9 anos (dos 6 aos 14 a" +
    //               "nos), tendo como objetivo a formação básica do cidadão. É dividido em duas fases: Anos Iniciais (1" +
    //               "º ao 5º ano) e Anos Finais (6º ao 9º ano), que inicia-se em torno dos interesses manifestados pela" +
    //               "s crianças até desafios de maior complexidade. Sendo importante busca o aprimoramento. da autonom" +
    //               "ia dos estudantes, desenvolvendo sua capacidade de aprendizagem tendo em vista a aquisição de conh" +
    //               "ecimentos e habilidades e a formação de atitudes e valores que se fundamentam a sociedade.",
    //    areasDeConhecimento: new int[]
    //    {
    //        AreaDeConhecimento.Linguagens.valor,
    //        AreaDeConhecimento.Matematica.valor,
    //        AreaDeConhecimento.CienciasDaNatureza.valor,
    //        AreaDeConhecimento.CienciasHumanas.valor,
    //        AreaDeConhecimento.EnsinoReligioso.valor,

    //    }
    //);

    public static readonly NivelDeEnsino EnsinoMedio = new NivelDeEnsino
    (
        valor: 2,
        nome: "Ensino Médio",
        descricao: "<style=\"title\">Ensino Médio</style>\n\nA etapa final da Educação Básica tem como finalidade o aprofu" +
                   "ndamento dos conhecimentos adquiridos anteriormente, a preparação básica para o trabalho e a cidad" +
                   "ania, a formação ética e o aprimoramento do pensamento crítico. Isso se dá através da compreensão " +
                   "dos fundamentos científico-tecnológicos dos processos produtivos, relacionando a teoria com a prát" +
                   "ica através de quatro grandes áreas do conhecimento. Dessa forma produz múltiplas culturas juvenis" +
                   " e  promove uma educação integral.",
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
        descricao: "<style=\"title\">Ensino Superior</style>\n\nÉ o nível que busca o desejo de aperfeiçoamento cultural e" +
                   " profissional, estimulando o conhecimento dos problemas do mundo presente. Busca prestar serviços " +
                   "especializados à comunidade através da pesquisa científica e tecnológica. Busca também o aprimor" +
                   "amento da educação básica mediante a formação e a capacitação de profissionais, por meio de pesqui" +
                   "sas pedagógicas e o desenvolvimento de atividades de extensão, em prol do desenvolvimento da socie" +
                   "dade brasileira.",
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
        switch (Textos.GetIdiomaSelecionado())
        {
            case Idiomas.INGLES:
                educacaoInfantilDescricao = educacaoInfantilDescricaoEua;
                break;
            case Idiomas.PORTUGUES:
                educacaoInfantilDescricao = educacaoInfantilDescricaoPtBr;
                break;
            case Idiomas.ESPANHOL:
                educacaoInfantilDescricao = educacaoInfantilDescricaoEspanhol;
                break;
        }
        NivelDeEnsino[] todosOsNiveisDeEnsino =
        {
            EducacaoInfantil,
            EnsinoFundamental(),
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
