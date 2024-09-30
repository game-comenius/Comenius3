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
        textos[(int)ChaveTextos.PRESSIONE_QUALQUER_BOTAO] = "Pressione qualquer botão";
        textos[(int)ChaveTextos.JOGAR] = "Jugar";
        textos[(int)ChaveTextos.SOBREOJOGO] = "Sobre el juego";
        textos[(int)ChaveTextos.INTRO_METODOLOGIAS_TXT] = "Este juego tiene <color=#330BB3> 3 metodologías</color> y tú" +
"\r\n<color=#330BB3>planifica una lección</color> en cada uno de ellos" +
"<color=#330BB3> usando </color><color=#330BB3> " +
"¡diferentes metodologías activas!\r\n </color>\r\n\r" +
"Las metodologías activas son estrategias\r\n" +
"prácticas pedagógicas que tienen a los estudiantes como\r\n" +
"centro del proceso de enseñanza y aprendizaje" +
"\r\n\r\nLos profesores median, orientan y" +
"\r\nasiguiendo los procesos de interacción en los que" +
"\r\nel aprendizaje se desarrolla.\r\n\r\n";
        textos[(int)ChaveTextos.METODOLOGIAS_ATIVAS] = "Metodologías Activas:";
        textos[(int)ChaveTextos.APRENDIZAGEM_BASEADA_EM_PROBLEMAS] = "Aprendizaje Basado en Problemas (ABP)";

        textos[(int)ChaveTextos.METODOLOGIA] = "<color=#1E0B5C>Metodología 1</color>";
        textos[(int)ChaveTextos.METODOLOGIA2] = "<color=#1E0B5C>Metodología 2</color>";
        textos[(int)ChaveTextos.METODOLOGIA3] = "<color=#1E0B5C>Metodología 3</color>";
        textos[(int)ChaveTextos.TEXT_METODOLOGIA] = "Metodología que parte de un\r\nproblema de complejidad adecuada para\r\ncrear una solución adecuada.";
        textos[(int)ChaveTextos.LABORATORIO] = "LABORATORIO";
        textos[(int)ChaveTextos.CONHECA_AS_METODOLOGIAS] = "Descubre las metodologías:";
        textos[(int)ChaveTextos.SALA_DE_AULA_INVERTIDA] = "Aula invertida (AI)";
        textos[(int)ChaveTextos.TEXT_METODOLOGIA2] = "Metodología en la que los estudiantes estudian \r\n un tema en casa y traen su\r\nproducción y dudas para discutir con la\r\nclase";
        textos[(int)ChaveTextos.QUARTO_DO_ALUNO] = "HABITACIÓN DE ESTUDIANTES";
        textos[(int)ChaveTextos.SALA_DE_AULAB] = "AULA";
        textos[(int)ChaveTextos.APRENDIZAGEM_BASEADA_EM_PROJETOS] = "Aprendizaje en base a proyectos (ABPj)";

        textos[(int)ChaveTextos.CIDADE] = "CIUDAD";
        textos[(int)ChaveTextos.TEXT_METODOLOGIA3] = "Metodología en la que\r\nse plantea un proyecto \r\n temático que se debe  planificar y\r\n ejecutar para dar cumplimiento a las\r\nacciones propuestas";

        textos[(int)ChaveTextos.AGORA_E_COM_VOCE] = "<color=#0B355D>¡Ahora les toca decidir a ustedes! </color>\r\n";
        textos[(int)ChaveTextos.SELECIONE_UMA_DAS_OPCOES] = "Selecciona una de las opciones:\r\n¿Quieres jugar la <color=#0B355D>EXPERIENCIA COMPLETA?</color>";
        textos[(int)ChaveTextos.OU_METODOLOGIAS_ATIVAS] = "¿O <color=#0B355D>UNA DE LAS METODOLOGÍAS ACTIVAS?</color>";
        textos[(int)ChaveTextos.POP_INTRO_2] = "Juntos exploraremos los diversos\r\nUsos de los medios digitales en la educación.\r\n\r\nComienzas el juego eligiendo tu apariencia y creando las características de tu clase, que se mantendrán a lo largo de las fases.\r\nsirviendo como base de su planificación.\r\n\r\nDebajo del botón = encontrarás las opciones del menú,\r\ny si tienes preguntas, simplemente haz clic en el botón: ?\r\n \r\nPara comenzar, haga clic en Aceptar y diviértase eligiendo\r\n¡Tu personaje y personaliza tu clase!";

        textos[(int)ChaveTextos.PERSONAGEM] = "<b>Personaje</b>";
        textos[(int)ChaveTextos.ESCOLHA_AVATAR] = "Elige tu avatar de clase.";
        textos[(int)ChaveTextos.ESTE_AVATAR] = "Este avatar te representará en el juego, tu elección no tiene ningún impacto en la jugabilidad del juego, es sólo una elección estética.";
        textos[(int)ChaveTextos.MENU_PRINCIPAL] = "Menú principal";
        textos[(int)ChaveTextos.VOLTAR_MENU] = "Volver al menú";
        textos[(int)ChaveTextos.INFORMACOES] = "Información";
        textos[(int)ChaveTextos.SOBRE_O_COMMENIUS_3] = "Game Comenius 3 es un juego casual, de estrategia y simulación que apuesta por los medios digitales, las metodologías activas y las inteligencias múltiples.\r\n      Game Comenius es parte de un proyecto de educación en medios que investiga cómo un juego digital puede enseñar a estudiantes universitarios y profesores de todos los niveles educativos a utilizar los medios en el aula, a educar “con”, “sobre” y “a través” de ellos.";
        textos[(int)ChaveTextos.AVALIAR_JOGO] = "Califica el juego";
        textos[(int)ChaveTextos.PRODUCAO_COORDENACAO] = "<b>Producción y Coordinación</b>\r\n\r\nDulce Marcia Cruz";
        textos[(int)ChaveTextos.GAME_DESIGN] = "<b>Diseño de juegos</b>\r\n\r\nFábio Medeiros\r\nMatheus Leutchuk Cademartori\r\nIsadora Beagle";
        textos[(int)ChaveTextos.ARTE_UI] = "<b>Arte y interfaz de usuario</b>\r\n\r\nIndra Rosa da Silva\r\nLucas Emanuel Leite da Rosa Gomes\r\nMaría Antônia Petrassi\r\nNatan Salles Medeiros\r\nVit Duarte";
        textos[(int)ChaveTextos.ARTE_DA_CIDADE] = "<b>Paisaje de la ciudad</b>\r\n\r\nVit Duarte";
        textos[(int)ChaveTextos.PROGRAMACAO] = "<b>Programación</b>\r\n\r\nAlexis Mendes Sequeira\r\nBruno Souza da Silva\r\nNicole Alves Guglielmetti\r\nMatheus Aparicio da Silva\r\nBernardo Gomes Duarte\r\nThéo Floriano dos Santos\r\nEric Fernandes Evaristo\r\nLuccas Baillo Lopes";
        textos[(int)ChaveTextos.PEDAGOGICO] = "<b>Pedagógico</b>\r\n\r\nDenise Figueredo Loch\r\nLucas Souza Pinheiro\r\nRaquel Ferreira da Rosa Oliveira\r\nRicardo Kerscher\r\nJayziela Jessica Mierda\r\nJeremías Martín Calandrini Coelho\r\nVicente Campana Bif";
        textos[(int)ChaveTextos.UX_GESTAO] = "<b>UX, Gestión y Control de Calidad</b>\r\n\r\nIsadora Beagle";
        textos[(int)ChaveTextos.CNPG] = "<b>Financiamiento CNPq</b>\r\n\r\nIsadora Beagle";
        textos[(int)ChaveTextos.ESCOLHA_ESTAGIO_APRENDIZAGEM] = "Elige la etapa de aprendizaje de la clase:";
        textos[(int)ChaveTextos.COM_BASE_ENSINO] = "Según el nivel de estudios ¿qué se estudiará?";
        textos[(int)ChaveTextos.QUAL_PERFIL] = "¿Cuál será el perfil de los estudiantes de esta clase?";
        textos[(int)ChaveTextos.NIVEL_DE_ENSINO] = "<b>Nivel de educación</b>";
        textos[(int)ChaveTextos.CAMPOS_DE_EXPERIENCIA] = "<b>Campos de experiencia</b>";
        textos[(int)ChaveTextos.INTELIGENCIAS_MULTIPLAS] = "<b>Inteligencias multiples</b>";
        textos[(int)ChaveTextos.CARACTERISTICAS_DA_TURMA] = "<b>Hoja 1: Características de Clase</b>";
        textos[(int)ChaveTextos.PERFIL_ESTUDANTES_TURMA] = "¿Cuál será el perfil de los estudiantes de esta clase?";
        textos[(int)ChaveTextos.SAO_AS_CARACTERISTICAS] = "¡Estas son las características de tu clase! Puedes consultarlos durante el juego accediendo\r\nal menú y haciendo clic en el botón \"Tu pandilla\".";

        textos[(int)ChaveTextos.CLIQUE_EM_CONFIRMAR] = "Haz clic en confirmar para iniciar la primera fase\r\ndel juego. Si has cambiado de opinión, haz clic en \r\npara cambiar cualquier opción.";
        textos[(int)ChaveTextos.DICA_SEUS_ESTUDANTES] = "Sus estudiantes deben poder consultar\r\n información actual sobre el tema y luego aplicar lo que descubrieron empíricamente!\r\n";
        textos[(int)ChaveTextos.OLA_SOU_LURDINHA] = "Hola, soy Lurdinha, soy coordinadora pedagógica y\r\n te ayudo con tu planificación!\r\n";
        textos[(int)ChaveTextos.AGORA_VOCE] = "Ahora que conoces el desafío de la primera metodología, finaliza tu\r\npersonalización con la temática de tu clase, tomando como base las características de la clase:\r\n";
        textos[(int)ChaveTextos.QUAL_SERA_O_TEMA] = "\r\n¿Cuál será el tema de su clase de metodología 1, que se llevará a cabo en el Laboratorio utilizando la Metodología de Aprendizaje Basado en Problemas?";
        textos[(int)ChaveTextos.CRIEI_UM_TEMA] = "Crea un tema que guiará tu planificación y elección de medios apropiados para tu clase.";
        textos[(int)ChaveTextos.ESSA_ESCOLHA] = "Esta elección no se refleja en la puntuación.";
        textos[(int)ChaveTextos.NO_MAXIMO_45] = "(Máximo 45 caracteres)";
        textos[(int)ChaveTextos.NA_APRENDIZAGEM_BASEADA] = "En el Aprendizaje Basado en Problemas (ABP)\r\nse debe prestar atención a la descripción de un contexto en el que las variables, temas y situaciones puedan ser \r\nidentificadas claramente por los estudiantes\r \n\r\nEl problema debe contener las siguientes características:\r\n\r\n* Presentar un tema y nivel de complejidad\r\ncompatible con\r\nlos conocimientos previos de los estudiantes;\r\n\r\n *Contener sugerencias o consejos que los alienten a\r\nidentificar posibles puntos de partida;\r\n\r\n* Ser simple y objetivo, para evitar que el grupo\r\ndesvíe la atención del tema;\r\n \r\n* Movilizar los elementos de \r\ncompetencia de manera articulada.\r\n";
        textos[(int)ChaveTextos.APRENSENTAR_O_PROBLEMA] = "1. Presentar el problema y recoger \r\nconocimientos sobre el tema;\r\n2.Analizar las variables del problema y\r\nproponer posibles soluciones;\r\n3. Buscar nuevos referentes para calificar\r\nlas propuestas, debatir y buscar consenso\r\nsobre posibles soluciones;";
        textos[(int)ChaveTextos.SEQUENCIA_DIDATICA] = "SECUENCIA DIDÁTICA:";
        textos[(int)ChaveTextos.PRIMEIRO_MOMENTO] = "1er Momento";
        textos[(int)ChaveTextos.SEGUNDO_MOMENTO] = "2do Momento";
        textos[(int)ChaveTextos.QUARTO_APRESENTAR] = "4.Presentar las respuestas y evaluar los \r\nresultados.";
        textos[(int)ChaveTextos.ESPACO_DE_APRENDIZAGEM] = "<b>Espacio de Aprendizaje</b>";
        textos[(int)ChaveTextos.SUA_AULA_ACONTECERA] = "Tu clase se llevará a cabo en el espacio:";
        textos[(int)ChaveTextos.DURANTE_O_MOMENTO] = "¡Durante la clase responderás cuestionarios sobre tu clase, metodología y los medios elegidos a continuación!\r\n";
        textos[(int)ChaveTextos.VOCE_IRA_JOGAR_UMA_AULA] = "Tocarás una clase de Educación Superior sobre Lingüística, Literatura y Artes con una clase de perfil de Lingüística y Lógico-Matemática.";
        textos[(int)ChaveTextos.NA_SEQUENCIA_DA_APRENDIZAGEM] = "Siguiendo el Aprendizaje Basado en Problemas, la clase está diseñada en dos momentos donde los estudiantes:";
        textos[(int)ChaveTextos.APRESENTAR_O_PROBLEMA] = "Presentar el problema y generar conocimientos sobre el tema";
        textos[(int)ChaveTextos.APRESENTAR_AS_RESPOSTAS] = "Presentar las respuestas y evaluar los resultados";
        textos[(int)ChaveTextos.ESCOLHA_AS_MIDIAS] = "¡Elija el medio adecuado para estos objetivos!";
        textos[(int)ChaveTextos.MIDIAS_PRIMEIRO_MOMENTO] = "<b>Medias - Primer momento</b>";
        textos[(int)ChaveTextos.ESCOLHA_DUAS_MIDIAS] = "Elegir los dos medios que se utilizarán en el aula";
        textos[(int)ChaveTextos.POPULAR] = "<style=\"title\">Popular</style>\r\n\r\n Estos son medios muy utilizados fuera del ámbito escolar, tanto para información como para conversación. \r\n Las estrategias que incluyen el debate, la recuperación de conocimientos previos y la contextualización del conocimiento escolar con la realidad pueden aprovechar los medios populares.";
        textos[(int)ChaveTextos.PRODUCAO] = "<style=\"title\">Producción</style>\r\n\r\nMedios que permiten al estudiante realizar, crear, desarrollar, construir, ensamblar, inventar, o sea, tener autoría, construir y organizar conocimientos durante las actividades. Las actividades que generan productos, ya sea en forma de ejercicios, escritura en diferentes idiomas, esquemas de comprensión o prototipos, son estrategias de enseñanza que utilizan medios de producción.";
        textos[(int)ChaveTextos.CONSULTA] = " <style=\"title\">Consulta</style>\r\n\r\nSon medios utilizados para consultar a los estudiantes sobre contenidos escolares. Admiten todo tipo de búsquedas. información y ayudar a fundamentar la toma de decisiones y profundizar el conocimiento. Todas las actividades que impliquen investigación, lectura, recopilación y análisis de datos requerirán generalmente medios de consulta.";
        textos[(int)ChaveTextos.EXPOSICAO] = "<style=\"title\">Exposición</style>\r\n\r\nMedio utilizado para presentar contenidos, tanto por parte de profesores como de estudiantes. La presentación de ideas o problemas. , del trabajo realizado, la explicación de temas específicos y la difusión de resultados y reflexiones son estrategias que se benefician de la exposición mediática.";
        textos[(int)ChaveTextos.DIGITAL] = "<style=\"title\">Digital</style>\r\n\r\nLos medios digitales son los más actuales. Su desarrollo se aceleró en el siglo XXI. Tienen la siguiente El procesamiento de datos se basa en diferentes medios físicos (equipos como computadora, videojuego, notebook, tableta, teléfono celular, etc.) pero también en medios virtuales como aplicaciones (programas que permiten grabar, editar y compartir textos, imágenes y sonidos (son los medios) de la cultura digital y participativa, la inteligencia colectiva y el ciberespacio. Sus principales características son la interactividad, la ubicuidad (estar en todas partes), la velocidad, la virtualidad y generalmente se utilizan desde una interfaz. proyectos que soporten internet, la comunicación online u offline como producciones gráficas, videojuegos, contenidos audiovisuales o hipertextuales, etc. Su contenido puede ser reproducido, remezclado y reutilizado sin pérdida de calidad, lo que garantiza un flujo de trabajo dinámico y multimedia, favoreciendo interdisciplinariedad e integración entre diferentes medios.";
        textos[(int)ChaveTextos.TRADICIONAL] = "<style=\"title\">Tradicional</style>\r\n\r\nLos medios tradicionales son aquellos que se consideran la base de la educación escolar y conforman el \"estándar del aula clases\" en el imaginario de la sociedad occidental desde hace siglos. Están presentes en todos los espacios educativos y se considera que los docentes saben planificar con ellas a través de la experiencia vivida en su propia formación. Su apoyo es material y físico y puede estar en papel (cuadernos, carteles o fotografías), sobre papel impreso (libro, periódicos y revistas), o fijado en el aula, como una pizarra.";
        textos[(int)ChaveTextos.AUDIO_VISUAL] = "<style=\"title\">Audiovisual</style>\r\n\r\nLos medios audiovisuales son la generación de medios que dominó el siglo XX. Son los de la comunicación. medios de comunicación de masas, que llegaban a grandes audiencias y utilizaban la imagen y el sonido como base de su lenguaje, como el cine, la radio y la televisión, y los equipos eran caros, grandes y profesionales, por lo que estos medios formaban parte de grandes empresas de comunicación y eran profesionales. sus productos se recibían localmente, a través de antenas, cables o directamente en películas, cintas de casete, CD o DVD. Los productos se consumían en su totalidad (programas) y poca gente los utilizaba, como cintas de casete o CD/DVD.";
        textos[(int)ChaveTextos.CONFIRA_SE_SUA_ESCOLHA] = "¡Comprueba si tu elección es la mejor opción para este objetivo!";
        textos[(int)ChaveTextos.AREA_DE_CONHECIMENTO] = "Áreas de Conocimiento";
        textos[(int)ChaveTextos.FICHA_DOIS] = "<b>Ficha 2: Planificación</b>";
        textos[(int)ChaveTextos.SALA_DE_AULA] = "Tus estudiantes deben poder consultar\r\n información actual sobre el tema y luego aplicar lo que descubrieron empíricamente!\r\n";
        textos[(int)ChaveTextos.REVISE_AS_CARACTERISTICAS] = "Revisa las características de tu clase y planificación haciendo clic en el bloc de notas antes de pasar al último paso, donde un cuestionario pondrá a prueba tus conocimientos y descubriremos qué pensaron los estudiantes de tu clase !";
        textos[(int)ChaveTextos.SUA_AULA] = "Tu clase se impartirá en el laboratorio utilizando la metodología de Aprendizaje Basado en Problemas (ABP) con los medios [...] y [...].";
        textos[(int)ChaveTextos.CONFIRMAR] = "CONFIRMAR";
        textos[(int)ChaveTextos.NASA_SALA_INVERTIDA] = "En el Flipped Classroom existe la posibilidad de concentrar en la plataforma o entorno virtual la información necesaria para el desarrollo de la materia o curso, lo cual es un gran atractivo de este método.";
        textos[(int)ChaveTextos.SEQUENCIA_DICATICA2] = "Secuencia didáctica, en el aula:\r\n\r\n1. Explorar el material\r\n\r\n2. Discutir con el grupo en el aula\r \n \r\n3. Realizar actividades";
        textos[(int)ChaveTextos.NA_SALA_DE_AULA_INVERTIDA_DOCENTE] = "En el Flipped Classroom, el docente propone contenidos y actividades para realizar en casa por los estudiantes, a través de materiales como videos, podcasts o lectura de textos, etc. Luego del estudio previo al tema, los estudiantes llevan sus dudas al aula, reflexionan en grupos y desarrollan proyectos.";
        textos[(int)ChaveTextos.MIDIAS_QUARTO] = "<b>Medias - Cuarto</b>";
        textos[(int)ChaveTextos.NA_SEQUENCIA] = "Siguiendo el <b>Aula Invertida</b>, este es el momento en que los estudiantes:";
        textos[(int)ChaveTextos.MIDIAS_SALA] = "<b>Medios - Aula</b>";
        textos[(int)ChaveTextos.CONHECER_SALA_INVERTIDA] = "¿Aprendamos un poco más sobre el Aula Invertida?";
        textos[(int)ChaveTextos.QUARTO_ESTUDANTE] = "SALA DE ESTUDIO";
        textos[(int)ChaveTextos.NO_MOMENTO] = "¡Durante la clase respondes preguntas sobre tu clase, metodología y los métodos elegidos a continuación!";
        textos[(int)ChaveTextos.NO_MOMENTO_DO_QUARTO] = "¡En la sala interactúas como estudiante usando objetos para realizar actividades!";
        textos[(int)ChaveTextos.FICHA_2_RESUMO_2] = "<b>Hoja de resumen 2: Planificación de la lección</b>";
        textos[(int)ChaveTextos.LOGO_APOS] = "¡Poco después, un cuestionario pondrá a prueba tus conocimientos y descubriremos qué pensaron los estudiantes de tu clase! ¡Buena suerte!";
        textos[(int)ChaveTextos.QUAL_SERA_O_SEU] = "¿Cuál será tu proyecto en la metodología 3, que se llevará a cabo en \r\nla ciudad utilizando la Metodología de Aprendizaje Basado en Proyectos?\r\n";
        textos[(int)ChaveTextos.DESEJA_REALMENTE] = "¿De verdad quieres volver al menú principal?";
        textos[(int)ChaveTextos.SIM] = "SI";
        textos[(int)ChaveTextos.NAO] = "NAO";
        textos[(int)ChaveTextos.O_PROBLEMA_DO_PROJETO] = "El problema del proyecto es multidimensional y altamente interactivo, ya que inserta a los participantes en un proceso de investigación estructurado en torno a cuestiones complejas. Ante esto, el gran aporte de esta metodología en el aula radica en el énfasis sobre el proceso de aprendizaje y la interacción entre los estudiantes.\r\n\r\n\r\nLos proyectos permiten unificar varios aspectos importantes del proceso de aprendizaje: la acción realizada por el estudiante, la intencionalidad de esta acción y su inserción. en un contexto social.\r\n";

        textos[(int)ChaveTextos.POR_MEIO] = "A través de los principios de autonomía, investigación, acción y reflexión, el desarrollo de un proyecto parte de definir una temática, proponer desafíos y planificar y ejecutar estrategias para el cumplimiento de las acciones propuestas.\r \n\r\nPara ello, el profesor debe observar los siguientes aspectos: \r\n\r\n• Contenido significativo: relevancia para los estudiantes.\r\n\r\n• Preguntas que hagan pensar: movilizar al grupo para la investigación, presentando diferentes posibilidades de solución. \r\n\r\n• Investigación e innovación: consultar diferentes fuentes especializadas, buscando resultados creativos e innovadores: Los aspectos relacionales y cognitivos del proceso son fundamentales para la vida de los estudiantes ";
        textos[(int)ChaveTextos.A_SEQUENCIA_DIDATICA] = "La secuencia didáctica en el aprendizaje basado en proyectos se puede dividir en tres momentos:\r\n\r\n• <b>Definir el alcance</b>, Planificar las etapas de proyecto: es la planificación, realizada no sólo con antelación, sino durante las primeras clases, con la participación de los estudiantes.\r\n\r\n• <b>Ejecutar las acciones planificadas</b>, Monitorear el desarrollo del proyecto: Este es el momento de practicar y ejecutar el proyecto, el cual debe ser realizado por los estudiantes y monitoreado por el docente \r\n\r\n• <b>Presentar los resultados</b>: De regreso al aula , ahora los estudiantes deben presentar sus análisis y resultados.";
        textos[(int)ChaveTextos.NO_MOMENTO_DA_CIDADE] = "En el momento de la ciudad se interactúa con los estudiantes, brindándoles apoyo para sus investigaciones.";
        textos[(int)ChaveTextos.NO_MOMENTO_AULA] = "¡En el momento de la clase respondes cuestionarios sobre tu clase, metodología y los medios elegidos a seguir!";
        textos[(int)ChaveTextos.NA_SEQUENCIA_PROJETOS] = "Siguiendo el Aprendizaje Basado en Proyectos,\r\n estos serán los momentos que vivirán los estudiantes";
        textos[(int)ChaveTextos.DEFINIR_ESCOPO] = "Definir el alcance, Planificar\r\n las etapas del proyecto";
        textos[(int)ChaveTextos.APRESENTAR_RESULTADOS] = "Mostrar los resultados";
        textos[(int)ChaveTextos.TERCEIRO_MOMENTO] = "Tercer momento";
        textos[(int)ChaveTextos.EXERCUTAR_ACOES] = "Ejecutar las acciones planificadas,\r\nMonitorear el desarrollo del proyecto";
        textos[(int)ChaveTextos.RELEMBRAR_CARACTERISTICAS] = "Recordando las características de la clase:";
        textos[(int)ChaveTextos.SEMPRE_QUE_POSSIVEL] = " Siempre que sea posible, en esta metodología, se parte del interés\r\n de los estudiantes, de una pregunta orientadora, de un problema real.\r\nConversa con los estudiantes para que encuentren motivación, relevancia y significado.\r\n";
        textos[(int)ChaveTextos.DICA] = "Consejo:";
        textos[(int)ChaveTextos.VAMOS_PARA_TERCEIRA] = "¿Pasamos a la tercera metodología? \r\n¡Ahora debes elegir un tema para tu última clase en el juego!";
        textos[(int)ChaveTextos.CARACTERISTICAS_TURMA] = "Características de la Clase";
        textos[(int)ChaveTextos.MIDIAS] = "Medias";
        textos[(int)ChaveTextos.TEMA] = "Tema";
        textos[(int)ChaveTextos.CAMPOS_DE_APRENDIZAGEM] = "Campo de Aprendizaje";
        textos[(int)ChaveTextos.METODOLOGIA_SIMPLES] = "Metodología";
        textos[(int)ChaveTextos.LABORATORIO_1] = "Laboratorio - Medio 1";
        textos[(int)ChaveTextos.LABORATORIO_2] = "Laboratorio - Medios 2";
        textos[(int)ChaveTextos.SUA_AULA_ACABOU] = "¡Tu clase terminó!";
        textos[(int)ChaveTextos.ESTUDANTES_IRAO_REAGIR] = "Los estudiantes reaccionarán a su elección de medio y un cuestionario pondrá a prueba sus conocimientos. Puede consultar el progreso de la clase en la barra de la derecha y su puntuación en la barra superior. Bueno ¡Suerte!\r\n";
        textos[(int)ChaveTextos.FINALIZOU_ABP] = "Has completado la Metodología de Aprendizaje Basado en Problemas";
        textos[(int)ChaveTextos.CONTINUAR] = "Continuar";
        textos[(int)ChaveTextos.JOGAR_NOVAMENTE] = "Jugar de nuevo";
        textos[(int)ChaveTextos.VOLTAR_PARA_O_MENU] = "Regresar al menú de selección";
        textos[(int)ChaveTextos.PARABENS] = "¡FELICIDADES!";
        textos[(int)ChaveTextos.AGORA_ESCOLHA_COMO_CONTINUAR] = "Ahora elige cómo continuar:";
        textos[(int)ChaveTextos.NESTE_MOMENTO_DO_JOGO] = "En este punto del juego respondes preguntas relacionadas con tus elecciones, ¡y esto definirá tu puntuación! Los comentarios hechos por los estudiantes sobre los medios están relacionados con lo útiles que son en el metodología Aprendizaje Basado en Problemas (ABP). La clase finaliza cuando la barra de duración de la clase está llena.";
        textos[(int)ChaveTextos.DESEJA_REALMENTE_VOLTAR] = "¿De verdad quieres volver al menú principal?";
        textos[(int)ChaveTextos.SUA_TURMA] = "Tu clase";
        textos[(int)ChaveTextos.FIQUE_ATENTO] = "Presta atención a los alumnos, es posible que necesiten tu ayuda.";
        textos[(int)ChaveTextos.ESTUDANTE] = "Estudiante";
        textos[(int)ChaveTextos.MIDIAS_ESPACO_DE_ENSINO] = "<b>Medios - Espacio Docente</b>";
        textos[(int)ChaveTextos.ESCOLHAS_AS_DUAS_MIDIAS] = "Elegir los dos medios que se utilizarán en el aula";
        textos[(int)ChaveTextos.AGORA_OS_ESTUDANTES] = "Ahora los estudiantes reaccionarán a su tema de clase\r\n¡Buena suerte!\r\n El tema de clase es: ";
        textos[(int)ChaveTextos.COM_ESSA_INFORMACAO] = "¡Con esta información continúa tu planificación!";
        textos[(int)ChaveTextos.OS_ESTUDANTES_TROUXERAM] = "Los estudiantes trajeron las tareas que realizaron en casa.\r\nAhora un cuestionario pondrá a prueba sus conocimientos y\r\ndademás de descubrir la reacción de los estudiantes ante su elección de medio, \r\n Les ayudarás con situaciones imprevistas en el aula.\r\n¡Buena suerte!\r\n";
        textos[(int)ChaveTextos.AGRUPAMENTOS] = "Grupos";
        textos[(int)ChaveTextos.AGRUPAMENTOS_1] = "Agrupaciones 1";
        textos[(int)ChaveTextos.AGRUPAMENTOS_2] = "Agrupaciones 2";
        textos[(int)ChaveTextos.QUARTO_MIDIA_1] = "Sala - Medios 1";
        textos[(int)ChaveTextos.QUARTO_MIDIA_2] = "Sala - Medios 2";
        textos[(int)ChaveTextos.SALA_MIDIA_1] = "Sala - Medios 1";
        textos[(int)ChaveTextos.SALA_MIDIA_2] = "Sala - Medios 2";
        textos[(int)ChaveTextos.AGORA_VOCE_ESTA] = "Ahora estás en el rol del estudiante, el perfil de tu clase\r\ndebe influir en las actividades de ocio y los objetos\r\n deben relacionarse con los medios seleccionados en tu planificación.";
        textos[(int)ChaveTextos.HORA_DE_ESTUDAR] = "¡Hora de estudiar!";
        textos[(int)ChaveTextos.VOU_FAZER_AS_TAREFAS] = "Voy a hacer las tareas de clase pero\r\nprimero voy a disfrutar de mi tiempo libre\r\ny divertirme un poco!";
        textos[(int)ChaveTextos.VOCE_CONCLUIU] = "Voy a hacer la tarea de clase pero\r\nprimero voy a disfrutar de mi tiempo libre\r\ny divertirme un poco!";
        textos[(int)ChaveTextos.TERMINEI_TUDO] = "Terminé todo, ¡qué bueno! Ahora es el momento de ir a la escuela.";
        textos[(int)ChaveTextos.ESCREVA_AQUI] = "Escribe aquí";
        textos[(int)ChaveTextos.ESCOLHA_AS_MIDIAS_ADEQUADAS] = "Elija los medios adecuados";
        textos[(int)ChaveTextos.EXPLORANDO_SOBRE_O_TEMA] = "Explorando el tema en casa, estudiantes.\r\n organizar mejor las ideas de forma activa en el aula, creando\r\n conocimientos y presentar lo que aprendieron a sus colegas!";
        textos[(int)ChaveTextos.ESCOLHA_O_AGRUPAMENTO] = "Elige agrupación";
        textos[(int)ChaveTextos.ESPERE_NA_AB] = "¡Esperar! ¡En ABProj, no puedes planificar sin escuchar a tus alumnos!\r\n\r\nPara elegir los medios utilizados en la ciudad, presenta tu propuesta del proyecto a los estudiantes y descubre en qué lugar de la ciudad prefieren llevarlo a cabo.";
        textos[(int)ChaveTextos.FICHA_NUMERO_2] = "<b>Hoja de resumen 2: Planificación de la lección</b>";
        textos[(int)ChaveTextos.QUIZ] = "Prueba";
        textos[(int)ChaveTextos.AULA_COMUM] = "Clase común";
        textos[(int)ChaveTextos.AULA_CONFUSA] = "Clase confusa";
        textos[(int)ChaveTextos.AULA_REVELADO] = "Clase revelada";
        textos[(int)ChaveTextos.DISCUTIR_COM_O_GRUPO] = "Debatir con el grupo en el aula.";
        textos[(int)ChaveTextos.REALIZAR_ATIVIDADES] = "Realizar actividades";
        textos[(int)ChaveTextos.POSITIVE_PRE_FIX] = "me divertí mucho";
        textos[(int)ChaveTextos.NEGATIVE_PRE_FIX] = "Para mí no me divertí mucho.";
        textos[(int)ChaveTextos.TIVE_DIFICULDADE_PARA_FAZER_AS_TAREFAS] = "<color=red>Tuve dificultades para realizar las tareas con";
        textos[(int)ChaveTextos.E] = "y";
        textos[(int)ChaveTextos.CONSEGUI_FAZER_AS_ATIVIDADES] = "Pude realizar las actividades con ";
        textos[(int)ChaveTextos.MAS_TIVE_DIFICULDADES] = "<color=red>pero tuve dificultades para realizar otras tareas con";
        textos[(int)ChaveTextos.VOCE_CONCLUIU_A_PRIMEIRA_PARTE] = "¡Has completado la primera parte de esta metodología! ¡Ahora tu planificación continuará en el aula!";
        textos[(int)ChaveTextos.FINALIZOU_INVERTIDA] = "Has completado la Metodología Flipped Classroom";
        textos[(int)ChaveTextos.ESTAMOS_CHEGANDO] = "¡Estamos llegando al final del proyecto! Después de un largo tiempo de planificación, visitas y dedicación a las actividades, ¡los alumnos presentarán sus conclusiones y resultados! \r\n¡Es hermoso ver cómo todo este trabajo toma forma!";
        textos[(int)ChaveTextos.VOCE_FINALIZOU_ABPJ] = "Has completado la Metodología Basada en Proyectos";
        textos[(int)ChaveTextos.AGORA_VOCE_RESPONDERA] = "¡Ahora responderás un cuestionario y te prepararás para llevar a cabo el proyecto en la ciudad!";
        textos[(int)ChaveTextos.NESTE_MOMENTO] = "Agora você responderá um quiz e irá se preparar para realizar o projeto na cidade! ";
        textos[(int)ChaveTextos.JOGOS] = "<style=\"title\">Juegos</style>\r\n\r\nLos juegos digitales son sistemas de simulación de la realidad que se sustituyen por situaciones lúdicas, permitiendo a los jugadores ver diferentes modelos de la realidad. Los estudios muestran que los juegos digitales pueden desarrollar habilidades como el pensamiento crítico y sistemático, la resolución de problemas, la ortografía, el vocabulario y el desarrollo de la lectura, así como el aprendizaje de dominios específicos en diferentes áreas (como un nuevo idioma, por ejemplo), así como una variedad de de las capacidades cognitivas, incluida la visualización espacial, la atención dividida y la autorregulación emocional. El juego se configura como un medio pedagógico versátil, a través del cual se entrelazan prácticas sociales y se relacionan conocimientos individuales, en interacción con información, con otros estudiantes, herramientas y materiales. La diversión es un factor importante en el proceso, combinada con la relajación y motivación que aportan los retos para realizar las acciones.";
        textos[(int)ChaveTextos.APPS_DE_GAMIFICACAO] = "<style=\"title\">Aplicaciones de gamificación de contenido educativo</style>\r\n\r\nLa gamificación consiste en utilizar herramientas y elementos del juego en un contexto no lúdico. Las aplicaciones de contenidos gamificados hacen del estudio un desafío, una práctica placentera que aprovecha las características de los juegos para crear un ambiente propicio para el aprendizaje. Una aplicación con ejercicios de matemáticas o lenguaje puede otorgar puntos y delimitar los logros del usuario con insignias e hitos que demuestran todo el recorrido y los logros hasta el momento.";
        textos[(int)ChaveTextos.EDITORES_DE_AUDIO] = "<style=\"title\">Editores de audio y vídeo</style>\r\n\r\nLos software de edición de audio y video son herramientas que incentivan la investigación en el aula, pues al producir con estos medios podemos incentivar la reflexión sobre diferentes temas, la creatividad y el trabajo en equipo. Muchos de estos programas de software cuentan con un conjunto de herramientas versátiles, dinámicas y fáciles de aprender. Para realizar sus videos o audios, los estudiantes necesitan ejercitar la interacción, la interactividad y pensar en formas diferentes y dinámicas de transmitir lo que quieren decir y llamar la atención de sus compañeros, de esta manera construyen conocimiento en colaboración, utilizando este recurso tecnológico. Además, la producción audiovisual es a la vez un lenguaje y una habilidad importante para las exigencias del siglo XXI.";
        textos[(int)ChaveTextos.COMPARTILHAMENTO_DE_AUDIOS] = "<style=\"title\">Compartir audio y sonido</style>\r\n\r\nLas redes sociales para compartir imágenes y sonidos permiten a los usuarios compartir y buscar imágenes y vídeos. Realizar comentarios e interactuar con otras personas, estableciendo contactos profesionales o personales.";
        textos[(int)ChaveTextos.COMPARTILHAMENTO_DE_OPINIOS] = "<style=\"title\">Compartir audio y sonido</style>\r\n\r\nLas redes sociales para compartir imágenes y sonidos permiten a los usuarios compartir y buscar imágenes y vídeos. Realizar comentarios e interactuar con otras personas, estableciendo contactos profesionales o personales.";
        textos[(int)ChaveTextos.CONEXOES_INTERPESSOAIS] = "<style=\"title\">Conexiones interpersonales</style>\r\n\r\nLas redes sociales de conexiones interpersonales tienen como objetivo crear redes de relaciones. Permiten enviar mensajes instantáneos. Además de permitir al usuario compartir y buscar conocimientos profesionales.";
        textos[(int)ChaveTextos.COMUNICACAO] = "<style=\"title\">Comunicación</style>\r\n\r\nLas plataformas de comunicación, a través de la red de datos, proporcionan un conjunto de funcionalidades que posibilitan la comunicación en tiempo real entre dos o más personas, recopilando, organizando y poner información a disposición para consultas e interacciones. Es posible tener reuniones, encuentros y clases de forma virtual.";
        textos[(int)ChaveTextos.ARMAZENAMENTO] = "<style=\"title\">Almacenamiento</style>\r\n\r\nLas plataformas de almacenamiento garantizan el acceso a imágenes, videos, audios, textos, hojas de cálculo y cualquier archivo digital en cualquier lugar que tenga acceso a internet. Es posible compartir, administrar y utilizar el mismo archivo por más de una persona, actualizando los cambios en tiempo real.";
        textos[(int)ChaveTextos.GERENCIAMENTO] = "<style=\"title\">Gestión</style>\r\n\r\nLas plataformas de gestión permiten el trabajo en equipo para desarrollar proyectos, planificar y ejecutar clases.";
        textos[(int)ChaveTextos.NA_SEQUENCIA_DA_APRENDIZAGEM_BASEADA_EM_PROJETOS] = "Siguiendo el <b>aprendizaje basado en proyectos</b>, \r\nEstos serán los momentos en los que los estudiantes experimentarán";
        textos[(int)ChaveTextos.OBSERVE_SE_SUA_ESCOLHA] = "¡Vea si su elección es la mejor opción para estos objetivos!";
        textos[(int)ChaveTextos.PEGUE_DENTRO_DO_ARMARIO] = "<b>Saca medios del armario para usarlos en la ciudad</b>";
        textos[(int)ChaveTextos.SUA_AULA_LAB] = "Tu clase se llevará a cabo en el LABORATORIO";
        textos[(int)ChaveTextos.TEMA] = "";
        textos[(int)ChaveTextos.DESBLOQUEOU_ABP] = "Has desbloqueado la metodología activa de";
        textos[(int)ChaveTextos.SUA_AULA_QUARTO] = "Su clase se llevará a cabo en el DORMITORIO DEL ESTUDIANTE y en el AULA.";
        textos[(int)ChaveTextos.SUA_AULA_CIDADE] = "Tu clase se realizará en la CIUDAD y en el AULA";
        textos[(int)ChaveTextos.PARA_COMECAR] = "Para empezar:";
        textos[(int)ChaveTextos.PRONTO] = "Listo";
        textos[(int)ChaveTextos.ESCOLHA_DO_TEMA] = "Elección del tema";
        textos[(int)ChaveTextos.TEMA] = "Tema";
        textos[(int)ChaveTextos.EXPLORAR_O_MATERIAL] = "Explora el material";
    }

}
