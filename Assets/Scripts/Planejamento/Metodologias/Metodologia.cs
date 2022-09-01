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

    public static readonly Metodologia SAI = new Metodologia
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
        descricao: "<bAprendizagem Baseada em Projeto</b>\n\n A Aprendizagem Baseada em Projetos é focada na construção de conhecimento por intermédio de um trabalho " +
                   "longo e contínuo de estudo, cujo propósito é atender a uma indagação, a um desafio ou a um problema. Dessa" +
                   " forma, permite que vários estudantes trabalhem juntos em torno de um problema e aprendam uns com os outros.",
        descricaoLonga: "O problema do projeto é multidimensional e altamente interativo, uma vez que insere os participantes em " +
                        "um processo de investigação estruturado em torno de questões complexas. Diante disso, a grande contribuição" +
                        " dessa metodologia em sala de aula reside na ênfase ao processo de aprendizagem e na interação entre os " +
                        "estudantes.\nOs projetos permitem unificar vários aspectos importantes do processo de aprendizagem: a ação " +
                        "protagonizada pelo aluno, a intencionalidade dessa ação e sua inserção em um contexto social. Por meio dos " +
                        "princípios de autonomia, pesquisa, ação e reflexão, o desenvolvimento de um projeto parte da definição de um " +
                        "tema, da proposição de desafios e do planejamento e execução de estratégias para o cumprimento das ações " +
                        "propostas.\n\nPara tanto, o docente deve observar os seguintes aspectos:\n• Conteúdo significativo: relevância " +
                        "para os estudantes.\n• Perguntas instigantes: mobilizar o grupo para a investigação, apresentando diferentes " +
                        "possibilidades de solução.\n• Pesquisa e inovação: consultar diferentes fontes especializadas, buscando resultados " +
                        "criativos e inovadores.\n• Valorização do processo: Aspectos relacionais e cognitivos do processo são fundamentais " +
                        "para a vida dos estudantes.\n\n- Sequência Didática\n1. Definir o escopo / Planejar as etapas do projeto - " +
                        "Sala de Aula\n2. Executar as ações previstas / Monitorar o desenvolvimento do projeto - Cidade\n3. Apresentar " +
                        "os resultados - Sala de Aula - Colégio (epílogo)"
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
            SAI,
            ABProj
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
        return new NomeDeMidia[]
        {
            NomeDeMidia.Lousa,
            NomeDeMidia.LivroDidatico,
            NomeDeMidia.CadernosECartazes,
            NomeDeMidia.Televisao,
            NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas,
            NomeDeMidia.EditoresDeAudioEVideo,
            NomeDeMidia.Aplicativos,
            NomeDeMidia.Plataformas,
            NomeDeMidia.Jogos,
            NomeDeMidia.ProjetorMultimidia,
        };
    }
}
