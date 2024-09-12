using System;
using UnityEngine;

[Serializable]
public sealed class AreaDeConhecimento
{
    // Áreas de conhecimento do Ensino Infantil
    #region aREASDOCONHECIMENTO
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

    #endregion
    #region Ptbr
    private static string EuOutroNosPtbr =
        "<style=\"title\">O Eu, o Outro e o Nós</style>\n\nÉ na interação com os pares e com adultos que as crianças ressi" +
        "gnificam sua aprendizagem, diferenciando-se e identificando-se como seres individuais e sociais valorizando s" +
        "ua identidade, respeitando os outros e reconhecendo suas diferenças que nos constituem como seres humanos.";

    private static string CorpoGestosMovimentosPtbr =
        "<style=\"title\">Corpo, Gestos e Movimentos</style>\n\nA exploração do mundo, através do corpo e dos sentidos" +
        ", estabelecendo relações e produzindo conhecimento sobre o universo social e cultural, através de diferentes " +
        "linguagens corporais animadas pelo lúdico e na interação com seus pares para descobrir variados modos de ocup" +
        "ação e uso do espaço com o corpo.";

    private static string TracosSonsCoresFormasPtbr =
        "<style=\"title\">Traços, Sons, Cores e Formas</style>\n\nAtravés de experiências diversificadas, vivenciar di" +
        "versar formas de expressão e linguagens contribuindo para desenvolver a sensibilidade, o senso estético e crí" +
        "tico, além da criatividade e da expressão pessoal para criarem seu próprio repertório artístico e cultural.";

    private static string EscutaFalaPensamentoImaginacaPtbr =
        "<style=\"title\">Escuta, Fala, Pensamento e Imaginação</style>\n\nPor meio das interações, progressivamente, a" +
        "s crianças vão ampliando a compreensão da linguagem oral e seus meios de comunicação no cotidiano. Assim como" +
        " sua curiosidade sobre a cultura escrita através da literatura infantil, desenvolvendo sua imaginação e ampli" +
        "ando seu conhecimento de mundo.";

    private static string EspacosTemposQuantidadesRelacoesTransformacoesPtbr =
        "<style=\"title\">Espaços, Tempos, Quantidades, Relações e Transformações</style>\n\nAs crianças demonstram cu" +
        "riosidade sobre os espaços e tempos de diferentes dimensões em um mundo constituído de fenômenos naturais e s" +
        "ocioculturais, nos quais, os conhecimentos matemáticos estão também inseridos, fazendo os pequenos, através d" +
        "a exploração do ambiente, entender melhor o seu uso no cotidiano e suas relações e transformações.";


    private static string LinguagensPtbr =
        "<style=\"title\">Linguagens</style>\n\nÉ composta pelos seguintes componentes curriculares: Língua Portuguesa" +
        ", Arte, Educação Física e, no Ensino Fundamental – Anos Finais, Língua Inglesa. A finalidade é possibilitar a" +
        "os estudantes participar de práticas de linguagens diversificadas, que lhes permitam ampliar suas capacidades" +
        " expressivas em manifestações artísticas, corporais e linguísticas, como também seus conhecimentos sobre essas linguagens.";

    private static string MatematicaPtbr =
        "<style=\"title\">Matemática</style>\n\nA Matemática cria sistemas abstratos, que organizam e inter-relacionam" +
        " fenômenos do espaço, do movimento, das formas e dos números, associados ou não a fenômenos do mundo físico. " +
        "Esses sistemas contêm ideias e objetos que são fundamentais para a compreensão de fenômenos, a construção de " +
        "representações significativas e argumentações consistentes nos mais variados contextos.";

    private static string CienciasDaNaturezaPtbr =
        "<style=\"title\">Ciências da Natureza</style>\n\nPor meio de um olhar articulado de diversos campos do saber, " +
        "busca assegurar aos estudantes do Ensino Fundamental o acesso à diversidade de conhecimentos científicos produ" +
        "zidos ao longo da história, bem como a aproximação gradativa aos principais processos, práticas e procedimento" +
        "s da investigação científica através do letramento científico.";


    private static string CienciasHumanasPtbr =
        "<style=\"title\">Ciências Humanas</style>\n\nContribui para que os estudantes desenvolvam a cognição in situ, " +
        "ou seja, sem prescindir da contextualização marcada pelas noções de tempo e espaço, baseando-se na ideia de qu" +
        "e o ser humano produz o espaço em que vive, apropriando-se dele em determinada circunstância histórica, valori" +
        "zando a crítica sistemática à ação humana, às relações sociais e de poder e, especialmente, à produção de conh" +
        "ecimentos e saberes.";

    private static string EnsinoReligiosoPtbr =
        "<style=\"title\">Ensino Religioso</style>\n\nO conhecimento religioso busca investigar a manifestação dos fen" +
        "ômenos religiosos em diferentes culturas e sociedades enquanto um dos bens simbólicos resultantes da busca hu" +
        "mana por respostas aos enigmas do mundo, da vida e da morte, de modo singular, complexo e diverso.";

    private static string LinguagensESuasTecnologiasoPtbr =
        "<style=\"title\">Linguagens e suas Tecnologias</style>\n\nO foco está na ampliação da autonomia, do protagonismo e da auto" +
        "ria nas práticas de diferentes linguagens; na identificação e na crítica aos diferentes usos das linguagens, " +
        "explicitando seu poder no estabelecimento de relações; na apreciação e na participação em diversas manifestaç" +
        "ões artísticas e culturais e no uso criativo das diversas mídias.";

