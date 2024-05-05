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
        textos[(int)ChaveTextos.SALA_DE_AULA] = "AULA";
        textos[(int)ChaveTextos.APRENDIZAGEM_BASEADA_EM_PROJETOS] = "Aprendizaje en base a proyectos (ABPj)";

        textos[(int)ChaveTextos.CIDADE] = "CIUDAD";
        textos[(int)ChaveTextos.TEXT_METODOLOGIA3] = "Metodología en la que\r\nse plantea un proyecto \r\n temático que se debe  planificar y\r\n ejecutar para dar cumplimiento a las\r\nacciones propuestas";

        textos[(int)ChaveTextos.AGORA_E_COM_VOCE] = "<color=#0B355D>¡Ahora depende de ti! </color>\r\n";
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

    }

}
