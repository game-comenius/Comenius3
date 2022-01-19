using UnityEngine;
[System.Serializable]
public class Midia
{
    public NomeDeMidia nomeMidia { get; private set; }

    public Sprite sprite;

    public string nome { get; private set; }
    public string descricao { get; private set; }
    public string descricaoLonga { get; private set;}

    public Agrupamento agrupamento;

    public Midia (NomeDeMidia nomeMidia)
    {
        this.nomeMidia = nomeMidia;

        switch (nomeMidia)
        {
            case NomeDeMidia.Lousa:
                nome = "Lousa";
                descricao = "A <b>lousa</b> é uma superfície reutilizável, geralmente riscada com giz branco, utilizada para exposição do conteúdo do docente" +
                            " ou de forma colaborativa para docente e estudante.";
                descricaoLonga = "A lousa é uma mídia de exposição que acompanha o ofício do docente há algumas décadas, podendo ser utilizado de diversas " +
                                 "formas, de acordo com a  proposta metodológica de cada docente. Também pode ser trabalhada como espaço de expressão dos e" +
                                 "studantes. A lousa no formato digital permite a conexão com a internet, abrindo possibilidade para novas maneiras de expo" +
                                 "sição, criação de conteúdos e apresentação de informações de uma variedade de fontes, ampliando a interação e a participa" +
                                 "ção dos estudantes na aula.";
                break;

            case NomeDeMidia.LivroDidatico:
                nome = "Livro Didático";
                descricao = "O <b>livro didático</b> é uma mídia de consulta comum do docente e aluno, de cunho pedagógico, composto de exercícios, textos e " +
                            "imagens do conteúdo estudado, que acompanham o currículo escolar.";
                descricaoLonga = "O livro didático impresso é fornecido pela escola para o estudante. Traz informações sobre todos os conteúdos do ano leti" +
                                 "vo, normalmente utilizado como leitura do material didático complementar para as disciplinas específicas, com a mediação " +
                                 "do docente. Possui conteúdos e recursos como imagens, gráficos e diversos gêneros textuais, podendo também incluir questõ" +
                                 "es transversais.";
                break;

            case NomeDeMidia.LivrosJornaisERevistas:
                nome = "Livros, Jornais e Revistas";
                descricao = "<b>Livros, jornais e revistas</b> são publicações de cunho literário, informativo, jornalístico ou de entretenimento. Contém pág" +
                            "inas impressas em papel com textos e imagens. Podem ser usados como material para leitura, consulta, ou base de recorte p" +
                            "ara atividades.";
                descricaoLonga = "Livros, jornais e revistas são mídias de circulação social, que podem ser utilizadas para trabalhar a leitura e interpret" +
                                 "ação de diversos temas de forma mais aprofundada. É possível refletir sobre o tratamento dos textos e imagens de acordo c" +
                                 "om cada gênero, ou as diferenças entre revistas, jornais e livros que são idealizadas e produzidas com objetivos e formas" +
                                 " diferentes nas diversas abordagens ideológicas e culturais ali evidentes, ou ainda discutir sobre a criticidade das info" +
                                 "rmações que são passadas, bem como os pontos de vista e a quais interesses essas mídias atendem.";
                break;

            case NomeDeMidia.CadernosECartazes:
                nome = "Cadernos e Cartazes";
                descricao = "<b>Cadernos e cartazes</b> são mídias utilizadas para produção e armazenamento de informações por uso da escrita ou das imagens. " +
                            "Auxiliam no exercício de autonomia, colaborando para que os estudantes aprendam a sistematizar o conhecimento adquirido, " +
                            "as dúvidas e as descobertas feitas.";
                descricaoLonga = "Caderno e cartazes geralmente são feitos pelos próprios estudantes, utilizados para atividades pedagógicas individuais ou" +
                                 " em grupo para proporcionar a produção coletiva. Com os cartazes, os estudantes podem apresentar e socializar o que foi p" +
                                 "roduzido com o grupo a partir de pesquisa, produção textual, produção visual e gráfica, expressando de forma artística op" +
                                 "iniões, reflexões e conhecimentos. Nos cadernos os estudantes elaboram, sistematizam e armazenam os conteúdos aprendidos.";
                break;

            case NomeDeMidia.Televisao:
                nome = "Televisão";
                descricao = "A <b>televisão aberta</b> é um meio de comunição de massa que exibe uma programação fixa. Um sistema eletrônico de transmissão e" +
                                 " recepção de imagens e sons gerados ao vivo ou previamente gravadas, com programações artísticas, culturais, educativas, " +
                                 "informativas etc.";
                descricaoLonga = "A televisão é tanto um sistema de transmissão, como o dispositivo ou aparelho de visualização das imagens e sons, como a " +
                                 "programação televisiva e como a emissora que transmite os programas, tanto em rede aberta gratuita ou canais fechados e p" +
                                 "agos. Como ferramenta, pode ser utilizada na sala de aula para mostrar vídeos, filmes e documentários que contribuam com " +
                                 "os conteúdos trabalhados, possibilitando refletir como um veículo de informação e comunicação de massa pode atingir diver" +
                                 "sos lugares e pessoas ao mesmo tempo e as práticas culturais por ele geradas. Além disso, pode-se estudar a programação e" +
                                 " as emissoras, seus produtos, a arte, a cultura e a ideologia, refletindo de forma criítica o que ali é transmitido, tant" +
                                 "o os pontos de vistas e seus interesses como as diferentes informações ali veiculadas.";
                break;
            case NomeDeMidia.AparelhoDeSom:  // Obsoleto?
                nome = "Aparelho de Som";
                descricao = "O <b>aparelho de som</b> é uma mídia de reprodução para propiciar comunicação por intermédio da transcepção de dados e informações como  fitas gravadas, " +
                    "CDs, DVDs e arquivos de diversos formatos, com diversos tipos de conteúdo sonoro como músicas, entrevistas ou sons ambientes."
                     + System.Environment.NewLine +
                     "  O reprodutor de áudio reproduz o som captado no gravador de áudio, CDs e diferentes formatos."
                      + System.Environment.NewLine + 
                      "  Seu uso diretamente ligado à ouvir, possibilitando a reprodução da atividade realizada por ele, seja para estudo, entretenimento ou informação." +
                      "Pode ser utilizado para estudar conteúdos diversos, as formas, as linguagens da gravação, por exemplo, de diferentes gêneros musicais ou programas literários sonoros, como audiolivros ou podcasts." 
                       +System.Environment.NewLine +
                      "  Assim como ser usado como base sonora para complementar qualquer atividade, como ilustração, informação ou acompanhamento.";
                break;

            case NomeDeMidia.RedesSociais:
                nome = "Redes Sociais";
                descricao = "<b>Redes Sociais</b> são estruturas dinâmicas e complexas formadas por pessoas com valores e/ou objetivos em comum, interligadas" +
                            " de forma horizontal e predominantemente descentralizada, que existem desde o início da sociedade humana. As redes sociai" +
                            "s online se articulam através das mídias sociais que são espaços de comunicação e de relacionamento, a partir da conexão " +
                            "pela internet, que permitem a troca de mensagens e a partilha de conteúdos entre indivíduos e grupos, ampliando as possib" +
                            "ilidades de todo tipo de relacionamento entre eles.";
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
                descricao = "Um <b>Jogo digital</b> é uma atividade lúdica composta por mecânicas, estéticas e narrativas, suportadas por uma tecnologia, ond" +
                            "e o jogador realiza uma série de ações e decisões, que estão limitadas por regras e pelo contexto do contexto do game, re" +
                            "cebendo feedback constante e buscando alcançar um meta.";
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
                descricao = "<b>Editores de áudio e vídeo</b> são softwares que proporcionam a edição de conteúdos que contenham som e imagem, por meio de op" +
                            "ções para cortar, copiar e colar trechos de áudio e video, bem como aplicar efeitos diversos.";
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
                descricao = "Um <b>editor de texto</b> é um software que permite aos usuários criar, alterar ou editar arquivos de texto simples. Planilha el" +
                            "etrônica é um programa de computador que utiliza tabelas para realização de cálculos ou apresentação de dados. Editores e" +
                            " planilhas permitem personalizar o conteúdo criado como definição de cores, fonte, espaçamentos e muito mais.";
                descricaoLonga = "O funcionamento desses softwares é bem simples, ao mesmo tempo em que permitem que os estudantes sejam protagonistas da p" +
                                 "rópria aprendizagem. Nas páginas em branco é possível criar, formatar, editar, salvar documentos eletrônicos, misturando " +
                                 "elementos visuais e verbais. Por ser composto de recursos de escolha da fonte, inseção de imagens, criação de gráficos e " +
                                 "tabelas, estes editores de texto convidam a fomentar a escrita, a leitura e o desenvolvimento da criatividade, da aprendi" +
                                 "zagem colaborativa, das habilidades de escrita além de serem ferramentas de apoio à produção de pesquisa, tratamento e ap" +
                                 "resentação de dados de forma visual e complexa.";
                break;

            case NomeDeMidia.AVEAs:
                nome = "Plataformas";
                descricao = "<b>Plataformas virtuais de aprendizagem</b> são softwares que agregam ferrramentas para a criação, tutoria, gestão e compartilha" +
                            "mento de atividades com o objetivo de auxiliar o usuário à desenvolver e distribuir conteúdos diversos para cursos online" +
                            " e disciplinas semipresenciais para estudantes em geral.";
                descricaoLonga = "As plataformas de ambiente virtual de aprendizagem disponibilizam diversas ferramentas de comunicação,  gestão e interaçã" +
                                 "o. Uma plataforma perpassa todo o processo de aprendizagem de um aluno, no caso de cursos ou disciplinas a distância, sej" +
                                 "a para o planejamento de atividades a distância, semi-presenciais ou para complementar aulas presenciais com conteúdos vi" +
                                 "rtuais. Além da troca de materiais de estudo, disponibilizam-se tarefas, ocorrem trocas  textuais ou audiovisuais, intera" +
                                 "ções por escrito nas diversas ferramentas (fórum, chat, mensagens, carregamento de arquivos). Algumas plataformas como o " +
                                 "Moodle, oferecem ferramentas de gamificação e jogos incluindo a possibilidade da aprendizagem lúdica.";
                break;

            case NomeDeMidia.Aplicativos:
                nome = "Aplicativos";
                descricao = "<b>App ou aplicativos</b> são softwares cujo objetivo é ajudar o usuário a realizar determinadas tarefas, relacionad" +
                            "as a trabalho ou entretenimento, adaptados para os dispositivos móveis que passaram a fazer parte da vida das pess" +
                            "oas. Geralmente se refere aos softwares presentes em celulares e dispositivos inteligentes, como smart TVs, para as mais " +
                            "diversas funções.";
                descricaoLonga = "Existem inúmeros aplicativos relacionados a diferentes necessidades e domínios. Para a utilização deles na educação é nec" +
                                 "essário traçar o objetivo pedagógico, em seguida analisar as possibidades da ferramenta e desenhar uma estratégia. O trab" +
                                 "alho com aplicativos permite hibridez e personalização do ensino. Traz diversos benefícios como ajudar a organizar tarefa" +
                                 "s, aprender um idioma, criar conteúdos multimídia, facilitar a distribuição de atividades, dentro e fora da sala de aula." +
                                 " Além disso, aproxima o aluno da mecânica, dinâmica, estética e finalidade das ferramentas utilizadas em diversos segment" +
                                 "os da sociedade, ampliando seu letramento do mundo digital.";
                break;

            case NomeDeMidia.ProjetorMultimidia:
                nome = "Projetor Multimídia";
                descricao = "Um <b>O projetor multimídia, ou datashow,</b> é um aparelho óptico, mecânico, capaz de projetar em uma superfície lisa e clara, tod" +
                            "o tipo de imagem, fixa e em movimento, acoplado a um computador. Bastante usado para aulas expositivas mas também para " +
                            "apresentação de trabalhos dos estudantes.";
                descricaoLonga = "O projetor multimídia tem sido cada vez mais utilizado pelos docentes como recurso pedagógico.  Acoplado ao computador, a" +
                                 " uma caixa de som e conectado na internet, o projetor permite inúmeras atividades interativas, como uma tela criativa tan" +
                                 "to para docentes como estudantes, pois permite trabalhar não apenas com imagens fixas *fotos, planilhas, slides) mas tamb" +
                                 "ém vídeos, filmes, jogos, animações e todo tipo de linguagem audiovisual multimídia. As vantagens são muitas, pois permit" +
                                 "e ir além das aulas expositivas incluindo atividades interativas, servindo como uma tela criativa tanto para docentes com" +
                                 "o estudantes em aula presencial.";
                break;

            default:
                nome = "Sem nome";
                descricao = "Sem texto";
                break;
        }
    }
}