    private static string MatematicaESuasTecnologiasPtbr =
        "<style=\"title\">Matemática e suas Tecnologias</style>\n\nOs estudantes devem utilizar conceitos, procediment" +
        "os e estratégias não apenas para resolver problemas, mas também para formulá-los, descrever dados, selecionar" +
        " modelos matemáticos e desenvolver o pensamento computacional, por meio da utilização de diferentes recursos da área.";

    private static string CienciasDaNaturezaESuasTecnologiasPtbr =
        "<style=\"title\">Ciências da Natureza e suas Tecnologias</style>\n\nÉ um campo de estudo que utiliza cálculo " +
        "e lógica para gerar predições e medições precisas, com expressões matemáticas e métodos rigorosos. Compreende" +
        " os cursos de matemática, probabilidade, estatística, ciência da computação, astronomia, física, química, geociências e suas subdivisões.";

    private static string CienciasHumanasESociaisAplicadasPtbr =
        "<style=\"title\">Ciências Humanas e Sociais Aplicadas</style>\n\nAmplia essa base conceitual e, mantendo refe" +
        "rência às principais categorias da área, concentra-se na análise e na avaliação das relações sociais, dos mod" +
        "elos econômicos, dos processos políticos e das diversas culturas.";

    private static string CienciasSociaisAplicadasPtbr =
        "<style=\"title\">Ciências Sociais Aplicadas</style>\n\nA área de Ciências Sociais Aplicadas reúne campos de conhecimen" +
        "to interdisciplinares, voltados para os aspectos sociais das diversas realidades humanas.";

    private static string CienciasDaSaudePtbr =
        "<style=\"title\">Ciências da Saúde</style>\n\nAs ciências da saúde são as áreas de estudo relacionadas com a " +
        "vida, a saúde e a doença. É importante saber lidar com as pessoas, ter a capacidade de ser meticuloso e prest" +
        "ar atenção em detalhes, devido ao contato intenso e direto com pacientes. ";

    private static string CienciasBiologicasPtbr =
        "<style=\"title\">Ciências Biológicas</style>\n\nAs Ciências Biológicas têm por missão estudar tudo o que diz " +
        "respeito aos seres vivos e sua relação com o meio ambiente. Demanda muita experimentação e pesquisa, além de " +
        "grande habilidade de foco e afinidade com animais e pessoas.";

    private static string EngenhariasPtbr =
        "<style=\"title\">Engenharias</style>\n\nAs Engenharias tratam de inventar soluções criativas e práticas que e" +
        "xigem conhecimento e habilidade visando a melhoria na qualidade de vida, não só da nossa sociedade atual, como das próximas gerações.";

    private static string CienciasExatasDaTerraPtbr =
        "<style=\"title\">Ciências Exatas e da Terra</style>\n\nÉ um campo de estudo que utiliza cálculo e lógica para" +
        " gerar predições e medições precisas, com expressões matemáticas e métodos rigorosos. Compreende os cursos de" +
        " matemática, probabilidade, estatística, ciência da computação, astronomia, física, química, geociências e suas subdivisões.";

    private static string CienciasHumanasSuperiorPtbr =
        "<style=\"title\">Ciências Humanas</style>\n\nEmbora do ponto de vista técnico todo e qualquer conhecimento pr" +
        "oduzido pela humanidade seja uma “ciência humana”, a expressão Ciências Humanas em si refere-se somente àquel" +
        "as ciências que têm o ser humano como seu objeto de estudo ou foco. Em outras palavras, consistem nas profiss" +
        "ões e carreiras que tratam primariamente dos aspectos humanos.";

    private static string CienciasAgrariasPtbr =
        "<style=\"title\">Ciências Agrárias</style>\n\nA área de Ciências Agrárias trata dos aspectos de exploração da" +
        " terra, de criação de animais e de cultivo de vegetais. Suas atividades possuem o objetivo de aumentar a prod" +
        "ução, aprimorar as tecnologias de manejo e preservação dos recursos naturais.";

    private static string LinguisticaLetrasArtesPtbr =
        "<style=\"title\">Linguística, Letras e Artes</style>\n\nOs cursos de Linguística e Letras preparam o estudant" +
        "e para viabilizar e facilitar a comunicação entre os seres humanos, e o campo das Artes é voltado para aquele" +
        "s que têm na expressão artística e cultural sua maior inspiração.";

    #endregion
    #region Eua
    private static string EuOutroNosEua =
    "<style=\"title\">The Self, the Other and We</style>\n\nIt is through interaction with peers and adults that children thrive " +
    "enhance their learning, differentiating themselves and identifying themselves as individual and social beings, valuing themselves " +
    "your identity, respecting others and recognizing their differences that constitute us as human beings.";

    private static string CorpoGestosMovimentosEua =
      "<style=\"title\">Body, Gestures and Movements</style>\n\nExploring the world, through the body and senses" +
      ", establishing relationships and producing knowledge about the social and cultural universe, through different " +
      "body languages ​​animated by play and interaction with peers to discover different ways of occupation" +
      "action and use of space with the body.";

