using UnityEngine;

[System.Serializable]
public class Midia
{
    public NomeDeMidia nomeMidia { get; private set; }

    public Sprite sprite;

    public string nome { get; private set; }
    public string descricao { get; private set; }

    public Agrupamento agrupamento;

    public Midia (NomeDeMidia nomeMidia)
    {
        this.nomeMidia = nomeMidia;

        switch (nomeMidia)
        {
            case NomeDeMidia.Lousa:
                nome = "Lousa";
                descricao = "A lousa é uma superfície reutilizável, geralmente riscada com giz branco, utilizada para exposição do conteúdo "+
                            "do docente ou de forma colaborativa para docente e estudante.";
                break;

            case NomeDeMidia.LivroDidatico:
                nome = "Livro Didático";
                descricao = "O livro didático é uma mídia de consulta comum do docente e aluno, de cunho pedagógico, composto de exercícios, textos e " +
                            "imagens do conteúdo estudado, que acompanham o currículo escolar.";
                break;

            case NomeDeMidia.LivrosJornaisERevistas:
                nome = "Livros, Jornais e Revistas";
                descricao = "Livros, jornais e revistas são publicações de cunho literário, informativo, jornalístico ou de entretenimento. Contém pág" +
                            "inas impressas em papel com textos e imagens. Podem ser usados como material para leitura, consulta, ou base de recorte p" +
                            "ara atividades.";
                break;

            case NomeDeMidia.CadernosECartazes:
                nome = "Cadernos e Cartazes";
                descricao = "Caderno e cartazes são mídias utilizadas para produção e armazenamento de informações por uso da escrita ou das imagens. " +
                            "Auxiliam no exercício de autonomia, colaborando para que os estudantes aprendam a sistematizar o conhecimento adquirido, " +
                            "as dúvidas e as descobertas feitas.";
                break;

            case NomeDeMidia.Televisao:
                nome = "Televisão";
                descricao = "A televisão é um meio de comunição de massa. Um sistema eletrônico de transmissão e recepção de imagens e sons gerados ao" +
                            " vivo ou previamente gravadas, com programações artísticas, culturais, educativas, informativas etc.";
                break;
            case NomeDeMidia.AparelhoDeSom:  // Obsoleto?
                nome = "Aparelho de Som";
                descricao = "Esse aparelho é uma mídia de reprodução para propiciar comunicação por intermédio da transcepção de dados e informações como  fitas gravadas, " +
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
                descricao = "Redes Sociais são estruturas dinâmicas e complexas formadas por pessoas com valores e/ou objetivos em comum, interligadas" +
                            " de forma horizontal e predominantemente descentralizada, que existem desde o início da sociedade humana. As redes sociai" +
                            "s online se articulam através das mídias sociais que são espaços de comunicação e de relacionamento, a partir da conexão " +
                            "pela internet, que permitem a troca de mensagens e a partilha de conteúdos entre indivíduos e grupos, ampliando as possib" +
                            "ilidades de todo tipo de relacionamento entre eles.";
                break;

            case NomeDeMidia.Jogos:
                nome = "Jogos";
                descricao = "Um Jogo digital é uma atividade lúdica composta por mecânicas, estéticas e narrativas, suportadas por uma tecnologia, ond" +
                            "e o jogador realiza uma série de ações e decisões, que estão limitadas por regras e pelo contexto do contexto do game, re" +
                            "cebendo feedback constante e buscando alcançar um meta.";
                break;

            case NomeDeMidia.EditoresDeAudioEVideo:
                nome = "Editores de Áudio e Vídeo";
                descricao = "Editores de áudio e vídeo são softwares que proporcionam a edição de conteúdos que contenham som e imagem, por meio de op" +
                            "ções para cortar, copiar e colar trechos de áudio e video, bem como aplicar efeitos diversos.";
                break;

            case NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas:
                nome = "Editores de Texto e Planilhas Eletrônicas";
                descricao = "Um editor de texto é um software que permite aos usuários criar, alterar ou editar arquivos de texto simples. Planilha el" +
                            "etrônica é um programa de computador que utiliza tabelas para realização de cálculos ou apresentação de dados. Editores e" +
                            " planilhas permitem personalizar o conteúdo criado como definição de cores, fonte, espaçamentos e muito mais.";
                break;

            case NomeDeMidia.AVEAs:
                nome = "Plataformas";
                descricao = "Plataformas virtuais de aprendizagem são softwares que agregam ferrramentas para a criação, tutoria, gestão e compartilha" +
                            "mento de atividades com o objetivo de auxiliar o usuário à desenvolver e distribuir conteúdos diversos para cursos online" +
                            " e disciplinas semipresenciais para estudantes em geral.";
                break;

            case NomeDeMidia.Aplicativos:
                nome = "Aplicativos";
                descricao = "Aplicativos são programas de software presentes em celulares e diversos dispositivos inteligentes, como smart TVs que des" +
                            "empenham diversas funções: vendas, produtividade, educação, streaming, namoro, gerenciadores, editores de fotos e vídeos," +
                            " entretenimento, informação, etc. Alguns já vêm instalados de fábrica, enquanto outros podem ser obtidos na Apple Store o" +
                            "u na Play Store. Podem ser gratuitos ou pagos..";
                break;

            case NomeDeMidia.ProjetorMultimidia:
                nome = "Projetor Multimídia";
                descricao = "Um projetor multimídia é um aparelho óptico mecânico capaz de produzir imagens, como fotos, vídeos, filmes, planilhas, sl" +
                            "ides, etc. Fornece imagens reais, invertidas e maiores que o objeto, podendo ser um slide ou filme.";
                break;

            default:
                nome = "Sem nome";
                descricao = "Sem texto";
                break;
        }
    }
}
