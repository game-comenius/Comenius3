using Mono.Cecil;
using UnityEngine;

public sealed class Metodologia
{
    public static Metodologia ABP = new Metodologia
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

    public static  Metodologia SAI = new Metodologia
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

    public static  Metodologia ABProj = new Metodologia
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

    public static void AtualizarTextosLinguas()
    {
        switch (Textos.GetIdiomaSelecionado())
        {
            case Idiomas._chaveInicial:
                break;
            case Idiomas.INGLES:
                ABProj.descricaoLonga = "The project problem is multidimensional and highly interactive, as it inserts participants into " +
                        "an investigation process structured around complex issues. Given this, the great contribution" +
                        " of this methodology in the classroom lies in the emphasis on the learning process and the interaction between " +
                        "students.\nProjects allow us to unify several important aspects of the learning process: action " +
                        "led by the student, the intentionality of this action and its insertion in a social context. Through " +
                        "principles of autonomy, research, action and reflection, the development of a project starts from the definition of a " +
                        "theme, proposing challenges and planning and executing strategies to fulfill the actions" +
                        "proposals.\n\nTo this end, the teacher must observe the following aspects:\n• Significant content: relevance " +
                        "for students.\n• Thought-provoking questions: mobilize the group for investigation, presenting different " +
                        "solution possibilities.\n• Research and innovation: consult different specialized sources, seeking results " +
                        "creative and innovative.\n• Valuing the process: Relational and cognitive aspects of the process are fundamental " +
                        "for students' lives.\n\n- Didactic Sequence\n1. Define the scope / Plan the project stages - " +
                        "Classroom\n2. Execute the planned actions / Monitor the development of the project - City\n3. Present " +
                        "the results - Classroom - College (epilogue)";
                SAI.descricaoLonga = "In the Flipped Classroom, the teacher proposes content and activities to be done" +
                        "at home by students, through materials such as videos, podcasts or reading texts," +
                        " etc. After previously studying the topic, students take their doubts to the classroom, " +
                        "they reflect in groups and develop projects.\n\nIn the Flipped Classroom there is " +
                        "possibility of concentrating the necessary information on the platform or virtual environment" +
                        "for the course of the subject or course, which is a great attraction of this method.\n\nSequence " +
                        "Didactics, in the classroom:\n1. Explore the material;\n2. Discuss with the group in the classroom;\n" +
                        "3. Carry out activities.";
                ABP.descricaoLonga = "In Problem-Based Learning (PBL), attention must be paid to the description of a context in which " + 
                        "variables, subjects and situations can be clearly identified by students. The problem " +
                        "must contain the following characteristics:\n\n• Present compatible theme and level of complexity " +
                        "with the students' prior knowledge;\n• Contain suggestions or tips that encourage them to " +
                        "identify possible starting points;\n• Be simple and objective, to avoid the group " +
                        "divert attention from the topic;\n• Mobilize the elements of competence in an articulated way.\n\n" +
                        "Didactic Sequence:\n\n1. Present the problem and gather knowledge on the subject;\n" +
                        "2. Analyze the problem variables and propose possible solutions;\n3. Search for new references " +
                        "to qualify the proposals, debate and seek consensus on possible solutions;\n4. " +
                        "Present answers and evaluate results.";

                ABProj.nome = "Project-Based Learning";
                SAI.nome = "Flipped Classroom";
                ABP.nome = "Problem-Based Learning";

                break;
            case Idiomas.PORTUGUES:
                ABProj.descricaoLonga = "O problema do projeto é multidimensional e altamente interativo, uma vez que insere os participantes em " +
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
                        "os resultados - Sala de Aula - Colégio (epílogo)";
                SAI.descricaoLonga = "Na Sala de Aula Invertida, o docente propõe um conteúdo e atividades para serem feitas " +
                        "em casa pelos estudantes, por meio de materiais como vídeos, podcasts ou leitura de textos," +
                        " etc. Após o estudo prévio do tema, os estudantes levam para a sala de aula suas dúvidas, " +
                        "realizam reflexões em grupos e desenvolvem projetos.\n\nNa Sala de Aula Invertida há a " +
                        "possibilidade de concentrar na plataforma ou ambiente virtual as informações necessárias " +
                        "para o decorrer da disciplina ou curso, o que é um grande atrativo desse método.\n\nSequência " +
                        "Didática, na sala de aula:\n1. Explorar o material;\n2. Discutir com o grupo em sala de aula;\n" +
                        "3. Realizar atividades.";
                ABP.descricaoLonga = "Na Aprendizagem Baseada em Problemas (ABP) deve-se atentar para a descrição de um contexto no qual " +
                        "variáveis, sujeitos e situações possam ser claramente identificados pelos estudantes. O problema " +
                        "deve conter as seguintes características:\n\n• Apresentar tema e nível de complexidade compatíveis " +
                        "com o conhecimento prévio dos estudantes;\n• Conter sugestões ou dicas que os estimulem a " +
                        "identificar possíveis pontos de partida;\n• Ser simples e objetivo, para evitar que o grupo " +
                        "desvie a atenção do tema;\n• Mobilizar de forma articulada os elementos de competência.\n\n" +
                        "Sequência Didática:\n\n1. Apresentar o problema e levantar os conhecimentos sobre o assunto;\n" +
                        "2. Analisar as variáveis do problema e propor possíveis soluções;\n3. Buscar novas referências " +
                        "para qualificar as propostas, debater e buscar consenso sobre as possíveis soluções;\n4. " +
                        "Apresentar as respostas e avaliar os resultados.";


                ABProj.nome = "Aprendizagem Baseada em Projetos";
                SAI.nome = "Sala de Aula Invertida";
                ABP.nome = "Aprendizagem Baseada em Problemas";
                break;
            case Idiomas.ESPANHOL:
                ABProj.descricaoLonga = "El problema del proyecto es multidimensional y altamente interactivo, ya que inserta a los participantes en " +
                        "un proceso de investigación estructurado en torno a temas complejos. Ante esto, el gran aporte" +
                        " de esta metodología en el aula radica en el énfasis en el proceso de aprendizaje y la interacción entre " +
                        "estudiantes.\nLos proyectos nos permiten unificar varios aspectos importantes del proceso de aprendizaje: acción " +
                        "liderado por el estudiante, la intencionalidad de esta acción y su inserción en un contexto social. A través de " +
                        "principios de autonomía, investigación, acción y reflexión, el desarrollo de un proyecto parte de la definición de un " +
                        "temática, proponiendo desafíos y planificando y ejecutando estrategias para el cumplimiento de las acciones" +
                        "propuestas.\n\nPara ello, el docente deberá observar los siguientes aspectos:\n• Contenido significativo: relevancia " +
                        "para estudiantes.\n• Preguntas que hagan reflexionar: movilice al grupo para la investigación, presentando diferentes " +
                        "posibilidades de solución.\n• Investigación e innovación: consultar diferentes fuentes especializadas, buscando resultados" +
                        "creativo e innovador.\n• Valorar el proceso: Los aspectos relacionales y cognitivos del proceso son fundamentales " +
                        "para la vida de los estudiantes.\n\n- Secuencia Didáctica\n1. Definir el alcance / Planificar las etapas del proyecto - " +
                        "Aula\n2. Ejecutar las acciones planificadas / Monitorear el desarrollo del proyecto - Ciudad\n3. Presente " +
                        "los resultados - Aula - Colegio (epílogo)";
                SAI.descricaoLonga = "En el Flipped Classroom el profesor propone contenidos y actividades a realizar" +
                        "en casa por parte de los alumnos, a través de materiales como vídeos, podcasts o lecturas de textos" +
                        "etc. Después de estudiar previamente el tema, los estudiantes llevan sus dudas al salón de clases, " +
                        "reflexionan en grupos y desarrollan proyectos.\n\nEn el Flipped Classroom hay " +
                        "posibilidad de concentrar la información necesaria en la plataforma o entorno virtual" +
                        "para el transcurso de la materia o curso, que es un gran atractivo de este método.\n\nSecuencia " +
                        "Didáctica, en el aula:\n1. Explorar el material;\n2. Discutir con el grupo en el aula;\n" +
                        "3. Realizar actividades.";
                ABP.descricaoLonga = "En el Aprendizaje Basado en Problemas (ABP), se debe prestar atención a la descripción de un contexto en el que " +
                        "Las variables, temas y situaciones pueden ser claramente identificadas por los estudiantes. El problema" +
                        "debe contener las siguientes características:\n\n• Presentar tema compatible y nivel de complejidad" +
                        "con el conocimiento previo de los estudiantes;\n• Contiene sugerencias o consejos que los alientan" +
                        "identificar posibles puntos de partida;\n• Sea simple y objetivo, para evitar el grupo" +
                        "desviar la atención del tema;\n• Mover los elementos de competencia de forma articulada.\n\n" +
                        "Secuencia didáctica:\n\n1. Presentar el problema y recopilar conocimientos sobre el tema;\n" +
                        "2. Analizar las variables del problema y proponer posibles soluciones;\n3. Buscar nuevas referencias " +
                        "Calificar propuestas, debatir y buscar consensos sobre posibles soluciones;\n4. " +
                        "Presentar respuestas y evaluar resultados";

                ABProj.nome = "Aprendizaje basado en proyectos";
                SAI.nome = "Aula invertida";
                ABP.nome = "Aprendizaje basado en problemas";
                break;
        }

    }
    public readonly int valor;
    public string nome;
    public string descricao;
    public string descricaoLonga;
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
