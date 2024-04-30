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

        textos[(int)ChaveTextos.APRENDIZAGEM_BASEADA_EM_PROJETOS] = "Aprendizagem baseada em projetos (ABPj)";
        textos[(int)ChaveTextos.CIDADE] = "CIDADE";
        textos[(int)ChaveTextos.TEXT_METODOLOGIA3] = "Metodologia na qual prop�e-se um projeto\r\ntem�tico que deve ser planejado e\r\n executado a fim de cumprir com as a��es\r\npropostas.";

        textos[(int)ChaveTextos.AGORA_E_COM_VOCE] = "<color=#0B355D>Agora � com voc�! </color>\r\n";
        textos[(int)ChaveTextos.SELECIONE_UMA_DAS_OPCOES] = "Selecione uma das op��es:\r\nVoc� quer jogar a <color=#0B355D>EXPERIENCIA COMPLETA?</color>";
        textos[(int)ChaveTextos.OU_METODOLOGIAS_ATIVAS] = "Ou <color=#0B355D>UMA DAS METODOLOGIAS ATIVAS?</color>";
        textos[(int)ChaveTextos.POP_INTRO_2] = "Juntos vamos explorar os v�rios\r\nusos de m�dias digitais na educa��o.\r\n\r\nVoc� come�a o jogo escolhendo a sua fisionomia e montando as caracter�sticas da sua turma, que v�o se manter ao longo das fases,\r\nservindo como base do seu planejamento.\r\n\r\nNo bot�o  =  voc� encontra as op��es do menu,\r\ne se tiver d�vidas basta clicar no bot�o : ?\r\n \r\nPara iniciar, clique em  OK  e divirta-se escolhendo\r\nseu personagem e personalizando sua turma!";

        textos[(int)ChaveTextos.PERSONAGEM] = "<b>Character</b>";
        textos[(int)ChaveTextos.ESCOLHA_AVATAR] = "Choose your classroom avatar.";
        textos[(int)ChaveTextos.ESTE_AVATAR] = "Este avatar representar� voc� dentro de jogo, sua escolha n�o tem impacto na jogabilidade do game, � apenas uma escolha est�tica.";
        textos[(int)ChaveTextos.MENU_PRINCIPAL] = "Menu Principal";
        textos[(int)ChaveTextos.VOLTAR_MENU] = "Voltar ao Menu";
        textos[(int)ChaveTextos.INFORMACOES] = "Informa��es";
        textos[(int)ChaveTextos.SOBRE_O_COMMENIUS_3] = "      O Game Comenius 3 � um jogo casual, de estrat�gia e simula��o que foca nas m�dias digitais, nas metodologias ativas e nas intelig�ncias m�ltiplas.\r\n      O Game Comenius faz parte um projeto de m�dia-educa��o que investiga como um jogo digital pode ensinar alunos de licenciatura e professores de todos os n�veis de ensino a utilizar as m�dias na sala de aula, para educar �com�, �sobre� e �atrav�s� delas. ";
        textos[(int)ChaveTextos.AVALIAR_JOGO] = "Avaliar Jogo";
        textos[(int)ChaveTextos.PRODUCAO_COORDENACAO] = "<b>Produ��o e Coordena��o</b>\r\n\r\nDulce M�rcia Cruz";
        textos[(int)ChaveTextos.GAME_DESIGN] = "<b>Game Design</b>\r\n\r\nF�bio Medeiros\r\nMatheus Leutchuk Cademartori\r\nIsadora Beagle";
        textos[(int)ChaveTextos.ARTE_UI] = "<b>Arte e UI</b>\r\n\r\nIndra Rosa da Silva\r\nLucas Emanuel Leite da Rosa Gomes\r\nMaria Ant�nia Petrassi\r\nNatan Salles Medeiros\r\nVit Duarte";
        textos[(int)ChaveTextos.ARTE_DA_CIDADE] = "<b>Cen�rio da Cidade</b>\r\n\r\nVit Duarte";
        textos[(int)ChaveTextos.PROGRAMACAO] = "<b>Programa��o</b>\r\n\r\nAlexis Mendes Sequeira\r\nBruno Souza da Silva\r\nNicole Alves Guglielmetti\r\nMatheus Aparicio da Silva\r\nBernardo Gomes Duarte\r\nTh�o Floriano dos Santos\r\nEric Fernandes Evaristo\r\nLuccas Baillo Lopes Floriano";
        textos[(int)ChaveTextos.PEDAGOGICO] = "<b>Pedag�gico</b>\r\n\r\nDenise Figueredo Loch\r\nLucas Souza Pinheiro\r\nRaquel Ferreira da Rosa Oliveira\r\nRicardo Kerscher\r\nJayziela Jessica Fuck\r\nJeremias Martin Calandrini Coelho\r\nVicente Campana Bif";
        textos[(int)ChaveTextos.UX_GESTAO] = "<b>UX, Gest�o e QA</b>\r\n\r\nIsadora Beagle";
        textos[(int)ChaveTextos.CNPG] = "<b>Financeamento CNPq</b>\r\n\r\nIsadora Beagle";

        textos[(int)ChaveTextos.ESCOLHA_ESTAGIO_APRENDIZAGEM] = "Escolha o est�gio de aprendizagem da turma:";
        textos[(int)ChaveTextos.COM_BASE_ENSINO] = "Com base no n�vel de ensino, o que ser� estudado?";
        textos[(int)ChaveTextos.QUAL_PERFIL] = "Qual ser� o perfil dos estudantes desta turma?";

    }

}