    private static string TracosSonsCoresFormasEua =
        "<style=\"title\">Traces, Sounds, Colors and Shapes</style>\n\nThrough diverse experiences, experience" +
        "Discover forms of expression and languages, contributing to developing sensitivity, aesthetic and creative sensetico," +
        "in addition to creativity and personal expression to create their own artistic and cultural repertoire.";

    private static string EscutaFalaPensamentoImaginacaEua =
        "<style=\"title\">Listening, Speaking, Thinking and Imagination</style>\n\nThrough interactions, progressively," +
        "Children expand their understanding of oral language and its means of communication in everyday life. Just like " +
        "your curiosity about culture written through children's literature, developing your imagination and broadening" +
        "I walk your knowledge of the world.";

    private static string EspacosTemposQuantidadesRelacoesTransformacoesEua =
        "<style=\"title\">Spaces, Times, Quantities, Relations and Transformations</style>\n\nChildren demonstrate" +
        "curiosity about spaces and times of different dimensions in a world made up of natural phenomena and s" +
        "ociocultural, in which mathematical knowledge is also inserted, making the little ones, through " +
        "the exploration of the environment, better understanding its use in everyday life and its relationships and transformations.";


    private static string LinguagensEua =
      "<style=\"title\">Languages</style>\n\nIt consists of the following curricular components: Portuguese Language" +
      ", Art, Physical Education and, in Elementary School – Final Years, English Language. The purpose is to enable" +
      "students participate in diverse language practices, which allow them to expand their capabilities" +
      "expressive in artistic, bodily and linguistic manifestations, as well as their knowledge of these languages.";

    private static string MatematicaEua =
        "<style=\"title\">Mathematics</style>\n\nMathematics creates abstract systems, which organize and interrelate" +
        "phenomena of space, movement, shapes and numbers, whether or not associated with phenomena in the physical world." +
        "These systems contain ideas and objects that are fundamental to the understanding of phenomena, the construction of " +
        "meaningful representations and consistent arguments in the most varied contexts.";

    private static string CienciasDaNaturezaEua =
    "<style=\"title\">Natural Sciences</style>\n\nThrough an articulated look at different fields of knowledge, " +
    "seeks to ensure that elementary school students have access to the diversity of scientific knowledge produced" +
    "done throughout history, as well as the gradual approach to the main processes, practices and procedures" +
    "s of scientific inquiry through scientific literacy.";


    private static string CienciasHumanasEua =
        "<style=\"title\">Human Sciences</style>\n\nContributes to students developing cognition in situ, " +
        "that is, without giving up the contextualization marked by the notions of time and space, based on the idea that" +
        "and human beings produce the space in which they live, appropriating it in a given historical circumstance, value it" +
        "using systematic criticism of human action, social and power relations and, especially, the production of knowledge" +
        "cements and knowledge.";

    private static string EnsinoReligiosoEua =
        "<style=\"title\">Religious Education</style>\n\nReligious knowledge seeks to investigate the manifestation of fen" +
        "religious omens in different cultures and societies as one of the symbolic goods resulting from the search for hu" +
        "flows for answers to the enigmas of the world, of life and death, in a unique, complex and diverse way.";

    private static string LinguagensESuasTecnologiasoEua =
        "<style=\"title\">Languages ​​and their Technologies</style>\n\nThe focus is on expanding autonomy, protagonism and self" +
        "laugh in the practices of different languages; in identifying and criticizing the different uses of languages, " +
        "explaining its power in establishing relationships; in appreciating and participating in various manifestations" +
        "artistic and cultural actions and the creative use of various media.";

    private static string MatematicaESuasTecnologiasEua =
        "<style=\"title\">Mathematics and its Technologies</style>\n\nStudents must use concepts, procedures" +
        "the and strategies not only to solve problems, but also to formulate them, describe data, select" +
        "mathematical models and develop computational thinking, through the use of different resources in the area.";

    private static string CienciasDaNaturezaESuasTecnologiasEua =
        "<style=\"title\">Natural Sciences and their Technologies</style>\n\nIt is a field of study that uses calculus " +
        "and logic to generate accurate predictions and measurements, with mathematical expressions and rigorous methods. Understands" +
        "courses in mathematics, probability, statistics, computer science, astronomy, physics, chemistry, geosciences and their subdivisions.";

    private static string CienciasHumanasESociaisAplicadasEua =
        "<style=\"title\">Applied Human and Social Sciences</style>\n\nExtends this conceptual base and, while maintaining freshness" +
        "reference to the main categories of the area, focuses on the analysis and evaluation of social relations, modality" +
        "economic links, political processes and diverse cultures.";

    private static string CienciasSociaisAplicadasEua =
        "<style=\"title\">Applied Social Sciences</style>\n\nThe area of ​​Applied Social Sciences brings together fields of knowledge" +
        "to be interdisciplinary, focused on the social aspects of diverse human realities.";

    private static string CienciasDaSaudeEua =
        "<style=\"title\">Health Sciences</style>\n\nHealth sciences are the areas of study related to " +
        "life, health and illness. It is important to know how to deal with people, to have the ability to be meticulous and helpful" +
        "Pay attention to detail, due to intense and direct contact with patients.";

    private static string CienciasBiologicasEua =
        "<style=\"title\">Biological Sciences</style>\n\nBiological Sciences' mission is to study everything that says " +
        "respect for living beings and their relationship with the environment. It demands a lot of experimentation and research, in addition to " +
        "great ability to focus and affinity with animals and people.";

