// Lista de mídias para o jogo foi retirada deste documento:
// https://docs.google.com/spreadsheets/d/107qEmnJbyoW8dPyvz0AiuGCE1Tqok4ybZdin8u_vKHQ/edit?usp=sharing

// Por favor, não altere os valores internos (int) dos enums
// Se você for adicionar uma nova mídia, atribua um novo valor à ela
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
    AVEAs = 11,
    Aplicativos = 12,
    ProjetorMultimidia = 13,
}

public static class NomeDeMidiaExtensions
{
    // Retorna quais mídias pertencem ao parâmetro metodologia
    // Fonte = https://docs.google.com/spreadsheets/d/1sndl_nQUZNEWMg2jXrBp6sa1fAIk7xq5WFwrJDtTWHI/edit#gid=0
    public static NomeDeMidia[] NomesDeMidiasDaMetodologia(Metodologia metodologia)
    {
        switch (metodologia)
        {
            default: // case Metodologia.ABP:
                return new NomeDeMidia[]
                {
                    NomeDeMidia.Lousa,
                    NomeDeMidia.LivroDidatico,
                    NomeDeMidia.CadernosECartazes,
                    NomeDeMidia.Televisao,
                    NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas,
                    NomeDeMidia.EditoresDeAudioEVideo,
                    NomeDeMidia.Aplicativos,
                    NomeDeMidia.AVEAs,
                    NomeDeMidia.Jogos,
                    NomeDeMidia.ProjetorMultimidia,
                };
        }
    }
}