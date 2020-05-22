using System;

[Serializable]
public sealed class AreaDeConhecimento
{
    public static readonly AreaDeConhecimento EuOutroNos = new AreaDeConhecimento(0, "O eu, o outro e o nós");
    public static readonly AreaDeConhecimento CorpoGestosMovimentos = new AreaDeConhecimento(1, "Corpo, gestos e movimentos");
    public static readonly AreaDeConhecimento TracosSonsCoresFormas = new AreaDeConhecimento(2, "Traços, sons, cores e formas");
    public static readonly AreaDeConhecimento EscutaFalaPensamentoImaginacao = new AreaDeConhecimento(3, "Escuta, fala, pensamento e imaginação");
    public static readonly AreaDeConhecimento EspacosTemposQuantidadesRelacoesTransformacoes = new AreaDeConhecimento(4, "Espaços, tempos, quantidades, relações e transformações");

    public static readonly AreaDeConhecimento LinguaPortuguesa = new AreaDeConhecimento(5, "Língua Portuguesa");
    public static readonly AreaDeConhecimento Artes = new AreaDeConhecimento(6, "Artes");
    public static readonly AreaDeConhecimento EducacaoFisica = new AreaDeConhecimento(7, "Educação Física");
    public static readonly AreaDeConhecimento Matematica = new AreaDeConhecimento(8, "Matemática");
    public static readonly AreaDeConhecimento CienciasDaNatureza = new AreaDeConhecimento(9, "Ciências da Natureza");
    public static readonly AreaDeConhecimento Geografia = new AreaDeConhecimento(10, "Geografia");
    public static readonly AreaDeConhecimento Historia = new AreaDeConhecimento(11, "História");
    public static readonly AreaDeConhecimento EnsinoReligioso = new AreaDeConhecimento(12, "Ensino Religioso");

    public static readonly AreaDeConhecimento LinguaInglesa = new AreaDeConhecimento(13, "Língua Inglesa");

    public static readonly AreaDeConhecimento LinguagensSuasTecnologias = new AreaDeConhecimento(14, "Linguagens e suas Tecnologias");
    public static readonly AreaDeConhecimento CienciasHumanas = new AreaDeConhecimento(15, "Ciências Humanas");
    public static readonly AreaDeConhecimento CienciasSociaisAplicadas = new AreaDeConhecimento(16, "Ciências Sociais Aplicadas");

    public static readonly AreaDeConhecimento EstudosDaSociedadeDaNatureza = new AreaDeConhecimento(17, "Estudos da Sociedade e da Natureza");

    public static readonly AreaDeConhecimento LinguaEstrangeira = new AreaDeConhecimento(18, "Língua Estrangeira");

    public static readonly AreaDeConhecimento CienciasExatasDaTerra = new AreaDeConhecimento(19, "Ciências Exatas e da Terra");
    public static readonly AreaDeConhecimento CienciasBiologicas = new AreaDeConhecimento(20, "Ciências Biológicas");
    public static readonly AreaDeConhecimento Engenharias = new AreaDeConhecimento(21, "Engenharias");
    public static readonly AreaDeConhecimento CienciasDaSaude = new AreaDeConhecimento(22, "Ciências da Saúde");
    public static readonly AreaDeConhecimento CienciasAgrarias = new AreaDeConhecimento(23, "Ciências Agrárias");


    public readonly int valor;
    public readonly string nome;


    private AreaDeConhecimento(int valor, string nome)
    {
        this.valor = valor;
        this.nome = nome;
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

            LinguaPortuguesa,
            Artes,
            EducacaoFisica,
            Matematica,
            CienciasDaNatureza,
            Geografia,
            Historia,
            EnsinoReligioso,

            LinguaInglesa,
            LinguagensSuasTecnologias,
            CienciasHumanas,
            CienciasSociaisAplicadas,

            EstudosDaSociedadeDaNatureza,

            LinguaEstrangeira,

            CienciasExatasDaTerra,
            CienciasBiologicas,
            Engenharias,
            CienciasDaSaude,
            CienciasAgrarias
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