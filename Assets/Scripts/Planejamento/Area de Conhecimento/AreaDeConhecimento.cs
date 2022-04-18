using System;
using UnityEngine;

[Serializable]
public sealed class AreaDeConhecimento
{
    // Áreas de conhecimento do Ensino Infantil
    public static readonly AreaDeConhecimento EuOutroNos = new AreaDeConhecimento(0, 
        "O eu, o outro e o nós", 
        "<style=\"title\">O Eu, o Outro e o Nós</style>\n\nÉ na interação com os pares e com adultos que as crianças ressi" +
        "gnificam sua aprendizagem, diferenciando-se e identificando-se como seres individuais e sociais valorizando s" +
        "ua identidade, respeitando os outros e reconhecendo suas diferenças que nos constituem como seres humanos.");
    public static readonly AreaDeConhecimento CorpoGestosMovimentos = new AreaDeConhecimento(1, 
        "Corpo, gestos e movimentos", 
        "<style=\"title\">Corpo, Gestos e Movimentos</style>\n\nA exploração do mundo, através do corpo e dos sentidos" +
        ", estabelecendo relações e produzindo conhecimento sobre o universo social e cultural, através de diferentes " +
        "linguagens corporais animadas pelo lúdico e na interação com seus pares para descobrir variados modos de ocup" +
        "ação e uso do espaço com o corpo.");
    public static readonly AreaDeConhecimento TracosSonsCoresFormas = new AreaDeConhecimento(2, 
        "Traços, sons, cores e formas", 
        "<style=\"title\">Traços, Sons, Cores e Formas</style>\n\nAtravés de experiências diversificadas, vivenciar di" +
        "versar formas de expressão e linguagens contribuindo para desenvolver a sensibilidade, o senso estético e crí" +
        "tico, além da criatividade e da expressão pessoal para criarem seu próprio repertório artístico e cultural.");
    public static readonly AreaDeConhecimento EscutaFalaPensamentoImaginacao = new AreaDeConhecimento(3, 
        "Escuta, fala, pensamento e imaginação", 
        "<style=\"title\">Escuta, Fala, Pensamento e Imaginação</style>\n\nPor meio das interações, progressivamente, a" +
        "s crianças vão ampliando a compreensão da linguagem oral e seus meios de comunicação no cotidiano. Assim como" +
        " sua curiosidade sobre a cultura escrita através da literatura infantil, desenvolvendo sua imaginação e ampli" +
        "ando seu conhecimento de mundo.");
    public static readonly AreaDeConhecimento EspacosTemposQuantidadesRelacoesTransformacoes = new AreaDeConhecimento(4, 
        "Espaços, tempos, quantidades, relações e transformações", 
        "<style=\"title\">Espaços, Tempos, Quantidades, Relações e Transformações</style>\n\nAs crianças demonstram cu" +
        "riosidade sobre os espaços e tempos de diferentes dimensões em um mundo constituído de fenômenos naturais e s" +
        "ocioculturais, nos quais, os conhecimentos matemáticos estão também inseridos, fazendo os pequenos, através d" +
        "a exploração do ambiente, entender melhor o seu uso no cotidiano e suas relações e transformações.");

    // Áreas de conhecimento do Ensino Fundamental
    public static readonly AreaDeConhecimento Linguagens = new AreaDeConhecimento(7, 
        "Linguagens", 
        "<style=\"title\">Linguagens</style>\n\nÉ composta pelos seguintes componentes curriculares: Língua Portuguesa" +
        ", Arte, Educação Física e, no Ensino Fundamental – Anos Finais, Língua Inglesa. A finalidade é possibilitar a" +
        "os estudantes participar de práticas de linguagens diversificadas, que lhes permitam ampliar suas capacidades" +
        " expressivas em manifestações artísticas, corporais e linguísticas, como também seus conhecimentos sobre essas linguagens.");
    public static readonly AreaDeConhecimento Matematica = new AreaDeConhecimento(8, 
        "Matemática", 
        "<style=\"title\">Matemática</style>\n\nA Matemática cria sistemas abstratos, que organizam e inter-relacionam" +
        " fenômenos do espaço, do movimento, das formas e dos números, associados ou não a fenômenos do mundo físico. " +
        "Esses sistemas contêm ideias e objetos que são fundamentais para a compreensão de fenômenos, a construção de " +
        "representações significativas e argumentações consistentes nos mais variados contextos.");
    public static readonly AreaDeConhecimento CienciasDaNatureza = new AreaDeConhecimento(9, 
        "Ciências da Natureza", 
        "<style=\"title\">Ciências da Natureza</style>\n\nPor meio de um olhar articulado de diversos campos do saber, " +
        "busca assegurar aos estudantes do Ensino Fundamental o acesso à diversidade de conhecimentos científicos produ" +
        "zidos ao longo da história, bem como a aproximação gradativa aos principais processos, práticas e procedimento" +
        "s da investigação científica através do letramento científico.");
    public static readonly AreaDeConhecimento CienciasHumanas = new AreaDeConhecimento(10, 
        "Ciências Humanas", 
        "<style=\"title\">Ciências Humanas</style>\n\nContribui para que os estudantes desenvolvam a cognição in situ, " +
        "ou seja, sem prescindir da contextualização marcada pelas noções de tempo e espaço, baseando-se na ideia de qu" +
        "e o ser humano produz o espaço em que vive, apropriando-se dele em determinada circunstância histórica, valori" +
        "zando a crítica sistemática à ação humana, às relações sociais e de poder e, especialmente, à produção de conh" +
        "ecimentos e saberes.");
    public static readonly AreaDeConhecimento EnsinoReligioso = new AreaDeConhecimento(12, 
        "Ensino Religioso", 
        "<style=\"title\">Ensino Religioso</style>\n\nO conhecimento religioso busca investigar a manifestação dos fen" +
        "ômenos religiosos em diferentes culturas e sociedades enquanto um dos bens simbólicos resultantes da busca hu" +
        "mana por respostas aos enigmas do mundo, da vida e da morte, de modo singular, complexo e diverso.");

