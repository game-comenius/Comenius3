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
        textos[(int)ChaveTextos.METODOLOGIA] = "<color=#1E0B5C>Metodologia 1 </color>";
        textos[(int)ChaveTextos.METODOLOGIA2] = "<color=#1E0B5C>Metodologia 2</color>";
        textos[(int)ChaveTextos.METODOLOGIA3] = "<color=#1E0B5C>Metodologia 3</color>";
        textos[(int)ChaveTextos.TEXT_METODOLOGIA] = "Metodologia que parte de um\r\nproblema de complexidade adequada para\r\ntraçar uma solução adequada.";
        textos[(int)ChaveTextos.LABORATORIO] = "LABORATÓRIO";
        textos[(int)ChaveTextos.CONHECA_AS_METODOLOGIAS] = "Conheça as metodologias:";
        textos[(int)ChaveTextos.SALA_DE_AULA_INVERTIDA] = "Sala de Aula Invertida (SAI)";
        textos[(int)ChaveTextos.TEXT_METODOLOGIA2] = "Metodologia na qual os estudantes estudam\r\nsobre um tema em casa e trazem sua\r\nprodução e dúvidas para discutir com a\r\nturma em aula.";
		textos[(int)ChaveTextos.QUARTO_DO_ALUNO] = "QUARTO DO ALUNO";
        textos[(int)ChaveTextos.SALA_DE_AULA] = "SALA DE AULA";

        textos[(int)ChaveTextos.APRENDIZAGEM_BASEADA_EM_PROJETOS] = "Aprendizagem baseada em projetos (ABPj)";
        textos[(int)ChaveTextos.CIDADE] = "CIDADE";
        textos[(int)ChaveTextos.TEXT_METODOLOGIA3] = "Metodologia na qual propõe-se um projeto\r\ntemático que deve ser planejado e\r\n executado a fim de cumprir com as ações\r\npropostas.";

        textos[(int)ChaveTextos.AGORA_E_COM_VOCE] = "<color=#0B355D>Agora é com você! </color>\r\n";
        textos[(int)ChaveTextos.SELECIONE_UMA_DAS_OPCOES] = "Selecione uma das opções:\r\nVocê quer jogar a <color=#0B355D>EXPERIENCIA COMPLETA?</color>";
        textos[(int)ChaveTextos.OU_METODOLOGIAS_ATIVAS] = "Ou <color=#0B355D>UMA DAS METODOLOGIAS ATIVAS?</color>";
        textos[(int)ChaveTextos.POP_INTRO_2] = "Juntos vamos explorar os vários\r\nusos de mídias digitais na educação.\r\n\r\nVocê começa o jogo escolhendo a sua fisionomia e montando as características da sua turma, que vão se manter ao longo das fases,\r\nservindo como base do seu planejamento.\r\n\r\nNo botão  =  você encontra as opções do menu,\r\ne se tiver dúvidas basta clicar no botão : ?\r\n \r\nPara iniciar, clique em  OK  e divirta-se escolhendo\r\nseu personagem e personalizando sua turma!";

        textos[(int)ChaveTextos.PERSONAGEM] = "<b>Character</b>";
        textos[(int)ChaveTextos.ESCOLHA_AVATAR] = "Choose your classroom avatar.";
        textos[(int)ChaveTextos.ESTE_AVATAR] = "Este avatar representará você dentro de jogo, sua escolha não tem impacto na jogabilidade do game, é apenas uma escolha estética.";
        textos[(int)ChaveTextos.MENU_PRINCIPAL] = "Menu Principal";
        textos[(int)ChaveTextos.VOLTAR_MENU] = "Voltar ao Menu";
        textos[(int)ChaveTextos.INFORMACOES] = "Informações";
        textos[(int)ChaveTextos.SOBRE_O_COMMENIUS_3] = "      O Game Comenius 3 é um jogo casual, de estratégia e simulação que foca nas mídias digitais, nas metodologias ativas e nas inteligências múltiplas.\r\n      O Game Comenius faz parte um projeto de mídia-educação que investiga como um jogo digital pode ensinar alunos de licenciatura e professores de todos os níveis de ensino a utilizar as mídias na sala de aula, para educar “com”, “sobre” e “através” delas. ";
        textos[(int)ChaveTextos.AVALIAR_JOGO] = "Avaliar Jogo";
        textos[(int)ChaveTextos.PRODUCAO_COORDENACAO] = "<b>Produção e Coordenação</b>\r\n\r\nDulce Márcia Cruz";
        textos[(int)ChaveTextos.GAME_DESIGN] = "<b>Game Design</b>\r\n\r\nFábio Medeiros\r\nMatheus Leutchuk Cademartori\r\nIsadora Beagle";
        textos[(int)ChaveTextos.ARTE_UI] = "<b>Arte e UI</b>\r\n\r\nIndra Rosa da Silva\r\nLucas Emanuel Leite da Rosa Gomes\r\nMaria Antônia Petrassi\r\nNatan Salles Medeiros\r\nVit Duarte";
        textos[(int)ChaveTextos.ARTE_DA_CIDADE] = "<b>Cenário da Cidade</b>\r\n\r\nVit Duarte";
        textos[(int)ChaveTextos.PROGRAMACAO] = "<b>Programação</b>\r\n\r\nAlexis Mendes Sequeira\r\nBruno Souza da Silva\r\nNicole Alves Guglielmetti\r\nMatheus Aparicio da Silva\r\nBernardo Gomes Duarte\r\nThéo Floriano dos Santos\r\nEric Fernandes Evaristo\r\nLuccas Baillo Lopes Floriano";
        textos[(int)ChaveTextos.PEDAGOGICO] = "<b>Pedagógico</b>\r\n\r\nDenise Figueredo Loch\r\nLucas Souza Pinheiro\r\nRaquel Ferreira da Rosa Oliveira\r\nRicardo Kerscher\r\nJayziela Jessica Fuck\r\nJeremias Martin Calandrini Coelho\r\nVicente Campana Bif";
        textos[(int)ChaveTextos.UX_GESTAO] = "<b>UX, Gestão e QA</b>\r\n\r\nIsadora Beagle";
        textos[(int)ChaveTextos.CNPG] = "<b>Financeamento CNPq</b>\r\n\r\nIsadora Beagle";

        textos[(int)ChaveTextos.ESCOLHA_ESTAGIO_APRENDIZAGEM] = "Escolha o estágio de aprendizagem da turma:";
        textos[(int)ChaveTextos.COM_BASE_ENSINO] = "Com base no nível de ensino, o que será estudado?";
        textos[(int)ChaveTextos.QUAL_PERFIL] = "Qual será o perfil dos estudantes desta turma?";

    }

}
