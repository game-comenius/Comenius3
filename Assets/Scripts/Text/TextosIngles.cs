using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextosIngles : Textos
{
	public TextosIngles()
	{
		instance = this;
		PreencherTextos();
	}

	protected override void PreencherTextos()
	{
		textos = new string[(int)ChaveTextos._chaveFinal];
        textos[(int)ChaveTextos.PRESSIONE_QUALQUER_BOTAO] = "Press any button";
        textos[(int)ChaveTextos.JOGAR] = "Play";
        textos[(int)ChaveTextos.SOBREOJOGO] = "About the game";
        textos[(int)ChaveTextos.INTRO_METODOLOGIAS_TXT] = "This game has<color=#330BB3> 3 methodologies</color> and you will" +
"\r\n<color=#330BB3>plan a lesson</color> in each of them" +
"<color=#330BB3> using</color><color=#330BB3> " +
"different active methodologies!\r\n </color>\r\n\r" +
"Active methodologies are pedagogical\r\n" +
"strategies that place students at the center\r\n" +
"of the teaching and learning proctipess." +
"\r\n\r\nTeachers act as mediators, guiding and" +
"\r\nmonitoring the interaction processes through which" +
"\r\nlearning develops.\r\n\r\n";
        textos[(int)ChaveTextos.METODOLOGIAS_ATIVAS] = "Active Methodologies";
        textos[(int)ChaveTextos.APRENDIZAGEM_BASEADA_EM_PROBLEMAS] = "Problem-Based Learning (PBL)";

        textos[(int)ChaveTextos.METODOLOGIA] = "<color=#1E0B5C>Methodology 1</color>";
        textos[(int)ChaveTextos.METODOLOGIA2] = "<color=#1E0B5C>Methodology 2</color>";
        textos[(int)ChaveTextos.METODOLOGIA3] = "<color=#1E0B5C>Methodology 3</color>";
        textos[(int)ChaveTextos.TEXT_METODOLOGIA] = "Methodology that starts from a\r\nproblem of adequate complexity for\r\ndevise a suitable solution.";
        textos[(int)ChaveTextos.LABORATORIO] = "LABORATORY";
        textos[(int)ChaveTextos.CONHECA_AS_METODOLOGIAS] = "Discover the methodologies:";
        textos[(int)ChaveTextos.SALA_DE_AULA_INVERTIDA] = "Flipped Classroom (FC)";
        textos[(int)ChaveTextos.TEXT_METODOLOGIA2] = "Methodology in which students study\r\nabout a topic at home and bring their\r\nproduction and questions to discuss with\r\nclass to class.";
        textos[(int)ChaveTextos.QUARTO_DO_ALUNO] = "STUDENT'S ROOM";
        textos[(int)ChaveTextos.SALA_DE_AULAB] = "CLASSROOM";
        textos[(int)ChaveTextos.APRENDIZAGEM_BASEADA_EM_PROJETOS] = "Project-Based Learning (PBL)";

        textos[(int)ChaveTextos.CIDADE] = "CITY";
        textos[(int)ChaveTextos.TEXT_METODOLOGIA3] = "Methodology in which a\r\ntematic project is proposed that must be planned and\r\nexecuted in order to comply with the\r\nproposed actions";

        textos[(int)ChaveTextos.AGORA_E_COM_VOCE] = "<color=#0B355D>Now it's up to you! </color>\r\n";
        textos[(int)ChaveTextos.SELECIONE_UMA_DAS_OPCOES] = "Select one of the options:\r\nDo you want to play the <color=#0B355D>FULL EXPERIENCE?</color>";
        textos[(int)ChaveTextos.OU_METODOLOGIAS_ATIVAS] = "Or <color=#0B355D>ONE OF THE ACTIVE METHODOLOGIES?</color>";
        textos[(int)ChaveTextos.POP_INTRO_2] = "Together we will explore the various\r\nuses of digital media in education.\r\n\r\nYou start the game by choosing your appearance and creating the characteristics of your class, which will be maintained throughout the phases,\r\nserving as the basis of your planning.\r\n\r\nUnder the button = you will find the menu options,\r\nand if you have questions, just click the button\r\n \r\nTo get started, click OK and have fun choosing\r\nyour character and customizing your class!";

        textos[(int)ChaveTextos.PERSONAGEM] = "\r\n<b>Personaje</b>";
        textos[(int)ChaveTextos.ESCOLHA_AVATAR] = "Chose your character.";
        textos[(int)ChaveTextos.ESTE_AVATAR] = "This avatar will represent you in the game, your choice has no impact on the game's gameplay, it is just an aesthetic choice.";
        textos[(int)ChaveTextos.MENU_PRINCIPAL] = "Main menu";
        textos[(int)ChaveTextos.VOLTAR_MENU] = "Return to Menu";
        textos[(int)ChaveTextos.INFORMACOES] = "Information";
        textos[(int)ChaveTextos.SOBRE_O_COMMENIUS_3] = "Game Comenius 3 is a casual, strategy and simulation game that focuses on digital media, active methodologies and multiple intelligences.\r\n      Game Comenius is part of a media education project that investigates how a digital game can teach undergraduate students and teachers at all levels of education to use media in the classroom, to educate “with”, “about” and “ through” them.";
        textos[(int)ChaveTextos.AVALIAR_JOGO] = "Review Game";
        textos[(int)ChaveTextos.PRODUCAO_COORDENACAO] = "<b>Production and Coordination</b>\r\n\r\nDulce Márcia Cruz";
        textos[(int)ChaveTextos.GAME_DESIGN] = "<b>Game Design</b>\r\n\r\nFábio Medeiros\r\nMatheus Leutchuk Cademartori\r\nIsadora Beagle";
        textos[(int)ChaveTextos.ARTE_UI] = "<b>Art and UI</b>\r\n\r\nIndra Rosa da Silva\r\nLucas Emanuel Leite da Rosa Gomes\r\nMaria Antônia Petrassi\r\nNatan Salles Medeiros\r\nVit Duarte";
        textos[(int)ChaveTextos.ARTE_DA_CIDADE] = "<b>City Scenery</b>\r\n\r\nVit Duarte";
        textos[(int)ChaveTextos.PROGRAMACAO] = "<b>Programming</b>\r\n\r\nAlexis Mendes Sequeira\r\nBruno Souza da Silva\r\nNicole Alves Guglielmetti\r\nMatheus Aparicio da Silva\r\nBernardo Gomes Duarte\r\nThéo Floriano dos Santos\r\nEric Fernandes Evaristo\r\nLuccas Baillo Lopes";
        textos[(int)ChaveTextos.PEDAGOGICO] = "<b>Pedagogical</b>\r\n\r\nDenise Figueredo Loch\r\nLucas Souza Pinheiro\r\nRaquel Ferreira da Rosa Oliveira\r\nRicardo Kerscher\r\nJayziela Jessica Fuck\r\nJeremias Martin Calandrini Coelho\r\nVicente Campana Bif";
        textos[(int)ChaveTextos.UX_GESTAO] = "<b>UX, Management and QA</b>\r\n\r\nIsadora Beagle";
        textos[(int)ChaveTextos.CNPG] = "<b>CNPq Financing</b>\r\n\r\nIsadora Beagle";
        textos[(int)ChaveTextos.ESCOLHA_ESTAGIO_APRENDIZAGEM] = "Choose the class's learning stage:";
        textos[(int)ChaveTextos.COM_BASE_ENSINO] = "Based on the level of education, what will be studied?";
        textos[(int)ChaveTextos.QUAL_PERFIL] = "What will be the profile of the students in this class?";
        textos[(int)ChaveTextos.NIVEL_DE_ENSINO] = "<b>Level of education</b>";
        textos[(int)ChaveTextos.CAMPOS_DE_EXPERIENCIA] = "<b>Fields of Experience</b>";
        textos[(int)ChaveTextos.INTELIGENCIAS_MULTIPLAS] = "<b>Multiple Intelligences</b>";
        textos[(int)ChaveTextos.CARACTERISTICAS_DA_TURMA] = "<b>Sheet 1: Class Characteristics</b>";
        textos[(int)ChaveTextos.PERFIL_ESTUDANTES_TURMA] = "What will be the profile of the students in this class?";
        textos[(int)ChaveTextos.SAO_AS_CARACTERISTICAS] = "These are the characteristics of your class! You\r\ncan consult them throughout the game by accessing\r\nthe menu and clicking the \"Your Class\" button.";

        textos[(int)ChaveTextos.CLIQUE_EM_CONFIRMAR] = "Click confirm to start the first phase\r\ngame. If you have changed your mind, click \r\nto change any option.";
        textos[(int)ChaveTextos.DICA_SEUS_ESTUDANTES] = "Your students must be able to consult current information on the topic and then apply what they discovered empirically!";
        textos[(int)ChaveTextos.OLA_SOU_LURDINHA] = "Hello, I'm Lurdinha, I'm a pedagogical coordinator and I'll\r\nhelp you with your planning!\r\n";
        textos[(int)ChaveTextos.AGORA_VOCE] = "Now that you know the challenge of the first methodology, finish your\r\npersonalization with the theme of your class, using the characteristics of the class as a basis:\r\n";
        textos[(int)ChaveTextos.QUAL_SERA_O_TEMA] = "\r\nWhat will be the topic of your class in methodology 1, which will take place in the Laboratory using the Problem-Based Learning Methodology?";
        textos[(int)ChaveTextos.CRIEI_UM_TEMA] = "Create a theme that will guide your planning and appropriate media choices for your class. ";
        textos[(int)ChaveTextos.ESSA_ESCOLHA] = "This choice does not reflect on the score.";
        textos[(int)ChaveTextos.NO_MAXIMO_45] = "(Maximum 45 characters)";
        textos[(int)ChaveTextos.NA_APRENDIZAGEM_BASEADA] = "In Problem-Based Learning (PBL)\r\nattention must be paid to the description of a context in which variables, subjects and situations can be \r\nclearly identified by students\r\n\r\nThe problem must contain the following characteristics:\r\n\r\nPresent a topic and level of complexity\r\ncompatible with the students' prior knowledge;\r\n\r\nContain suggestions or tips that encourage them to\r \nidentify possible starting points;\r\n\r\nBe simple and objective, to prevent the group\r\n from diverting attention from the topic;\r\n\r\nMobilize the elements in an articulated way of \r\ncompetence.\r\n";
        textos[(int)ChaveTextos.APRENSENTAR_O_PROBLEMA] = "1. Present the problem and gather \r\nknowledge about the subject;\r\n2.Analyze the problem variables and\r\npropose possible solutions;\r\n3. Search for new references to qualify\r\nthe proposals, debate and seek consensus\r\non possible solutions";
        textos[(int)ChaveTextos.SEQUENCIA_DIDATICA] = "FOLLOWING TEACHING:";
        textos[(int)ChaveTextos.PRIMEIRO_MOMENTO] = "1st Moment";
        textos[(int)ChaveTextos.SEGUNDO_MOMENTO] = "2nd Moment";
        textos[(int)ChaveTextos.QUARTO_APRESENTAR] = "4. Present the answers and evaluate the results";
        textos[(int)ChaveTextos.ESPACO_DE_APRENDIZAGEM] = "<b>Learning Space</b>";
        textos[(int)ChaveTextos.SUA_AULA_ACONTECERA] = "Your class will take place in the space:";
        textos[(int)ChaveTextos.DURANTE_O_MOMENTO] = "During the class you will answer quizzes about your class, methodology and the media chosen below!\r\n";
        textos[(int)ChaveTextos.VOCE_IRA_JOGAR_UMA_AULA] = "You will play a Higher Education class on Linguistics, Literature and Arts with a Linguistics and Logical-Mathematics profile class";
        textos[(int)ChaveTextos.NA_SEQUENCIA_DA_APRENDIZAGEM] = "Following Problem-Based Learning, the class is designed in two moments where students will:";
        textos[(int)ChaveTextos.APRESENTAR_O_PROBLEMA] = "Present the problem and raise knowledge about the subject";
        textos[(int)ChaveTextos.APRESENTAR_AS_RESPOSTAS] = "Present the answers and evaluate the results";
        textos[(int)ChaveTextos.ESCOLHA_AS_MIDIAS] = "Choose the appropriate media for these objectives!";
        textos[(int)ChaveTextos.MIDIAS_PRIMEIRO_MOMENTO] = "<b>Medias - First moment</b>";
        textos[(int)ChaveTextos.ESCOLHA_DUAS_MIDIAS] = "Choose the two media that will be used in the classroom";
        textos[(int)ChaveTextos.POPULAR] = "<style=\"title\">Popular</style>\r\n\r\nThese are media widely used outside of school, both for information and conversation. \r\n Strategies that include debate, the retrieval of prior knowledge and the contextualization of school knowledge with reality can take advantage of popular media.";
        textos[(int)ChaveTextos.PRODUCAO] = "<style=\"title\">Production</style>\r\n\r\nMedia that allow the student to make, create, develop, construct, assemble, invent, or that is, having authorship, building and organizing knowledge during activities. Activities that generate products, whether in the form of exercises, writing in different languages, schemes for understanding or prototypes, are teaching strategies that use production media.";
        textos[(int)ChaveTextos.CONSULTA] = " <style=\"title\">Consultation</style>\r\n\r\nThese are media used to consult students about school content. They support all types of search for information and help inform decision-making and deepen knowledge. All activities that involve research, reading, compilation and analysis of data will generally require consultation media.";
        textos[(int)ChaveTextos.EXPOSICAO] = "<style=\"title\">Exhibition</style>\r\n\r\nMedia used to present content, both by teachers and students. The presentation of ideas or problems, of work carried out, the explanation of specific themes and the dissemination of results and reflections are strategies that benefit from exposure media.";
        textos[(int)ChaveTextos.DIGITAL] = "<style=\"title\">Digital</style>\r\n\r\nDigital media are the most current. Their development accelerated in the 21st century. They have the following The processing of data is based on different physical media (equipment such as computer, video game, notebook, tablet, cell phone, etc.) but also virtual media such as applications (programs that allow recording, editing and sharing of texts, images and sounds. These are the media). of digital and participatory culture, collective intelligence and cyberspace. Its main characteristics are interactivity, ubiquity (being everywhere), speed, virtuality and are generally used from an interface. sharing, storing and converting data in projects that support the internet, online or offline communication such as graphic productions, video games, audiovisual or hypertextual content, etc. Your content can be reproduced, remixed and reused without loss of quality, o. which guarantees a dynamic and multimedia workflow, favoring interdisciplinarity and integration between different media.";
        textos[(int)ChaveTextos.TRADICIONAL] = "<style=\"title\">Traditional</style>\r\n\r\nTraditional media are those considered the basis of school education and make up the \"classroom standard classes\" in the imagination of Western society for centuries. They are present in all educational spaces and it is considered that teachers know how to plan with them through the experience lived in their own training. Their support is material and physical and can be on paper (notebooks , posters or photos), on printed paper (book, newspapers and magazines), or fixed in the classroom, such as a chalk board.";
        textos[(int)ChaveTextos.AUDIO_VISUAL] = "<style=\"title\">Audiovisual</style>\r\n\r\nAudiovisual media are the generation of media that dominated the 20th century. They are those of communication mass media, which reached large audiences and used image and sound as the basis of their language, like cinema, radio and television, and the equipment was expensive, large and professional. Therefore, these media were part of large communication companies and were professional. their products were received locally, via antennas, cables or directly on films, cassette tapes, CDs or DVDs. The products were consumed in their entirety (programs) and few people used them, such as cassette tapes or CD/DVD.";
        textos[(int)ChaveTextos.CONFIRA_SE_SUA_ESCOLHA] = "Check if your choice is the best option for this objective!";
        textos[(int)ChaveTextos.AREA_DE_CONHECIMENTO] = "Knowledge Areas";
        textos[(int)ChaveTextos.FICHA_DOIS] = "<b>Ficha 2: Planning</b>";
        textos[(int)ChaveTextos.SALA_DE_AULA] = "Your students must be able to consult\r\n current information on the topic and then apply what they discovered empirically!\r\n";
        textos[(int)ChaveTextos.REVISE_AS_CARACTERISTICAS] = "Review the characteristics of your class and planning by clicking on the notepad before moving on to the last step, where a quiz will test your knowledge and we will find out what the students thought of your class !";
        textos[(int)ChaveTextos.SUA_AULA] = "Your class will be taught in the laboratory using the Problem-Based Learning (PBL) methodology with the media [...] and [...].";
        textos[(int)ChaveTextos.CONFIRMAR] = "CONFIRM";
        textos[(int)ChaveTextos.NASA_SALA_INVERTIDA] = "In a Flipped Classroom, there is the possibility of concentrating the necessary information for the course or subject on the platform or virtual environment, which is a great attraction of this method.";
        textos[(int)ChaveTextos.SEQUENCIA_DICATICA2] = "Didactic Sequence, in the classroom:\r\n\r\n1. Explore the material\r\n\r\n2. Discuss with the group in the classroom\r \n\r\n3. Carry out activities";
        textos[(int)ChaveTextos.NA_SALA_DE_AULA_INVERTIDA_DOCENTE] = "In the Flipped Classroom, the teacher proposes content and activities to be done at home by students, through materials such as videos, podcasts or reading texts, etc. After studying prior to the topic, students take their doubts to the classroom, reflect in groups and develop projects.";
        textos[(int)ChaveTextos.MIDIAS_QUARTO] = "<b>Media - Bedroom</b>";
        textos[(int)ChaveTextos.NA_SEQUENCIA] = "Following the <b>Flipped Classroom</b>, this is the moment when students will:";
        textos[(int)ChaveTextos.MIDIAS_SALA] = "<b>Media - Classroom</b>";
        textos[(int)ChaveTextos.CONHECER_SALA_INVERTIDA] = "Let's learn a little more about the Flipped Classroom?";
        textos[(int)ChaveTextos.QUARTO_ESTUDANTE] = "STUDENT ROOM";
        textos[(int)ChaveTextos.NO_MOMENTO] = "During the class you answer questions about your class, methodology and the methods chosen next!";
        textos[(int)ChaveTextos.NO_MOMENTO_DO_QUARTO] = "In the room you interact as a student using objects to carry out activities!";
        textos[(int)ChaveTextos.FICHA_2_RESUMO_2] = "<b>Summary Sheet 2: Lesson Planning</b>";
        textos[(int)ChaveTextos.LOGO_APOS] = "Soon after, a quiz will test your knowledge and we will find out what the students thought of your class! Good luck!";
        textos[(int)ChaveTextos.QUAL_SERA_O_SEU] = "What will be your project in methodology 3, which will take place in \r\nthe city using the Project-Based Learning Methodology?\r\n";
        textos[(int)ChaveTextos.DESEJA_REALMENTE] = "Do you really want to return to the main menu?";
        textos[(int)ChaveTextos.SIM] = "YES";
        textos[(int)ChaveTextos.NAO] = "NO";
        textos[(int)ChaveTextos.O_PROBLEMA_DO_PROJETO] = "The project problem is multidimensional and highly interactive, as it inserts participants into an investigation process structured around complex issues. Given this, the great contribution of this methodology in the classroom class lies in the emphasis on the learning process and the interaction between students.\r\n\r\n\r\nThe projects allow to unify several important aspects of the learning process: the action carried out by the student, the intentionality of this action and its insertion into a social context.\r\n";

        textos[(int)ChaveTextos.POR_MEIO] = "Through the principles of autonomy, research, action and reflection, the development of a project starts from defining a theme, proposing challenges and planning and executing strategies for compliance of the proposed actions.\r\n\r\nTo this end, the teacher must observe the following aspects: \r\n\r\n• Significant content: relevance for students.\r\n\r\n• Thought-provoking questions : mobilize the group for research, presenting different solution possibilities. \r\n\r\n• Research and innovation: consult different specialized sources, seeking creative and innovative results. : Relational and cognitive aspects of the process are fundamental to students' lives ";
        textos[(int)ChaveTextos.A_SEQUENCIA_DIDATICA] = "The didactic sequence in project-based learning can be divided into three moments:\r\n\r\n• <b>Define the scope</b>, Plan the stages of project: is the planning, done not only in advance, but during the first classes, with the participation of students.\r\n\r\n• <b>Execute the planned actions</b>, Monitor the development of the project : This is the time to practice and execute the project, which must be carried out by the students and monitored by the teacher \r\n\r\n• <b>Present the results</b>: Back in the classroom, now. students must present their analyzes and results.";
        textos[(int)ChaveTextos.NO_MOMENTO_DA_CIDADE] = "At the time of the city you interact with students, providing support for their research.";
        textos[(int)ChaveTextos.NO_MOMENTO_AULA] = "At the time of class you answer quizzes about your class, methodology and the media chosen to follow!";
        textos[(int)ChaveTextos.NA_SEQUENCIA_PROJETOS] = "Following Project-Based Learning,\r\n these will be the moments that students will experience";
        textos[(int)ChaveTextos.DEFINIR_ESCOPO] = "Define the scope, Plan\r\n the project stages";
        textos[(int)ChaveTextos.APRESENTAR_RESULTADOS] = "Show the results";
        textos[(int)ChaveTextos.TERCEIRO_MOMENTO] = "Third moment";
        textos[(int)ChaveTextos.EXERCUTAR_ACOES] = "Execute the planned actions,\r\nMonitor the development of the project";
        textos[(int)ChaveTextos.RELEMBRAR_CARACTERISTICAS] = "Remembering the characteristics of the class:";
        textos[(int)ChaveTextos.SEMPRE_QUE_POSSIVEL] = " Whenever possible, in this methodology, start from the\r\n students' interest, from a guiding question, from a real problem. Talk\r\nwith the students so that they find motivation, relevance and meaning.\r\n";
        textos[(int)ChaveTextos.DICA] = "Tip:";
        textos[(int)ChaveTextos.VAMOS_PARA_TERCEIRA] = "Shall we go to the third methodology? \r\nNow you must choose a theme for your last class in the game!";
        textos[(int)ChaveTextos.CARACTERISTICAS_TURMA] = "Characteristics of the Class";
        textos[(int)ChaveTextos.MIDIAS] = "Media";
        textos[(int)ChaveTextos.TEMA] = "Theme";
        textos[(int)ChaveTextos.CAMPOS_DE_APRENDIZAGEM] = "Learning Field";
        textos[(int)ChaveTextos.METODOLOGIA_SIMPLES] = "Methodology";
        textos[(int)ChaveTextos.LABORATORIO_1] = "Laboratory - Media 1";
        textos[(int)ChaveTextos.LABORATORIO_2] = "Laboratory - Media 2";
        textos[(int)ChaveTextos.SUA_AULA_ACABOU] = "Your class is over!";
        textos[(int)ChaveTextos.ESTUDANTES_IRAO_REAGIR] = "Students will react to your choice of media and a quiz will test their knowledge. You can check the progress of the class in the bar on the right and your score in the top bar. Good Luck!\r\n";
        textos[(int)ChaveTextos.FINALIZOU_ABP] = "You have completed the Problem-Based Learning Methodology";
        textos[(int)ChaveTextos.CONTINUAR] = "Continue";
        textos[(int)ChaveTextos.JOGAR_NOVAMENTE] = "Play again";
        textos[(int)ChaveTextos.VOLTAR_PARA_O_MENU] = "Return to the selection menu";
        textos[(int)ChaveTextos.PARABENS] = "CONGRATULATIONS!";
        textos[(int)ChaveTextos.AGORA_ESCOLHA_COMO_CONTINUAR] = "Now choose how to continue:";
        textos[(int)ChaveTextos.NESTE_MOMENTO_DO_JOGO] = "At this point in the game you answer quiz questions related to your choices, and this will define your score! The comments made by students about the media are related to how useful they are in the methodology Problem-Based Learning (PBL). The class ends when the class duration bar is full.";
        textos[(int)ChaveTextos.DESEJA_REALMENTE_VOLTAR] = "Do you really want to return to the main menu?";
        textos[(int)ChaveTextos.SUA_TURMA] = "Your class";
        textos[(int)ChaveTextos.FIQUE_ATENTO] = "Pay attention to the students, they may need your help.";
        textos[(int)ChaveTextos.ESTUDANTE] = "Student";
        textos[(int)ChaveTextos.MIDIAS_ESPACO_DE_ENSINO] = "<b>Media - Teaching space</b>";
        textos[(int)ChaveTextos.ESCOLHAS_AS_DUAS_MIDIAS] = "Choose the two media that will be used in the classroom";
        textos[(int)ChaveTextos.AGORA_OS_ESTUDANTES] = "Now the students will react to your class topic\r\nGood Luck!\r\n The class topic is: " + EstadoDoJogo.Instance.Tema;
        textos[(int)ChaveTextos.COM_ESSA_INFORMACAO] = "With this information, continue your planning!";
        textos[(int)ChaveTextos.OS_ESTUDANTES_TROUXERAM] = "The students brought the tasks they carried out at home.\r\nNow a quiz will test their knowledge and in addition to\r\nddiscovering the students' reaction to their choice of media,\r\n You will help them with unforeseen situations in the classroom.\r\nGood Luck!\r\n";
        textos[(int)ChaveTextos.AGRUPAMENTOS] = "Groups";
        textos[(int)ChaveTextos.AGRUPAMENTOS_1] = "Groupings 1";
        textos[(int)ChaveTextos.AGRUPAMENTOS_2] = "Groupings 2";
        textos[(int)ChaveTextos.QUARTO_MIDIA_1] = "Room - Media 1";
        textos[(int)ChaveTextos.QUARTO_MIDIA_2] = "Room - Media 2";
        textos[(int)ChaveTextos.SALA_MIDIA_1] = "Room - Media 1";
        textos[(int)ChaveTextos.SALA_MIDIA_2] = "Room - Media 2";
        textos[(int)ChaveTextos.AGORA_VOCE_ESTA] = "Now you are in the role of the student, the profile of your class\r\nmust influence leisure activities and the objects must\r\nrelate to the media selected in your planning .";
        textos[(int)ChaveTextos.HORA_DE_ESTUDAR] = "Time to study!";
        textos[(int)ChaveTextos.VOU_FAZER_AS_TAREFAS] = "I'm going to do the tasks for class but\r\nfirst I'm going to enjoy my free time\r\nand have a little fun!";
        textos[(int)ChaveTextos.VOCE_CONCLUIU] = "I'm going to do the homework for class but\r\nfirst I'm going to enjoy my free time\r\nand have a little fun!";
        textos[(int)ChaveTextos.TERMINEI_TUDO] = "I finished everything, that's good! Now it's time to go to school.";
        textos[(int)ChaveTextos.ESCREVA_AQUI] = "Write here";
        textos[(int)ChaveTextos.ESCOLHA_AS_MIDIAS_ADEQUADAS] = "Choose the appropriate media";
        textos[(int)ChaveTextos.EXPLORANDO_SOBRE_O_TEMA] = "Exploring the topic at home, students\r\n better organize ideas actively in the classroom, creating\r\n knowledge and presenting what they learned to colleagues!";
        textos[(int)ChaveTextos.ESCOLHA_O_AGRUPAMENTO] = "Choose grouping";
        textos[(int)ChaveTextos.ESPERE_NA_AB] = "Wait! At ABProj, you can’t plan without listening to your students!\r\n\r\nTo choose the media used in the city, present your proposal for the project to the students, and find out where in the city they prefer to carry it out!";
        textos[(int)ChaveTextos.FICHA_NUMERO_2] = "<b>Summary Sheet 2: Lesson Planning</b>";
        textos[(int)ChaveTextos.QUIZ] = "Quiz";
        textos[(int)ChaveTextos.AULA_COMUM] = "Common Class";
        textos[(int)ChaveTextos.AULA_CONFUSA] = "Confused class";
        textos[(int)ChaveTextos.AULA_REVELADO] = "Revealing class";
        textos[(int)ChaveTextos.DISCUTIR_COM_O_GRUPO] = "Discuss with the group in the classroom";
        textos[(int)ChaveTextos.REALIZAR_ATIVIDADES] = "Carry out activities";
        textos[(int)ChaveTextos.POSITIVE_PRE_FIX] = "I had a lot of fun";
        textos[(int)ChaveTextos.NEGATIVE_PRE_FIX] = "I didn't have much fun, for me.";
        textos[(int)ChaveTextos.TIVE_DIFICULDADE_PARA_FAZER_AS_TAREFAS] = "<color=red>I had difficulty doing the tasks with";
        textos[(int)ChaveTextos.E] = "and";
        textos[(int)ChaveTextos.CONSEGUI_FAZER_AS_ATIVIDADES] = "I was able to do the activities with ";
        textos[(int)ChaveTextos.MAS_TIVE_DIFICULDADES] = "<color=red>but I had difficulty doing other tasks with";
        textos[(int)ChaveTextos.VOCE_CONCLUIU_A_PRIMEIRA_PARTE] = "You have completed the first part of this methodology! Now your planning will continue in the classroom!";
        textos[(int)ChaveTextos.FINALIZOU_INVERTIDA] = "You have completed the Flipped Classroom Methodology";
        textos[(int)ChaveTextos.ESTAMOS_CHEGANDO] = "We are reaching the end of the project! After a long time of planning, visiting and dedicating themselves to the activities, the students will present their conclusions and results! \r\nIt's beautiful to see all this work taking shape!";
        textos[(int)ChaveTextos.VOCE_FINALIZOU_ABPJ] = "You have completed the Project-Based Methodology";
        textos[(int)ChaveTextos.AGORA_VOCE_RESPONDERA] = "Now you will answer a quiz and prepare to carry out the project in the city!";
        textos[(int)ChaveTextos.NESTE_MOMENTO] = "At this point in the game you answer quiz questions related to your choices, and this will define your score! The comments made by students about the media are related to how useful they are in the Problem-Based Learning (PBL) methodology. The class ends when the class duration bar is full.";
        textos[(int)ChaveTextos.JOGOS] = "At this point in the game you answer quiz questions related to your choices, and this will define your score! The comments made by students about the media are related to how useful they are in the Problem-Based Learning (PBL) methodology. The class ends when the class duration bar is full.";
        textos[(int)ChaveTextos.APPS_DE_GAMIFICACAO] = "<style=\"title\">Educational Content Gamification Apps</style>\r\n\r\nGamification consists of using game tools and elements in a non-game context. Gamified content applications make studying a challenge, a pleasurable practice that takes advantage of the characteristics of games to create an environment conducive to learning. An application with math or language exercises can award points and demarcate the user's achievements with badges and milestones that demonstrate the entire journey and achievements so far.";
        textos[(int)ChaveTextos.EDITORES_DE_AUDIO] = "<style=\"title\">Audio and Video Editors</style>\r\n\r\nAudio and video editing software are tools that encourage research in the classroom, because when producing with these media we can encourage reflection on different themes, creativity and teamwork. Many of these software programs feature a set of versatile, dynamic and easy-to-learn tools. To make their videos or audios, students need to exercise interaction, interactivity and think of different and dynamic ways of transmitting what they want to say and gaining the attention of their colleagues, in this way they build knowledge in collaboration, using this technological resource. Furthermore, audiovisual production is both a language and an important skill for the demands of the 21st century.";
        textos[(int)ChaveTextos.COMPARTILHAMENTO_DE_AUDIOS] = "<style=\"title\">Audio and sound sharing</style>\r\n\r\nImage and sound sharing social networks enable users to share and search for images and videos. Make comments and interact with other people, establishing professional or personal contacts.";
        textos[(int)ChaveTextos.COMPARTILHAMENTO_DE_OPINIOS] = "<style=\"title\">Opinion Sharing</style>\r\n\r\nOpinion social networks are characterized by sharing and searching for information on various topics. As well as the exchange of photos and videos that generate relationship networks and connect people.";
        textos[(int)ChaveTextos.CONEXOES_INTERPESSOAIS] = "<style=\"title\">Interpersonal Connections</style>\r\n\r\nSocial networks of interpersonal connections aim to create relationship networks. They make it possible to send instant messages. In addition to allowing the user to share and seek professional knowledge.";
        textos[(int)ChaveTextos.COMUNICACAO] = "<style=\"title\">Communication</style>\r\n\r\nCommunication platforms, through the data network, provide a set of functionalities that make real-time communication between two or more people possible , collecting, organizing and making information available for consultations and interactions. It is possible to have meetings, meetings and classes virtually.";
        textos[(int)ChaveTextos.ARMAZENAMENTO] = "<style=\"title\">Storage</style>\r\n\r\nStorage platforms guarantee access to images, videos, audios, texts, spreadsheets and any digital file anywhere that has internet access. It is possible to share, manage and use the same file by more than one person, updating changes in real time.";
        textos[(int)ChaveTextos.GERENCIAMENTO] = "<style=\"title\">Management</style>\r\n\r\nManagement platforms allow teamwork to develop projects, plan and execute classes.";
        textos[(int)ChaveTextos.NA_SEQUENCIA_DA_APRENDIZAGEM_BASEADA_EM_PROJETOS] = "Following <b>Project-Based Learning</b>, \r\nThese will be the moments in which students will experience";
        textos[(int)ChaveTextos.OBSERVE_SE_SUA_ESCOLHA] = "See if your choice is the best option for these objectives!";
        textos[(int)ChaveTextos.PEGUE_DENTRO_DO_ARMARIO] = "<b>Take media from the closet to use in the city</b>";
        textos[(int)ChaveTextos.SUA_AULA_LAB] = "Your class will take place in the LABORATORY";
        textos[(int)ChaveTextos.DESBLOQUEOU_ABP] = "You have unlocked the active methodology of";
        textos[(int)ChaveTextos.SUA_AULA_QUARTO] = "Your class will take place in the STUDENT'S BEDROOM and in the CLASSROOM.";
        textos[(int)ChaveTextos.SUA_AULA_CIDADE] = "Your class will take place in the CITY and in the CLASSROOM";
        textos[(int)ChaveTextos.PARA_COMECAR] = "To start:";
        textos[(int)ChaveTextos.PRONTO] = "READY";
        textos[(int)ChaveTextos.ESCOLHA_DO_TEMA] = "Choice of theme";
        textos[(int)ChaveTextos.TEMA] = "Theme";
        textos[(int)ChaveTextos.EXPLORAR_O_MATERIAL] = "Explore the material";
        textos[(int)ChaveTextos.CLIQUE_NOS_OBJETOS] = "Click on the objects in the scene to select them, combining them with your multiple intelligence and media choices for the activities that will be done at home";
        textos[(int)ChaveTextos.SITE_COMENIUS] = "comenius Website";
        textos[(int)ChaveTextos.JOGAR_COMENIUS_2] = "Play comenius 1";
        textos[(int)ChaveTextos.JOGAR_COMENIUS_3] = "Play comenius 2";
        textos[(int)ChaveTextos.JOGAR_COMENIUS_2_COSTUMIZAVEIS] = "Play comenius 2 customizable";
        textos[(int)ChaveTextos.CREDITOS] = "Credits";
        textos[(int)ChaveTextos.AQUI_VC_REVISA] = "Here you review and confirm your lesson plan. Then a quiz will start about your choices. If you prefer, you can change your plan by clicking on the arrow located in the top tab.\r\n";
        textos[(int)ChaveTextos.A_AULA_TERMINA] = "At this point in the game you answer quiz questions related to your choices, and this will define your score! The comments made by students about the media are related to how useful they are in the Problem-Based Learning (PBL) methodology. The class ends when the class duration bar is full.";


    }

}
