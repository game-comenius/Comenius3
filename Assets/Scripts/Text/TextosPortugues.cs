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
        textos[(int)ChaveTextos.SALA_DE_AULAB] = "SALA DE AULA";

        textos[(int)ChaveTextos.APRENDIZAGEM_BASEADA_EM_PROJETOS] = "Aprendizagem baseada em projetos (ABPj)";
        textos[(int)ChaveTextos.CIDADE] = "CIDADE";
        textos[(int)ChaveTextos.TEXT_METODOLOGIA3] = "Metodologia na qual prop�e-se um projeto\r\ntem�tico que deve ser planejado e\r\n executado a fim de cumprir com as a��es\r\npropostas.";

        textos[(int)ChaveTextos.AGORA_E_COM_VOCE] = "<color=#0B355D>Agora � com voc�! </color>\r\n";
        textos[(int)ChaveTextos.SELECIONE_UMA_DAS_OPCOES] = "Selecione uma das op��es:\r\nVoc� quer jogar a <color=#0B355D>EXPERIENCIA COMPLETA?</color>";
        textos[(int)ChaveTextos.OU_METODOLOGIAS_ATIVAS] = "Ou <color=#0B355D>UMA DAS METODOLOGIAS ATIVAS?</color>";
        textos[(int)ChaveTextos.POP_INTRO_2] = "Juntos vamos explorar os v�rios\r\nusos de m�dias digitais na educa��o.\r\n\r\nVoc� come�a o jogo escolhendo a sua fisionomia e montando as caracter�sticas da sua turma, que v�o se manter ao longo das fases,\r\nservindo como base do seu planejamento.\r\n\r\nNo bot�o  =  voc� encontra as op��es do menu,\r\ne se tiver d�vidas basta clicar no bot�o : ?\r\n \r\nPara iniciar, clique em  OK  e divirta-se escolhendo\r\nseu personagem e personalizando sua turma!";

        textos[(int)ChaveTextos.PERSONAGEM] = "<b>Character</b>";
        textos[(int)ChaveTextos.ESCOLHA_AVATAR] = "Escolha seu personagem";
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
        textos[(int)ChaveTextos.PROGRAMACAO] = "<b>Programa��o</b>\r\n\r\nAlexis Mendes Sequeira\r\nBruno Souza da Silva\r\nNicole Alves Guglielmetti\r\nMatheus Aparicio da Silva\r\nBernardo Gomes Duarte\r\nTh�o Floriano dos Santos\r\nEric Fernandes Evaristo\r\nLuccas Baillo Lopes";
        textos[(int)ChaveTextos.PEDAGOGICO] = "<b>Pedag�gico</b>\r\n\r\nDenise Figueredo Loch\r\nLucas Souza Pinheiro\r\nRaquel Ferreira da Rosa Oliveira\r\nRicardo Kerscher\r\nJayziela Jessica Fuck\r\nJeremias Martin Calandrini Coelho\r\nVicente Campana Bif";
        textos[(int)ChaveTextos.UX_GESTAO] = "<b>UX, Gest�o e QA</b>\r\n\r\nIsadora Beagle";
        textos[(int)ChaveTextos.CNPG] = "<b>Financeamento CNPq</b>\r\n\r\nIsadora Beagle";

        textos[(int)ChaveTextos.ESCOLHA_ESTAGIO_APRENDIZAGEM] = "Escolha o est�gio de aprendizagem da turma:";
        textos[(int)ChaveTextos.COM_BASE_ENSINO] = "Com base no n�vel de ensino, o que ser� estudado?";
        textos[(int)ChaveTextos.NIVEL_DE_ENSINO] = "<b>N�vel de Ensino</b>";
        textos[(int)ChaveTextos.CAMPOS_DE_EXPERIENCIA] = "<b>Campos de Experi�ncias</b>";
        textos[(int)ChaveTextos.INTELIGENCIAS_MULTIPLAS] = "<b>Intelig�ncias M�ltiplas</b>";
        textos[(int)ChaveTextos.CARACTERISTICAS_DA_TURMA] = "<b>Ficha 1: Caracter�sticas da Turma</b>";
        textos[(int)ChaveTextos.PERFIL_ESTUDANTES_TURMA] = "Qual ser� o perfil dos estudantes desta turma?";

        textos[(int)ChaveTextos.SAO_AS_CARACTERISTICAS] = "Essas s�o as caracter�sticas da sua turma! Voc�\r\npoder� consult�-las ao longo do jogo acessando\r\no menu e clicando no bot�o \"Sua Turma\".";
        textos[(int)ChaveTextos.CLIQUE_EM_CONFIRMAR] = "Clique em confirmar para come�ar a primeira fase\r\ndo jogo. Caso tenha mudado de ideia, clique em \r\npara alterar alguma op��o.";
        textos[(int)ChaveTextos.DICA_SEUS_ESTUDANTES] = "           Seus estudantes devem conseguir consultar\r\n informa��es atuais sobre o tema para depois aplicar o que descobriram de forma emp�rica!\r\n";
        textos[(int)ChaveTextos.OLA_SOU_LURDINHA] = "Ol�, sou a Lurdinha, sou coordenadora pedag�gica e vou\r\nte ajudar com seu planejamento!\r\n";
        textos[(int)ChaveTextos.AGORA_VOCE] = "Agora que voc� sabe o desafio da primeira metodologia, finalize sua\r\npersonaliza��o com o tema da sua aula, usando como base as caracter�sticas da turma:\r\n";
        textos[(int)ChaveTextos.QUAL_SERA_O_TEMA] = "\r\nQual ser� o tema da sua aula na metodologia 1, que acontecer� no Laborat�rio utilizando a Metodologia Aprendizagem Baseada em Problemas?";
        textos[(int)ChaveTextos.CRIEI_UM_TEMA] = "Crie um tema que vai guiar seu planejamento e as escolhas de m�dias adequadas para sua aula. ";
        textos[(int)ChaveTextos.ESSA_ESCOLHA] = "Essa escolha n�o reflete na pontua��o.";
        textos[(int)ChaveTextos.NO_MAXIMO_45] = "(No m�ximo 45 caracteres)";
        textos[(int)ChaveTextos.NA_APRENDIZAGEM_BASEADA] = "Na Aprendizagem Baseada em Problemas (ABP)\r\ndeve-se atentar para a descri��o de um contexto no qual vari�veis, sujeitos e situa��es possam ser \r\nclaramente identificados pelos estudantes\r\n\r\nO problema deve conter as seguintes caracter�sticas:\r\n\r\n* Apresentar tema e n�vel de complexidade\r\ncompat�veis com o conhecimento pr�vio dos\r\nestudantes;\r\n\r\n* Conter sugest�es ou dicas que os estimulem a\r\nidentificar poss�veis pontos de partida;\r\n\r\n* Ser simples e objetivo, para evitar que o grupo\r\ndesvie a aten��o do tema;\r\n\r\n* Mobilizar de forma articulada os elementos de \r\ncompet�ncia.\r\n";
        textos[(int)ChaveTextos.APRENSENTAR_O_PROBLEMA] = "1.Apresentar o problema e levantar os \r\nconhecimentos sobre o assunto;\r\n2.Analisar as vari�veis do problema e\r\npropor poss�veis solu��es;\r\n3. Buscar novas refer�ncias para qualificar\r\nas propostas, debater e buscar consenso\r\nsobre as poss�veis solu��es;";
        textos[(int)ChaveTextos.SEQUENCIA_DIDATICA] = "SEQU�NCIA DID�TICA:";
        textos[(int)ChaveTextos.PRIMEIRO_MOMENTO] = "1� Momento";
        textos[(int)ChaveTextos.SEGUNDO_MOMENTO] = "2� Momento";
        textos[(int)ChaveTextos.QUARTO_APRESENTAR] = "4.Apresentar as respostas e avaliar os \r\nresultados.";
        textos[(int)ChaveTextos.ESPACO_DE_APRENDIZAGEM] = "<b>Espa�o de Aprendizagem</b>";
        textos[(int)ChaveTextos.SUA_AULA_ACONTECERA] = "Sua aula acontecer� no espa�o:";
        textos[(int)ChaveTextos.DURANTE_O_MOMENTO] = "Durante o momento da aula voc� ir� responder quizes sobre sua turma, metodologia e as m�dias escolhidas a seguir!\r\n";
        textos[(int)ChaveTextos.VOCE_IRA_JOGAR_UMA_AULA] = "Voc� ir� jogar uma aula do Ensino Superior sobre Lingu�stica, Letras e Artes com uma turma de perfil Lingu�stica e L�gico-matem�tica.";
        textos[(int)ChaveTextos.NA_SEQUENCIA_DA_APRENDIZAGEM] = "Na sequ�ncia da Aprendizagem Baseada em Problemas, a aula � pensada em dois momentos onde os estudantes ir�o:";
        textos[(int)ChaveTextos.APRESENTAR_O_PROBLEMA] = "Apresentar o problema e levantar os conhecimentos sobre o assunto";
        textos[(int)ChaveTextos.APRESENTAR_AS_RESPOSTAS] = "Apresentar as respostas e avaliar os resultados";
        textos[(int)ChaveTextos.ESCOLHA_AS_MIDIAS] = "Escolha as midias adequadas para estes objetivos!";
        textos[(int)ChaveTextos.MIDIAS_PRIMEIRO_MOMENTO] = "<b>Midias - Primeiro momento</b>";
        textos[(int)ChaveTextos.ESCOLHA_DUAS_MIDIAS] = "Escolhas as duas m�dias que ser�o utilizadas na sala de aula";
        textos[(int)ChaveTextos.POPULAR] = "<style=\"title\">Popular</style>\r\n\r\nS�o m�dias muito utilizadas fora da escola, tanto para informa��o quanto para conversa��o. \r\nEstrat�gias que incluem o debate, o resgate de conhecimentos pr�vios e a contextualiza��o dos saberes escolares com a realidade podem aproveitar as m�dias populares.";
        textos[(int)ChaveTextos.PRODUCAO] = "<style=\"title\">Produ��o</style>\r\n\r\nM�dias que permitem ao estudante fazer, criar, desenvolver,  construir, montar, inventar, ou seja, ter autoria, construindo e organizando saberes durante as atividades. Atividades que geram produtos, seja na forma de exerc�cios, escrita em diferentes linguagens, esquemas para compreens�o ou prot�tipos, s�o estrat�gias did�ticas que utilizam m�dias de produ��o.";
        textos[(int)ChaveTextos.CONSULTA] = " <style=\"title\">Consulta</style>\r\n\r\nS�o m�dias utilizadas para consulta dos estudantes sobre o conte�do escolar. Apoiam todo tipo de busca de informa��o e ajudam no embasamento para tomadas de decis�o e aprofundar o conhecimento. Todas as as atividades que envolvem pesquisa, leitura, compila��o e an�lise de dados geralmente v�o exigir m�dias de consulta.";
        textos[(int)ChaveTextos.EXPOSICAO] = "<style=\"title\">Exposi��o</style>\r\n\r\nM�dias utilizadas para apresenta��o dos conte�dos, tanto por professores quanto pelos estudantes. A apresenta��o de ideias ou problemas, de trabalhos realizados, a explica��o sobre temas espec�ficos e a divulga��o de resultados e reflex�es s�o estrat�gias que se beneficiam das m�dias de exposi��o.";
        textos[(int)ChaveTextos.DIGITAL] = "<style=\"title\">Digital</style>\r\n\r\nAs m�dias digitais s�o as mais atuais. Seu desenvolvimento acelerou no s�culo XXI. Elas t�m como base o tratamento de dados em diferentes suportes f�sicos (equipamentos como computador, videogame, notebook, tablet, celular, etc) mas tamb�m virtuais como os aplicativos (programas que perimitem permitem gravar, editar e compartilhar textos, imagens e sons). S�o as m�dias da cultura digital e participativa, da intelig�ncia coletiva e do ciberespa�o. Suas principais caracter�sticas s�o a interatividade, a ubiquidade (estar em todos os lugares), a velocidade, a virtualidade e geralmente s�o utilizadas a partir de uma interface . Permitem cria��o, tratamento, compartilhamento, armazenamento e convers�o de dados em projetos que tenham como suporte a internet, a comunica��o online ou offline tais como produ��es gr�ficas, videogames, conte�dos audiovisuais ou hipertextuais, etc. Seu conte�do pode ser reproduzido, remixado e reutilizado sem perda de qualidade, o que garante um fluxo de trabalho din�mico e multimidi�tico, favorecendo a interdisciplinaridade e a integra��o entre os diferentes meios.";
        textos[(int)ChaveTextos.TRADICIONAL] = "<style=\"title\">Tradicional</style>\r\n\r\nAs m�dias tradicionais s�o aquelas consideradas a base da educa��o escolar e comp�em o padr�o \"sala de aula\" no imagin�rio da sociedade ocidental h� s�culos. Est�o presentes em todos os espa�os educativos e considera-se que os professores sabem como planejar com elas pela experi�ncia vivida na pr�pria forma��o. Seu suporte � material e f�sico podendo ser em papel (cadernos, cartazes ou fotos), em papel impresso (livro, jornais e revistas), ou estar fixo na sala de aula, como o quadro de giz.";
        textos[(int)ChaveTextos.AUDIO_VISUAL] = "<style=\"title\">Audiovisual</style>\r\n\r\nAs m�dias audiovisuais s�o a gera��o de m�dias que dominou o s�culo XX. S�o aquelas da comunica��o de massa, que atingiam grandes p�blicos e traziam imagem e som como base de sua linguagem, como o cinema, o r�dio e a televis�o e os equipamentos eram caros, grandes e profissionais. Por isso, essas m�dias faziam parte de grandes empresas de comunica��o e seus protudos eram recebidos nos locais, por antenas, cabos ou diretamente em filmes, fitas cassete, CDs ou DVDs. Os produtos eram consumidos por inteiro (programas) e poucas pessoas po, como fitas cassete ou CD/DVD.";
        textos[(int)ChaveTextos.CONFIRA_SE_SUA_ESCOLHA] = "Confira se sua escolha � a melhor op��o para este objetivo!";
        textos[(int)ChaveTextos.AREA_DE_CONHECIMENTO] = "�reas de Conhecimento";
        textos[(int)ChaveTextos.FICHA_DOIS] = "<b>Ficha 2: Planejamento</b>";
        textos[(int)ChaveTextos.SALA_DE_AULA] = "Seus estudantes devem conseguir consultar\r\n informa��es atuais sobre o tema para depois aplicar o que descobriram de forma emp�rica!\r\n";
        textos[(int)ChaveTextos.REVISE_AS_CARACTERISTICAS] = "Revise as caracter�sticas da sua turma e planejamento clicando no bloco de notas antes de avan�ar para a �ltima etapa, onde um quiz ir� testar seus conhecimentos e vamos descobrir o que os estudantes acharam da sua aula!";
        textos[(int)ChaveTextos.SUA_AULA] = "Sua aula ser� ministrada em laborat�rio utilizando a metodologia de Aprendizagem Baseada em Problemas (PBL) com as m�dias [...] e [...].";
        textos[(int)ChaveTextos.CONFIRMAR] = "CONFIRMAR";
        textos[(int)ChaveTextos.NASA_SALA_INVERTIDA] = "Na Sala de Aula Invertida h� a possibilidade de concentrar na plataforma ou ambiente virtual as informa��es necess�rias para o decorrer da disciplina ou curso, o que � um grande atrativo desse m�todo.";
        textos[(int)ChaveTextos.SEQUENCIA_DICATICA2] = "Sequ�ncia Did�tica, na sala de aula:\r\n\r\n1. Explorar o material\r\n\r\n2. Discutir com o grupo em sala de aula\r\n\r\n3. Realizar atividades";
        textos[(int)ChaveTextos.NA_SALA_DE_AULA_INVERTIDA_DOCENTE] = "Na Sala de Aula Invertida, o docente prop�e um conte�do e atividades para serem feitas em casa pelos estudantes, por meio de materiais como v�deos, podcasts ou leitura de textos, etc. Ap�s o estudo pr�vio do tema, os estudantes levam para a sala de aula suas d�vidas, realizam reflex�es em grupos e desenvolvem projetos.";
        textos[(int)ChaveTextos.MIDIAS_QUARTO] = "<b>M�dias - Quarto</b>";
        textos[(int)ChaveTextos.NA_SEQUENCIA] = "Na sequ�ncia da <b>Sala de Aula Invertida</b>, este � o momento em que os estudantes ir�o:";
        textos[(int)ChaveTextos.MIDIAS_SALA] = "<b>M�dias - Sala de Aula</b>";
        textos[(int)ChaveTextos.CONHECER_SALA_INVERTIDA] = "Vamos conhecer um pouco mais sobre a Sala de Aula Invertida?";
        textos[(int)ChaveTextos.QUARTO_ESTUDANTE] = "SALA DE ESTUDANTES";
        textos[(int)ChaveTextos.NO_MOMENTO] = "Durante a aula voc� responde question�rios sobre sua aula, metodologia e a m�dia escolhida para seguir!";
        textos[(int)ChaveTextos.NO_MOMENTO_DO_QUARTO] = "Na sala voc� interage como aluno utilizando objetos para realizar atividades!";
        textos[(int)ChaveTextos.FICHA_2_RESUMO_2] = "<b>Ficha Resumo 2: Planejamento da Aula</b>";
        textos[(int)ChaveTextos.LOGO_APOS] = "Logo ap�s, um quiz ir� testa seus conhecimentos e vamos descobrir o que os estudantes acharam da sua aula!  Boa sorte!";
        textos[(int)ChaveTextos.QUAL_SERA_O_SEU] = "Qual ser� o seu projeto na metodologia 3, que acontecer� na \r\ncidade utilizando a Metodologia Aprendizagem Baseada em Projetos?\r\n";
        textos[(int)ChaveTextos.DESEJA_REALMENTE] = "Deseja realmente voltar ao menu principal?";
        textos[(int)ChaveTextos.SIM] = "SIM";
        textos[(int)ChaveTextos.NAO] = "NAO";
        textos[(int)ChaveTextos.O_PROBLEMA_DO_PROJETO] = "O problema do projeto � multidimensional e altamente interativo, uma vez que insere os participantes em um processo de investiga��o estruturado em torno de quest�es complexas. Diante disso, a grande contribui��o dessa metodologia em sala de aula reside na �nfase ao processo de aprendizagem e na intera��o entre os estudantes.\r\n\r\n\r\nOs projetos permitem unificar v�rios aspectos importantes do processo de aprendizagem: a a��o protagonizada pelo aluno, a intencionalidade dessa a��o e sua inser��o em um contexto social.\r\n";
        textos[(int)ChaveTextos.QUAL_PERFIL] = "Qual ser� o perfil dos alunos desta turma?";
        textos[(int)ChaveTextos.POR_MEIO] = "Por meio dos princ�pios de autonomia, pesquisa, a��o e reflex�o, o desenvolvimento de um projeto parte da defini��o de um tema, da proposi��o de desafios e do planejamento e execu��o de estrat�gias para o cumprimento das a��es propostas.\r\n\r\nPara tanto, o docente deve observar os seguintes aspectos: \r\n\r\n� Conte�do significativo: relev�ncia para os estudantes.\r\n\r\n� Perguntas instigantes: mobilizar o grupo para a investiga��o, apresentando diferentes possibilidades de solu��o. \r\n\r\n� Pesquisa e inova��o: consultar diferentes fontes especializadas, buscando resultados criativos e inovadores. \r\n\r\n� Valoriza��o do processo: Aspectos relacionais e cognitivos do processo s�o fundamentais para a vida dos estudantes. ";
        textos[(int)ChaveTextos.A_SEQUENCIA_DIDATICA] = "A sequ�ncia did�tica na aprendizagem baseada em projetos pode ser dividida em tr�s momentos:\r\n\r\n� <b>Definir o escopo</b>, Planejar as etapas do projeto: � o planejamento, feito n�o s� previamente, mas durante as primeiras aulas, contando com a participa��o dos alunos.\r\n\r\n� <b>Executar as a��es previstas</b>, Monitorar o desenvolvimento do projeto: � o momento de pr�tica e execu��o do projeto, que deve ser realizado pelos alunos e acompanhado pelo professor. \r\n\r\n� <b>Apresentar os resultados</b>: De volta em sala de aula, agora os alunos devem apresentar suas an�lises e resultados. ";
        textos[(int)ChaveTextos.NO_MOMENTO_DA_CIDADE] = "No momento da cidade voc� interage com os estudantes, dando suporte para suas pesquisas.";
        textos[(int)ChaveTextos.NO_MOMENTO_AULA] = "No momento da aula voc� responde quizzes sobre sua turma, metodologia e as m�dias escolhidas a seguir!";
        textos[(int)ChaveTextos.NA_SEQUENCIA_PROJETOS] = "Na sequ�ncia da Aprendizagem Baseada em Projetos,\r\nestes ser�o os moentos em que os estudantes ir�o vivenciar";
        textos[(int)ChaveTextos.DEFINIR_ESCOPO] = "Definir o escopo, Planejar\r\nas etapas do projeto";
        textos[(int)ChaveTextos.APRESENTAR_RESULTADOS] = "Apresentar os resultados";
        textos[(int)ChaveTextos.TERCEIRO_MOMENTO] = "Terceiro momento";
        textos[(int)ChaveTextos.EXERCUTAR_ACOES] = "Executar �s a��es previstas,\r\nMonitorar o desenvolvimento \r\ndo projeto";
        textos[(int)ChaveTextos.VAMOS_PARA_TERCEIRA] = "Vamos para a terceira metodologia? \r\nAgora voc� deve escolher um tema para sua �ltima aula do jogo!";
        textos[(int)ChaveTextos.RELEMBRAR_CARACTERISTICAS] = "Relembrando as caracter�sticas da turma:";
        textos[(int)ChaveTextos.SEMPRE_QUE_POSSIVEL] = "             Sempre que poss�vel, nesta metodologia, parta do interesse dos\r\n estudantes, de uma quest�o norteadora, de um problema real. Converse\r\ncom os alunos para que encontrem motiva��o, relev�ncia e significado.\r\n";
        textos[(int)ChaveTextos.DICA] = "Dica:";
        textos[(int)ChaveTextos.VAMOS_PARA_TERCEIRA] = "Vamos para a terceira metodologia? \r\nAgora voc� deve escolher um tema para sua �ltima aula do jogo!";
        textos[(int)ChaveTextos.CARACTERISTICAS_TURMA] = "Caracteristicas da Turma";
        textos[(int)ChaveTextos.MIDIAS] = "Midias";
        textos[(int)ChaveTextos.TEMA] = "Tema";
        textos[(int)ChaveTextos.CAMPOS_DE_APRENDIZAGEM] = "Campo de Aprendizagem";
        textos[(int)ChaveTextos.METODOLOGIA_SIMPLES] = "Metodologia";
        textos[(int)ChaveTextos.LABORATORIO_1] = "Laborat�rio - M�dia 1";
        textos[(int)ChaveTextos.LABORATORIO_2] = "Laborat�rio - M�dia 2";
        textos[(int)ChaveTextos.SUA_AULA_ACABOU] = "Sua aula acabou!";
        textos[(int)ChaveTextos.ESTUDANTES_IRAO_REAGIR] = "Os estudantes ir�o reagir � sua escolha de m�dias e um quiz ir� testar seus conhecimentos. Voc� pode conferir o progresso da aula na barra � direita e sua pontua��o na barra superior.  Boa Sorte!\r\n";
        textos[(int)ChaveTextos.FINALIZOU_ABP] = "Voc� finalizou a Metodologia de Aprendizagem Baseada em Problemas";
        textos[(int)ChaveTextos.CONTINUAR] = "Continuar";
        textos[(int)ChaveTextos.JOGAR_NOVAMENTE] = "Jogar novamente";
        textos[(int)ChaveTextos.VOLTAR_PARA_O_MENU] = "Voltar para o menu de sele��o";
        textos[(int)ChaveTextos.PARABENS] = "PARAB�NS!";
        textos[(int)ChaveTextos.AGORA_ESCOLHA_COMO_CONTINUAR] = "Agora escolha como continuar:";
        textos[(int)ChaveTextos.NESTE_MOMENTO_DO_JOGO] = "Neste momento do jogo voc� responde perguntas de quiz relacionadas com suas escolhas, e isso ir� definir sua pontua��o! Os coment�rios feitos pelos estudantes sobre as m�dias t�m rela��o com o quanto elas s�o proveitosas na metodologia Aprendizagem Baseada em Problemas (ABP). A aula termina quando a barra de dura��o da aula estiver cheia.";
        textos[(int)ChaveTextos.DESEJA_REALMENTE_VOLTAR] = "Deseja realmente voltar ao menu principal?";
        textos[(int)ChaveTextos.SUA_TURMA] = "Sua turma";
        textos[(int)ChaveTextos.FIQUE_ATENTO] = "Fique atento aos estudantes, eles podem precisar da sua ajuda.";
        textos[(int)ChaveTextos.ESTUDANTE] = "Estudante";
        textos[(int)ChaveTextos.MIDIAS_ESPACO_DE_ENSINO] = "<b>Midias - Espa�o de ensino</b>";
        textos[(int)ChaveTextos.ESCOLHAS_AS_DUAS_MIDIAS] = "Escolhas as duas m�dias que ser�o utilizadas na sala de aula";
        textos[(int)ChaveTextos.AGORA_OS_ESTUDANTES] = "Agora os estudantes v�o reagir ao seu tema de aula\r\nBoa Sorte!\r\n O tema da aula �: ";
        textos[(int)ChaveTextos.COM_ESSA_INFORMACAO] = "Com essa informa��o d� continuidade ao seu planejamento!";
        textos[(int)ChaveTextos.OS_ESTUDANTES_TROUXERAM] = "Os estudantes trouxeram as tarefas realizadas em casa.\r\nAgora um quiz ir� testar seus conhecimentos e al�m de\r\ndescobrir a rea��o dos estudantes � sua escolha de m�dias,\r\nvoc� ir� ajuda-los em imprevistos da sala de aula.\r\nBoa Sorte!\r\n";
        textos[(int)ChaveTextos.AGRUPAMENTOS] = "Agrupamentos";
        textos[(int)ChaveTextos.AGRUPAMENTOS_1] = "Agrupamentos 1";
        textos[(int)ChaveTextos.AGRUPAMENTOS_2] = "Agrupamentos 2";
        textos[(int)ChaveTextos.QUARTO_MIDIA_1] = "Quarto - Midia 1";
        textos[(int)ChaveTextos.QUARTO_MIDIA_2] = "Quarto - Midia 2";
        textos[(int)ChaveTextos.SALA_MIDIA_1] = "Sala - Midia 1";
        textos[(int)ChaveTextos.SALA_MIDIA_2] = "Sala - Midia 2";
        textos[(int)ChaveTextos.AGORA_VOCE_ESTA] = "Agora voc� est� no papel do estudante, o perfil da sua turma\r\ndeve influenciar nas atividades de lazer e os objetos t�m que\r\nse relacionar com as m�dias selecionadas no seu planejamento.";
        textos[(int)ChaveTextos.HORA_DE_ESTUDAR] = "Hora de estudar!";
        textos[(int)ChaveTextos.VOU_FAZER_AS_TAREFAS] = "Vou fazer as tarefas para a aula mas\r\nantes vou aproveitar meu tempo\r\nlivre e me divertir um pouco!";
        textos[(int)ChaveTextos.VOCE_CONCLUIU] = "Vou fazer as tarefas para a aula mas\r\nantes vou aproveitar meu tempo\r\nlivre e me divertir um pouco!";
        textos[(int)ChaveTextos.TERMINEI_TUDO] = "Terminei tudo, que bom! Agora � hora de ir pra escola.";
        textos[(int)ChaveTextos.ESCREVA_AQUI] = "Escreva aqui"; 
        textos[(int)ChaveTextos.ESCOLHA_AS_MIDIAS_ADEQUADAS] = "Escolha as midias adequadas";
        textos[(int)ChaveTextos.EXPLORANDO_SOBRE_O_TEMA] = "               Explorando sobre o tema em casa, os estudantes\r\n organizam melhor as ideias ativamente em sala criando\r\n conhecimento e apresentando aos colegas o que aprenderam!";
        textos[(int)ChaveTextos.ESCOLHA_O_AGRUPAMENTO] = "Escolha o agrupamento";
        textos[(int)ChaveTextos.ESPERE_NA_AB] = "Espere! Na ABProj n�o d� para planejar sem ouvir seus estudantes!\r\n\r\nPara escolher a m�dia utilizada na cidade, apresente sua proposta para o projeto aos estudantes, e descubra em qual lugar da cidade eles preferem realiz�-lo!";
        textos[(int)ChaveTextos.FICHA_NUMERO_2] = "<b>Ficha Resumo 2: Planejamento da Aula</b>";
        textos[(int)ChaveTextos.QUIZ] = "Quiz";
        textos[(int)ChaveTextos.AULA_COMUM] = "Aula Comum";
        textos[(int)ChaveTextos.AULA_CONFUSA] = "Aula confusa";
        textos[(int)ChaveTextos.AULA_REVELADO] = "Aula revelado";
        textos[(int)ChaveTextos.DISCUTIR_COM_O_GRUPO] = "Discutir com o grupo em sala de aula";
        textos[(int)ChaveTextos.REALIZAR_ATIVIDADES] = "Realizar atividades";
        textos[(int)ChaveTextos.POSITIVE_PRE_FIX] = "Me diverti muito";
        textos[(int)ChaveTextos.NEGATIVE_PRE_FIX] = "N�o me diverti muito, pra mim";
        textos[(int)ChaveTextos.TIVE_DIFICULDADE_PARA_FAZER_AS_TAREFAS] = "<color=red>Tive dificuldades para fazer as tarefas com";
        textos[(int)ChaveTextos.E] = "e";
        textos[(int)ChaveTextos.CONSEGUI_FAZER_AS_ATIVIDADES] = "Consegui fazer as atividades com ";
        textos[(int)ChaveTextos.MAS_TIVE_DIFICULDADES] = "<color=red>mas tive dificuldades para fazer outras tarefas com";
        textos[(int)ChaveTextos.VOCE_CONCLUIU_A_PRIMEIRA_PARTE] = "Voc� concluiu a primeira parte desta metodologia! Agora seu planejamento continuar� na sala de aula!";
        textos[(int)ChaveTextos.FINALIZOU_INVERTIDA] = "Voc� finalizou a Metodologia Sala de Aula Invertida";
        textos[(int)ChaveTextos.ESTAMOS_CHEGANDO] = "Estamos chegando no final do projeto! Ap�s muito tempo de planejamento, visita��o e dedica��o �s atividades, os estudantes v�o apresentar suas conclus�es e resultados! \r\n� lindo ver todo esse trabalho tomando forma!";
        textos[(int)ChaveTextos.AGORA_VOCE_RESPONDERA] = "Agora voc� responder� um quiz e ir� se preparar para realizar o projeto na cidade! ";
        textos[(int)ChaveTextos.NESTE_MOMENTO] = "Tema";
        textos[(int)ChaveTextos.JOGOS] = "<style=\"title\">Jogos</style>\r\n\r\nOs jogos digitais s�o sistemas de simula��es da realidade que substitu�da por situa��es l�dicas, permitindo aos jogadores uma vis�o de distintos modelos de realidade. Estudos demostram que os jogos digitais podem desenvolver habilidades como o pensamento cr�tico e o sistem�tico, a resolu��o de problemas, o desenvolvimento da ortografia, do vocabul�rio e da leitura, bem como aprendizagens espec�ficas de dom�nio de diferentes �reas (como um novo idioma, por exemplo) al�m de uma gama de habilidades cognitivas, incluindo visualiza��o espacial, aten��o dividida e autorregula��o emocional. Os jogos se configuram como um meio pedag�gico vers�til, atrav�s do qual as pr�ticas sociais se entrela�am e os conhecimentos individuais se relacionam, na intera��o com a informa��o, com outros estudantes, ferramentas e materiais. A divers�o assume fator importante no processo, aliada ao relaxamento e motiva��o que os desafios trazem para executar as a��es.";
        textos[(int)ChaveTextos.APPS_DE_GAMIFICACAO] = "<style=\"title\">Apps de Gamifica��o de Conte�dos Educacionais</style>\r\n\r\nA gamifica��o consiste em utilizar ferramentas e elementos de jogos em contexto fora de jogo. Os aplicativos de conte�dos gamificados tornam a pr�tica de estudar um desafio, uma pr�tica prazeirosa que aproveita as caracter�sticas dos jogos para criar um ambiente prop�cio para a aprendizagem. Um aplicativo com exerc�cios de matem�tica ou de idiomas pode dar pontos e demarcar os feitos do usu�rio com distintivos e marcos que demonstram todo o trajeto e conquistas at� o momento.";
        textos[(int)ChaveTextos.EDITORES_DE_AUDIO] = "<style=\"title\">Editores de �udio e V�deo</style>\r\n\r\nOs sotwares de edi��o de �udio e v�deo s�o ferramentas que instigam a pesquisa em sala de aula, pois, ao produzir com essas m�dias podemos incentivar a reflex�o de diferentes temas, a criatividade e o trabalho em equipe. Muitos destes softwares apresentam um conjunto de ferramentas vers�teis, din�micas e de f�cil aprendizado. Para fazer seus v�deos ou �udios, os estudantes precisam exercitar intera��o, interatividade e pensar em formas diferentes e din�micas de transmitir o que eles querem dizer e de conquistar a aten��o de seus colegas, dessa forma constroem conhecimento em colabora��o, a partir deste recurso tecnol�gico. Al�m disso, a produ��o audiovisual � tanto uma linguagem como uma habilidade importante para as demandas do s�culo XXI.";
        textos[(int)ChaveTextos.COMPARTILHAMENTO_DE_AUDIOS] = "<style=\"title\">Compartilhamento de �udio e som</style>\r\n\r\nAs redes sociais de compartilhamento de imagem e som possibilitam aos usu�rios compartilhar e buscar imagens e v�deos. Fazer coment�rios e interagir com outras pessoas, estabelecendo contatos profissionais ou pessoais.";
        textos[(int)ChaveTextos.COMPARTILHAMENTO_DE_OPINIOS] = "<style=\"title\">Compartilhamento de Opini�o</style>\r\n\r\nAs redes sociais de opini�o t�m como caracter�stica o compartilhamento e busca de informa��es sobre temas variados. Como tamb�m a troca de fotos e v�deos que geram redes de relacionamento e a conex�o de pessoas.";
        textos[(int)ChaveTextos.CONEXOES_INTERPESSOAIS] = "<style=\"title\">Conex�es Interpessoais</style>\r\n\r\nAs redes sociais de conex�es interpessoais t�m como objetivo as redes de relacionamento. Possibilitam o envio de mensagens instant�neas. Al�m de permitir ao usu�rio compartilhar e buscar conhecimentos profissionais.";
        textos[(int)ChaveTextos.COMUNICACAO] = "<style=\"title\">Comunica��o</style>\r\n\r\nPlataformas de comunica��o, por meio da rede de dados, disponibilizam um conjunto de funcionalidades que torna poss�vel a comunica��o em tempo real entre duas ou mais pessoas, coletando, organizando e disponibilizando informa��es para consultas e intera��es. Sendo poss�vel ter de maneira virtual reuni�es, encontros e aulas.";
        textos[(int)ChaveTextos.ARMAZENAMENTO] = "<style=\"title\">Armazenamento</style>\r\n\r\nPlataformas de armazenamento garantem acesso a imagens, v�deos, �udios, textos, planilhas e qualquer arquivo digital em qualquer lugar que tenha acesso � internet. � poss�vel compartilhar, gerenciar e utilizar um mesmo arquivo por mais de uma pessoa tendo atualiza��o das mudan�as em tempo real.";
        textos[(int)ChaveTextos.GERENCIAMENTO] = "<style=\"title\">Gerenciamento</style>\r\n\r\nPlataformas de gerenciamento permite trabalhos em equipe para desenvolvimento de projetos, para planejamento e execu��o de aulas.";
        textos[(int)ChaveTextos.NA_SEQUENCIA_DA_APRENDIZAGEM_BASEADA_EM_PROJETOS] = "Na sequ�ncia da <b>Aprendizagem Baseada em Projetos</b>, \r\nestes ser�o os momentos em que os estudantes ir�o vivenciar\r\n";
        textos[(int)ChaveTextos.OBSERVE_SE_SUA_ESCOLHA] = "Observe se sua escolha � a melhor op��o para estes objetivos!";
        textos[(int)ChaveTextos.PEGUE_DENTRO_DO_ARMARIO] = "<b>Pegue dentro do arm�rio m�dias para utilizar na cidade</b>";
        textos[(int)ChaveTextos.SUA_AULA_LAB] = "Sua aula acontecer� no LABORAT�RIO";
        textos[(int)ChaveTextos.DESBLOQUEOU_ABP] = "Voc� desbloqueou a metodologia ativa de";
        textos[(int)ChaveTextos.SUA_AULA_QUARTO] = "Sua aula acontecer� QUARTO DO ALUNO e na SALA DE AULA.";
        textos[(int)ChaveTextos.SUA_AULA_CIDADE] = "Sua aula acontecer� na CIDADE e na SALA DE AULA";
        textos[(int)ChaveTextos.PARA_COMECAR] = "Para come�ar:";
        textos[(int)ChaveTextos.TEMA] = "Tema";
        textos[(int)ChaveTextos.TEMA] = "Tema";
        textos[(int)ChaveTextos.TEMA] = "Tema";
        textos[(int)ChaveTextos.TEMA] = "Tema";
        textos[(int)ChaveTextos.TEMA] = "Tema";
        textos[(int)ChaveTextos.TEMA] = "Tema";
    }

}
