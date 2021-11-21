using System;
using UnityEngine;

[Serializable]
public sealed class AreaDeConhecimento
{
    // Áreas de conhecimento do Ensino Infantil
    public static readonly AreaDeConhecimento EuOutroNos = new AreaDeConhecimento(0, 
        "O eu, o outro e o nós", 
        "<b>O eu, o outro e o nós</b>\n\nÉ na interação com os pares e com adultos que as crianças ressignificam sua aprendizagem, diferenciando-se e identificando-se como seres " +
        "individuais e sociais valorizando sua identidade, respeitando os outros e reconhecendo suas diferenças que nos constituem como seres humanos.");
    public static readonly AreaDeConhecimento CorpoGestosMovimentos = new AreaDeConhecimento(1, 
        "Corpo, gestos e movimentos", 
        "<b>Corpo, gestos e movimentos</b>\n\nA exploração do mundo, através do corpo e dos sentidos, estabelecendo relações e produzindo conhecimento sobre o universo social e cultural, " +
        "através de diferentes linguagens corporais animadas pelo lúdico e na interação com seus pares para descobrir variados modos de ocupação e " +
        "uso do espaço com o corpo.");
    public static readonly AreaDeConhecimento TracosSonsCoresFormas = new AreaDeConhecimento(2, 
        "Traços, sons, cores e formas", 
        "<b>Traços, sons, cores e formas</b>\n\nAtravés de experiências diversificadas, vivenciar diversar formas de expressão e linguagens contribuindo para desenvolver a sensibilidade, " +
        "o senso estético e crítico, além da criatividade e da expressão pessoal para criarem seu próprio repertório artístico e cultural.");
    public static readonly AreaDeConhecimento EscutaFalaPensamentoImaginacao = new AreaDeConhecimento(3, 
        "Escuta, fala, pensamento e imaginação", 
        "<b>Escuta, fala, pensamento e imaginação</b>\n\nPor meio das interações, progressivamente, as crianças vão ampliando a compreensão da linguagem oral e seus meios de comunicação no cotidiano. " +
        "Assim como sua curiosidade sobre a cultura escrita através da literatura infantil, desenvolvendo sua imaginação e ampliando seu conhecimento de mundo.");
    public static readonly AreaDeConhecimento EspacosTemposQuantidadesRelacoesTransformacoes = new AreaDeConhecimento(4, 
        "Espaços, tempos, quantidades, relações e transformações", 
        "<b>Espaços, tempos, quantidades, relações e transformações</b>\n\nAs crianças demonstram curiosidade sobre os espaços e tempos de diferentes dimensões em um mundo constituído de fenômenos naturais e " +
        "socioculturais, nos quais, os conhecimentos matemáticos estão também inseridos, fazendo os pequenos, através da exploração do ambiente, " +
        "entender melhor o seu uso no cotidiano e suas relações e transformações.");

    // Áreas de conhecimento do Ensino Fundamental
    public static readonly AreaDeConhecimento Linguagens = new AreaDeConhecimento(7, 
        "Linguagens", 
        "<b>Linguagens</b>\n\nÉ composta pelos seguintes componentes curriculares: Língua Portuguesa, Arte, Educação Física e, no Ensino Fundamental – Anos Finais, " +
        "Língua Inglesa. A finalidade é possibilitar aos estudantes participar de práticas de linguagens diversificadas, que lhes permitam ampliar " +
        "suas capacidades expressivas em manifestações artísticas, corporais e linguísticas, como também seus conhecimentos sobre essas linguagens.");
    public static readonly AreaDeConhecimento Matematica = new AreaDeConhecimento(8, 
        "Matemática", 
        "<b>Matemática</b>\n\nA Matemática cria sistemas abstratos, que organizam e inter-relacionam fenômenos do espaço, do movimento, das formas e dos números, " +
        "associados ou não a fenômenos do mundo físico. Esses sistemas contêm ideias e objetos que são fundamentais para a compreensão de fenômenos, " +
        "a construção de representações significativas e argumentações consistentes nos mais variados contextos.");
    public static readonly AreaDeConhecimento CienciasDaNatureza = new AreaDeConhecimento(9, 
        "Ciências da Natureza", 
        "<b>Ciências da Natureza</b>\n\nPor meio de um olhar articulado de diversos campos do saber, busca assegurar aos estudantes do Ensino Fundamental o acesso à diversidade " +
        "de conhecimentos científicos produzidos ao longo da história, bem como a aproximação gradativa aos principais processos, práticas e " +
        "procedimentos da investigação científica através do letramento científico.");
    public static readonly AreaDeConhecimento CienciasHumanas = new AreaDeConhecimento(10, 
        "Ciências Humanas", 
        "<b>Ciências Humanas</b>\n\nContribui para que os estudantes desenvolvam a cognição in situ, ou seja, sem prescindir da contextualização marcada pelas noções de " +
        "tempo e espaço, baseando-se na ideia de que o ser humano produz o espaço em que vive, apropriando-se dele em determinada circunstância " +
        "histórica, valorizando a crítica sistemática à ação humana, às relações sociais e de poder e, especialmente, à produção de conhecimentos e saberes.");
    public static readonly AreaDeConhecimento EnsinoReligioso = new AreaDeConhecimento(12, 
        "Ensino Religioso", 
        "<b>Ensino Religioso</b>\n\nO conhecimento religioso busca investigar a manifestação dos fenômenos religiosos em diferentes culturas e sociedades enquanto um dos " +
        "bens simbólicos resultantes da busca humana por respostas aos enigmas do mundo, da vida e da morte, de modo singular, complexo e diverso.");

