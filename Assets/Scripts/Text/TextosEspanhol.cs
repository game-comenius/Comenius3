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
    }
}
