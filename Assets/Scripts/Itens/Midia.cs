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
                Descricao = "É um livro didático.";
                break;
            case NomeMidias.LivrosJornaisERevistas:
                NomeApresentavel = "Livros, Jornais e Revistas";
                Descricao = "São livros, jornais e revistas.";
                break;
            case NomeMidias.CadernosECartazes:
                NomeApresentavel = "Cadernos e Cartazes";
                Descricao = "É um caderno";
                break;
            case NomeMidias.Televisao:
                NomeApresentavel = "Televisão";
                Descricao = "É uma televisão.";
                break;
            case NomeMidias.AparelhoDeSom:
                NomeApresentavel = "Aparelho de Som";
                Descricao = "É um aparelho de som.";
                break;
            case NomeMidias.RedesSociais:
                NomeApresentavel = "Redes Sociais";
                Descricao = "É uma rede social.";
                break;
            case NomeMidias.Jogos:
                NomeApresentavel = "Jogos";
                Descricao = "São jogos.";
                break;
            case NomeMidias.EditoresDeAudioEVideo:
                NomeApresentavel = "Editores de Áudio e Vídeo";
                Descricao = "São editores de áudio e vídeo.";
                break;
            case NomeMidias.EditoresDeTextoEPlanilhasEletronicas:
                NomeApresentavel = "Editores de Texto e Planilhas Eletrônicas";
                Descricao = "São editores de texto e planilhas eletrônicas.";
                break;
            case NomeMidias.AVEAs:
                NomeApresentavel = "AVEAs";
                Descricao = "São AVEAs.";
                break;
            case NomeMidias.Aplicativos:
                NomeApresentavel = "Aplicativos";
                Descricao = "São aplicativos.";
                break;
            default:
                NomeApresentavel = "Sem nome";
                Descricao = "Sem texto";
                break;
        }
    }
}
