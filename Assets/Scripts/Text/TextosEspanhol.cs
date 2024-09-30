using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextosEspanhol : Textos
{
	public TextosEspanhol()
	{
		instance = this;
		PreencherTextos();
	}

	protected override void PreencherTextos()
	{
		textos = new string[(int)ChaveTextos._chaveFinal];
        textos[(int)ChaveTextos.PRESSIONE_QUALQUER_BOTAO] = "Pressione qualquer bot�o";
        textos[(int)ChaveTextos.JOGAR] = "Jugar";
        textos[(int)ChaveTextos.SOBREOJOGO] = "Sobre el juego";
        textos[(int)ChaveTextos.INTRO_METODOLOGIAS_TXT] = "Este juego tiene <color=#330BB3> 3 metodolog�as</color> y t�" +
"\r\n<color=#330BB3>planifica una lecci�n</color> en cada uno de ellos" +
"<color=#330BB3> usando </color><color=#330BB3> " +
"�diferentes metodolog�as activas!\r\n </color>\r\n\r" +
"Las metodolog�as activas son estrategias\r\n" +
"pr�cticas pedag�gicas que tienen a los estudiantes como\r\n" +
"centro del proceso de ense�anza y aprendizaje" +
"\r\n\r\nLos profesores median, orientan y" +
"\r\nasiguiendo los procesos de interacci�n en los que" +
"\r\nel aprendizaje se desarrolla.\r\n\r\n";
        textos[(int)ChaveTextos.METODOLOGIAS_ATIVAS] = "Metodolog�as Activas:";
        textos[(int)ChaveTextos.APRENDIZAGEM_BASEADA_EM_PROBLEMAS] = "Aprendizaje Basado en Problemas (ABP)";

        textos[(int)ChaveTextos.METODOLOGIA] = "<color=#1E0B5C>Metodolog�a 1</color>";
        textos[(int)ChaveTextos.METODOLOGIA2] = "<color=#1E0B5C>Metodolog�a 2</color>";
        textos[(int)ChaveTextos.METODOLOGIA3] = "<color=#1E0B5C>Metodolog�a 3</color>";
        textos[(int)ChaveTextos.TEXT_METODOLOGIA] = "Metodolog�a que parte de un\r\nproblema de complejidad adecuada para\r\ncrear una soluci�n adecuada.";
        textos[(int)ChaveTextos.LABORATORIO] = "LABORATORIO";
        textos[(int)ChaveTextos.CONHECA_AS_METODOLOGIAS] = "Descubre las metodolog�as:";
        textos[(int)ChaveTextos.SALA_DE_AULA_INVERTIDA] = "Aula invertida (AI)";
        textos[(int)ChaveTextos.TEXT_METODOLOGIA2] = "Metodolog�a en la que los estudiantes estudian \r\n un tema en casa y traen su\r\nproducci�n y dudas para discutir con la\r\nclase";
        textos[(int)ChaveTextos.QUARTO_DO_ALUNO] = "HABITACI�N DE ESTUDIANTES";
        textos[(int)ChaveTextos.SALA_DE_AULAB] = "AULA";
        textos[(int)ChaveTextos.APRENDIZAGEM_BASEADA_EM_PROJETOS] = "Aprendizaje en base a proyectos (ABPj)";

        textos[(int)ChaveTextos.CIDADE] = "CIUDAD";
        textos[(int)ChaveTextos.TEXT_METODOLOGIA3] = "Metodolog�a en la que\r\nse plantea un proyecto \r\n tem�tico que se debe  planificar y\r\n ejecutar para dar cumplimiento a las\r\nacciones propuestas";

        textos[(int)ChaveTextos.AGORA_E_COM_VOCE] = "<color=#0B355D>�Ahora les toca decidir a ustedes! </color>\r\n";
        textos[(int)ChaveTextos.SELECIONE_UMA_DAS_OPCOES] = "Selecciona una de las opciones:\r\n�Quieres jugar la <color=#0B355D>EXPERIENCIA COMPLETA?</color>";
        textos[(int)ChaveTextos.OU_METODOLOGIAS_ATIVAS] = "�O <color=#0B355D>UNA DE LAS METODOLOG�AS ACTIVAS?</color>";
        textos[(int)ChaveTextos.POP_INTRO_2] = "Juntos exploraremos los diversos\r\nUsos de los medios digitales en la educaci�n.\r\n\r\nComienzas el juego eligiendo tu apariencia y creando las caracter�sticas de tu clase, que se mantendr�n a lo largo de las fases.\r\nsirviendo como base de su planificaci�n.\r\n\r\nDebajo del bot�n = encontrar�s las opciones del men�,\r\ny si tienes preguntas, simplemente haz clic en el bot�n: ?\r\n \r\nPara comenzar, haga clic en Aceptar y divi�rtase eligiendo\r\n�Tu personaje y personaliza tu clase!";

        textos[(int)ChaveTextos.PERSONAGEM] = "<b>Personaje</b>";
        textos[(int)ChaveTextos.ESCOLHA_AVATAR] = "Elige tu avatar de clase.";
        textos[(int)ChaveTextos.ESTE_AVATAR] = "Este avatar te representar� en el juego, tu elecci�n no tiene ning�n impacto en la jugabilidad del juego, es s�lo una elecci�n est�tica.";
        textos[(int)ChaveTextos.MENU_PRINCIPAL] = "Men� principal";
        textos[(int)ChaveTextos.VOLTAR_MENU] = "Volver al men�";
        textos[(int)ChaveTextos.INFORMACOES] = "Informaci�n";
        textos[(int)ChaveTextos.SOBRE_O_COMMENIUS_3] = "Game Comenius 3 es un juego casual, de estrategia y simulaci�n que apuesta por los medios digitales, las metodolog�as activas y las inteligencias m�ltiples.\r\n      Game Comenius es parte de un proyecto de educaci�n en medios que investiga c�mo un juego digital puede ense�ar a estudiantes universitarios y profesores de todos los niveles educativos a utilizar los medios en el aula, a educar �con�, �sobre� y �a trav�s� de ellos.";
        textos[(int)ChaveTextos.AVALIAR_JOGO] = "Califica el juego";
        textos[(int)ChaveTextos.PRODUCAO_COORDENACAO] = "<b>Producci�n y Coordinaci�n</b>\r\n\r\nDulce Marcia Cruz";
        textos[(int)ChaveTextos.GAME_DESIGN] = "<b>Dise�o de juegos</b>\r\n\r\nF�bio Medeiros\r\nMatheus Leutchuk Cademartori\r\nIsadora Beagle";
        textos[(int)ChaveTextos.ARTE_UI] = "<b>Arte y interfaz de usuario</b>\r\n\r\nIndra Rosa da Silva\r\nLucas Emanuel Leite da Rosa Gomes\r\nMar�a Ant�nia Petrassi\r\nNatan Salles Medeiros\r\nVit Duarte";
        textos[(int)ChaveTextos.ARTE_DA_CIDADE] = "<b>Paisaje de la ciudad</b>\r\n\r\nVit Duarte";
        textos[(int)ChaveTextos.PROGRAMACAO] = "<b>Programaci�n</b>\r\n\r\nAlexis Mendes Sequeira\r\nBruno Souza da Silva\r\nNicole Alves Guglielmetti\r\nMatheus Aparicio da Silva\r\nBernardo Gomes Duarte\r\nTh�o Floriano dos Santos\r\nEric Fernandes Evaristo\r\nLuccas Baillo Lopes";
        textos[(int)ChaveTextos.PEDAGOGICO] = "<b>Pedag�gico</b>\r\n\r\nDenise Figueredo Loch\r\nLucas Souza Pinheiro\r\nRaquel Ferreira da Rosa Oliveira\r\nRicardo Kerscher\r\nJayziela Jessica Mierda\r\nJerem�as Mart�n Calandrini Coelho\r\nVicente Campana Bif";
        textos[(int)ChaveTextos.UX_GESTAO] = "<b>UX, Gesti�n y Control de Calidad</b>\r\n\r\nIsadora Beagle";
        textos[(int)ChaveTextos.CNPG] = "<b>Financiamiento CNPq</b>\r\n\r\nIsadora Beagle";
        textos[(int)ChaveTextos.ESCOLHA_ESTAGIO_APRENDIZAGEM] = "Elige la etapa de aprendizaje de la clase:";
        textos[(int)ChaveTextos.COM_BASE_ENSINO] = "Seg�n el nivel de estudios �qu� se estudiar�?";
        textos[(int)ChaveTextos.QUAL_PERFIL] = "�Cu�l ser� el perfil de los estudiantes de esta clase?";
        textos[(int)ChaveTextos.NIVEL_DE_ENSINO] = "<b>Nivel de educaci�n</b>";
        textos[(int)ChaveTextos.CAMPOS_DE_EXPERIENCIA] = "<b>Campos de experiencia</b>";
        textos[(int)ChaveTextos.INTELIGENCIAS_MULTIPLAS] = "<b>Inteligencias multiples</b>";
        textos[(int)ChaveTextos.CARACTERISTICAS_DA_TURMA] = "<b>Hoja 1: Caracter�sticas de Clase</b>";
        textos[(int)ChaveTextos.PERFIL_ESTUDANTES_TURMA] = "�Cu�l ser� el perfil de los estudiantes de esta clase?";
        textos[(int)ChaveTextos.SAO_AS_CARACTERISTICAS] = "�Estas son las caracter�sticas de tu clase! Puedes consultarlos durante el juego accediendo\r\nal men� y haciendo clic en el bot�n \"Tu pandilla\".";

        textos[(int)ChaveTextos.CLIQUE_EM_CONFIRMAR] = "Haz clic en confirmar para iniciar la primera fase\r\ndel juego. Si has cambiado de opini�n, haz clic en \r\npara cambiar cualquier opci�n.";
        textos[(int)ChaveTextos.DICA_SEUS_ESTUDANTES] = "Sus estudiantes deben poder consultar\r\n informaci�n actual sobre el tema y luego aplicar lo que descubrieron emp�ricamente!\r\n";
        textos[(int)ChaveTextos.OLA_SOU_LURDINHA] = "Hola, soy Lurdinha, soy coordinadora pedag�gica y\r\n te ayudo con tu planificaci�n!\r\n";
        textos[(int)ChaveTextos.AGORA_VOCE] = "Ahora que conoces el desaf�o de la primera metodolog�a, finaliza tu\r\npersonalizaci�n con la tem�tica de tu clase, tomando como base las caracter�sticas de la clase:\r\n";
        textos[(int)ChaveTextos.QUAL_SERA_O_TEMA] = "\r\n�Cu�l ser� el tema de su clase de metodolog�a 1, que se llevar� a cabo en el Laboratorio utilizando la Metodolog�a de Aprendizaje Basado en Problemas?";
        textos[(int)ChaveTextos.CRIEI_UM_TEMA] = "Crea un tema que guiar� tu planificaci�n y elecci�n de medios apropiados para tu clase.";
        textos[(int)ChaveTextos.ESSA_ESCOLHA] = "Esta elecci�n no se refleja en la puntuaci�n.";
        textos[(int)ChaveTextos.NO_MAXIMO_45] = "(M�ximo 45 caracteres)";
        textos[(int)ChaveTextos.NA_APRENDIZAGEM_BASEADA] = "En el Aprendizaje Basado en Problemas (ABP)\r\nse debe prestar atenci�n a la descripci�n de un contexto en el que las variables, temas y situaciones puedan ser \r\nidentificadas claramente por los estudiantes\r \n\r\nEl problema debe contener las siguientes caracter�sticas:\r\n\r\n* Presentar un tema y nivel de complejidad\r\ncompatible con\r\nlos conocimientos previos de los estudiantes;\r\n\r\n *Contener sugerencias o consejos que los alienten a\r\nidentificar posibles puntos de partida;\r\n\r\n* Ser simple y objetivo, para evitar que el grupo\r\ndesv�e la atenci�n del tema;\r\n \r\n* Movilizar los elementos de \r\ncompetencia de manera articulada.\r\n";
        textos[(int)ChaveTextos.APRENSENTAR_O_PROBLEMA] = "1. Presentar el problema y recoger \r\nconocimientos sobre el tema;\r\n2.Analizar las variables del problema y\r\nproponer posibles soluciones;\r\n3. Buscar nuevos referentes para calificar\r\nlas propuestas, debatir y buscar consenso\r\nsobre posibles soluciones;";
        textos[(int)ChaveTextos.SEQUENCIA_DIDATICA] = "SECUENCIA DID�TICA:";
        textos[(int)ChaveTextos.PRIMEIRO_MOMENTO] = "1er Momento";
        textos[(int)ChaveTextos.SEGUNDO_MOMENTO] = "2do Momento";
        textos[(int)ChaveTextos.QUARTO_APRESENTAR] = "4.Presentar las respuestas y evaluar los \r\nresultados.";
        textos[(int)ChaveTextos.ESPACO_DE_APRENDIZAGEM] = "<b>Espacio de Aprendizaje</b>";
        textos[(int)ChaveTextos.SUA_AULA_ACONTECERA] = "Tu clase se llevar� a cabo en el espacio:";
        textos[(int)ChaveTextos.DURANTE_O_MOMENTO] = "�Durante la clase responder�s cuestionarios sobre tu clase, metodolog�a y los medios elegidos a continuaci�n!\r\n";
        textos[(int)ChaveTextos.VOCE_IRA_JOGAR_UMA_AULA] = "Tocar�s una clase de Educaci�n Superior sobre Ling��stica, Literatura y Artes con una clase de perfil de Ling��stica y L�gico-Matem�tica.";
        textos[(int)ChaveTextos.NA_SEQUENCIA_DA_APRENDIZAGEM] = "Siguiendo el Aprendizaje Basado en Problemas, la clase est� dise�ada en dos momentos donde los estudiantes:";
        textos[(int)ChaveTextos.APRESENTAR_O_PROBLEMA] = "Presentar el problema y generar conocimientos sobre el tema";
        textos[(int)ChaveTextos.APRESENTAR_AS_RESPOSTAS] = "Presentar las respuestas y evaluar los resultados";
        textos[(int)ChaveTextos.ESCOLHA_AS_MIDIAS] = "�Elija el medio adecuado para estos objetivos!";
        textos[(int)ChaveTextos.MIDIAS_PRIMEIRO_MOMENTO] = "<b>Medias - Primer momento</b>";
        textos[(int)ChaveTextos.ESCOLHA_DUAS_MIDIAS] = "Elegir los dos medios que se utilizar�n en el aula";
        textos[(int)ChaveTextos.POPULAR] = "<style=\"title\">Popular</style>\r\n\r\n Estos son medios muy utilizados fuera del �mbito escolar, tanto para informaci�n como para conversaci�n. \r\n Las estrategias que incluyen el debate, la recuperaci�n de conocimientos previos y la contextualizaci�n del conocimiento escolar con la realidad pueden aprovechar los medios populares.";
        textos[(int)ChaveTextos.PRODUCAO] = "<style=\"title\">Producci�n</style>\r\n\r\nMedios que permiten al estudiante realizar, crear, desarrollar, construir, ensamblar, inventar, o sea, tener autor�a, construir y organizar conocimientos durante las actividades. Las actividades que generan productos, ya sea en forma de ejercicios, escritura en diferentes idiomas, esquemas de comprensi�n o prototipos, son estrategias de ense�anza que utilizan medios de producci�n.";
        textos[(int)ChaveTextos.CONSULTA] = " <style=\"title\">Consulta</style>\r\n\r\nSon medios utilizados para consultar a los estudiantes sobre contenidos escolares. Admiten todo tipo de b�squedas. informaci�n y ayudar a fundamentar la toma de decisiones y profundizar el conocimiento. Todas las actividades que impliquen investigaci�n, lectura, recopilaci�n y an�lisis de datos requerir�n generalmente medios de consulta.";
        textos[(int)ChaveTextos.EXPOSICAO] = "<style=\"title\">Exposici�n</style>\r\n\r\nMedio utilizado para presentar contenidos, tanto por parte de profesores como de estudiantes. La presentaci�n de ideas o problemas. , del trabajo realizado, la explicaci�n de temas espec�ficos y la difusi�n de resultados y reflexiones son estrategias que se benefician de la exposici�n medi�tica.";
        textos[(int)ChaveTextos.DIGITAL] = "<style=\"title\">Digital</style>\r\n\r\nLos medios digitales son los m�s actuales. Su desarrollo se aceler� en el siglo XXI. Tienen la siguiente El procesamiento de datos se basa en diferentes medios f�sicos (equipos como computadora, videojuego, notebook, tableta, tel�fono celular, etc.) pero tambi�n en medios virtuales como aplicaciones (programas que permiten grabar, editar y compartir textos, im�genes y sonidos (son los medios) de la cultura digital y participativa, la inteligencia colectiva y el ciberespacio. Sus principales caracter�sticas son la interactividad, la ubicuidad (estar en todas partes), la velocidad, la virtualidad y generalmente se utilizan desde una interfaz. proyectos que soporten internet, la comunicaci�n online u offline como producciones gr�ficas, videojuegos, contenidos audiovisuales o hipertextuales, etc. Su contenido puede ser reproducido, remezclado y reutilizado sin p�rdida de calidad, lo que garantiza un flujo de trabajo din�mico y multimedia, favoreciendo interdisciplinariedad e integraci�n entre diferentes medios.";
        textos[(int)ChaveTextos.TRADICIONAL] = "<style=\"title\">Tradicional</style>\r\n\r\nLos medios tradicionales son aquellos que se consideran la base de la educaci�n escolar y conforman el \"est�ndar del aula clases\" en el imaginario de la sociedad occidental desde hace siglos. Est�n presentes en todos los espacios educativos y se considera que los docentes saben planificar con ellas a trav�s de la experiencia vivida en su propia formaci�n. Su apoyo es material y f�sico y puede estar en papel (cuadernos, carteles o fotograf�as), sobre papel impreso (libro, peri�dicos y revistas), o fijado en el aula, como una pizarra.";
        textos[(int)ChaveTextos.AUDIO_VISUAL] = "<style=\"title\">Audiovisual</style>\r\n\r\nLos medios audiovisuales son la generaci�n de medios que domin� el siglo XX. Son los de la comunicaci�n. medios de comunicaci�n de masas, que llegaban a grandes audiencias y utilizaban la imagen y el sonido como base de su lenguaje, como el cine, la radio y la televisi�n, y los equipos eran caros, grandes y profesionales, por lo que estos medios formaban parte de grandes empresas de comunicaci�n y eran profesionales. sus productos se recib�an localmente, a trav�s de antenas, cables o directamente en pel�culas, cintas de casete, CD o DVD. Los productos se consum�an en su totalidad (programas) y poca gente los utilizaba, como cintas de casete o CD/DVD.";
        textos[(int)ChaveTextos.CONFIRA_SE_SUA_ESCOLHA] = "�Comprueba si tu elecci�n es la mejor opci�n para este objetivo!";
        textos[(int)ChaveTextos.AREA_DE_CONHECIMENTO] = "�reas de Conocimiento";
        textos[(int)ChaveTextos.FICHA_DOIS] = "<b>Ficha 2: Planificaci�n</b>";
        textos[(int)ChaveTextos.SALA_DE_AULA] = "Tus estudiantes deben poder consultar\r\n informaci�n actual sobre el tema y luego aplicar lo que descubrieron emp�ricamente!\r\n";
        textos[(int)ChaveTextos.REVISE_AS_CARACTERISTICAS] = "Revisa las caracter�sticas de tu clase y planificaci�n haciendo clic en el bloc de notas antes de pasar al �ltimo paso, donde un cuestionario pondr� a prueba tus conocimientos y descubriremos qu� pensaron los estudiantes de tu clase !";
        textos[(int)ChaveTextos.SUA_AULA] = "Tu clase se impartir� en el laboratorio utilizando la metodolog�a de Aprendizaje Basado en Problemas (ABP) con los medios [...] y [...].";
        textos[(int)ChaveTextos.CONFIRMAR] = "CONFIRMAR";
        textos[(int)ChaveTextos.NASA_SALA_INVERTIDA] = "En el Flipped Classroom existe la posibilidad de concentrar en la plataforma o entorno virtual la informaci�n necesaria para el desarrollo de la materia o curso, lo cual es un gran atractivo de este m�todo.";
        textos[(int)ChaveTextos.SEQUENCIA_DICATICA2] = "Secuencia did�ctica, en el aula:\r\n\r\n1. Explorar el material\r\n\r\n2. Discutir con el grupo en el aula\r \n \r\n3. Realizar actividades";
        textos[(int)ChaveTextos.NA_SALA_DE_AULA_INVERTIDA_DOCENTE] = "En el Flipped Classroom, el docente propone contenidos y actividades para realizar en casa por los estudiantes, a trav�s de materiales como videos, podcasts o lectura de textos, etc. Luego del estudio previo al tema, los estudiantes llevan sus dudas al aula, reflexionan en grupos y desarrollan proyectos.";
        textos[(int)ChaveTextos.MIDIAS_QUARTO] = "<b>Medias - Cuarto</b>";
        textos[(int)ChaveTextos.NA_SEQUENCIA] = "Siguiendo el <b>Aula Invertida</b>, este es el momento en que los estudiantes:";
        textos[(int)ChaveTextos.MIDIAS_SALA] = "<b>Medios - Aula</b>";
        textos[(int)ChaveTextos.CONHECER_SALA_INVERTIDA] = "�Aprendamos un poco m�s sobre el Aula Invertida?";
        textos[(int)ChaveTextos.QUARTO_ESTUDANTE] = "SALA DE ESTUDIO";
        textos[(int)ChaveTextos.NO_MOMENTO] = "�Durante la clase respondes preguntas sobre tu clase, metodolog�a y los m�todos elegidos a continuaci�n!";
        textos[(int)ChaveTextos.NO_MOMENTO_DO_QUARTO] = "�En la sala interact�as como estudiante usando objetos para realizar actividades!";
        textos[(int)ChaveTextos.FICHA_2_RESUMO_2] = "<b>Hoja de resumen 2: Planificaci�n de la lecci�n</b>";
        textos[(int)ChaveTextos.LOGO_APOS] = "�Poco despu�s, un cuestionario pondr� a prueba tus conocimientos y descubriremos qu� pensaron los estudiantes de tu clase! �Buena suerte!";
        textos[(int)ChaveTextos.QUAL_SERA_O_SEU] = "�Cu�l ser� tu proyecto en la metodolog�a 3, que se llevar� a cabo en \r\nla ciudad utilizando la Metodolog�a de Aprendizaje Basado en Proyectos?\r\n";
        textos[(int)ChaveTextos.DESEJA_REALMENTE] = "�De verdad quieres volver al men� principal?";
        textos[(int)ChaveTextos.SIM] = "SI";
        textos[(int)ChaveTextos.NAO] = "NAO";
        textos[(int)ChaveTextos.O_PROBLEMA_DO_PROJETO] = "El problema del proyecto es multidimensional y altamente interactivo, ya que inserta a los participantes en un proceso de investigaci�n estructurado en torno a cuestiones complejas. Ante esto, el gran aporte de esta metodolog�a en el aula radica en el �nfasis sobre el proceso de aprendizaje y la interacci�n entre los estudiantes.\r\n\r\n\r\nLos proyectos permiten unificar varios aspectos importantes del proceso de aprendizaje: la acci�n realizada por el estudiante, la intencionalidad de esta acci�n y su inserci�n. en un contexto social.\r\n";

        textos[(int)ChaveTextos.POR_MEIO] = "A trav�s de los principios de autonom�a, investigaci�n, acci�n y reflexi�n, el desarrollo de un proyecto parte de definir una tem�tica, proponer desaf�os y planificar y ejecutar estrategias para el cumplimiento de las acciones propuestas.\r \n\r\nPara ello, el profesor debe observar los siguientes aspectos: \r\n\r\n� Contenido significativo: relevancia para los estudiantes.\r\n\r\n� Preguntas que hagan pensar: movilizar al grupo para la investigaci�n, presentando diferentes posibilidades de soluci�n. \r\n\r\n� Investigaci�n e innovaci�n: consultar diferentes fuentes especializadas, buscando resultados creativos e innovadores: Los aspectos relacionales y cognitivos del proceso son fundamentales para la vida de los estudiantes ";
        textos[(int)ChaveTextos.A_SEQUENCIA_DIDATICA] = "La secuencia did�ctica en el aprendizaje basado en proyectos se puede dividir en tres momentos:\r\n\r\n� <b>Definir el alcance</b>, Planificar las etapas de proyecto: es la planificaci�n, realizada no s�lo con antelaci�n, sino durante las primeras clases, con la participaci�n de los estudiantes.\r\n\r\n� <b>Ejecutar las acciones planificadas</b>, Monitorear el desarrollo del proyecto: Este es el momento de practicar y ejecutar el proyecto, el cual debe ser realizado por los estudiantes y monitoreado por el docente \r\n\r\n� <b>Presentar los resultados</b>: De regreso al aula , ahora los estudiantes deben presentar sus an�lisis y resultados.";
        textos[(int)ChaveTextos.NO_MOMENTO_DA_CIDADE] = "En el momento de la ciudad se interact�a con los estudiantes, brind�ndoles apoyo para sus investigaciones.";
        textos[(int)ChaveTextos.NO_MOMENTO_AULA] = "�En el momento de la clase respondes cuestionarios sobre tu clase, metodolog�a y los medios elegidos a seguir!";
        textos[(int)ChaveTextos.NA_SEQUENCIA_PROJETOS] = "Siguiendo el Aprendizaje Basado en Proyectos,\r\n estos ser�n los momentos que vivir�n los estudiantes";
        textos[(int)ChaveTextos.DEFINIR_ESCOPO] = "Definir el alcance, Planificar\r\n las etapas del proyecto";
        textos[(int)ChaveTextos.APRESENTAR_RESULTADOS] = "Mostrar los resultados";
        textos[(int)ChaveTextos.TERCEIRO_MOMENTO] = "Tercer momento";
        textos[(int)ChaveTextos.EXERCUTAR_ACOES] = "Ejecutar las acciones planificadas,\r\nMonitorear el desarrollo del proyecto";
        textos[(int)ChaveTextos.RELEMBRAR_CARACTERISTICAS] = "Recordando las caracter�sticas de la clase:";
        textos[(int)ChaveTextos.SEMPRE_QUE_POSSIVEL] = " Siempre que sea posible, en esta metodolog�a, se parte del inter�s\r\n de los estudiantes, de una pregunta orientadora, de un problema real.\r\nConversa con los estudiantes para que encuentren motivaci�n, relevancia y significado.\r\n";
        textos[(int)ChaveTextos.DICA] = "Consejo:";
        textos[(int)ChaveTextos.VAMOS_PARA_TERCEIRA] = "�Pasamos a la tercera metodolog�a? \r\n�Ahora debes elegir un tema para tu �ltima clase en el juego!";
        textos[(int)ChaveTextos.CARACTERISTICAS_TURMA] = "Caracter�sticas de la Clase";
        textos[(int)ChaveTextos.MIDIAS] = "Medias";
        textos[(int)ChaveTextos.TEMA] = "Tema";
        textos[(int)ChaveTextos.CAMPOS_DE_APRENDIZAGEM] = "Campo de Aprendizaje";
        textos[(int)ChaveTextos.METODOLOGIA_SIMPLES] = "Metodolog�a";
        textos[(int)ChaveTextos.LABORATORIO_1] = "Laboratorio - Medio 1";
        textos[(int)ChaveTextos.LABORATORIO_2] = "Laboratorio - Medios 2";
        textos[(int)ChaveTextos.SUA_AULA_ACABOU] = "�Tu clase termin�!";
        textos[(int)ChaveTextos.ESTUDANTES_IRAO_REAGIR] = "Los estudiantes reaccionar�n a su elecci�n de medio y un cuestionario pondr� a prueba sus conocimientos. Puede consultar el progreso de la clase en la barra de la derecha y su puntuaci�n en la barra superior. Bueno �Suerte!\r\n";
        textos[(int)ChaveTextos.FINALIZOU_ABP] = "Has completado la Metodolog�a de Aprendizaje Basado en Problemas";
        textos[(int)ChaveTextos.CONTINUAR] = "Continuar";
        textos[(int)ChaveTextos.JOGAR_NOVAMENTE] = "Jugar de nuevo";
        textos[(int)ChaveTextos.VOLTAR_PARA_O_MENU] = "Regresar al men� de selecci�n";
        textos[(int)ChaveTextos.PARABENS] = "�FELICIDADES!";
        textos[(int)ChaveTextos.AGORA_ESCOLHA_COMO_CONTINUAR] = "Ahora elige c�mo continuar:";
        textos[(int)ChaveTextos.NESTE_MOMENTO_DO_JOGO] = "En este punto del juego respondes preguntas relacionadas con tus elecciones, �y esto definir� tu puntuaci�n! Los comentarios hechos por los estudiantes sobre los medios est�n relacionados con lo �tiles que son en el metodolog�a Aprendizaje Basado en Problemas (ABP). La clase finaliza cuando la barra de duraci�n de la clase est� llena.";
        textos[(int)ChaveTextos.DESEJA_REALMENTE_VOLTAR] = "�De verdad quieres volver al men� principal?";
        textos[(int)ChaveTextos.SUA_TURMA] = "Tu clase";
        textos[(int)ChaveTextos.FIQUE_ATENTO] = "Presta atenci�n a los alumnos, es posible que necesiten tu ayuda.";
        textos[(int)ChaveTextos.ESTUDANTE] = "Estudiante";
        textos[(int)ChaveTextos.MIDIAS_ESPACO_DE_ENSINO] = "<b>Medios - Espacio Docente</b>";
        textos[(int)ChaveTextos.ESCOLHAS_AS_DUAS_MIDIAS] = "Elegir los dos medios que se utilizar�n en el aula";
        textos[(int)ChaveTextos.AGORA_OS_ESTUDANTES] = "Ahora los estudiantes reaccionar�n a su tema de clase\r\n�Buena suerte!\r\n El tema de clase es: ";
        textos[(int)ChaveTextos.COM_ESSA_INFORMACAO] = "�Con esta informaci�n contin�a tu planificaci�n!";
        textos[(int)ChaveTextos.OS_ESTUDANTES_TROUXERAM] = "Los estudiantes trajeron las tareas que realizaron en casa.\r\nAhora un cuestionario pondr� a prueba sus conocimientos y\r\ndadem�s de descubrir la reacci�n de los estudiantes ante su elecci�n de medio, \r\n Les ayudar�s con situaciones imprevistas en el aula.\r\n�Buena suerte!\r\n";
        textos[(int)ChaveTextos.AGRUPAMENTOS] = "Grupos";
        textos[(int)ChaveTextos.AGRUPAMENTOS_1] = "Agrupaciones 1";
        textos[(int)ChaveTextos.AGRUPAMENTOS_2] = "Agrupaciones 2";
        textos[(int)ChaveTextos.QUARTO_MIDIA_1] = "Sala - Medios 1";
        textos[(int)ChaveTextos.QUARTO_MIDIA_2] = "Sala - Medios 2";
        textos[(int)ChaveTextos.SALA_MIDIA_1] = "Sala - Medios 1";
        textos[(int)ChaveTextos.SALA_MIDIA_2] = "Sala - Medios 2";
        textos[(int)ChaveTextos.AGORA_VOCE_ESTA] = "Ahora est�s en el rol del estudiante, el perfil de tu clase\r\ndebe influir en las actividades de ocio y los objetos\r\n deben relacionarse con los medios seleccionados en tu planificaci�n.";
        textos[(int)ChaveTextos.HORA_DE_ESTUDAR] = "�Hora de estudiar!";
        textos[(int)ChaveTextos.VOU_FAZER_AS_TAREFAS] = "Voy a hacer las tareas de clase pero\r\nprimero voy a disfrutar de mi tiempo libre\r\ny divertirme un poco!";
        textos[(int)ChaveTextos.VOCE_CONCLUIU] = "Voy a hacer la tarea de clase pero\r\nprimero voy a disfrutar de mi tiempo libre\r\ny divertirme un poco!";
        textos[(int)ChaveTextos.TERMINEI_TUDO] = "Termin� todo, �qu� bueno! Ahora es el momento de ir a la escuela.";
        textos[(int)ChaveTextos.ESCREVA_AQUI] = "Escribe aqu�";
        textos[(int)ChaveTextos.ESCOLHA_AS_MIDIAS_ADEQUADAS] = "Elija los medios adecuados";
        textos[(int)ChaveTextos.EXPLORANDO_SOBRE_O_TEMA] = "Explorando el tema en casa, estudiantes.\r\n organizar mejor las ideas de forma activa en el aula, creando\r\n conocimientos y presentar lo que aprendieron a sus colegas!";
        textos[(int)ChaveTextos.ESCOLHA_O_AGRUPAMENTO] = "Elige agrupaci�n";
        textos[(int)ChaveTextos.ESPERE_NA_AB] = "�Esperar! �En ABProj, no puedes planificar sin escuchar a tus alumnos!\r\n\r\nPara elegir los medios utilizados en la ciudad, presenta tu propuesta del proyecto a los estudiantes y descubre en qu� lugar de la ciudad prefieren llevarlo a cabo.";
        textos[(int)ChaveTextos.FICHA_NUMERO_2] = "<b>Hoja de resumen 2: Planificaci�n de la lecci�n</b>";
        textos[(int)ChaveTextos.QUIZ] = "Prueba";
        textos[(int)ChaveTextos.AULA_COMUM] = "Clase com�n";
        textos[(int)ChaveTextos.AULA_CONFUSA] = "Clase confusa";
        textos[(int)ChaveTextos.AULA_REVELADO] = "Clase revelada";
        textos[(int)ChaveTextos.DISCUTIR_COM_O_GRUPO] = "Debatir con el grupo en el aula.";
        textos[(int)ChaveTextos.REALIZAR_ATIVIDADES] = "Realizar actividades";
        textos[(int)ChaveTextos.POSITIVE_PRE_FIX] = "me divert� mucho";
        textos[(int)ChaveTextos.NEGATIVE_PRE_FIX] = "Para m� no me divert� mucho.";
        textos[(int)ChaveTextos.TIVE_DIFICULDADE_PARA_FAZER_AS_TAREFAS] = "<color=red>Tuve dificultades para realizar las tareas con";
        textos[(int)ChaveTextos.E] = "y";
        textos[(int)ChaveTextos.CONSEGUI_FAZER_AS_ATIVIDADES] = "Pude realizar las actividades con ";
        textos[(int)ChaveTextos.MAS_TIVE_DIFICULDADES] = "<color=red>pero tuve dificultades para realizar otras tareas con";
        textos[(int)ChaveTextos.VOCE_CONCLUIU_A_PRIMEIRA_PARTE] = "�Has completado la primera parte de esta metodolog�a! �Ahora tu planificaci�n continuar� en el aula!";
        textos[(int)ChaveTextos.FINALIZOU_INVERTIDA] = "Has completado la Metodolog�a Flipped Classroom";
        textos[(int)ChaveTextos.ESTAMOS_CHEGANDO] = "�Estamos llegando al final del proyecto! Despu�s de un largo tiempo de planificaci�n, visitas y dedicaci�n a las actividades, �los alumnos presentar�n sus conclusiones y resultados! \r\n�Es hermoso ver c�mo todo este trabajo toma forma!";
        textos[(int)ChaveTextos.VOCE_FINALIZOU_ABPJ] = "Has completado la Metodolog�a Basada en Proyectos";
        textos[(int)ChaveTextos.AGORA_VOCE_RESPONDERA] = "�Ahora responder�s un cuestionario y te preparar�s para llevar a cabo el proyecto en la ciudad!";
        textos[(int)ChaveTextos.NESTE_MOMENTO] = "Agora voc� responder� um quiz e ir� se preparar para realizar o projeto na cidade! ";
        textos[(int)ChaveTextos.JOGOS] = "<style=\"title\">Juegos</style>\r\n\r\nLos juegos digitales son sistemas de simulaci�n de la realidad que se sustituyen por situaciones l�dicas, permitiendo a los jugadores ver diferentes modelos de la realidad. Los estudios muestran que los juegos digitales pueden desarrollar habilidades como el pensamiento cr�tico y sistem�tico, la resoluci�n de problemas, la ortograf�a, el vocabulario y el desarrollo de la lectura, as� como el aprendizaje de dominios espec�ficos en diferentes �reas (como un nuevo idioma, por ejemplo), as� como una variedad de de las capacidades cognitivas, incluida la visualizaci�n espacial, la atenci�n dividida y la autorregulaci�n emocional. El juego se configura como un medio pedag�gico vers�til, a trav�s del cual se entrelazan pr�cticas sociales y se relacionan conocimientos individuales, en interacci�n con informaci�n, con otros estudiantes, herramientas y materiales. La diversi�n es un factor importante en el proceso, combinada con la relajaci�n y motivaci�n que aportan los retos para realizar las acciones.";
        textos[(int)ChaveTextos.APPS_DE_GAMIFICACAO] = "<style=\"title\">Aplicaciones de gamificaci�n de contenido educativo</style>\r\n\r\nLa gamificaci�n consiste en utilizar herramientas y elementos del juego en un contexto no l�dico. Las aplicaciones de contenidos gamificados hacen del estudio un desaf�o, una pr�ctica placentera que aprovecha las caracter�sticas de los juegos para crear un ambiente propicio para el aprendizaje. Una aplicaci�n con ejercicios de matem�ticas o lenguaje puede otorgar puntos y delimitar los logros del usuario con insignias e hitos que demuestran todo el recorrido y los logros hasta el momento.";
        textos[(int)ChaveTextos.EDITORES_DE_AUDIO] = "<style=\"title\">Editores de audio y v�deo</style>\r\n\r\nLos software de edici�n de audio y video son herramientas que incentivan la investigaci�n en el aula, pues al producir con estos medios podemos incentivar la reflexi�n sobre diferentes temas, la creatividad y el trabajo en equipo. Muchos de estos programas de software cuentan con un conjunto de herramientas vers�tiles, din�micas y f�ciles de aprender. Para realizar sus videos o audios, los estudiantes necesitan ejercitar la interacci�n, la interactividad y pensar en formas diferentes y din�micas de transmitir lo que quieren decir y llamar la atenci�n de sus compa�eros, de esta manera construyen conocimiento en colaboraci�n, utilizando este recurso tecnol�gico. Adem�s, la producci�n audiovisual es a la vez un lenguaje y una habilidad importante para las exigencias del siglo XXI.";
        textos[(int)ChaveTextos.COMPARTILHAMENTO_DE_AUDIOS] = "<style=\"title\">Compartir audio y sonido</style>\r\n\r\nLas redes sociales para compartir im�genes y sonidos permiten a los usuarios compartir y buscar im�genes y v�deos. Realizar comentarios e interactuar con otras personas, estableciendo contactos profesionales o personales.";
        textos[(int)ChaveTextos.COMPARTILHAMENTO_DE_OPINIOS] = "<style=\"title\">Compartir audio y sonido</style>\r\n\r\nLas redes sociales para compartir im�genes y sonidos permiten a los usuarios compartir y buscar im�genes y v�deos. Realizar comentarios e interactuar con otras personas, estableciendo contactos profesionales o personales.";
        textos[(int)ChaveTextos.CONEXOES_INTERPESSOAIS] = "<style=\"title\">Conexiones interpersonales</style>\r\n\r\nLas redes sociales de conexiones interpersonales tienen como objetivo crear redes de relaciones. Permiten enviar mensajes instant�neos. Adem�s de permitir al usuario compartir y buscar conocimientos profesionales.";
        textos[(int)ChaveTextos.COMUNICACAO] = "<style=\"title\">Comunicaci�n</style>\r\n\r\nLas plataformas de comunicaci�n, a trav�s de la red de datos, proporcionan un conjunto de funcionalidades que posibilitan la comunicaci�n en tiempo real entre dos o m�s personas, recopilando, organizando y poner informaci�n a disposici�n para consultas e interacciones. Es posible tener reuniones, encuentros y clases de forma virtual.";
        textos[(int)ChaveTextos.ARMAZENAMENTO] = "<style=\"title\">Almacenamiento</style>\r\n\r\nLas plataformas de almacenamiento garantizan el acceso a im�genes, videos, audios, textos, hojas de c�lculo y cualquier archivo digital en cualquier lugar que tenga acceso a internet. Es posible compartir, administrar y utilizar el mismo archivo por m�s de una persona, actualizando los cambios en tiempo real.";
        textos[(int)ChaveTextos.GERENCIAMENTO] = "<style=\"title\">Gesti�n</style>\r\n\r\nLas plataformas de gesti�n permiten el trabajo en equipo para desarrollar proyectos, planificar y ejecutar clases.";
        textos[(int)ChaveTextos.NA_SEQUENCIA_DA_APRENDIZAGEM_BASEADA_EM_PROJETOS] = "Siguiendo el <b>aprendizaje basado en proyectos</b>, \r\nEstos ser�n los momentos en los que los estudiantes experimentar�n";
        textos[(int)ChaveTextos.OBSERVE_SE_SUA_ESCOLHA] = "�Vea si su elecci�n es la mejor opci�n para estos objetivos!";
        textos[(int)ChaveTextos.PEGUE_DENTRO_DO_ARMARIO] = "<b>Saca medios del armario para usarlos en la ciudad</b>";
        textos[(int)ChaveTextos.SUA_AULA_LAB] = "Tu clase se llevar� a cabo en el LABORATORIO";
        textos[(int)ChaveTextos.TEMA] = "";
        textos[(int)ChaveTextos.DESBLOQUEOU_ABP] = "Has desbloqueado la metodolog�a activa de";
        textos[(int)ChaveTextos.SUA_AULA_QUARTO] = "Su clase se llevar� a cabo en el DORMITORIO DEL ESTUDIANTE y en el AULA.";
        textos[(int)ChaveTextos.SUA_AULA_CIDADE] = "Tu clase se realizar� en la CIUDAD y en el AULA";
        textos[(int)ChaveTextos.PARA_COMECAR] = "Para empezar:";
        textos[(int)ChaveTextos.PRONTO] = "Listo";
        textos[(int)ChaveTextos.ESCOLHA_DO_TEMA] = "Elecci�n del tema";
        textos[(int)ChaveTextos.TEMA] = "Tema";
        textos[(int)ChaveTextos.EXPLORAR_O_MATERIAL] = "Explora el material";
    }

}