    private static string EngenhariasEua =
        "<style=\"title\">Engineering</style>\n\nEngineering is about inventing creative and practical solutions that are" +
        "they require knowledge and skill aimed at improving the quality of life, not only for our current society, but for future generations.";

    private static string CienciasExatasDaTerraEua =
        "<style=\"title\">Exact and Earth Sciences</style>\n\nIt is a field of study that uses calculation and logic to" +
        "generate accurate predictions and measurements, with mathematical expressions and rigorous methods. Includes the courses" +
        "mathematics, probability, statistics, computer science, astronomy, physics, chemistry, geosciences and their subdivisions.";

    private static string CienciasHumanasSuperiorEua =
        "<style=\"title\">Human Sciences</style>\n\nAlthough from a technical point of view any and all practical knowledge" +
        "produced by humanity is a “human science”, the expression Human Sciences itself refers only to that" +
        "the sciences that have the human being as their object of study or focus. In other words, they consist of the professions" +
        "ons and careers that deal primarily with human aspects.";

    private static string CienciasAgrariasEua =
       "<style=\"title\">Agrarian Sciences</style>\n\nThe area of ​​Agricultural Sciences deals with the exploration aspects of" +
       "land, animal husbandry and vegetable cultivation. Their activities aim to increase production" +
       "uction, improve technologies for managing and preserving natural resources.";

    private static string LinguisticaLetrasArtesEua =
        "<style=\"title\">Linguistics, Literature and Arts</style>\n\nLinguistics and Literature courses prepare the student" +
        "and to enable and facilitate communication between human beings, and the field of Arts is aimed at that" +
        "s that find artistic and cultural expression their greatest inspiration.";
    #endregion
    #region ESP
    private static string EuOutroNosEspanhol =
"<style=\"title\">El yo, el otro y nosotros</style>\n\nEs a través de la interacción con compañeros y adultos que los niños prosperan" +
"potenciar su aprendizaje, diferenciándose e identificándose como seres individuales y sociales, valorándose" +
"tu identidad, respetando a los demás y reconociendo sus diferencias que nos constituyen como seres humanos.";

    private static string CorpoGestosMovimentosEspanhol =
      "<style=\"title\">Cuerpo, Gestos y Movimientos</style>\n\nExplorando el mundo, a través del cuerpo y los sentidos" +
      ", estableciendo relaciones y produciendo conocimiento sobre el universo social y cultural, a través de diferentes " +
      "lenguajes corporales animados por el juego y la interacción con pares para descubrir diferentes formas de ocupación" +
      "acción y uso del espacio con el cuerpo";

    private static string TracosSonsCoresFormasEspanhol =
        "<style=\"title\">Huellas, Sonidos, Colores y Formas</style>\n\nA través de diversas experiencias, experimenta di" +
        "Descubrir formas de expresión y lenguajes, contribuyendo a desarrollar la sensibilidad, el sentido estético y creativo" +
        "tico, además de la creatividad y expresión personal para crear su propio repertorio artístico y cultural";

    private static string EscutaFalaPensamentoImaginacaEspanhol =
        "<style=\"title\">Escuchar, Hablar, Pensar e Imaginar</style>\n\nA través de interacciones, progresivamente," +
        "Los niños amplían su comprensión del lenguaje oral y sus medios de comunicación en la vida cotidiana. Al igual que" +
        "tu curiosidad por la cultura escrita a través de la literatura infantil, desarrollando y ampliando tu imaginación" +
        "Camino tu conocimiento del mundo";

    private static string EspacosTemposQuantidadesRelacoesTransformacoesEspanhol =
        "<style=\"title\">Espacios, Tiempos, Cantidades, Relaciones y Transformaciones</style>\n\nLos niños demuestran el culo" +
        "riosidad sobre espacios y tiempos de diferentes dimensiones en un mundo formado por fenómenos naturales ys" +
        "ociocultural, en el que también se inserta el conocimiento matemático, haciendo que los más pequeños, a través de" +
        "la exploración del medio ambiente, comprendiendo mejor su uso en la vida cotidiana y sus relaciones y transformaciones";


    private static string LinguagensEspanhol =
      "<style=\"title\">Idiomas</style>\n\nConsta de los siguientes componentes curriculares: Idioma Portugués" +
      ", Arte, Educación Física y, en Educación Primaria – Últimos Años, Idioma Inglés. El propósito es posibilitar" +
      "los estudiantes participan en diversas prácticas lingüísticas, que les permiten ampliar sus capacidades" +
      "expresivo en manifestaciones artísticas, corporales y lingüísticas, así como su conocimiento de estas lenguas.";

    private static string MatematicaEspanhol =
        "<style=\"title\">Matemáticas</style>\n\nLas matemáticas crean sistemas abstractos, que organizan e interrelacionan" +
        "fenómenos de espacio, movimiento, formas y números, asociados o no con fenómenos del mundo físico"+
        "Estos sistemas contienen ideas y objetos que son fundamentales para la comprensión de los fenómenos, la construcción de " +
        "representaciones significativas y argumentos consistentes en los más variados contextos.";

