// Lista de mídias para o jogo foi retirada deste documento:
// https://docs.google.com/spreadsheets/d/107qEmnJbyoW8dPyvz0AiuGCE1Tqok4ybZdin8u_vKHQ/edit?usp=sharing

// Por favor, não altere os valores internos (int) dos enums
// Se você for adicionar uma nova mídia, atribua um novo valor à ela/
[System.Serializable]
public enum NomeDeMidia
{
    Nenhuma = 0,
    Lousa = 1,
    LivroDidatico = 2,
    LivrosJornaisERevistas = 3,
    CadernosECartazes = 4,
    Televisao = 5,
    AparelhoDeSom = 6,
    RedesSociais = 7,
    Jogos = 8,
    EditoresDeAudioEVideo = 9,
    EditoresDeTextoEPlanilhasEletronicas = 10,
    Plataformas = 11,
    Aplicativos = 12,
    ProjetorMultimidia = 13,
    Celular = 14,
    Tablet = 15,
    Notebook = 16,
}

public static class NomeDeMidiaExtensions
{
    public static CategoriasDeMidia CategoriasDaMidia(this NomeDeMidia nomeDeMidia)
    {
        switch (nomeDeMidia)
        {
            case NomeDeMidia.Lousa:
                return CategoriasDeMidia.Exposicao | CategoriasDeMidia.Impressa;
            case NomeDeMidia.ProjetorMultimidia:
                return CategoriasDeMidia.Exposicao | CategoriasDeMidia.Digital;
            case NomeDeMidia.LivroDidatico:
                return CategoriasDeMidia.ConsultaRepositorio | CategoriasDeMidia.Impressa;
            case NomeDeMidia.Aplicativos:
            case NomeDeMidia.Plataformas:
                return CategoriasDeMidia.ConsultaRepositorio | CategoriasDeMidia.Digital;
            case NomeDeMidia.LivrosJornaisERevistas:
                return CategoriasDeMidia.Popular | CategoriasDeMidia.Impressa;
            case NomeDeMidia.Televisao:
                return CategoriasDeMidia.Popular | CategoriasDeMidia.AudioVisual;
            case NomeDeMidia.RedesSociais:
            case NomeDeMidia.Jogos:
                return CategoriasDeMidia.Popular | CategoriasDeMidia.Digital;
            case NomeDeMidia.Celular:
                return CategoriasDeMidia.Popular | CategoriasDeMidia.Digital;
            case NomeDeMidia.Tablet:
                return CategoriasDeMidia.Popular | CategoriasDeMidia.Digital;
            case NomeDeMidia.Notebook:
                return CategoriasDeMidia.Popular | CategoriasDeMidia.Digital;
            case NomeDeMidia.CadernosECartazes:
                return CategoriasDeMidia.ProducaoArmazenamento | CategoriasDeMidia.Impressa;
            case NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas:
                return CategoriasDeMidia.ProducaoArmazenamento | CategoriasDeMidia.AudioVisual;
            case NomeDeMidia.EditoresDeAudioEVideo:
                return CategoriasDeMidia.ProducaoArmazenamento | CategoriasDeMidia.Digital;
            default:
                return CategoriasDeMidia.Nenhuma;
        }
    }
}