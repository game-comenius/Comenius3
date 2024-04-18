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
        textos[(int)ChaveTextos.SALA_DE_AULA_INVERTIDA] = "Aula invertida (SAI)";
        textos[(int)ChaveTextos.TEXT_METODOLOGIA2] = "Metodolog�a en la que los estudiantes estudian\r\nun tema en casa y traen su\r\nproducci�n y dudas para discutir con la\r\nclase";
        textos[(int)ChaveTextos.QUARTO_DO_ALUNO] = "HABITACI�N DE ESTUDIANTES";
        textos[(int)ChaveTextos.SALA_DE_AULA] = "AULA";
        textos[(int)ChaveTextos.APRENDIZAGEM_BASEADA_EM_PROJETOS] = "Aprendizaje en base a proyectos";

        textos[(int)ChaveTextos.CIDADE] = "CIUDAD";
        textos[(int)ChaveTextos.TEXT_METODOLOGIA3] = "Metodologia na qual prop�e-se um projeto\r\ntem�tico que deve ser planejado e\r\n executado a fim de cumprir com as a��es\r\npropostas.";

    }

}
