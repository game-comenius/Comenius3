using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextosPortugues : Textos
{
	public TextosPortugues()
	{
		instance = this;
		PreencherTextos();
	}

	protected override void PreencherTextos()
	{
		textos = new string[(int)ChaveTextos._chaveFinal];
        textos[(int)ChaveTextos.PRESSIONE_QUALQUER_BOTAO] = "Pressione qualquer botão";
        textos[(int)ChaveTextos.JOGAR] = "Jogar";
        textos[(int)ChaveTextos.SOBREOJOGO] = "Sobre o jogo";
		textos[(int)ChaveTextos.INTRO_METODOLOGIAS_TXT] = "Este jogo tem<color=#330BB3> 3 metodologias</color> e você irá" +
			"\r\n<color=#330BB3>planejar uma aula</color> em cada uma  delas" +
			"<color=#330BB3> utilizando </color><color=#330BB3> " +
			"diferentes metodologias ativas!\r\n </color>\r\n\r" +
			"As metodologias ativas são estratégias\r\n" +
			"pedagógicas que têm os estudantes como\r\n" +
			"centro do processo de ensino e aprendizagem." +
			"\r\n\r\nOs docentes mediam, orientando e" +
			"\r\nacompanhando os processos de interação nos quais a" +
			"\r\naprendizagem se desenvolve.\r\n\r\n";
        textos[(int)ChaveTextos.METODOLOGIAS_ATIVAS] = "Metodologias Ativas:";
        textos[(int)ChaveTextos.APRENDIZAGEM_BASEADA_EM_PROBLEMAS] = "Aprendizagem Baseada em Problemas (ABP)";
    }
}
