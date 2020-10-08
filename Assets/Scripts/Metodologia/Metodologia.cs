public sealed class Metodologia
{
    public static readonly Metodologia ABP = new Metodologia
    (
        valor: 0,
        nome: "Aprendizagem Baseada em Problemas",
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
}
