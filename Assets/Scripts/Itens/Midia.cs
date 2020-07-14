using UnityEngine;

public class Midia
{
    public NomeMidias NomeMidia { get; private set; }
    public Sprite Sprite { get; private set; }

    public string NomeApresentavel { get; private set; }
    public string Descricao { get; private set; }

    public Midia (NomeMidias nomeMidia)
    {
        NomeMidia = nomeMidia;

        switch (nomeMidia)
        {
            case NomeMidias.Lousa:
                NomeApresentavel = "Lousa";
                Descricao = "É um quadro negro.";
                break;
            case NomeMidias.LivroDidatico:
                NomeApresentavel = "Livro Didático";
                Descricao = "Descrição de uma mídia.";
                break;
            case NomeMidias.LivrosJornaisERevistas:
                NomeApresentavel = "Livros, Jornais e Revistas";
                Descricao = "Descrição de uma mídia.";
                break;
            case NomeMidias.CadernosECartazes:
                NomeApresentavel = "Cadernos e Cartazes";
                Descricao = "É um caderno";
                break;
            case NomeMidias.Televisao:
                NomeApresentavel = "Televisão";
                Descricao = "Descrição de uma mídia.";
                break;
            case NomeMidias.AparelhoDeSom:
                NomeApresentavel = "Aparelho de Som";
                Descricao = "Descrição de uma mídia.";
                break;
            case NomeMidias.RedesSociais:
                NomeApresentavel = "Redes Sociais";
                Descricao = "Descrição de uma mídia.";
                break;
            case NomeMidias.Jogos:
                NomeApresentavel = "Jogos";
                Descricao = "Descrição de uma mídia.";
                break;
            case NomeMidias.EditoresDeAudioEVideo:
                NomeApresentavel = "Editores de Áudio e Vídeo";
                Descricao = "Descrição de uma mídia.";
                break;
            case NomeMidias.EditoresDeTextoEPlanilhasEletronicas:
                NomeApresentavel = "Editores de Texto e Planilhas Eletrônicas";
                Descricao = "Descrição de uma mídia.";
                break;
            case NomeMidias.AVEAs:
                NomeApresentavel = "AVEAs";
                Descricao = "Descrição de uma mídia.";
                break;
            case NomeMidias.Aplicativos:
                NomeApresentavel = "Aplicativos";
                Descricao = "Descrição de uma mídia.";
                break;
            default:
                NomeApresentavel = "Sem nome";
                Descricao = "Sem texto";
                break;
        }
    }
}
