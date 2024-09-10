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
        textos[(int)ChaveTextos.SALA_DE_AULAB] = "SALA DE AULA";

        textos[(int)ChaveTextos.APRENDIZAGEM_BASEADA_EM_PROJETOS] = "Aprendizagem baseada em projetos (ABPj)";
        textos[(int)ChaveTextos.CIDADE] = "CIDADE";
        textos[(int)ChaveTextos.TEXT_METODOLOGIA3] = "Metodologia na qual propõe-se um projeto\r\ntemático que deve ser planejado e\r\n executado a fim de cumprir com as ações\r\npropostas.";

        textos[(int)ChaveTextos.AGORA_E_COM_VOCE] = "<color=#0B355D>Agora é com você! </color>\r\n";
        textos[(int)ChaveTextos.SELECIONE_UMA_DAS_OPCOES] = "Selecione uma das opções:\r\nVocê quer jogar a <color=#0B355D>EXPERIENCIA COMPLETA?</color>";
        textos[(int)ChaveTextos.OU_METODOLOGIAS_ATIVAS] = "Ou <color=#0B355D>UMA DAS METODOLOGIAS ATIVAS?</color>";
        textos[(int)ChaveTextos.POP_INTRO_2] = "Juntos vamos explorar os vários\r\nusos de mídias digitais na educação.\r\n\r\nVocê começa o jogo escolhendo a sua fisionomia e montando as características da sua turma, que vão se manter ao longo das fases,\r\nservindo como base do seu planejamento.\r\n\r\nNo botão  =  você encontra as opções do menu,\r\ne se tiver dúvidas basta clicar no botão : ?\r\n \r\nPara iniciar, clique em  OK  e divirta-se escolhendo\r\nseu personagem e personalizando sua turma!";

        textos[(int)ChaveTextos.PERSONAGEM] = "<b>Character</b>";
        textos[(int)ChaveTextos.ESCOLHA_AVATAR] = "Escolha seu personagem";
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
        textos[(int)ChaveTextos.PROGRAMACAO] = "<b>Programação</b>\r\n\r\nAlexis Mendes Sequeira\r\nBruno Souza da Silva\r\nNicole Alves Guglielmetti\r\nMatheus Aparicio da Silva\r\nBernardo Gomes Duarte\r\nThéo Floriano dos Santos\r\nEric Fernandes Evaristo\r\nLuccas Baillo Lopes";
        textos[(int)ChaveTextos.PEDAGOGICO] = "<b>Pedagógico</b>\r\n\r\nDenise Figueredo Loch\r\nLucas Souza Pinheiro\r\nRaquel Ferreira da Rosa Oliveira\r\nRicardo Kerscher\r\nJayziela Jessica Fuck\r\nJeremias Martin Calandrini Coelho\r\nVicente Campana Bif";
        textos[(int)ChaveTextos.UX_GESTAO] = "<b>UX, Gestão e QA</b>\r\n\r\nIsadora Beagle";
        textos[(int)ChaveTextos.CNPG] = "<b>Financeamento CNPq</b>\r\n\r\nIsadora Beagle";

        textos[(int)ChaveTextos.ESCOLHA_ESTAGIO_APRENDIZAGEM] = "Escolha o estágio de aprendizagem da turma:";
        textos[(int)ChaveTextos.COM_BASE_ENSINO] = "Com base no nível de ensino, o que será estudado?";
        textos[(int)ChaveTextos.NIVEL_DE_ENSINO] = "<b>Nível de Ensino</b>";
        textos[(int)ChaveTextos.CAMPOS_DE_EXPERIENCIA] = "<b>Campos de Experiências</b>";
        textos[(int)ChaveTextos.INTELIGENCIAS_MULTIPLAS] = "<b>Inteligências Múltiplas</b>";
        textos[(int)ChaveTextos.CARACTERISTICAS_DA_TURMA] = "<b>Ficha 1: Características da Turma</b>";
        textos[(int)ChaveTextos.PERFIL_ESTUDANTES_TURMA] = "Qual será o perfil dos estudantes desta turma?";

        textos[(int)ChaveTextos.SAO_AS_CARACTERISTICAS] = "Essas são as características da sua turma! Você\r\npoderá consultá-las ao longo do jogo acessando\r\no menu e clicando no botão \"Sua Turma\".";
        textos[(int)ChaveTextos.CLIQUE_EM_CONFIRMAR] = "Clique em confirmar para começar a primeira fase\r\ndo jogo. Caso tenha mudado de ideia, clique em \r\npara alterar alguma opção.";
        textos[(int)ChaveTextos.DICA_SEUS_ESTUDANTES] = "           Seus estudantes devem conseguir consultar\r\n informações atuais sobre o tema para depois aplicar o que descobriram de forma empírica!\r\n";
        textos[(int)ChaveTextos.OLA_SOU_LURDINHA] = "Olá, sou a Lurdinha, sou coordenadora pedagógica e vou\r\nte ajudar com seu planejamento!\r\n";
        textos[(int)ChaveTextos.AGORA_VOCE] = "Agora que você sabe o desafio da primeira metodologia, finalize sua\r\npersonalização com o tema da sua aula, usando como base as características da turma:\r\n";
        textos[(int)ChaveTextos.QUAL_SERA_O_TEMA] = "\r\nQual será o tema da sua aula na metodologia 1, que acontecerá no Laboratório utilizando a Metodologia Aprendizagem Baseada em Problemas?";
        textos[(int)ChaveTextos.CRIEI_UM_TEMA] = "Crie um tema que vai guiar seu planejamento e as escolhas de mídias adequadas para sua aula. ";
        textos[(int)ChaveTextos.ESSA_ESCOLHA] = "Essa escolha não reflete na pontuação.";
        textos[(int)ChaveTextos.NO_MAXIMO_45] = "(No máximo 45 caracteres)";
        textos[(int)ChaveTextos.NA_APRENDIZAGEM_BASEADA] = "Na Aprendizagem Baseada em Problemas (ABP)\r\ndeve-se atentar para a descrição de um contexto no qual variáveis, sujeitos e situações possam ser \r\nclaramente identificados pelos estudantes\r\n\r\nO problema deve conter as seguintes características:\r\n\r\n* Apresentar tema e nível de complexidade\r\ncompatíveis com o conhecimento prévio dos\r\nestudantes;\r\n\r\n* Conter sugestões ou dicas que os estimulem a\r\nidentificar possíveis pontos de partida;\r\n\r\n* Ser simples e objetivo, para evitar que o grupo\r\ndesvie a atenção do tema;\r\n\r\n* Mobilizar de forma articulada os elementos de \r\ncompetência.\r\n";
        textos[(int)ChaveTextos.APRENSENTAR_O_PROBLEMA] = "1.Apresentar o problema e levantar os \r\nconhecimentos sobre o assunto;\r\n2.Analisar as variáveis do problema e\r\npropor possíveis soluções;\r\n3. Buscar novas referências para qualificar\r\nas propostas, debater e buscar consenso\r\nsobre as possíveis soluções;";
        textos[(int)ChaveTextos.SEQUENCIA_DIDATICA] = "SEQUÊNCIA DIDÁTICA:";
        textos[(int)ChaveTextos.PRIMEIRO_MOMENTO] = "1° Momento";
        textos[(int)ChaveTextos.SEGUNDO_MOMENTO] = "2° Momento";
        textos[(int)ChaveTextos.QUARTO_APRESENTAR] = "4.Apresentar as respostas e avaliar os \r\nresultados.";
        textos[(int)ChaveTextos.ESPACO_DE_APRENDIZAGEM] = "<b>Espaço de Aprendizagem</b>";
        textos[(int)ChaveTextos.SUA_AULA_ACONTECERA] = "Sua aula acontecerá no espaço:";
        textos[(int)ChaveTextos.DURANTE_O_MOMENTO] = "Durante o momento da aula você irá responder quizes sobre sua turma, metodologia e as mídias escolhidas a seguir!\r\n";
        textos[(int)ChaveTextos.VOCE_IRA_JOGAR_UMA_AULA] = "Você irá jogar uma aula do Ensino Superior sobre Linguística, Letras e Artes com uma turma de perfil Linguística e Lógico-matemática.";
        textos[(int)ChaveTextos.NA_SEQUENCIA_DA_APRENDIZAGEM] = "Na sequência da Aprendizagem Baseada em Problemas, a aula é pensada em dois momentos onde os estudantes irão:";
        textos[(int)ChaveTextos.APRESENTAR_O_PROBLEMA] = "Apresentar o problema e levantar os conhecimentos sobre o assunto";
        textos[(int)ChaveTextos.APRESENTAR_AS_RESPOSTAS] = "Apresentar as respostas e avaliar os resultados";
        textos[(int)ChaveTextos.ESCOLHA_AS_MIDIAS] = "Escolha as midias adequadas para estes objetivos!";
        textos[(int)ChaveTextos.MIDIAS_PRIMEIRO_MOMENTO] = "<b>Midias - Primeiro momento</b>";
        textos[(int)ChaveTextos.ESCOLHA_DUAS_MIDIAS] = "Escolhas as duas mídias que serão utilizadas na sala de aula";
        textos[(int)ChaveTextos.POPULAR] = "<style=\"title\">Popular</style>\r\n\r\nSão mídias muito utilizadas fora da escola, tanto para informação quanto para conversação. \r\nEstratégias que incluem o debate, o resgate de conhecimentos prévios e a contextualização dos saberes escolares com a realidade podem aproveitar as mídias populares.";
        textos[(int)ChaveTextos.PRODUCAO] = "<style=\"title\">Produção</style>\r\n\r\nMídias que permitem ao estudante fazer, criar, desenvolver,  construir, montar, inventar, ou seja, ter autoria, construindo e organizando saberes durante as atividades. Atividades que geram produtos, seja na forma de exercícios, escrita em diferentes linguagens, esquemas para compreensão ou protótipos, são estratégias didáticas que utilizam mídias de produção.";
        textos[(int)ChaveTextos.CONSULTA] = " <style=\"title\">Consulta</style>\r\n\r\nSão mídias utilizadas para consulta dos estudantes sobre o conteúdo escolar. Apoiam todo tipo de busca de informação e ajudam no embasamento para tomadas de decisão e aprofundar o conhecimento. Todas as as atividades que envolvem pesquisa, leitura, compilação e análise de dados geralmente vão exigir mídias de consulta.";
        textos[(int)ChaveTextos.EXPOSICAO] = "<style=\"title\">Exposição</style>\r\n\r\nMídias utilizadas para apresentação dos conteúdos, tanto por professores quanto pelos estudantes. A apresentação de ideias ou problemas, de trabalhos realizados, a explicação sobre temas específicos e a divulgação de resultados e reflexões são estratégias que se beneficiam das mídias de exposição.";
        textos[(int)ChaveTextos.DIGITAL] = "<style=\"title\">Digital</style>\r\n\r\nAs mídias digitais são as mais atuais. Seu desenvolvimento acelerou no século XXI. Elas têm como base o tratamento de dados em diferentes suportes físicos (equipamentos como computador, videogame, notebook, tablet, celular, etc) mas também virtuais como os aplicativos (programas que perimitem permitem gravar, editar e compartilhar textos, imagens e sons). São as mídias da cultura digital e participativa, da inteligência coletiva e do ciberespaço. Suas principais características são a interatividade, a ubiquidade (estar em todos os lugares), a velocidade, a virtualidade e geralmente são utilizadas a partir de uma interface . Permitem criação, tratamento, compartilhamento, armazenamento e conversão de dados em projetos que tenham como suporte a internet, a comunicação online ou offline tais como produções gráficas, videogames, conteúdos audiovisuais ou hipertextuais, etc. Seu conteúdo pode ser reproduzido, remixado e reutilizado sem perda de qualidade, o que garante um fluxo de trabalho dinâmico e multimidiático, favorecendo a interdisciplinaridade e a integração entre os diferentes meios.";
        textos[(int)ChaveTextos.TRADICIONAL] = "<style=\"title\">Tradicional</style>\r\n\r\nAs mídias tradicionais são aquelas consideradas a base da educação escolar e compõem o padrão \"sala de aula\" no imaginário da sociedade ocidental há séculos. Estão presentes em todos os espaços educativos e considera-se que os professores sabem como planejar com elas pela experiência vivida na própria formação. Seu suporte é material e físico podendo ser em papel (cadernos, cartazes ou fotos), em papel impresso (livro, jornais e revistas), ou estar fixo na sala de aula, como o quadro de giz.";
        textos[(int)ChaveTextos.AUDIO_VISUAL] = "<style=\"title\">Audiovisual</style>\r\n\r\nAs mídias audiovisuais são a geração de mídias que dominou o século XX. São aquelas da comunicação de massa, que atingiam grandes públicos e traziam imagem e som como base de sua linguagem, como o cinema, o rádio e a televisão e os equipamentos eram caros, grandes e profissionais. Por isso, essas mídias faziam parte de grandes empresas de comunicação e seus protudos eram recebidos nos locais, por antenas, cabos ou diretamente em filmes, fitas cassete, CDs ou DVDs. Os produtos eram consumidos por inteiro (programas) e poucas pessoas po, como fitas cassete ou CD/DVD.";
        textos[(int)ChaveTextos.CONFIRA_SE_SUA_ESCOLHA] = "Confira se sua escolha é a melhor opção para este objetivo!";
        textos[(int)ChaveTextos.AREA_DE_CONHECIMENTO] = "Áreas de Conhecimento";
        textos[(int)ChaveTextos.FICHA_DOIS] = "<b>Ficha 2: Planejamento</b>";
        textos[(int)ChaveTextos.SALA_DE_AULA] = "Seus estudantes devem conseguir consultar\r\n informações atuais sobre o tema para depois aplicar o que descobriram de forma empírica!\r\n";
        textos[(int)ChaveTextos.REVISE_AS_CARACTERISTICAS] = "Revise as características da sua turma e planejamento clicando no bloco de notas antes de avançar para a última etapa, onde um quiz irá testar seus conhecimentos e vamos descobrir o que os estudantes acharam da sua aula!";
        textos[(int)ChaveTextos.SUA_AULA] = "Sua aula será ministrada em laboratório utilizando a metodologia de Aprendizagem Baseada em Problemas (PBL) com as mídias [...] e [...].";
        textos[(int)ChaveTextos.CONFIRMAR] = "CONFIRMAR";
        textos[(int)ChaveTextos.NASA_SALA_INVERTIDA] = "Na Sala de Aula Invertida há a possibilidade de concentrar na plataforma ou ambiente virtual as informações necessárias para o decorrer da disciplina ou curso, o que é um grande atrativo desse método.";
        textos[(int)ChaveTextos.SEQUENCIA_DICATICA2] = "Sequência Didática, na sala de aula:\r\n\r\n1. Explorar o material\r\n\r\n2. Discutir com o grupo em sala de aula\r\n\r\n3. Realizar atividades";
        textos[(int)ChaveTextos.NA_SALA_DE_AULA_INVERTIDA_DOCENTE] = "Na Sala de Aula Invertida, o docente propõe um conteúdo e atividades para serem feitas em casa pelos estudantes, por meio de materiais como vídeos, podcasts ou leitura de textos, etc. Após o estudo prévio do tema, os estudantes levam para a sala de aula suas dúvidas, realizam reflexões em grupos e desenvolvem projetos.";
        textos[(int)ChaveTextos.MIDIAS_QUARTO] = "<b>Mídias - Quarto</b>";
        textos[(int)ChaveTextos.NA_SEQUENCIA] = "Na sequência da <b>Sala de Aula Invertida</b>, este é o momento em que os estudantes irão:";
        textos[(int)ChaveTextos.MIDIAS_SALA] = "<b>Mídias - Sala de Aula</b>";
        textos[(int)ChaveTextos.CONHECER_SALA_INVERTIDA] = "Vamos conhecer um pouco mais sobre a Sala de Aula Invertida?";
        textos[(int)ChaveTextos.QUARTO_ESTUDANTE] = "SALA DE ESTUDANTES";
        textos[(int)ChaveTextos.NO_MOMENTO] = "Durante a aula você responde questionários sobre sua aula, metodologia e a mídia escolhida para seguir!";
        textos[(int)ChaveTextos.NO_MOMENTO_DO_QUARTO] = "Na sala você interage como aluno utilizando objetos para realizar atividades!";
        textos[(int)ChaveTextos.FICHA_2_RESUMO_2] = "<b>Ficha Resumo 2: Planejamento da Aula</b>";
        textos[(int)ChaveTextos.LOGO_APOS] = "Logo após, um quiz irá testa seus conhecimentos e vamos descobrir o que os estudantes acharam da sua aula!  Boa sorte!";
        textos[(int)ChaveTextos.QUAL_SERA_O_SEU] = "Qual será o seu projeto na metodologia 3, que acontecerá na \r\ncidade utilizando a Metodologia Aprendizagem Baseada em Projetos?\r\n";
        textos[(int)ChaveTextos.DESEJA_REALMENTE] = "Deseja realmente voltar ao menu principal?";
        textos[(int)ChaveTextos.SIM] = "SIM";
        textos[(int)ChaveTextos.NAO] = "NAO";
        textos[(int)ChaveTextos.O_PROBLEMA_DO_PROJETO] = "O problema do projeto é multidimensional e altamente interativo, uma vez que insere os participantes em um processo de investigação estruturado em torno de questões complexas. Diante disso, a grande contribuição dessa metodologia em sala de aula reside na ênfase ao processo de aprendizagem e na interação entre os estudantes.\r\n\r\n\r\nOs projetos permitem unificar vários aspectos importantes do processo de aprendizagem: a ação protagonizada pelo aluno, a intencionalidade dessa ação e sua inserção em um contexto social.\r\n";
        textos[(int)ChaveTextos.QUAL_PERFIL] = "Qual será o perfil dos alunos desta turma?";
        textos[(int)ChaveTextos.POR_MEIO] = "Por meio dos princípios de autonomia, pesquisa, ação e reflexão, o desenvolvimento de um projeto parte da definição de um tema, da proposição de desafios e do planejamento e execução de estratégias para o cumprimento das ações propostas.\r\n\r\nPara tanto, o docente deve observar os seguintes aspectos: \r\n\r\n• Conteúdo significativo: relevância para os estudantes.\r\n\r\n• Perguntas instigantes: mobilizar o grupo para a investigação, apresentando diferentes possibilidades de solução. \r\n\r\n• Pesquisa e inovação: consultar diferentes fontes especializadas, buscando resultados criativos e inovadores. \r\n\r\n• Valorização do processo: Aspectos relacionais e cognitivos do processo são fundamentais para a vida dos estudantes. ";
        textos[(int)ChaveTextos.A_SEQUENCIA_DIDATICA] = "A sequência didática na aprendizagem baseada em projetos pode ser dividida em três momentos:\r\n\r\n• <b>Definir o escopo</b>, Planejar as etapas do projeto: é o planejamento, feito não só previamente, mas durante as primeiras aulas, contando com a participação dos alunos.\r\n\r\n• <b>Executar as ações previstas</b>, Monitorar o desenvolvimento do projeto: É o momento de prática e execução do projeto, que deve ser realizado pelos alunos e acompanhado pelo professor. \r\n\r\n• <b>Apresentar os resultados</b>: De volta em sala de aula, agora os alunos devem apresentar suas análises e resultados. ";
        textos[(int)ChaveTextos.NO_MOMENTO_DA_CIDADE] = "No momento da cidade você interage com os estudantes, dando suporte para suas pesquisas.";
        textos[(int)ChaveTextos.NO_MOMENTO_AULA] = "No momento da aula você responde quizzes sobre sua turma, metodologia e as mídias escolhidas a seguir!";
        textos[(int)ChaveTextos.NA_SEQUENCIA_PROJETOS] = "Na sequência da Aprendizagem Baseada em Projetos,\r\nestes serão os moentos em que os estudantes irão vivenciar";
        textos[(int)ChaveTextos.DEFINIR_ESCOPO] = "Definir o escopo, Planejar\r\nas etapas do projeto";
        textos[(int)ChaveTextos.APRESENTAR_RESULTADOS] = "Apresentar os resultados";
        textos[(int)ChaveTextos.TERCEIRO_MOMENTO] = "Terceiro momento";
        textos[(int)ChaveTextos.EXERCUTAR_ACOES] = "Executar ás ações previstas,\r\nMonitorar o desenvolvimento \r\ndo projeto";
        textos[(int)ChaveTextos.VAMOS_PARA_TERCEIRA] = "Vamos para a terceira metodologia? \r\nAgora você deve escolher um tema para sua última aula do jogo!";
        textos[(int)ChaveTextos.RELEMBRAR_CARACTERISTICAS] = "Relembrando as características da turma:";
        textos[(int)ChaveTextos.SEMPRE_QUE_POSSIVEL] = "             Sempre que possível, nesta metodologia, parta do interesse dos\r\n estudantes, de uma questão norteadora, de um problema real. Converse\r\ncom os alunos para que encontrem motivação, relevância e significado.\r\n";
        textos[(int)ChaveTextos.DICA] = "Dica:";
        textos[(int)ChaveTextos.VAMOS_PARA_TERCEIRA] = "Vamos para a terceira metodologia? \r\nAgora você deve escolher um tema para sua última aula do jogo!";
        textos[(int)ChaveTextos.CARACTERISTICAS_TURMA] = "Caracteristicas da Turma";
        textos[(int)ChaveTextos.MIDIAS] = "Midias";
        textos[(int)ChaveTextos.TEMA] = "Tema";
        textos[(int)ChaveTextos.CAMPOS_DE_APRENDIZAGEM] = "Campo de Aprendizagem";
        textos[(int)ChaveTextos.METODOLOGIA_SIMPLES] = "Metodologia";
        textos[(int)ChaveTextos.LABORATORIO_1] = "Laboratório - Mídia 1";
        textos[(int)ChaveTextos.LABORATORIO_2] = "Laboratório - Mídia 2";
        textos[(int)ChaveTextos.SUA_AULA_ACABOU] = "Sua aula acabou!";
        textos[(int)ChaveTextos.ESTUDANTES_IRAO_REAGIR] = "Os estudantes irão reagir à sua escolha de mídias e um quiz irá testar seus conhecimentos. Você pode conferir o progresso da aula na barra à direita e sua pontuação na barra superior.  Boa Sorte!\r\n";
        textos[(int)ChaveTextos.FINALIZOU_ABP] = "Você finalizou a Metodologia de Aprendizagem Baseada em Problemas";
        textos[(int)ChaveTextos.CONTINUAR] = "Continuar";
        textos[(int)ChaveTextos.JOGAR_NOVAMENTE] = "Jogar novamente";
        textos[(int)ChaveTextos.VOLTAR_PARA_O_MENU] = "Voltar para o menu de seleção";
        textos[(int)ChaveTextos.PARABENS] = "PARABÉNS!";
        textos[(int)ChaveTextos.AGORA_ESCOLHA_COMO_CONTINUAR] = "Agora escolha como continuar:";
        textos[(int)ChaveTextos.NESTE_MOMENTO_DO_JOGO] = "Neste momento do jogo você responde perguntas de quiz relacionadas com suas escolhas, e isso irá definir sua pontuação! Os comentários feitos pelos estudantes sobre as mídias têm relação com o quanto elas são proveitosas na metodologia Aprendizagem Baseada em Problemas (ABP). A aula termina quando a barra de duração da aula estiver cheia.";
        textos[(int)ChaveTextos.DESEJA_REALMENTE_VOLTAR] = "Deseja realmente voltar ao menu principal?";
        textos[(int)ChaveTextos.SUA_TURMA] = "Sua turma";
        textos[(int)ChaveTextos.FIQUE_ATENTO] = "Fique atento aos estudantes, eles podem precisar da sua ajuda.";
        textos[(int)ChaveTextos.ESTUDANTE] = "Estudante";
        textos[(int)ChaveTextos.MIDIAS_ESPACO_DE_ENSINO] = "<b>Midias - Espaço de ensino</b>";
        textos[(int)ChaveTextos.ESCOLHAS_AS_DUAS_MIDIAS] = "Escolhas as duas mídias que serão utilizadas na sala de aula";
        textos[(int)ChaveTextos.AGORA_OS_ESTUDANTES] = "Agora os estudantes vão reagir ao seu tema de aula\r\nBoa Sorte!\r\n O tema da aula é: ";
        textos[(int)ChaveTextos.COM_ESSA_INFORMACAO] = "Com essa informação dê continuidade ao seu planejamento!";
        textos[(int)ChaveTextos.OS_ESTUDANTES_TROUXERAM] = "Os estudantes trouxeram as tarefas realizadas em casa.\r\nAgora um quiz irá testar seus conhecimentos e além de\r\ndescobrir a reação dos estudantes à sua escolha de mídias,\r\nvocê irá ajuda-los em imprevistos da sala de aula.\r\nBoa Sorte!\r\n";
        textos[(int)ChaveTextos.AGRUPAMENTOS] = "Agrupamentos";
        textos[(int)ChaveTextos.AGRUPAMENTOS_1] = "Agrupamentos 1";
        textos[(int)ChaveTextos.AGRUPAMENTOS_2] = "Agrupamentos 2";
        textos[(int)ChaveTextos.QUARTO_MIDIA_1] = "Quarto - Midia 1";
        textos[(int)ChaveTextos.QUARTO_MIDIA_2] = "Quarto - Midia 2";
        textos[(int)ChaveTextos.SALA_MIDIA_1] = "Sala - Midia 1";
        textos[(int)ChaveTextos.SALA_MIDIA_2] = "Sala - Midia 2";
        textos[(int)ChaveTextos.AGORA_VOCE_ESTA] = "Agora você está no papel do estudante, o perfil da sua turma\r\ndeve influenciar nas atividades de lazer e os objetos têm que\r\nse relacionar com as mídias selecionadas no seu planejamento.";
        textos[(int)ChaveTextos.HORA_DE_ESTUDAR] = "Hora de estudar!";
        textos[(int)ChaveTextos.VOU_FAZER_AS_TAREFAS] = "Vou fazer as tarefas para a aula mas\r\nantes vou aproveitar meu tempo\r\nlivre e me divertir um pouco!";
        textos[(int)ChaveTextos.VOCE_CONCLUIU] = "Vou fazer as tarefas para a aula mas\r\nantes vou aproveitar meu tempo\r\nlivre e me divertir um pouco!";
        textos[(int)ChaveTextos.TERMINEI_TUDO] = "Terminei tudo, que bom! Agora é hora de ir pra escola.";
        textos[(int)ChaveTextos.ESCREVA_AQUI] = "Escreva aqui"; 
        textos[(int)ChaveTextos.ESCOLHA_AS_MIDIAS_ADEQUADAS] = "Escolha as midias adequadas";
        textos[(int)ChaveTextos.EXPLORANDO_SOBRE_O_TEMA] = "               Explorando sobre o tema em casa, os estudantes\r\n organizam melhor as ideias ativamente em sala criando\r\n conhecimento e apresentando aos colegas o que aprenderam!";
        textos[(int)ChaveTextos.ESCOLHA_O_AGRUPAMENTO] = "Escolha o agrupamento";
        textos[(int)ChaveTextos.ESPERE_NA_AB] = "Espere! Na ABProj não dá para planejar sem ouvir seus estudantes!\r\n\r\nPara escolher a mídia utilizada na cidade, apresente sua proposta para o projeto aos estudantes, e descubra em qual lugar da cidade eles preferem realizá-lo!";
        textos[(int)ChaveTextos.FICHA_NUMERO_2] = "<b>Ficha Resumo 2: Planejamento da Aula</b>";
        textos[(int)ChaveTextos.QUIZ] = "Quiz";
        textos[(int)ChaveTextos.AULA_COMUM] = "Aula Comum";
        textos[(int)ChaveTextos.AULA_CONFUSA] = "Aula confusa";
        textos[(int)ChaveTextos.AULA_REVELADO] = "Aula revelado";
        textos[(int)ChaveTextos.DISCUTIR_COM_O_GRUPO] = "Discutir com o grupo em sala de aula";
        textos[(int)ChaveTextos.REALIZAR_ATIVIDADES] = "Realizar atividades";
        textos[(int)ChaveTextos.POSITIVE_PRE_FIX] = "Me diverti muito";
        textos[(int)ChaveTextos.NEGATIVE_PRE_FIX] = "Não me diverti muito, pra mim";
        textos[(int)ChaveTextos.TIVE_DIFICULDADE_PARA_FAZER_AS_TAREFAS] = "<color=red>Tive dificuldades para fazer as tarefas com";
        textos[(int)ChaveTextos.E] = "e";
        textos[(int)ChaveTextos.CONSEGUI_FAZER_AS_ATIVIDADES] = "Consegui fazer as atividades com ";
        textos[(int)ChaveTextos.MAS_TIVE_DIFICULDADES] = "<color=red>mas tive dificuldades para fazer outras tarefas com";
        textos[(int)ChaveTextos.VOCE_CONCLUIU_A_PRIMEIRA_PARTE] = "Você concluiu a primeira parte desta metodologia! Agora seu planejamento continuará na sala de aula!";
        textos[(int)ChaveTextos.FINALIZOU_INVERTIDA] = "Você finalizou a Metodologia Sala de Aula Invertida";
        textos[(int)ChaveTextos.ESTAMOS_CHEGANDO] = "Estamos chegando no final do projeto! Após muito tempo de planejamento, visitação e dedicação às atividades, os estudantes vão apresentar suas conclusões e resultados! \r\nÉ lindo ver todo esse trabalho tomando forma!";
        textos[(int)ChaveTextos.AGORA_VOCE_RESPONDERA] = "Agora você responderá um quiz e irá se preparar para realizar o projeto na cidade! ";
        textos[(int)ChaveTextos.NESTE_MOMENTO] = "Tema";
        textos[(int)ChaveTextos.JOGOS] = "<style=\"title\">Jogos</style>\r\n\r\nOs jogos digitais são sistemas de simulações da realidade que substituída por situações lúdicas, permitindo aos jogadores uma visão de distintos modelos de realidade. Estudos demostram que os jogos digitais podem desenvolver habilidades como o pensamento crítico e o sistemático, a resolução de problemas, o desenvolvimento da ortografia, do vocabulário e da leitura, bem como aprendizagens específicas de domínio de diferentes áreas (como um novo idioma, por exemplo) além de uma gama de habilidades cognitivas, incluindo visualização espacial, atenção dividida e autorregulação emocional. Os jogos se configuram como um meio pedagógico versátil, através do qual as práticas sociais se entrelaçam e os conhecimentos individuais se relacionam, na interação com a informação, com outros estudantes, ferramentas e materiais. A diversão assume fator importante no processo, aliada ao relaxamento e motivação que os desafios trazem para executar as ações.";
        textos[(int)ChaveTextos.APPS_DE_GAMIFICACAO] = "<style=\"title\">Apps de Gamificação de Conteúdos Educacionais</style>\r\n\r\nA gamificação consiste em utilizar ferramentas e elementos de jogos em contexto fora de jogo. Os aplicativos de conteúdos gamificados tornam a prática de estudar um desafio, uma prática prazeirosa que aproveita as características dos jogos para criar um ambiente propício para a aprendizagem. Um aplicativo com exercícios de matemática ou de idiomas pode dar pontos e demarcar os feitos do usuário com distintivos e marcos que demonstram todo o trajeto e conquistas até o momento.";
        textos[(int)ChaveTextos.EDITORES_DE_AUDIO] = "<style=\"title\">Editores de Áudio e Vídeo</style>\r\n\r\nOs sotwares de edição de áudio e vídeo são ferramentas que instigam a pesquisa em sala de aula, pois, ao produzir com essas mídias podemos incentivar a reflexão de diferentes temas, a criatividade e o trabalho em equipe. Muitos destes softwares apresentam um conjunto de ferramentas versáteis, dinâmicas e de fácil aprendizado. Para fazer seus vídeos ou áudios, os estudantes precisam exercitar interação, interatividade e pensar em formas diferentes e dinâmicas de transmitir o que eles querem dizer e de conquistar a atenção de seus colegas, dessa forma constroem conhecimento em colaboração, a partir deste recurso tecnológico. Além disso, a produção audiovisual é tanto uma linguagem como uma habilidade importante para as demandas do século XXI.";
        textos[(int)ChaveTextos.COMPARTILHAMENTO_DE_AUDIOS] = "<style=\"title\">Compartilhamento de áudio e som</style>\r\n\r\nAs redes sociais de compartilhamento de imagem e som possibilitam aos usuários compartilhar e buscar imagens e vídeos. Fazer comentários e interagir com outras pessoas, estabelecendo contatos profissionais ou pessoais.";
        textos[(int)ChaveTextos.COMPARTILHAMENTO_DE_OPINIOS] = "<style=\"title\">Compartilhamento de Opinião</style>\r\n\r\nAs redes sociais de opinião têm como característica o compartilhamento e busca de informações sobre temas variados. Como também a troca de fotos e vídeos que geram redes de relacionamento e a conexão de pessoas.";
        textos[(int)ChaveTextos.CONEXOES_INTERPESSOAIS] = "<style=\"title\">Conexões Interpessoais</style>\r\n\r\nAs redes sociais de conexões interpessoais têm como objetivo as redes de relacionamento. Possibilitam o envio de mensagens instantâneas. Além de permitir ao usuário compartilhar e buscar conhecimentos profissionais.";
        textos[(int)ChaveTextos.COMUNICACAO] = "<style=\"title\">Comunicação</style>\r\n\r\nPlataformas de comunicação, por meio da rede de dados, disponibilizam um conjunto de funcionalidades que torna possível a comunicação em tempo real entre duas ou mais pessoas, coletando, organizando e disponibilizando informações para consultas e interações. Sendo possível ter de maneira virtual reuniões, encontros e aulas.";
        textos[(int)ChaveTextos.ARMAZENAMENTO] = "<style=\"title\">Armazenamento</style>\r\n\r\nPlataformas de armazenamento garantem acesso a imagens, vídeos, áudios, textos, planilhas e qualquer arquivo digital em qualquer lugar que tenha acesso à internet. É possível compartilhar, gerenciar e utilizar um mesmo arquivo por mais de uma pessoa tendo atualização das mudanças em tempo real.";
        textos[(int)ChaveTextos.GERENCIAMENTO] = "<style=\"title\">Gerenciamento</style>\r\n\r\nPlataformas de gerenciamento permite trabalhos em equipe para desenvolvimento de projetos, para planejamento e execução de aulas.";
        textos[(int)ChaveTextos.NA_SEQUENCIA_DA_APRENDIZAGEM_BASEADA_EM_PROJETOS] = "Na sequência da <b>Aprendizagem Baseada em Projetos</b>, \r\nestes serão os momentos em que os estudantes irão vivenciar\r\n";
        textos[(int)ChaveTextos.OBSERVE_SE_SUA_ESCOLHA] = "Observe se sua escolha é a melhor opção para estes objetivos!";
        textos[(int)ChaveTextos.PEGUE_DENTRO_DO_ARMARIO] = "<b>Pegue dentro do armário mídias para utilizar na cidade</b>";
        textos[(int)ChaveTextos.SUA_AULA_LAB] = "Sua aula acontecerá no LABORATÓRIO";
        textos[(int)ChaveTextos.DESBLOQUEOU_ABP] = "Você desbloqueou a metodologia ativa de";
        textos[(int)ChaveTextos.SUA_AULA_QUARTO] = "Sua aula acontecerá QUARTO DO ALUNO e na SALA DE AULA.";
        textos[(int)ChaveTextos.SUA_AULA_CIDADE] = "Sua aula acontecerá na CIDADE e na SALA DE AULA";
        textos[(int)ChaveTextos.PARA_COMECAR] = "Para começar:";
        textos[(int)ChaveTextos.TEMA] = "Tema";
        textos[(int)ChaveTextos.TEMA] = "Tema";
        textos[(int)ChaveTextos.TEMA] = "Tema";
        textos[(int)ChaveTextos.TEMA] = "Tema";
        textos[(int)ChaveTextos.TEMA] = "Tema";
        textos[(int)ChaveTextos.TEMA] = "Tema";
    }

}