    // Áreas de conhecimento do Ensino Médio
    public static readonly AreaDeConhecimento LinguagensESuasTecnologias = new AreaDeConhecimento(13, 
        "Linguagens e suas Tecnologias", 
        "<style=\"title\">Linguagens e suas Tecnologias</style>\n\nO foco está na ampliação da autonomia, do protagonismo e da auto" +
        "ria nas práticas de diferentes linguagens; na identificação e na crítica aos diferentes usos das linguagens, " +
        "explicitando seu poder no estabelecimento de relações; na apreciação e na participação em diversas manifestaç" +
        "ões artísticas e culturais e no uso criativo das diversas mídias.");
    public static readonly AreaDeConhecimento MatematicaESuasTecnologias = new AreaDeConhecimento(14, 
        "Matemática e suas Tecnologias", 
        "<style=\"title\">Matemática e suas Tecnologias</style>\n\nOs estudantes devem utilizar conceitos, procediment" +
        "os e estratégias não apenas para resolver problemas, mas também para formulá-los, descrever dados, selecionar" +
        " modelos matemáticos e desenvolver o pensamento computacional, por meio da utilização de diferentes recursos da área.");
    public static readonly AreaDeConhecimento CienciasDaNaturezaESuasTecnologias = new AreaDeConhecimento(15, 
        "Ciências da Natureza e suas Tecnologias", 
        "<style=\"title\">Ciências da Natureza e suas Tecnologias</style>\n\nÉ um campo de estudo que utiliza cálculo " +
        "e lógica para gerar predições e medições precisas, com expressões matemáticas e métodos rigorosos. Compreende" +
        " os cursos de matemática, probabilidade, estatística, ciência da computação, astronomia, física, química, geociências e suas subdivisões.");
    public static readonly AreaDeConhecimento CienciasHumanasESociaisAplicadas = new AreaDeConhecimento(16, 
        "Ciências Humanas e Sociais Aplicadas",
        "<style=\"title\">Ciências Humanas e Sociais Aplicadas</style>\n\nAmplia essa base conceitual e, mantendo refe" +
        "rência às principais categorias da área, concentra-se na análise e na avaliação das relações sociais, dos mod" +
        "elos econômicos, dos processos políticos e das diversas culturas.");

