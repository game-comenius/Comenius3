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
    }
}
