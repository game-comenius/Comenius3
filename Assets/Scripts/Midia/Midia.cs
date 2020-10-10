using UnityEngine;

public class Midia
{
    public NomeDeMidia NomeMidia { get; private set; }

    public Sprite SpriteIcone;

    public string NomeApresentavel { get; private set; }
    public string Descricao { get; private set; }

    public Midia (NomeDeMidia nomeMidia)
    {
        NomeMidia = nomeMidia;

        switch (nomeMidia)
        {
            case NomeDeMidia.Lousa:
                NomeApresentavel = "Lousa";
                Descricao = "É um quadro negro.";
                break;
            case NomeDeMidia.LivroDidatico:
                NomeApresentavel = "Livro Didático";
                Descricao = "É um livro didático.";
                break;
            case NomeDeMidia.LivrosJornaisERevistas:
                NomeApresentavel = "Livros, Jornais e Revistas";
                Descricao = "São livros, jornais e revistas.";
                break;
            case NomeDeMidia.CadernosECartazes:
                NomeApresentavel = "Cadernos e Cartazes";
                Descricao = "É um caderno";
                break;
            case NomeDeMidia.Televisao:
                NomeApresentavel = "Televisão";
                Descricao = "É uma televisão.";
                break;
            case NomeDeMidia.AparelhoDeSom:
                NomeApresentavel = "Aparelho de Som";
                Descricao = "É um aparelho de som.";
                break;
            case NomeDeMidia.RedesSociais:
                NomeApresentavel = "Redes Sociais";
                Descricao = "É uma rede social.";
                break;
            case NomeDeMidia.Jogos:
                NomeApresentavel = "Jogos";
                Descricao = "São jogos.";
                break;
            case NomeDeMidia.EditoresDeAudioEVideo:
                NomeApresentavel = "Editores de Áudio e Vídeo";
                Descricao = "São editores de áudio e vídeo.";
                break;
            case NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas:
                NomeApresentavel = "Editores de Texto e Planilhas Eletrônicas";
                Descricao = "São editores de texto e planilhas eletrônicas.";
                break;
            case NomeDeMidia.AVEAs:
                NomeApresentavel = "AVEAs";
                Descricao = "São AVEAs.";
                break;
            case NomeDeMidia.Aplicativos:
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
