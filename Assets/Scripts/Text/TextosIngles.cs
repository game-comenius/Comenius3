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
    }
}
