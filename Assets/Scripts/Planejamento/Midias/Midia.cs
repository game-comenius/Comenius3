using UnityEngine;
[System.Serializable]
public class Midia
{
    public NomeDeMidia nomeMidia { get; private set; }

    public Sprite sprite;

    public string nome { get; private set; }
    public string descricao { get; private set; }
    public string descricaoLonga { get; private set; }

    public Agrupamento agrupamento;

    public Midia(NomeDeMidia nomeMidia)
    {
        this.nomeMidia = nomeMidia;

        switch (nomeMidia)
        {
            case NomeDeMidia.Lousa:
                nome = "Lousa";
                descricao = "<style=\"title\">Lousa</style>\n\nA lousa é uma superfície reutilizável, geralmente riscada com giz branco, utilizada para exp" +
                            "osição do conteúdo do docente ou de forma colaborativa para docente e estudante.\n\n<b>Categoria:</b>\nMídia de exposição tradicional";
                descricaoLonga = "A lousa é uma mídia de exposição que acompanha o ofício do docente há algumas décadas, podendo ser utilizado de diversas " +
                                 "formas, de acordo com a  proposta metodológica de cada docente. Também pode ser trabalhada como espaço de expressão dos e" +
                                 "studantes. A lousa no formato digital permite a conexão com a internet, abrindo possibilidade para novas maneiras de expo" +
                                 "sição, criação de conteúdos e apresentação de informações de uma variedade de fontes, ampliando a interação e a participa" +
                                 "ção dos estudantes na aula.";
                break;

            case NomeDeMidia.LivroDidatico:
                nome = "Livro Didático";
                descricao = "<style=\"title\">Livro Didático</style>\n\nO livro didático é uma mídia de consulta comum do docente e estudante, de cunho ped" +
                            "agógico, composto de exercícios, textos e imagens do conteúdo estudado, que acompanham o currículo escolar.\n\n<b>Categoria:</b>\nMíd" +
                            "ia de consulta tradicional";
                descricaoLonga = "O livro didático impresso é fornecido pela escola para o estudante. Traz informações sobre todos os conteúdos do ano leti" +
                                 "vo, normalmente utilizado como leitura do material didático complementar para as disciplinas específicas, com a mediação " +
                                 "do docente. Possui conteúdos e recursos como imagens, gráficos e diversos gêneros textuais, podendo também incluir questõ" +
                                 "es transversais.";
                break;

            case NomeDeMidia.Notebook:
                nome = "Notebook";
                descricao = " <style=\"title\">Notebook</style>\n\n Computador portátil, provido de monitor de vídeo, geralmente de cristal líquido, e ativado por bateria, com peso inferior a 6 kg e dimensões compatíveis para ser utilizado no colo ou sobre uma pequena superfície plana. Normalmente exige que a pessoa esteja sentada.";
                descricaoLonga = "";
                break;

            case NomeDeMidia.Celular:
                nome = "Celular";
                descricao = "<style=\"title\">Celular</style>\n\n O smartphone é um celular com tecnologias que incluem programas executados num sistema operacional, equivalente aos computadores. Os smartphones possibilitam que qualquer pessoa possa desenvolver e utilizar aplicativos. Existem apps dos mais variados tipos e para os mais variados objetivos. São capazes de conectar redes de dados para acesso à internet, sincronizar dados como um computador, além da agenda de contatos.";
                descricaoLonga = "";
                break;

            case NomeDeMidia.Tablet:
                nome = "Tablet";
                descricao = " <style=\"title\">Tablet</style>\n\n Dispositivo eletrónico portátil, fino e retangular, com tela tátil, usado para visualização de vários tipos de arquivos digitais, comunicação móvel, entretenimento. Possui funcionalidades diversas, como acesso a internet, visualização de fotos e arquivos e até leitura de livros. O Tablet é um meio termo entre o smartphone e o notebook.";
                descricaoLonga = "";
                break;

            case NomeDeMidia.LivrosJornaisERevistas:
                nome = "Livros, Jornais e Revistas";
                descricao = "<style=\"title\">Livros, Jornais e Revistas</style>\n\nLivros, jornais e revistas são publicações de cunho literário, informat" +
                            "ivo, jornalístico ou de entretenimento. Contém páginas impressas em papel com textos e imagens. Podem ser usados como material" +
                            " para leitura, consulta, ou base de recorte para atividades.\n\n<b>Categoria:</b>\nMídia popular tracional";
                descricaoLonga = "Livros, jornais e revistas são mídias de circulação social, que podem ser utilizadas para trabalhar a leitura e interpret" +
                                 "ação de diversos temas de forma mais aprofundada. É possível refletir sobre o tratamento dos textos e imagens de acordo c" +
                                 "om cada gênero, ou as diferenças entre revistas, jornais e livros que são idealizadas e produzidas com objetivos e formas" +
                                 " diferentes nas diversas abordagens ideológicas e culturais ali evidentes, ou ainda discutir sobre a criticidade das info" +
                                 "rmações que são passadas, bem como os pontos de vista e a quais interesses essas mídias atendem.";
                break;

            case NomeDeMidia.CadernosECartazes:
                nome = "Cadernos e Cartazes";
                descricao = "<style=\"title\">Caderno e Cartazes</style>\n\nCaderno e cartazes são mídias utilizadas para produção e armazenamento de infor" +
                            "mações por uso da escrita ou das imagens. Auxiliam no exercício de autonomia, colaborando para que os estudantes aprendam a si" +
                            "stematizar o conhecimento adquirido, as dúvidas e as descobertas feitas.\n\n<b>Categoria:</b>\nMídia de produção tradicional";
                descricaoLonga = "Caderno e cartazes geralmente são feitos pelos próprios estudantes, utilizados para atividades pedagógicas individuais ou" +
                                 " em grupo para proporcionar a produção coletiva. Com os cartazes, os estudantes podem apresentar e socializar o que foi p" +
                                 "roduzido com o grupo a partir de pesquisa, produção textual, produção visual e gráfica, expressando de forma artística op" +
                                 "iniões, reflexões e conhecimentos. Nos cadernos os estudantes elaboram, sistematizam e armazenam os conteúdos aprendidos.";
                break;

            case NomeDeMidia.Televisao:
                nome = "Televisão";
                descricao = "<style=\"title\">Televisão</style>\n\nA televisão aberta é um meio de comunição de massa que exibe uma programação fixa. Um si" +
                            "stema eletrônico de transmissão e recepção de imagens e sons gerados ao vivo ou previamente gravadas, com programações artísti" +
                            "cas, culturais, educativas, informativas etc.\n\n<b>Categoria:</b>\nMídia popular audiovisual.";
                descricaoLonga = "A televisão é tanto um sistema de transmissão, como o dispositivo ou aparelho de visualização das imagens e sons, como a " +
                                 "programação televisiva e como a emissora que transmite os programas, tanto em rede aberta gratuita ou canais fechados e p" +
                                 "agos. Como ferramenta, pode ser utilizada na sala de aula para mostrar vídeos, filmes e documentários que contribuam com " +
                                 "os conteúdos trabalhados, possibilitando refletir como um veículo de informação e comunicação de massa pode atingir diver" +
                                 "sos lugares e pessoas ao mesmo tempo e as práticas culturais por ele geradas. Além disso, pode-se estudar a programação e" +
                                 " as emissoras, seus produtos, a arte, a cultura e a ideologia, refletindo de forma criítica o que ali é transmitido, tant" +
                                 "o os pontos de vistas e seus interesses como as diferentes informações ali veiculadas.";
                break;
            case NomeDeMidia.AparelhoDeSom:  // Obsoleto
                nome = "Aparelho de Som";
                descricao = "";
                break;

            case NomeDeMidia.RedesSociais:
                nome = "Redes Sociais";
                descricao = "<style=\"title\">Redes Sociais</style>\n\nRedes Sociais são estruturas dinâmicas e complexas formadas por pessoas com valores " +
                            "e/ou objetivos em comum, interligadas de forma horizontal e predominantemente descentralizada, que existem desde o início da s" +
                            "ociedade humana. As redes sociais online se articulam pela internet através das mídias sociais para comunicação, troca de mens" +
                            "agens e partilha de conteúdos entre indivíduos e grupos, ampliando as possibilidades de todo tipo de relacionamento entre eles" +
                            ".\n\n<b>Categoria:</b>\nMídia popular digital";
                descricaoLonga = "As redes sociais online têm o objetivo de conectar pessoas e compartilhar informações entre os que compactuam dos mesmos " +
                                 "valores e interesses. As escolas podem usá-las para contribuir para a mobilização de saberes e de aprendizagens colaborat" +
                                 "ivas, por meio de frequentes trocas, debates, de diferentes perspectivas, fortalecendo as relações interpessoais da turma" +
                                 " e aumentando a interação com os docentes, com os pais e com a sociedade em geral. Além disso, as redes sociais online po" +
                                 "dem ser usadas para grupos de estudo, conteúdos extras, chat para dúvidas, calendários de eventos escolares e formação pa" +
                                 "ra leitura e uso crítico. Com uma utilização contextualizada, mediada e expressivo-produtiva, os estudantes podem criar, " +
                                 "produzir e compartilhar conteúdos, subtituindo uma interação passiva e sendo mais protagonistas no desenvolvimento de sua" +
                                 " aprendizagem.";
                break;

            case NomeDeMidia.Jogos:
                nome = "Jogos";
                descricao = "<style=\"title\">Jogos</style>\n\nUm Jogo digital é uma atividade lúdica composta por mecânicas, estéticas e narrativas, suporta" +
                            "das por uma tecnologia, onde o jogador realiza uma série de ações e decisões, que estão limitadas por regras e pelo contexto d" +
                            "o contexto do game, recebendo feedback constante e buscando alcançar um meta.\n\nCategoria:\nMídia popular digital";
                descricaoLonga = "Os jogos digitais são sistemas de simulações da realidade que substituída por situações lúdicas, permitindo aos jogadores" +
                                 " uma visão de distintos modelos de realidade. Estudos demostram que os jogos digitais podem desenvolver habilidades como " +
                                 "o pensamento crítico e o sistemático, a resolução de problemas, o desenvolvimento da ortografia, do vocabulário e da leit" +
                                 "ura, bem como aprendizagens específicas de domínio de diferentes áreas (como um novo idioma, por exemplo) além de uma gam" +
                                 "a de habilidades cognitivas, incluindo visualização espacial, atenção dividida e autorregulação emocional. Os jogos se co" +
                                 "nfiguram como um meio pedagógico versátil, através do qual as práticas sociais se entrelaçam e os conhecimentos individua" +
                                 "is se relacionam, na interação com a informação, com outros estudantes, ferramentas e materiais. A diversão assume fator " +
                                 "importante no processo, aliada ao relaxamento e motivação que os desafios trazem para executar as ações.";
                break;

            case NomeDeMidia.EditoresDeAudioEVideo:
                nome = "Editores de Áudio e Vídeo";
                descricao = "<style=\"title\">Editores de áudio e vídeo</style>\n\nEditores de áudio e vídeo são softwares que proporcionam a edição de con" +
                            "teúdos que contenham som e imagem, por meio de opções para cortar, copiar e colar trechos de áudio e video, bem como aplicar e" +
                            "feitos diversos.\n\n<b>Categoria:</b>\nMídia de produção digital.";
                descricaoLonga = "Os sotwares de edição de áudio e vídeo são ferramentas que instigam a pesquisa em sala de aula, pois, ao produzir com ess" +
                                 "as mídias podemos incentivar a reflexão de diferentes temas, a criatividade e o trabalho em equipe. Muitos destes softwar" +
                                 "es apresentam um conjunto de ferramentas versáteis, dinâmicas e de fácil aprendizado. Para fazer seus vídeos ou áudios, o" +
                                 "s estudantes precisam exercitar interação, interatividade e pensar em formas diferentes e dinâmicas de transmitir o que e" +
                                 "les querem dizer e de conquistar a atenção de seus colegas, dessa forma constroem conhecimento em colaboração, a partir d" +
                                 "este recurso tecnológico. Além disso, a produção audiovisual é tanto uma linguagem como uma habilidade importante para as" +
                                 " demandas do século XXI.";
                break;

            case NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas:
                nome = "Editores de Texto e Planilhas Eletrônicas";
                descricao = "<style=\"title\">Editor de Texto e Planilhas</style>\n\nUm editor de texto é um software que permite aos usuários criar, alter" +
                            "ar ou editar arquivos de texto simples. Planilha eletrônica é um programa de computador que utiliza tabelas para realização de" +
                            " cálculos ou apresentação de dados. Editores e planilhas permitem personalizar o conteúdo criado como definição de cores, font" +
                            "e, espaçamentos e muito mais.\n\n<b>Categoria:</b>\nMídia de produção audiovisual.";
                descricaoLonga = "O funcionamento desses softwares é bem simples, ao mesmo tempo em que permitem que os estudantes sejam protagonistas da p" +
                                 "rópria aprendizagem. Nas páginas em branco é possível criar, formatar, editar, salvar documentos eletrônicos, misturando " +
                                 "elementos visuais e verbais. Por ser composto de recursos de escolha da fonte, inseção de imagens, criação de gráficos e " +
                                 "tabelas, estes editores de texto convidam a fomentar a escrita, a leitura e o desenvolvimento da criatividade, da aprendi" +
                                 "zagem colaborativa, das habilidades de escrita além de serem ferramentas de apoio à produção de pesquisa, tratamento e ap" +
                                 "resentação de dados de forma visual e complexa.";
                break;

            case NomeDeMidia.Plataformas:
                nome = "Plataformas";
                descricao = "<style=\"title\">Plataformas</style>\n\nPlataformas virtuais de aprendizagem são softwares que agregam ferrramentas para a cri" +
                            "ação, tutoria, gestão e compartilhamento de atividades com o objetivo de auxiliar o usuário à desenvolver e distribuir conteúd" +
                            "os diversos para cursos online e disciplinas semipresenciais para estudantes em geral.\n\n<b>Categoria:</b>\nMídia de consulta digital";
                descricaoLonga = "As plataformas de ambiente virtual de aprendizagem disponibilizam diversas ferramentas de comunicação, gestão e interaçã" +
                                 "o. Uma plataforma perpassa todo o processo de aprendizagem de um aluno, no caso de cursos ou disciplinas a distância, sej" +
                                 "a para o planejamento de atividades a distância, semi-presenciais ou para complementar aulas presenciais com conteúdos vi" +
                                 "rtuais. Além da troca de materiais de estudo, disponibilizam-se tarefas, ocorrem trocas  textuais ou audiovisuais, intera" +
                                 "ções por escrito nas diversas ferramentas (fórum, chat, mensagens, carregamento de arquivos). Algumas plataformas como o " +
                                 "Moodle, oferecem ferramentas de gamificação e jogos incluindo a possibilidade da aprendizagem lúdica.";
                break;

            case NomeDeMidia.Aplicativos:
                nome = "Aplicativos";
                descricao = "<style=\"title\">Aplicativos</style>\n\nApp ou aplicativos são softwares cujo  objetivo é ajudar o usuário a realizar d" +
                            "eterminadas tarefas, relacionadas a trabalho ou entretenimento, adaptados para os dispositivos móveis que passaram " +
                            "a fazer parte da vida das pessoas. Geralmente se refere aos softwares presentes em celulares e dispositivos inteligentes, como" +
                            " smart TVs, para as mais diversas funções.\n\n<b>Categoria:</b>\nMídia de consulta digital";
                descricaoLonga = "Existem inúmeros aplicativos relacionados a diferentes necessidades e domínios. Para a utilização deles na educação é nec" +
                                 "essário traçar o objetivo pedagógico, em seguida analisar as possibidades da ferramenta e desenhar uma estratégia. O trab" +
                                 "alho com aplicativos permite hibridez e personalização do ensino. Traz diversos benefícios como ajudar a organizar tarefa" +
                                 "s, aprender um idioma, criar conteúdos multimídia, facilitar a distribuição de atividades, dentro e fora da sala de aula." +
                                 " Além disso, aproxima o aluno da mecânica, dinâmica, estética e finalidade das ferramentas utilizadas em diversos segment" +
                                 "os da sociedade, ampliando seu letramento do mundo digital.";
                break;

            case NomeDeMidia.ProjetorMultimidia:
                nome = "Projetor Multimídia";
                descricao = "<style=\"title\">Projetor Multimídia</style>\n\nO projetor multimídia, ou datashow, é um aparelho óptico, mecânico, capaz de p" +
                            "rojetar em uma superfície lisa e clara, todo tipo de imagem, fixa e em movimento, acoplado a um computador. Bastante usado p" +
                            "ara aulas expositivas mas também para apresentação de trabalhos dos estudantes.\n\n<b>Categoria:</b>Categoria:\nMídia de exposição digital.";
                descricaoLonga = "O projetor multimídia tem sido cada vez mais utilizado pelos docentes como recurso pedagógico. Acoplado ao computador, a" +
                                 " uma caixa de som e conectado na internet, o projetor permite inúmeras atividades interativas, como uma tela criativa tan" +
                                 "to para docentes como estudantes, pois permite trabalhar não apenas com imagens fixas *fotos, planilhas, slides) mas tamb" +
                                 "ém vídeos, filmes, jogos, animações e todo tipo de linguagem audiovisual multimídia. As vantagens são muitas, pois permit" +
                                 "e ir além das aulas expositivas incluindo atividades interativas, servindo como uma tela criativa tanto para docentes com" +
                                 "o estudantes em aula presencial.";
                break;

            case NomeDeMidia.VideoGamePortatil:
                nome = "Video game Portátil";
                descricao = "<style=\"title\">Video game Portátil</style>\n\n É um console de videogame com tela e controles embutidos e dimensões reduzidas para que possa ser facilmente transportado. Tem como objetivo executar jogos eletrônicos como num videogame, é a opção ideal para jogar em espaços externos, quando estiver em trânsito ou para quem quer jogar online ou localmente no modo multiplayer.";
                descricaoLonga = "";
                break;


            default:
                nome = "Sem nome";
                descricao = "Sem texto";
                break;
        }
    }
}
