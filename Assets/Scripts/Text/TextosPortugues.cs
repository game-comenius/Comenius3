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
        textos[(int)ChaveTextos.PRESSIONE_QUALQUER_BOTAO] = "Pressione qualquer bot�o";
        textos[(int)ChaveTextos.JOGAR] = "Jogar";
        textos[(int)ChaveTextos.SOBREOJOGO] = "Sobre o jogo";
		textos[(int)ChaveTextos.INTRO_METODOLOGIAS_TXT] = "Este jogo tem<color=#330BB3> 3 metodologias</color> e voc� ir�" +
			"\r\n<color=#330BB3>planejar uma aula</color> em cada uma  delas" +
			"<color=#330BB3> utilizando </color><color=#330BB3> " +
			"diferentes metodologias ativas!\r\n </color>\r\n\r" +
			"As metodologias ativas s�o estrat�gias\r\n" +
			"pedag�gicas que t�m os estudantes como\r\n" +
			"centro do processo de ensino e aprendizagem." +
			"\r\n\r\nOs docentes mediam, orientando e" +
			"\r\nacompanhando os processos de intera��o nos quais a" +
			"\r\naprendizagem se desenvolve.\r\n\r\n";
        textos[(int)ChaveTextos.METODOLOGIAS_ATIVAS] = "Metodologias Ativas:";
        textos[(int)ChaveTextos.APRENDIZAGEM_BASEADA_EM_PROBLEMAS] = "Aprendizagem Baseada em Problemas (ABP)";
        textos[(int)ChaveTextos.METODOLOGIA] = "<color=#1E0B5C>Metodologia 1 </color>";
        textos[(int)ChaveTextos.METODOLOGIA2] = "<color=#1E0B5C>Metodologia 2</color>";
        textos[(int)ChaveTextos.METODOLOGIA3] = "<color=#1E0B5C>Metodologia 3</color>";
        textos[(int)ChaveTextos.TEXT_METODOLOGIA] = "Metodologia que parte de um\r\nproblema de complexidade adequada para\r\ntra�ar uma solu��o adequada.";
        textos[(int)ChaveTextos.LABORATORIO] = "LABORAT�RIO";
        textos[(int)ChaveTextos.CONHECA_AS_METODOLOGIAS] = "Conhe�a as metodologias:";
        textos[(int)ChaveTextos.SALA_DE_AULA_INVERTIDA] = "Sala de Aula Invertida (SAI)";
        textos[(int)ChaveTextos.TEXT_METODOLOGIA2] = "Metodologia na qual os estudantes estudam\r\nsobre um tema em casa e trazem sua\r\nprodu��o e d�vidas para discutir com a\r\nturma em aula.";
		textos[(int)ChaveTextos.QUARTO_DO_ALUNO] = "QUARTO DO ALUNO";
        textos[(int)ChaveTextos.SALA_DE_AULA] = "SALA DE AULA";

        textos[(int)ChaveTextos.APRENDIZAGEM_BASEADA_EM_PROJETOS] = "Aprendizagem baseada em projetos";
        textos[(int)ChaveTextos.CIDADE] = "CIDADE";
        textos[(int)ChaveTextos.TEXT_METODOLOGIA3] = "Metodologia na qual prop�e-se um projeto\r\ntem�tico que deve ser planejado e\r\n executado a fim de cumprir com as a��es\r\npropostas.";

    }
}
