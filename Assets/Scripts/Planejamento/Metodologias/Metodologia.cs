using UnityEngine;

public sealed class Metodologia
{
    public static readonly Metodologia ABP = new Metodologia
    (
        valor: 0,
        nome: "Aprendizagem Baseada em Problemas",
        descricao: "Nessa abordagem os alunos se deparam com um problema e precisam buscar possíveis soluções... "
    );

    public static readonly Metodologia Invertida = new Metodologia
    (
        valor: 1,
        nome: "Sala de Aula Invertida",
        descricao: "É o método que inverte a sequência tradicional das situações de aprendizagem. Nessa proposta..."
    );

    public static readonly Metodologia ABProj = new Metodologia
    (
        valor: 2,
        nome: "Aprendizagem Baseada em Projetos",
        descricao: ""
    );

    public static readonly Metodologia ABJ = new Metodologia
    (
        valor: 3,
        nome: "Aprendizagem Baseada em Jogos",
        descricao: ""
    );



    public readonly int valor;
    public readonly string nome;
    public readonly string descricao;
    public Sprite sprite;

    private Metodologia(int valor, string nome, string descricao)
    {
        this.valor = valor;
        this.nome = nome;
        this.descricao = descricao;
    }

    public static Metodologia[] TodasAsMetodologias()
    {
        Metodologia[] TodasAsMetodologias =
        {
            ABP,
            Invertida,
            ABProj,
            ABJ
        };
        return TodasAsMetodologias;
    }

    public static Metodologia Get(int valor)
    {
        foreach (var metodologia in TodasAsMetodologias())
        {
            if (valor == metodologia.valor)
                return metodologia;
        }
        return null;
    }

    public static Metodologia Get(string nome)
    {
        foreach (var metodologia in TodasAsMetodologias())
        {
            if (nome.Equals(metodologia.nome))
                return metodologia;
        }
        return null;
    }

    public override string ToString()
    {
        return nome;
    }




    // Retorna quais mídias pertencem ao parâmetro metodologia
    // Fonte = https://docs.google.com/spreadsheets/d/1sndl_nQUZNEWMg2jXrBp6sa1fAIk7xq5WFwrJDtTWHI/edit#gid=0
    public NomeDeMidia[] NomesDeMidiasDaMetodologia()
    {
        if (this == Metodologia.ABJ)
        {
            // TODO
            return null;
        }
        else // this == Metodologia.ABP:
        {
            return new NomeDeMidia[]
            {
                NomeDeMidia.Lousa,
                NomeDeMidia.LivroDidatico,
                NomeDeMidia.CadernosECartazes,
                NomeDeMidia.Televisao,
                NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas,
                NomeDeMidia.EditoresDeAudioEVideo,
                NomeDeMidia.Aplicativos,
                NomeDeMidia.AVEAs,
                NomeDeMidia.Jogos,
                NomeDeMidia.ProjetorMultimidia,
            };
        }
    }

    // Cada metodologia define a pontuação das mídias usadas nela de acordo com as categorias dessas mídias
    // Fonte = https://docs.google.com/spreadsheets/d/1sndl_nQUZNEWMg2jXrBp6sa1fAIk7xq5WFwrJDtTWHI/edit#gid=1166836280
    // A pontuação será entre [0, 1] (inclusive)
    public float PontuacaoParaCategoriasDeMidia(CategoriasDeMidia categoria, bool receberaPenalidade)
    {
        float pontuacao = 0;

        float incrementoPadrao = 1.0f;

        float multiplicadorMidiaOtima = 1 / 1f;
        float multiplicadorMidiaBoa = 1 / 2f;
        float multiplicadorMidiaRegular = 1 / 3f;

        // Se a pontuação receberá penalidade, os multiplicadores serão diferentes
        if (receberaPenalidade)
        {
            multiplicadorMidiaOtima = multiplicadorMidiaBoa;
            multiplicadorMidiaBoa = multiplicadorMidiaRegular;
            multiplicadorMidiaRegular = 0;
        }

        // Número máximo de categorias simultaneas em um objeto CategoriasDeMidia, padrão = 2
        // Ou seja, uma mídia pode pertencer à, no máximo, x categorias simultaneamente.
        int numeroMaxDeCategoriasSimultaneas = 2;

        if (this == Metodologia.ABJ)
        {
            // TODO
            return 0;
        }
        else if (this == Metodologia.ABP)
        {
            if (categoria.HasFlag(CategoriasDeMidia.ConsultaRepositorio)) pontuacao += incrementoPadrao * multiplicadorMidiaOtima;
            if (categoria.HasFlag(CategoriasDeMidia.Digital)) pontuacao += incrementoPadrao * multiplicadorMidiaOtima;

            if (categoria.HasFlag(CategoriasDeMidia.ProducaoArmazenamento)) pontuacao += incrementoPadrao * multiplicadorMidiaBoa;
            if (categoria.HasFlag(CategoriasDeMidia.Exposicao)) pontuacao += incrementoPadrao * multiplicadorMidiaBoa;
            if (categoria.HasFlag(CategoriasDeMidia.Impressa)) pontuacao += incrementoPadrao * multiplicadorMidiaBoa;
            if (categoria.HasFlag(CategoriasDeMidia.AudioVisual)) pontuacao += incrementoPadrao * multiplicadorMidiaBoa;

            if (categoria.HasFlag(CategoriasDeMidia.Popular)) pontuacao += incrementoPadrao * multiplicadorMidiaRegular;
        }
        else //this == Metodologia.Invertida
        {

        }

        return pontuacao / numeroMaxDeCategoriasSimultaneas;
    }
}
