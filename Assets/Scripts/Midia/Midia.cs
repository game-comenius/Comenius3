using UnityEngine;

public class Midia
{
    public NomeDeMidia NomeMidia { get; private set; }

    public Sprite SpriteIcone;

    public string NomeApresentavel { get; private set; }
    public string Descricao { get; private set; }
    public string Expansao { get; private set; }

    public int indiceDaMidia;

    public Agrupamento agrupamento;

    public Midia (NomeDeMidia nomeMidia)
    {
        NomeMidia = nomeMidia;

        switch (nomeMidia)
        {
            case NomeDeMidia.Lousa:
                NomeApresentavel = "Lousa";
                Descricao = "  Superfície reutilizável, geralmente riscada com giz branco, utilizada para exposição do conteúdo ou usado...";
                Expansao = "  Superfície reutilizável, geralmente riscada com giz branco, utilizada para exposição do conteúdo ou usado de forma colaborativa entre professor e estudante." 
                    + System.Environment.NewLine + 
                    "  É uma mídia de exposição que acompanha o ofício do professor há algumas décadas, podendo ser utilizado de diversas formas, de acordo com a proposta metodológica de cada professor";
                break;

            case NomeDeMidia.LivroDidatico:
                NomeApresentavel = "Livro Didático";
                Descricao = "  É uma mídia de consulta comum do professor e aluno, de cunho pedagógico composto...";
                Expansao = "  É uma mídia de consulta comum do professor e aluno, de cunho pedagógico composto de exercícios, textos e imagens do conteúdo estudado em sala que acompanha o currículo escolar." 
                    + System.Environment.NewLine + 
                    "  É um livro impresso fornecido pela escola que traz informações sobre todos os conteúdos das disciplinas do ano letivo em questão, normalmente utilizado como leitura do material didático complementar" +
                    " para as disciplinas específicas, com a mediação do professor. Essa mídia possui conteúdos e recursos como imagens, gráficos e diversos gêneros textuais, bem como questões transversais são abordadas neles.";
                break;

            case NomeDeMidia.LivrosJornaisERevistas:
                NomeApresentavel = "Livros, Jornais e Revistas";
                Descricao = "  Essas mídias impressas são de uso popular e contém diversos gêneros literários, destinadas à diferentes públicos."
                    + System.Environment.NewLine +
                    "  São publicações de cunho literário, informativo, jornalístico ou de entretenimento, geralmente voltada para o público em geral. Contém páginas impressas com textos e imagens. " +
                    "Podem ser usados como material para leitura,consulta, ou base de recorte para atividades. " +
                    "São mídias de circulação social, que podem ser utilizadas para trabalhar a leitura e interpretação de diversos temas de forma mais aprofundada. " +
                    "Refletir sobre o tratamento dos textos e imagens de acordo com cada gênero, ou as diferenças entre revistas, jornais e livros que são idealizadas e produzidas com objetivos e formas diferentes e as diversas abordagens ideológicas e culturais ali evidentes. " +
                    "Ou ainda discutir sobre a criticidade das informações que são passadas, bem como os pontos de vistas e a quais interesses essas mídias atendem.";
                break;

            case NomeDeMidia.CadernosECartazes:
                NomeApresentavel = "Cadernos e Cartazes";
                Descricao = "  São mídias utilizadas para produção e armazenamento de informações por uso da escrita...";
                Expansao = "  São mídias utilizadas para produção e armazenamento de informações por uso da escrita ou imagens, geralmente utilizadas pelos alunos."
                    + System.Environment.NewLine +
                    "  É uma litografia. Geralmente feito pelos próprios estudantes, utilizados para atividades pedagógicas individuais ou em grupo para proporcionar a produção coletiva. " +
                    "Com os cartazes os alunos podem apresentar e socializar o que foi produzido com o grupo escolar, produzir textos que permitem a pesquisa, produção textual, produção artística e expressar opiniões. " +
                    "Nos cadernos os estudantes elaboram e sistematizam os conteúdos aprendidos. ";
                break;

            case NomeDeMidia.Televisao:
                NomeApresentavel = "Televisão";
                Descricao = "  Sistema eletrônico de recepção/reprodução de imagens e sons de programas televisivos jornalísticos...";
                Expansao = "  Sistema eletrônico de recepção/reprodução de imagens e sons de programas televisivos jornalísticos, esportivos, educacionais e ficcionais, gravados ou ao vivo."
                    + System.Environment.NewLine +
                    "  A televisão é uma máquina que reproduz imagens e sons transmitidos por antena ou por meio de um VHS.  " +
                    "Pode ser utilizada na sala de aula para mostrar vídeos, filmes e documentários para contribuir com os conteúdos trabalhados. " +
                    "É possível refletir sobre a televisão como um veículo de informação de massa, que pode atingir diversos lugares ao mesmo tempo. " +
                    "Além disso, discutir sobre a criticidade das informações que são passadas, bem como os pontos de vistas e a quais interesses essa mídia atende. " +
                    "Com o auxílio de equipamentos de gravação ou contato com emissoras é possível a criação de vídeos feitos pela turma sobre determinados assuntos, seja sobre o cotidiano escolar ou disciplinas específicas.";
                break;
            case NomeDeMidia.AparelhoDeSom:
                NomeApresentavel = "Aparelho de Som";
                Descricao = "  Esse aparelho é uma mídia de reprodução para propiciar comunicação por intermédio da transcepção de dados e informações como  fitas gravadas, " +
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
                NomeApresentavel = "Redes Sociais";
                Descricao = "  São estruturas digitais (sites e aplicativos) formada por pessoas ou empresas com interesses comuns, que permite o compartilhamento de informações, criação de grupos e diálogos entre seus usuários."
                    + System.Environment.NewLine +
                    "  As redes sociais tem o objetivo de conectar pessoas e compartilhar informações entre elas, reunindo usuários que compactuam dos mesmos valores e interesses. " +
                    "As escolas com propostas intencionais podem usá-la para contribuir para a mobilização de saberes e de aprendizagens colaborativas, por meio de frequentes trocas, debates e contribuições de diferentes perspectivas, com uma construção social de significados e compartilhamento. " +
                    "Além disso, podem ser usadas para grupos de estudo, conteúdos extras, chat para dúvidas, calendários de eventos escolares e formação para leitura e uso crítico. " +
                    "Uma das fundamentais características na definição das redes é a sua abertura, possibilitando relacionamentos horizontais e não hierárquicos entre os participantes.";
                break;

            case NomeDeMidia.Jogos:
                NomeApresentavel = "Jogos";
                Descricao = "  Os Jogos Digitais são desenhados para serem jogados num computador, numa console ou outro dispositivo...";
                Expansao = "  Os Jogos Digitais são desenhados para serem jogados num computador, numa console ou outro dispositivo tecnológico, contendo gêneros, propostas e mecânicas variadas."
                    + System.Environment.NewLine +
                    "  Os jogos digitais são sistemas de simulações nos quais as situações reais são substituídas por situações lúdicas, permitindo aos jogadores uma visão de distintos modelos de realidade. " +
                    "O lúdico chega às aulas para torna-las mais interessantes e agradáveis, uma estratégia que busca estimular o raciocínio, concentração, levando o aluno a enfrentar situações conflitantes relacionadas com seu cotidiano. " +
                    "Os jogos se configuram como um meio pedagógico versátil, através do qual as práticas sociais se entrelaçam e os conhecimentos individuais se relacionam, na interação com a informação, com outros alunos, ferramentas e materiais. " +
                    "A diversão assume fator importante no processo, aliada ao relaxamento e motivação para executar as ações. 'É um trabalho colaborativo no qual os esforços são dedicados sem ressentimento ou temor.' (Prensky, 2002)";
                break;

            case NomeDeMidia.EditoresDeAudioEVideo:
                NomeApresentavel = "Editores de Áudio e Vídeo";
                Descricao = "  Softwares que proporcionam a edição de conteúdos que contenham som e imagem, por meio de opções...";
                Expansao = "  Softwares que proporcionam a edição de conteúdos que contenham som e imagem, por meio de opções para cortar, copiar e colar trechos de áudio e video, bem como aplicar efeitos diversos."
                    + System.Environment.NewLine +
                    "  Os editores de áudio e vídeo são ferramentas que instigam a pesquisa em sala de aula, pois ao construir essas mídias podemos incentivar a reflexão de diferentes temas, criatividade e trabalho em equipe dos envolvidos.  " +
                    "Para fazer seus vídeos ou áudios, os alunos precisaram exercitar interação e interatividade e pensar em formas diferentes e dinâmicas de transmitir o que eles querem dizer e de " +
                    "conquistar a atenção de seus colegas, dessa forma constroem conhecimento em colaboração a partir da elaboração deste recurso tecnológico.";
                break;

            case NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas:
                NomeApresentavel = "Editores de Texto e Planilhas Eletrônicas";
                Descricao = "  Softwares que permitem a edição ou criação de conteúdos que estejam em formato de texto ou planilhas...";
                Expansao = "  Softwares que permitem a edição ou criação de conteúdos que estejam em formato de texto ou planilhas, contendo diversas ferramentas para personalizar seu conteúdo como definição de cores, fonte, espaçamentos e muito mais."
                    + System.Environment.NewLine +
                    "  O funcionamento desses softwares é bem simples, ao mesmo tempo em que permitem uma aprendizagem interativa, rica e que os alunos sejam protagonistas da própria aprendizagem. " +
                    "Nessas páginas em branco é possível criar, formatar, editar, salvar documentos eletrônicos, misturando elementos visuais e verbais. " +
                    "Por ser composto de recursos que possibilitam escolher a fonte, inserir imagens, gráficos e tabelas, o programa é um convite para fomentar a escrita, a leitura e o desenvolvimento da criatividade e aprendizagem colaborativa.";
                break;

            case NomeDeMidia.AVEAs:
                NomeApresentavel = "AVEAs";
                Descricao = "  São Softwares com o objetivo de auxiliar o usuário professor à desenvolver e distribuir conteúdos...";
                Expansao = "  São Softwares com o objetivo de auxiliar o usuário professor à desenvolver e distribuir conteúdos diversos para cursos online e disciplinas semipresenciais para alunos em geral."
                    + System.Environment.NewLine +
                    "  Um AVEA pode ser utilizado como uma plataforma que perpassa todo o processo de aprendizagem de um aluno, no caso de cursos ou disciplinas à distância, " +
                    "ou como um recurso didático no planejamento de atividades semi-presenciais ou para complementar aulas presenciais com conteúdos virtuais. Além da troca de materiais de estudo, " +
                    "disponibilizam-se tarefas, ocorrem trocas  textuais ou audiovisuais, interações por escrito nas diversas ferramentas (fórum, chat, mensagens, carregamento de arquivos) que enriquecem o processo " +
                    "não só no seu resultado, mas no próprio processo de sua construção.";
                break;

            case NomeDeMidia.Aplicativos:
                NomeApresentavel = "Aplicativos";
                Descricao = "  Os aplicativos são softwares com o objetivo de auxiliar o usuário a desempenhar uma tarefa, enviar...";
                Expansao = "  Os aplicativos são softwares com o objetivo de auxiliar o usuário a desempenhar uma tarefa, enviar um e-mail, ou acessar alguma informação, como o GPS, entre outros."
                    + System.Environment.NewLine +
                    "  Tanto para alunos quanto para professores, os aplicativos tornaram-se uma das principais ferramentas para aprender e ensinar com mais facilidade. " +
                    "O trabalho com aplicativos permitem hibridez e personalização do ensino, trazem diversos benefícios como ajudar a organizar suas tarefas, aprender algum idioma, criar um ambiente de estudo para educadores e alunos, conhecer diferentes lugares do mundo, facilitar a distribuição de atividades, dentro e fora da sala de aula. " +
                    "Além de aproximar o aluno de ferramentas utilizadas em diferentes segmentos e finalidades da sociedade, incluindo-o no mundo digital.";
                break;

            case NomeDeMidia.ProjetorMultimidia:
                NomeApresentavel = "Projetor Multimídia";
                Descricao = "  É um aparelho óptico mecânico capaz de produzir imagens, como fotos, vídeos, filmes, planilhas...";
                Expansao = "  É um aparelho óptico mecânico capaz de produzir imagens, como fotos, vídeos, filmes, planilhas, slides à partir da projeção (em maior escala) do que estiver sendo realizado no computador."
                    + System.Environment.NewLine +
                    "  O projetor multimídia é uma ferramenta tecnológica cada vez mais utilizada pelos professores como recurso pedagógico. As vantagens são muitas, " +
                    "pois ele permite que se escape do ritmo comum das aulas expositivas em lousas e também facilita a observação de imagens, gráficos e animações didáticas.";
                break;

            default:
                NomeApresentavel = "Sem nome";
                Descricao = "Sem texto";
                break;
        }
    }
}