    // Áreas de conhecimento do Ensino Superior
    public static readonly AreaDeConhecimento CienciasSociaisAplicadas = new AreaDeConhecimento(17, 
        "Ciências Sociais Aplicadas", 
        "<style=\"title\">Ciências Sociais Aplicadas</style>\n\nA área de Ciências Sociais Aplicadas reúne campos de conhecimen" +
        "to interdisciplinares, voltados para os aspectos sociais das diversas realidades humanas.");
    public static readonly AreaDeConhecimento CienciasDaSaude = new AreaDeConhecimento(22, 
        "Ciências da Saúde", 
        "<style=\"title\">Ciências da Saúde</style>\n\nAs ciências da saúde são as áreas de estudo relacionadas com a " +
        "vida, a saúde e a doença. É importante saber lidar com as pessoas, ter a capacidade de ser meticuloso e prest" +
        "ar atenção em detalhes, devido ao contato intenso e direto com pacientes. ");
    public static readonly AreaDeConhecimento CienciasBiologicas = new AreaDeConhecimento(20, 
        "Ciências Biológicas", 
        "<style=\"title\">Ciências Biológicas</style>\n\nAs Ciências Biológicas têm por missão estudar tudo o que diz " +
        "respeito aos seres vivos e sua relação com o meio ambiente. Demanda muita experimentação e pesquisa, além de " +
        "grande habilidade de foco e afinidade com animais e pessoas.");
    public static readonly AreaDeConhecimento Engenharias = new AreaDeConhecimento(21, 
        "Engenharias", 
        "<style=\"title\">Engenharias</style>\n\nAs Engenharias tratam de inventar soluções criativas e práticas que e" +
        "xigem conhecimento e habilidade visando a melhoria na qualidade de vida, não só da nossa sociedade atual, como das próximas gerações.");
    public static readonly AreaDeConhecimento CienciasExatasDaTerra = new AreaDeConhecimento(19, 
        "Ciências Exatas e da Terra", 
        "<style=\"title\">Ciências Exatas e da Terra</style>\n\nÉ um campo de estudo que utiliza cálculo e lógica para" +
        " gerar predições e medições precisas, com expressões matemáticas e métodos rigorosos. Compreende os cursos de" +
        " matemática, probabilidade, estatística, ciência da computação, astronomia, física, química, geociências e suas subdivisões.");
    public static readonly AreaDeConhecimento CienciasHumanasSuperior = new AreaDeConhecimento(18, 
        "Ciências Humanas", 
        "<style=\"title\">Ciências Humanas</style>\n\nEmbora do ponto de vista técnico todo e qualquer conhecimento pr" +
        "oduzido pela humanidade seja uma “ciência humana”, a expressão Ciências Humanas em si refere-se somente àquel" +
        "as ciências que têm o ser humano como seu objeto de estudo ou foco. Em outras palavras, consistem nas profiss" +
        "ões e carreiras que tratam primariamente dos aspectos humanos.");
    public static readonly AreaDeConhecimento CienciasAgrarias = new AreaDeConhecimento(23, 
        "Ciências Agrárias", 
        "<style=\"title\">Ciências Agrárias</style>\n\nA área de Ciências Agrárias trata dos aspectos de exploração da" +
        " terra, de criação de animais e de cultivo de vegetais. Suas atividades possuem o objetivo de aumentar a prod" +
        "ução, aprimorar as tecnologias de manejo e preservação dos recursos naturais.");
    public static readonly AreaDeConhecimento LinguisticaLetrasArtes = new AreaDeConhecimento(24, 
        "Linguística, Letras e Artes", 
        "<style=\"title\">Linguística, Letras e Artes</style>\n\nOs cursos de Linguística e Letras preparam o estudant" +
        "e para viabilizar e facilitar a comunicação entre os seres humanos, e o campo das Artes é voltado para aquele" +
        "s que têm na expressão artística e cultural sua maior inspiração.");

    public readonly int valor;
    public readonly string nome;
    public readonly string descricao;
    // Quando o jogador seleciona este quando aperta sobre o ícone que
    // representa ele, o ícone salva seu sprite nesta propriedade
    // para que o jogo possa apresentá-la depois em outras cenas
    public Sprite sprite;


    private AreaDeConhecimento(int valor, string nome, string descricao)
    {
        this.valor = valor;
        this.nome = nome;
        this.descricao = descricao;
    }

    public static AreaDeConhecimento[] TodasAsAreasDeConhecimento()
    {
        AreaDeConhecimento[] areas =
        {
            EuOutroNos,
            CorpoGestosMovimentos,
            TracosSonsCoresFormas,
            EscutaFalaPensamentoImaginacao,
            EspacosTemposQuantidadesRelacoesTransformacoes,

            Linguagens,
            Matematica,
            CienciasDaNatureza,
            CienciasHumanas,
            EnsinoReligioso,

            LinguagensESuasTecnologias,
            MatematicaESuasTecnologias,
            CienciasDaNaturezaESuasTecnologias,
            CienciasHumanasESociaisAplicadas,

            CienciasSociaisAplicadas,
            CienciasDaSaude,
            CienciasBiologicas,
            Engenharias,
            CienciasExatasDaTerra,
            CienciasHumanasSuperior,
            CienciasAgrarias,
            LinguisticaLetrasArtes,
        };
        return areas;
    }

    public static AreaDeConhecimento Get(int valor)
    {
        foreach (var area in TodasAsAreasDeConhecimento())
        {
            if (valor == area.valor)
                return area;
        }
        return null;
    }

    public static AreaDeConhecimento Get(string nome)
    {
        foreach (var area in TodasAsAreasDeConhecimento())
        {
            if (nome.Equals(area.nome))
                return area;
        }
        return null;
    }

    public override string ToString()
    {
        return nome;
    }
}