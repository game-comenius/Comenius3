[System.Serializable]
public class FlagDeEstadoDeJogo
{
    public FlagDeEstadoDeJogo(string _nome, bool _valor)
    {
        nome = _nome;
        valor = _valor;
    }
    public string nome;
    public bool valor;
}