    // Áreas de conhecimento do Ensino Médio
    public static readonly AreaDeConhecimento LinguagensESuasTecnologias = new AreaDeConhecimento(13, 
        "Linguagens e suas Tecnologias", 
        "<b>Linguagens e suas Tecnologias</b>\n\nO foco está na ampliação da autonomia, do protagonismo e da autoria nas práticas de diferentes linguagens; na identificação e na crítica " +
        "aos diferentes usos das linguagens, explicitando seu poder no estabelecimento de relações; na apreciação e na participação em diversas " +
        "manifestações artísticas e culturais e no uso criativo das diversas mídias.");
    public static readonly AreaDeConhecimento MatematicaESuasTecnologias = new AreaDeConhecimento(14, 
        "Matemática e suas Tecnologias", 
        "<b>Matemática e suas Tecnologias</b>\n\nOs estudantes devem utilizar conceitos, procedimentos e estratégias não apenas para resolver problemas, mas também para formulá-los, " +
        "descrever dados, selecionar modelos matemáticos e desenvolver o pensamento computacional, por meio da utilização de diferentes " +
        "recursos da área.");
    public static readonly AreaDeConhecimento CienciasDaNaturezaESuasTecnologias = new AreaDeConhecimento(15, 
        "Ciências da Natureza e suas Tecnologias", 
        "<b>Ciências da Natureza e suas Tecnologias</b>\n\nPropõe que os estudantes possam construir e utilizar conhecimentos específicos da área para argumentar, propor soluções e " +
        "enfrentar desafios locais e/ou globais, relativos às condições de vida e ao ambiente.");
    public static readonly AreaDeConhecimento CienciasHumanasESociaisAplicadas = new AreaDeConhecimento(16, 
        "Ciências Humanas e Sociais Aplicadas",
        "<b>Ciências Humanas e Sociais Aplicadas</b>\n\nAmplia essa base conceitual e, mantendo referência às principais categorias da área, concentra-se na análise e na avaliação das " +
        "relações sociais, dos modelos econômicos, dos processos políticos e das diversas culturas.");

    // Áreas de conhecimento do Ensino Superior
    public static readonly AreaDeConhecimento CienciasSociaisAplicadas = new AreaDeConhecimento(17, 
        "Ciências Sociais Aplicadas", 
        "<b>Ciências Sociais Aplicadas</b>\n\nA área de Ciências Sociais Aplicadas reúne campos de conhecimento interdisciplinares, voltados para os aspectos sociais das " +
        "diversas realidades humanas.");
    public static readonly AreaDeConhecimento CienciasDaSaude = new AreaDeConhecimento(22, 
        "Ciências da Saúde", 
        "<b>Ciências da Saúde</b>\n\nAs ciências da saúde são as áreas de estudo relacionadas com a vida, a saúde e a doença.");
    public static readonly AreaDeConhecimento CienciasBiologicas = new AreaDeConhecimento(20, 
        "Ciências Biológicas", 
        "<b>Ciências Biológicas</b>\n\nAs Ciências Biológicas têm por missão estudar tudo o que diz respeito aos seres vivos e sua relação com o meio ambiente.");
    public static readonly AreaDeConhecimento Engenharias = new AreaDeConhecimento(21, 
        "Engenharias", 
        "<b>Engenharias</b>\n\nAs Engenharias tratam de inventar soluções criativas e práticas que exigem conhecimento e habilidade visando a melhoria na " +
        "qualidade de vida, não só da nossa sociedade atual, como das próximas gerações.");
    public static readonly AreaDeConhecimento CienciasExatasDaTerra = new AreaDeConhecimento(19, 
        "Ciências Exatas e da Terra", 
        "<b>Ciências Exatas e da Terra</b>\n\nEmbora inclua cursos com perfis bem distintos, a área das Ciências Exatas e da Terra tem por característica a presença de " +
        "disciplinas baseadas em cálculos físico-matemáticos.");
    public static readonly AreaDeConhecimento CienciasHumanasSuperior = new AreaDeConhecimento(18, 
        "Ciências Humanas", 
        "<b>Ciências Humanas</b>\n\nEmbora do ponto de vista técnico todo e qualquer conhecimento produzido pela humanidade seja uma “ciência humana”, a expressão " +
        "Ciências Humanas em si refere-se somente àquelas ciências que têm o ser humano como seu objeto de estudo ou foco. Em outras " +
        "palavras, consistem nas profissões e carreiras que tratam primariamente dos aspectos humanos.");
    public static readonly AreaDeConhecimento CienciasAgrarias = new AreaDeConhecimento(23, 
        "Ciências Agrárias", 
        "<b>Ciências Agrárias</b>\n\nA área de Ciências Agrárias trata dos aspectos de exploração da terra, de criação de animais e de cultivo de vegetais. Suas " +
        "atividades possuem o objetivo de aumentar a produção, aprimorar as tecnologias de manejo e preservação dos recursos naturais.");
    public static readonly AreaDeConhecimento LinguisticaLetrasArtes = new AreaDeConhecimento(24, 
        "Linguística, Letras e Artes", 
        "<b>Linguística, Letras e Artes</b>\n\nOs cursos de Linguística e Letras preparam o estudante para viabilizar e facilitar a comunicação entre os seres humanos, e o " +
        "campo das Artes é voltado para aqueles que têm na expressão artística e cultural sua maior inspiração.");


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