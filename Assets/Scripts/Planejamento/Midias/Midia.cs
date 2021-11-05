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
                descricao = "Superfície reutilizável, geralmente riscada com giz branco, utilizada para exposição do conteúdo ou usado...";
                break;

            case NomeDeMidia.LivroDidatico:
                nome = "Livro Didático";
                descricao = "É uma mídia de consulta comum do professor e aluno, de cunho pedagógico composto...";
                break;

            case NomeDeMidia.LivrosJornaisERevistas:
                nome = "Livros, Jornais e Revistas";
                descricao = "Essas mídias impressas são de uso popular e contém diversos gêneros literários, destinadas à diferentes públicos.";
                break;

            case NomeDeMidia.CadernosECartazes:
                nome = "Cadernos e Cartazes";
                descricao = "São mídias utilizadas para produção e armazenamento de informações por uso da escrita...";
                break;

            case NomeDeMidia.Televisao:
                nome = "Televisão";
                descricao = "Sistema eletrônico de recepção/reprodução de imagens e sons de programas televisivos jornalísticos...";
                break;
            case NomeDeMidia.AparelhoDeSom:
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
                descricao = "São estruturas digitais (sites e aplicativos) formada por pessoas ou empresas com interesses comuns, que permite o compartilhamento de informações, criação de grupos e diálogos entre seus usuários.";
                break;

            case NomeDeMidia.Jogos:
                nome = "Jogos";
                descricao = "Os Jogos Digitais são desenhados para serem jogados num computador, numa console ou outro dispositivo...";
                break;

            case NomeDeMidia.EditoresDeAudioEVideo:
                nome = "Editores de Áudio e Vídeo";
                descricao = "Softwares que proporcionam a edição de conteúdos que contenham som e imagem, por meio de opções...";
                break;

            case NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas:
                nome = "Editores de Texto e Planilhas Eletrônicas";
                descricao = "Softwares que permitem a edição ou criação de conteúdos que estejam em formato de texto ou planilhas...";
                break;

            case NomeDeMidia.AVEAs:
                nome = "Plataformas";
                descricao = "São Softwares com o objetivo de auxiliar o usuário professor à desenvolver e distribuir conteúdos...";
                break;

            case NomeDeMidia.Aplicativos:
                nome = "Aplicativos";
                descricao = "Os aplicativos são softwares com o objetivo de auxiliar o usuário a desempenhar uma tarefa, enviar...";
                break;

            case NomeDeMidia.ProjetorMultimidia:
                nome = "Projetor Multimídia";
                descricao = "É um aparelho óptico mecânico capaz de produzir imagens, como fotos, vídeos, filmes, planilhas...";
                break;

            default:
                nome = "Sem nome";
                descricao = "Sem texto";
                break;
        }
    }
}
