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
"<color=#330BB3> using </color><color=#330BB3> " +
"different active methodologies!\r\n </color>\r\n\r" +
"Active methodologies are strategies\r\n" +
"pedagogical practices that have students like\r\n" +
"center of the teaching and learning process." +
"\r\n\r\nThe teachers mediate, guiding and" +
"\r\nafollowing the interaction processes in which the" +
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
        textos[(int)ChaveTextos.SALA_DE_AULA] = "CLASSROOM";
        textos[(int)ChaveTextos.APRENDIZAGEM_BASEADA_EM_PROJETOS] = "Project-Based Learning (PBL)";

        textos[(int)ChaveTextos.CIDADE] = "CITY";
        textos[(int)ChaveTextos.TEXT_METODOLOGIA3] = "Methodology in which a\r\ntematic project is proposed that must be planned and\r\nexecuted in order to comply with the\r\nproposed actions";

        textos[(int)ChaveTextos.AGORA_E_COM_VOCE] = "<color=#0B355D>Now it's up to you! </color>\r\n";
        textos[(int)ChaveTextos.SELECIONE_UMA_DAS_OPCOES] = "Select one of the options:\r\nDo you want to play the <color=#0B355D>FULL EXPERIENCE?</color>";
        textos[(int)ChaveTextos.OU_METODOLOGIAS_ATIVAS] = "Or <color=#0B355D>ONE OF THE ACTIVE METHODOLOGIES?</color>";
        textos[(int)ChaveTextos.POP_INTRO_2] = "Together we will explore the various\r\nuses of digital media in education.\r\n\r\nYou start the game by choosing your appearance and creating the characteristics of your class, which will be maintained throughout the phases,\r\nserving as the basis of your planning.\r\n\r\nUnder the button = you will find the menu options,\r\nand if you have questions, just click the button: ?\r\n \r\nTo get started, click OK and have fun choosing\r\nyour character and customizing your class!";

        textos[(int)ChaveTextos.PERSONAGEM] = "\r\n<b>Personaje</b>";
        textos[(int)ChaveTextos.ESCOLHA_AVATAR] = "Elige tu avatar de clase.";
        textos[(int)ChaveTextos.ESTE_AVATAR] = "This avatar will represent you in the game, your choice has no impact on the game's gameplay, it is just an aesthetic choice.";
        textos[(int)ChaveTextos.MENU_PRINCIPAL] = "Main menu";
        textos[(int)ChaveTextos.VOLTAR_MENU] = "Return to Menu";
        textos[(int)ChaveTextos.INFORMACOES] = "Information";
        textos[(int)ChaveTextos.SOBRE_O_COMMENIUS_3] = "Game Comenius 3 is a casual, strategy and simulation game that focuses on digital media, active methodologies and multiple intelligences.\r\n      Game Comenius is part of a media education project that investigates how a digital game can teach undergraduate students and teachers at all levels of education to use media in the classroom, to educate “with”, “about” and “ through” them.";
        textos[(int)ChaveTextos.AVALIAR_JOGO] = "Review Game";
    }
    
}
