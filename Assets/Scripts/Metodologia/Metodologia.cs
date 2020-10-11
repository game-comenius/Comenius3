public sealed class Metodologia
{
    public static readonly Metodologia ABP = new Metodologia
    (
        valor: 0,
        nome: "Aprendizagem Baseada em Problemas",
        descricao: ""
    );

    public static readonly Metodologia ABJ = new Metodologia
    (
        valor: 3,
        nome: "Aprendizagem Baseada em Jogos",
        descricao: ""
    );  

    public readonly int Valor;
    public readonly string Nome;
    public readonly string Descricao;

    private Metodologia(int valor, string nome, string descricao)
    {
        this.Valor = valor;
        this.Nome = nome;
        this.Descricao = descricao;
    }

    public override string ToString() { return Nome; }

    // Retorna quais mídias pertencem ao parâmetro metodologia
    // Fonte = https://docs.google.com/spreadsheets/d/1sndl_nQUZNEWMg2jXrBp6sa1fAIk7xq5WFwrJDtTWHI/edit#gid=0
    public NomeDeMidia[] NomesDeMidiasDaMetodologia()
    {
        if (this == Metodologia.ABJ)
        {
            // TODO
            return null;
        }
        else // this == Metodologia.ABP:
        {
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
