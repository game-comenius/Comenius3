using UnityEngine;

public sealed class Metodologia
{
    public static readonly Metodologia ABP = new Metodologia
    (
        valor: 0,
        nome: "Aprendizagem Baseada em Problemas",
        descricao: "<b>Aprendizagem Baseada em Problemas</b>\n\nNessa abordagem os estudantes se deparam com um problema e precisam buscar possíveis soluções. " +
                   "Assim a curiosidade é a base para a elaboração de perguntas acerca dos assuntos estudados.  A ideia " +
                   "não é ter sempre o problema resolvido na etapa final do trabalho, e sim enfatizar o processo de aprendizagem do grupo na busca de uma solução.",
        descricaoLonga: "Na Aprendizagem Baseada em Problemas (ABP) deve-se atentar para a descrição de um contexto no qual " + 
                        "variáveis, sujeitos e situações possam ser claramente identificados pelos estudantes. O problema " +
                        "deve conter as seguintes características:\n\n• Apresentar tema e nível de complexidade compatíveis " +
                        "com o conhecimento prévio dos estudantes;\n• Conter sugestões ou dicas que os estimulem a " +
                        "identificar possíveis pontos de partida;\n• Ser simples e objetivo, para evitar que o grupo " +
                        "desvie a atenção do tema;\n• Mobilizar de forma articulada os elementos de competência.\n\n" +
                        "Sequência Didática:\n\n1. Apresentar o problema e levantar os conhecimentos sobre o assunto;\n" +
                        "2. Analisar as variáveis do problema e propor possíveis soluções;\n3. Buscar novas referências " +
                        "para qualificar as propostas, debater e buscar consenso sobre as possíveis soluções;\n4. " +
                        "Apresentar as respostas e avaliar os resultados."
    );

    public static readonly Metodologia Invertida = new Metodologia
    (
        valor: 1,
        nome: "Sala de Aula Invertida",
        descricao: "<b>Sala de Aula Invertida</b>\n\nA sala de aula invertida, também conhecida como Flipped Classroom, é o método que inverte a sequência tradicional do processo " +
                   "de ensino e aprendizagem.\nOs estudantes realizam leituras e pesquisas antes da aula. Podem participar de atividades interativas " +
                   "como jogos e chats, ou ainda fazer uma leitura, assistir um vídeo.\nEm sala de aula, discutem sobre o tema com o docente e os " +
                   "demais colegas, tiram suas dúvidas e fazem atividades. As dúvidas e reflexões que os estudantes levarem para a aula são tomadas " +
                   "como ponto de partida para as atividades presenciais, tornando as aulas mais participativas.",
        descricaoLonga: "Na Sala de Aula Invertida, o docente propõe um conteúdo e atividades para serem feitas " +
                        "em casa pelos estudantes, por meio de materiais como vídeos, podcasts ou leitura de textos," +
                        " etc. Após o estudo prévio do tema, os estudantes levam para a sala de aula suas dúvidas, " +
                        "realizam reflexões em grupos e desenvolvem projetos.\n\nNa Sala de Aula Invertida há a " +
                        "possibilidade de concentrar na plataforma ou ambiente virtual as informações necessárias " +
                        "para o decorrer da disciplina ou curso, o que é um grande atrativo desse método.\n\nSequência " +
                        "Didática, na sala de aula:\n1. Explorar o material;\n2. Discutir com o grupo em sala de aula;\n" +
                        "3. Realizar atividades."
    );

    public static readonly Metodologia ABProj = new Metodologia
    (
        valor: 2,
        nome: "Aprendizagem Baseada em Projetos",
        descricao: "",
        descricaoLonga: ""
    );

    public static readonly Metodologia ABJ = new Metodologia
    (
        valor: 3,
        nome: "Aprendizagem Baseada em Jogos",
        descricao: "",
        descricaoLonga: ""
    );

    public readonly int valor;
    public readonly string nome;
    public readonly string descricao;
    public readonly string descricaoLonga;
    public Sprite sprite;

    private Metodologia(int valor, string nome, string descricao, string descricaoLonga)
    {
        this.valor = valor;
        this.nome = nome;
        this.descricao = descricao;
        this.descricaoLonga = descricaoLonga;
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
