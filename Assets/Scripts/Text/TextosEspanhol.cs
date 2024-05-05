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
        textos[(int)ChaveTextos.SALA_DE_AULA] = "AULA";
        textos[(int)ChaveTextos.APRENDIZAGEM_BASEADA_EM_PROJETOS] = "Aprendizaje en base a proyectos (ABPj)";

        textos[(int)ChaveTextos.CIDADE] = "CIUDAD";
        textos[(int)ChaveTextos.TEXT_METODOLOGIA3] = "Metodolog�a en la que\r\nse plantea un proyecto \r\n tem�tico que se debe  planificar y\r\n ejecutar para dar cumplimiento a las\r\nacciones propuestas";

        textos[(int)ChaveTextos.AGORA_E_COM_VOCE] = "<color=#0B355D>�Ahora depende de ti! </color>\r\n";
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

    }

}