    private static string CienciasDaNaturezaEspanhol =
    "<style=\"title\">Ciencias Naturales</style>\n\nA través de una mirada articulada a diferentes campos del conocimiento, " +
    "busca garantizar que los estudiantes de primaria tengan acceso a la diversidad del conocimiento científico producido" +
    "realizado a lo largo de la historia, así como el acercamiento paulatino a los principales procesos, prácticas y procedimientos" +
    "s de investigación científica a través de la alfabetización científica.";


    private static string CienciasHumanasEspanhol =
        "<style=\"title\">Ciencias Humanas</style>\n\nContribuye a que los estudiantes desarrollen la cognición in situ, " +
        "es decir, sin renunciar a la contextualización marcada por las nociones de tiempo y espacio, partiendo de la idea de que" +
        "y el ser humano produce el espacio en el que vive, apropiándose de él en una determinada circunstancia histórica, valorándolo" +
        "utilizando la crítica sistemática de la acción humana, las relaciones sociales y de poder y, especialmente, la producción de conocimiento" +
        "cementos y conocimiento";

    private static string EnsinoReligiosoEspanhol =
        "<style=\"title\">Educación Religiosa</style>\n\nEl conocimiento religioso busca investigar la manifestación del fen" +
        "presagios religiosos en diferentes culturas y sociedades como uno de los bienes simbólicos resultantes de la búsqueda de hu" +
        "fluye en busca de respuestas a los enigmas del mundo, de la vida y de la muerte, de una manera única, compleja y diversa.";

    private static string LinguagensESuasTecnologiasoEspanhol =
        "<style=\"title\">Lenguajes y sus Tecnologías</style>\n\nLa atención se centra en ampliar la autonomía, el protagonismo y el yo" +
        "reír en las prácticas de diferentes idiomas; en identificar y criticar los diferentes usos de los idiomas"+
        "explicando su poder para establecer relaciones; para apreciar y participar en diversas manifestaciones" +
        "acciones artísticas y culturales y el uso creativo de diversos medios";

    private static string MatematicaESuasTecnologiasEspanhol =
        "<style=\"title\">Matemáticas y sus Tecnologías</style>\n\nLos estudiantes deben utilizar conceptos, procedimientos" +
        "las estrategias y no solo para resolver problemas, sino también para formularlos, describir datos, seleccionar" +
        "modelos matemáticos y desarrollar el pensamiento computacional, mediante el uso de diferentes recursos del área";

    private static string CienciasDaNaturezaESuasTecnologiasEspanhol =
        "<style=\"title\">Ciencias Naturales y sus Tecnologías</style>\n\nEs un campo de estudio que utiliza el cálculo " +
        "y lógica para generar predicciones y mediciones precisas, con expresiones matemáticas y métodos rigurosos. Entiende" +
        "cursos de matemáticas, probabilidad, estadística, informática, astronomía, física, química, geociencias y sus subdivisiones";

    private static string CienciasHumanasESociaisAplicadasEspanhol =
        "<style=\"title\">Ciencias Humanas y Sociales Aplicadas</style>\n\nAmplía esta base conceptual y, manteniendo la frescura" +
        "referencia a las principales categorías del área, se centra en el análisis y evaluación de las relaciones sociales, modalidad" +
        "vínculos económicos, procesos políticos y culturas diversas";

    private static string CienciasSociaisAplicadasEspanhol =
        "<style=\"title\">Ciencias Sociales Aplicadas</style>\n\nEl área de Ciencias Sociales Aplicadas reúne campos del conocimiento" +
        "ser interdisciplinario, centrado en los aspectos sociales de las diversas realidades humanas";

    private static string CienciasDaSaudeEspanhol =
        "<style=\"title\">Ciencias Biológicas</style>\n\nLa misión de las Ciencias Biológicas es estudiar todo lo que dice " +
        "El respeto por los seres vivos y su relación con el medio ambiente. Exige mucha experimentación e investigación, además de " +
        "gran capacidad de concentración y afinidad con animales y personas";

    private static string CienciasBiologicasEspanhol =
        "<style=\"title\">Ciencias Biológicas</style>\n\nLa misión de las Ciencias Biológicas es estudiar todo lo que dice " +
        "El respeto por los seres vivos y su relación con el medio ambiente. Exige mucha experimentación e investigación, además de " +
        "gran capacidad de concentración y afinidad con animales y personas.";

    private static string EngenhariasEspanhol =
        "<style=\"title\">Ingeniería</style>\n\nLa ingeniería se trata de inventar soluciones creativas y prácticas que sean" +
        "Requieren conocimientos y habilidades destinados a mejorar la calidad de vida, no sólo de nuestra sociedad actual, sino también de las generaciones futuras.";

    private static string CienciasExatasDaTerraEspanhol =
        "<style=\"title\">Ciencias Exactas y de la Tierra</style>\n\nEs un campo de estudio que utiliza el cálculo y la lógica para" +
        "generar predicciones y mediciones precisas, con expresiones matemáticas y métodos rigurosos. Incluye los cursos" +
        "matemáticas, probabilidad, estadística, informática, astronomía, física, química, geociencias y sus subdivisiones";

