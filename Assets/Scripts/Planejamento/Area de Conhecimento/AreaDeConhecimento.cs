using System;
using UnityEngine;

[Serializable]
public sealed class AreaDeConhecimento
{
    // Áreas de conhecimento do Ensino Infantil
    public static readonly AreaDeConhecimento EuOutroNos = new AreaDeConhecimento(0, 
        "O eu, o outro e o nós", 
        "É na interação com os pares e com adultos que as crianças ressignificam sua aprendizagem, diferenciando-se...");
    public static readonly AreaDeConhecimento CorpoGestosMovimentos = new AreaDeConhecimento(1, 
        "Corpo, gestos e movimentos", 
        "A exploração do mundo, através do corpo e dos sentidos, estabelecendo relações e produzindo conhecimento...");
    public static readonly AreaDeConhecimento TracosSonsCoresFormas = new AreaDeConhecimento(2, 
        "Traços, sons, cores e formas", 
        "Através de experiências diversificadas, vivenciar diversar formas de expresão e linguagens contribuindo...");
    public static readonly AreaDeConhecimento EscutaFalaPensamentoImaginacao = new AreaDeConhecimento(3, 
        "Escuta, fala, pensamento e imaginação", 
        "Por meio das interações, progressivamente, as crianças vão ampliando a compreensão da linguagem oral...");
    public static readonly AreaDeConhecimento EspacosTemposQuantidadesRelacoesTransformacoes = new AreaDeConhecimento(4, 
        "Espaços, tempos, quantidades, relações e transformações", 
        "As crianças demonstram curiosidade sobre os espaços e tempos de diferentes dimensões em um mundo...");

    // Áreas de conhecimento do Ensino Fundamental
    public static readonly AreaDeConhecimento Linguagens = new AreaDeConhecimento(7, 
        "Linguagens", 
        "É composta pelos seguintes componentes curriculares: Língua Portuguesa, Arte, Educação Física...");
    public static readonly AreaDeConhecimento Matematica = new AreaDeConhecimento(8, 
        "Matemática", 
        "A Matemática cria sistemas abstratos, que organizam e inter-relacionam fenômenos do espaço...");
    public static readonly AreaDeConhecimento CienciasDaNatureza = new AreaDeConhecimento(9, 
        "Ciências da Natureza", 
        "Por meio de um olhar articulado de diversos campos do saber, busca assegurar aos alunos do Ensino Fundamental...");
    public static readonly AreaDeConhecimento CienciasHumanas = new AreaDeConhecimento(10, 
        "Ciências Humanas", 
        "Contribui para que os alunos desenvolvam a cognição in situ, ou seja, sem prescindir da contextualização...");
    public static readonly AreaDeConhecimento EnsinoReligioso = new AreaDeConhecimento(12, 
        "Ensino Religioso", 
        "O conhecimento religioso busca investigar a manifestação dos fenômenos religiosos em diferentes culturas...");

    // Áreas de conhecimento do Ensino Médio
    public static readonly AreaDeConhecimento LinguagensESuasTecnologias = new AreaDeConhecimento(13, 
        "Linguagens e suas Tecnologias", 
        "O foco está na ampliação da autonomia, do protagonismo e da autoria nas práticas de diferentes linguagens...");
    public static readonly AreaDeConhecimento MatematicaESuasTecnologias = new AreaDeConhecimento(14, 
        "Matemática e suas Tecnologias", 
        "Os estudantes devem utilizar conceitos, procedimentos e estratégias não apenas para resolver...");
    public static readonly AreaDeConhecimento CienciasDaNaturezaESuasTecnologias = new AreaDeConhecimento(15, 
        "Ciências da Natureza e suas Tecnologias", 
        "Propõe que os estudantes possam construir e utilizar conhecimentos específicos da área para argumentar, propor soluções...");
    public static readonly AreaDeConhecimento CienciasHumanasESociaisAplicadas = new AreaDeConhecimento(16, 
        "Ciências Humanas e Sociais Aplicadas",
        "Amplia essa base conceitual e, mantendo referência às principais categorias da área, concentra-se na...");

    // Áreas de conhecimento do Ensino Superior
    public static readonly AreaDeConhecimento CienciasSociaisAplicadas = new AreaDeConhecimento(17, 
        "Ciências Sociais Aplicadas", 
        "A área de Ciências Sociais Aplicadas reúne campos de conhecimento interdisciplinares, voltados para os aspectos sociais das diversas realidades humanas.");
    public static readonly AreaDeConhecimento CienciasDaSaude = new AreaDeConhecimento(22, 
        "Ciências da Saúde", 
        "As ciências da saúde são as áreas de estudo relacionadas com a vida, a saúde e a doença.");
    public static readonly AreaDeConhecimento CienciasBiologicas = new AreaDeConhecimento(20, 
        "Ciências Biológicas", 
        "As Ciências Biológicas têm por missão estudar tudo o que diz respeito aos seres vivos e sua relação com o meio ambiente.");
    public static readonly AreaDeConhecimento Engenharias = new AreaDeConhecimento(21, 
        "Engenharias", 
        "As Engenharias tratam de inventar soluções criativas e práticas que exigem conhecimento e habilidade...");
    public static readonly AreaDeConhecimento CienciasExatasDaTerra = new AreaDeConhecimento(19, 
        "Ciências Exatas e da Terra", 
        "Embora inclua cursos com perfis bem distintos, a área das Ciências Exatas e da Terra tem por característica...");
    public static readonly AreaDeConhecimento CienciasHumanasSuperior = new AreaDeConhecimento(18, 
        "Ciências Humanas", 
        "Embora do ponto de vista técnico todo e qualquer conhecimento produzido pela humanidade seja uma...");
    public static readonly AreaDeConhecimento CienciasAgrarias = new AreaDeConhecimento(23, 
        "Ciências Agrárias", 
        "A área de Ciências Agrárias trata dos aspectos de exploração da terra, de criação de animais e de cultivo...");
    public static readonly AreaDeConhecimento LinguisticaLetrasArtes = new AreaDeConhecimento(24, 
        "Linguística, Letras e Artes", 
        "Os cursos de Linguística e Letras preparam o estudante para viabilizar e facilitar a comunicação entre os seres...");


    public readonly int valor;
    public readonly string nome;
    public readonly string Descricao;
    // Quando o jogador seleciona este quando aperta sobre o ícone que
    // representa ele, o ícone salva seu sprite nesta propriedade
    // para que o jogo possa apresentá-la depois em outras cenas
    public Sprite Sprite;


    private AreaDeConhecimento(int valor, string nome, string descricao)
    {
        this.valor = valor;
        this.nome = nome;
        this.Descricao = descricao;
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