    private static string CienciasHumanasSuperiorEspanhol =
        "<style=\"title\">Ciencias Humanas</style>\n\nAunque desde el punto de vista técnico todos y cada uno de los conocimientos prácticos" +
        "producida por la humanidad es una “ciencia humana”, la propia expresión Ciencias Humanas se refiere sólo a eso" +
        "las ciencias que tienen al ser humano como objeto de estudio o enfoque. En otras palabras, consisten en las profesiones" +
        "Actividades y carreras que se ocupan principalmente de aspectos humanos";

    private static string CienciasAgrariasEspanhol =
       "<style=\"title\">Ciencias Agrarias</style>\n\nEl área de Ciencias Agrícolas se ocupa de los aspectos de exploración de" +
       "tierra, ganadería y cultivo de hortalizas. Sus actividades tienen como objetivo incrementar la producción" +
       "Ucción, mejorar las tecnologías para la gestión y conservación de los recursos naturales";

    private static string LinguisticaLetrasArtesEspanhol =
        "<style=\"title\">Lingüística, Literatura y Artes</style>\n\nLos cursos de Lingüística y Literatura preparan al estudiante" +
        "y posibilitar y facilitar la comunicación entre los seres humanos, y el campo de las Artes va dirigido a eso" +
        "s que encuentran en la expresión artística y cultural su mayor inspiración.";
    #endregion
    public static void AtualizarTextosLinguas()
    {
        switch (Textos.GetIdiomaSelecionado())
        {

            case Idiomas.PORTUGUES:
                AreaDeConhecimento.EuOutroNos.descricao = EuOutroNosPtbr;
                AreaDeConhecimento.CorpoGestosMovimentos.descricao = CorpoGestosMovimentosPtbr;
                AreaDeConhecimento.TracosSonsCoresFormas.descricao = TracosSonsCoresFormasPtbr;
                AreaDeConhecimento.EscutaFalaPensamentoImaginacao.descricao = EscutaFalaPensamentoImaginacaPtbr;
                AreaDeConhecimento.EspacosTemposQuantidadesRelacoesTransformacoes.descricao = EspacosTemposQuantidadesRelacoesTransformacoesPtbr;
                AreaDeConhecimento.Linguagens.descricao = LinguagensPtbr;
                AreaDeConhecimento.Matematica.descricao = MatematicaPtbr;
                AreaDeConhecimento.CienciasDaNatureza.descricao = CienciasDaNaturezaPtbr;
                AreaDeConhecimento.CienciasHumanas.descricao = CienciasHumanasPtbr;
                AreaDeConhecimento.EnsinoReligioso.descricao = EnsinoReligiosoPtbr;
                AreaDeConhecimento.LinguagensESuasTecnologias.descricao = LinguagensESuasTecnologiasoPtbr;
                AreaDeConhecimento.MatematicaESuasTecnologias.descricao = MatematicaESuasTecnologiasPtbr;
                AreaDeConhecimento.CienciasDaNaturezaESuasTecnologias.descricao = CienciasDaNaturezaESuasTecnologiasPtbr;
                AreaDeConhecimento.CienciasHumanasESociaisAplicadas.descricao = CienciasHumanasESociaisAplicadasPtbr;
                AreaDeConhecimento.CienciasSociaisAplicadas.descricao = CienciasSociaisAplicadasPtbr;
                AreaDeConhecimento.CienciasDaSaude.descricao = CienciasDaSaudePtbr;
                AreaDeConhecimento.CienciasBiologicas.descricao = CienciasBiologicasPtbr;
                AreaDeConhecimento.Engenharias.descricao = EngenhariasPtbr;
                AreaDeConhecimento.CienciasExatasDaTerra.descricao = CienciasExatasDaTerraPtbr;
                AreaDeConhecimento.CienciasHumanasSuperior.descricao = CienciasHumanasSuperiorPtbr;
                AreaDeConhecimento.CienciasAgrarias.descricao = CienciasAgrariasPtbr;
                AreaDeConhecimento.LinguisticaLetrasArtes.descricao = LinguisticaLetrasArtesPtbr;

                AreaDeConhecimento.EuOutroNos.nome = "O eu, o outro e o nós";
                AreaDeConhecimento.CorpoGestosMovimentos.nome = "Corpo, gestos e movimentos";
                AreaDeConhecimento.TracosSonsCoresFormas.nome = "Traços, sons, cores e formas";
                AreaDeConhecimento.EscutaFalaPensamentoImaginacao.nome = "Escuta, fala, pensamento e imaginação";
                AreaDeConhecimento.EspacosTemposQuantidadesRelacoesTransformacoes.nome = "Espaços, tempos, quantidades, relações e transformações";
                AreaDeConhecimento.Linguagens.nome = "Linguagens";
                AreaDeConhecimento.Matematica.nome = "Matemática";
                AreaDeConhecimento.CienciasDaNatureza.nome = "Ciências da Natureza";
                AreaDeConhecimento.CienciasHumanas.nome = "Ciências Humanas";
                AreaDeConhecimento.EnsinoReligioso.nome = "Ensino Religioso";
                AreaDeConhecimento.LinguagensESuasTecnologias.nome = "Linguagens e suas Tecnologias";
                AreaDeConhecimento.MatematicaESuasTecnologias.nome = "Matemática e suas Tecnologias";
                AreaDeConhecimento.CienciasDaNaturezaESuasTecnologias.nome = "Ciências da Natureza e suas Tecnologias";
                AreaDeConhecimento.CienciasHumanasESociaisAplicadas.nome = "Ciências Humanas e Sociais Aplicadas";
                AreaDeConhecimento.CienciasSociaisAplicadas.nome = "Ciências Sociais Aplicadas";
                AreaDeConhecimento.CienciasDaSaude.nome = "Ciências da Saúde";
                AreaDeConhecimento.CienciasBiologicas.nome = "Ciências Biológicas";
                AreaDeConhecimento.Engenharias.nome = "Engenharias";
                AreaDeConhecimento.CienciasExatasDaTerra.nome = "Ciências Exatas e da Terra";
                AreaDeConhecimento.CienciasHumanasSuperior.nome = "Ciências Humanas";
                AreaDeConhecimento.CienciasAgrarias.nome = "Ciências Agrárias";
                AreaDeConhecimento.LinguisticaLetrasArtes.nome = "Linguística, Letras e Artes";


                break;

            case Idiomas.INGLES:
                AreaDeConhecimento.EuOutroNos.descricao = EuOutroNosEua;
                AreaDeConhecimento.CorpoGestosMovimentos.descricao = CorpoGestosMovimentosEua;
                AreaDeConhecimento.TracosSonsCoresFormas.descricao = TracosSonsCoresFormasEua;
                AreaDeConhecimento.EscutaFalaPensamentoImaginacao.descricao = EscutaFalaPensamentoImaginacaEua;
                AreaDeConhecimento.EspacosTemposQuantidadesRelacoesTransformacoes.descricao = EspacosTemposQuantidadesRelacoesTransformacoesEua;
                AreaDeConhecimento.Linguagens.descricao = LinguagensEua;
                AreaDeConhecimento.Matematica.descricao = MatematicaEua;
                AreaDeConhecimento.CienciasDaNatureza.descricao = CienciasDaNaturezaEua;
                AreaDeConhecimento.CienciasHumanas.descricao = CienciasHumanasEua;
                AreaDeConhecimento.EnsinoReligioso.descricao = EnsinoReligiosoEua;
                AreaDeConhecimento.LinguagensESuasTecnologias.descricao = LinguagensESuasTecnologiasoEua;
                AreaDeConhecimento.MatematicaESuasTecnologias.descricao = MatematicaESuasTecnologiasEua;
                AreaDeConhecimento.CienciasDaNaturezaESuasTecnologias.descricao = CienciasDaNaturezaESuasTecnologiasEua;
                AreaDeConhecimento.CienciasHumanasESociaisAplicadas.descricao = CienciasHumanasESociaisAplicadasEua;
                AreaDeConhecimento.CienciasSociaisAplicadas.descricao = CienciasSociaisAplicadasEua;
                AreaDeConhecimento.CienciasDaSaude.descricao = CienciasDaSaudeEua;
                AreaDeConhecimento.CienciasBiologicas.descricao = CienciasBiologicasEua;
                AreaDeConhecimento.Engenharias.descricao = EngenhariasEua;
                AreaDeConhecimento.CienciasExatasDaTerra.descricao = CienciasExatasDaTerraEua;
                AreaDeConhecimento.CienciasHumanasSuperior.descricao = CienciasHumanasSuperiorEua;
                AreaDeConhecimento.CienciasAgrarias.descricao = CienciasAgrariasEua;
                AreaDeConhecimento.LinguisticaLetrasArtes.descricao = LinguisticaLetrasArtesEua;


                AreaDeConhecimento.EuOutroNos.nome = "The I, the other and the us";
                AreaDeConhecimento.CorpoGestosMovimentos.nome = "Body, gestures and movements";
                AreaDeConhecimento.TracosSonsCoresFormas.nome = "Traces, sounds, colors and shapes";
                AreaDeConhecimento.EscutaFalaPensamentoImaginacao.nome = "Listening, speaking, thinking and imagining";
                AreaDeConhecimento.EspacosTemposQuantidadesRelacoesTransformacoes.nome = "Spaces, times, quantities, relations and transformations";
                AreaDeConhecimento.Linguagens.nome = "Languages";
                AreaDeConhecimento.Matematica.nome = "Mathematics";
                AreaDeConhecimento.CienciasDaNatureza.nome = "Natural Sciences";
                AreaDeConhecimento.CienciasHumanas.nome = "Human Sciences";
                AreaDeConhecimento.EnsinoReligioso.nome = "Religious Education";
                AreaDeConhecimento.LinguagensESuasTecnologias.nome = "Languages ​​and their Technologies";
                AreaDeConhecimento.MatematicaESuasTecnologias.nome = "Mathematics and its Technologies";
                AreaDeConhecimento.CienciasDaNaturezaESuasTecnologias.nome = "Natural Sciences and their Technologies";
                AreaDeConhecimento.CienciasHumanasESociaisAplicadas.nome = "Applied Humanities and Social Sciences";
                AreaDeConhecimento.CienciasSociaisAplicadas.nome = "Applied Social Sciences";
                AreaDeConhecimento.CienciasDaSaude.nome = "Health Sciences";
                AreaDeConhecimento.CienciasBiologicas.nome = "Biological Sciences";
                AreaDeConhecimento.Engenharias.nome = "Engineering";
                AreaDeConhecimento.CienciasExatasDaTerra.nome = "Exact and Earth Sciences";
                AreaDeConhecimento.CienciasHumanasSuperior.nome = "Human Sciences";
                AreaDeConhecimento.CienciasAgrarias.nome = "Agricultural Sciences";
                AreaDeConhecimento.LinguisticaLetrasArtes.nome = "Linguistics, Letters and Arts";



                break;
            case Idiomas.ESPANHOL:
                AreaDeConhecimento.EuOutroNos.descricao = EuOutroNosEspanhol;
                AreaDeConhecimento.CorpoGestosMovimentos.descricao = CorpoGestosMovimentosEspanhol;
                AreaDeConhecimento.TracosSonsCoresFormas.descricao = TracosSonsCoresFormasEspanhol;
                AreaDeConhecimento.EscutaFalaPensamentoImaginacao.descricao = EscutaFalaPensamentoImaginacaEspanhol;
                AreaDeConhecimento.EspacosTemposQuantidadesRelacoesTransformacoes.descricao = EspacosTemposQuantidadesRelacoesTransformacoesEspanhol;
                AreaDeConhecimento.Linguagens.descricao = LinguagensEspanhol;
                AreaDeConhecimento.Matematica.descricao = MatematicaEspanhol;
                AreaDeConhecimento.CienciasDaNatureza.descricao = CienciasDaNaturezaEspanhol;
                AreaDeConhecimento.CienciasHumanas.descricao = CienciasHumanasEspanhol;
                AreaDeConhecimento.EnsinoReligioso.descricao = EnsinoReligiosoEspanhol;
                AreaDeConhecimento.LinguagensESuasTecnologias.descricao = LinguagensESuasTecnologiasoEspanhol;
                AreaDeConhecimento.MatematicaESuasTecnologias.descricao = MatematicaESuasTecnologiasEspanhol;
                AreaDeConhecimento.CienciasDaNaturezaESuasTecnologias.descricao = CienciasDaNaturezaESuasTecnologiasEspanhol;
                AreaDeConhecimento.CienciasHumanasESociaisAplicadas.descricao = CienciasHumanasESociaisAplicadasEspanhol;
                AreaDeConhecimento.CienciasSociaisAplicadas.descricao = CienciasSociaisAplicadasEspanhol;
                AreaDeConhecimento.CienciasDaSaude.descricao = CienciasDaSaudeEspanhol;
                AreaDeConhecimento.CienciasBiologicas.descricao = CienciasBiologicasEspanhol;
                AreaDeConhecimento.Engenharias.descricao = EngenhariasEspanhol;
                AreaDeConhecimento.CienciasExatasDaTerra.descricao = CienciasExatasDaTerraEspanhol;
                AreaDeConhecimento.CienciasHumanasSuperior.descricao = CienciasHumanasSuperiorEspanhol;
                AreaDeConhecimento.CienciasAgrarias.descricao = CienciasAgrariasEspanhol;
                AreaDeConhecimento.LinguisticaLetrasArtes.descricao = LinguisticaLetrasArtesEspanhol;

                AreaDeConhecimento.EuOutroNos.nome = "El yo, el otro y el nosotros";
                AreaDeConhecimento.CorpoGestosMovimentos.nome = "Cuerpo, gestos y movimientos.";
                AreaDeConhecimento.TracosSonsCoresFormas.nome = "Huellas, sonidos, colores y formas.";
                AreaDeConhecimento.EscutaFalaPensamentoImaginacao.nome = "Escuchar, hablar, pensar e imaginar.";
                AreaDeConhecimento.EspacosTemposQuantidadesRelacoesTransformacoes.nome = "Espacios, tiempos, cantidades, relaciones y transformaciones.";
                AreaDeConhecimento.Linguagens.nome = "Idiomas";
                AreaDeConhecimento.Matematica.nome = "Matemática";
                AreaDeConhecimento.CienciasDaNatureza.nome = "Ciencias naturales";
                AreaDeConhecimento.CienciasHumanas.nome = "Ciencias Humanas";
                AreaDeConhecimento.EnsinoReligioso.nome = "Educación religiosa";
                AreaDeConhecimento.LinguagensESuasTecnologias.nome = "Idiomas y sus Tecnologías";
                AreaDeConhecimento.MatematicaESuasTecnologias.nome = "Idiomas y sus Tecnologías";
                AreaDeConhecimento.CienciasDaNaturezaESuasTecnologias.nome = "Ciencias Naturales y sus Tecnologías";
                AreaDeConhecimento.CienciasHumanasESociaisAplicadas.nome = "Humanidades Aplicadas y Ciencias Sociales";
                AreaDeConhecimento.CienciasSociaisAplicadas.nome = "Ciencias Sociales Aplicadas";
                AreaDeConhecimento.CienciasDaSaude.nome = "Ciencias de la Salud";
                AreaDeConhecimento.CienciasBiologicas.nome = "Ciencias Biológicas";
                AreaDeConhecimento.Engenharias.nome = "Ingeniería";
                AreaDeConhecimento.CienciasExatasDaTerra.nome = "Ciencias Exactas y de la Tierra";
                AreaDeConhecimento.CienciasHumanasSuperior.nome = "Ciencias Humanas";
                AreaDeConhecimento.CienciasAgrarias.nome = "Ciencias Agrícolas";
                AreaDeConhecimento.LinguisticaLetrasArtes.nome = "Lingüística, Letras y Artes";
                break;
        }
    }
    public readonly int valor;
    public string nome;
    public string descricao;
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