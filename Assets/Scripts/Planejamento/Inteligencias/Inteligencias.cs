// Representa um par de inteligências múltiplas
using UnityEngine;

public sealed class Inteligencias
{
    public static readonly Inteligencias CorporalCinestesicaComNaturalista = new Inteligencias
    (
        valor: 0,
        nome: "Corporal-cinestésica e Naturalista",
        descricao: "Corporal-cinestésica:\nImplica o uso do próprio corpo para resolver problemas. " +
        "Diz respeito à capacidade..."
    );

    public static readonly Inteligencias IntrapessoalComEspacialVisual = new Inteligencias
    (
        valor: 1,
        nome: "Intrapessoal e Espacial-visual",
        descricao: "Intrapessoal:\nRefere-se à capacidade das pessoas de reconhecerem a si mesmos, percebendo seus sentimentos..."
    );

    public static readonly Inteligencias InterpessoalComMusical = new Inteligencias
    (
        valor: 2,
        nome: "Interpessoal e Musical",
        descricao: "Interpessoal:\nRefere-se à capacidade de se relacionar com os outros, e o estilo de aprendizado..."
    );

    public static readonly Inteligencias LinguisticaComLogicoMatematica = new Inteligencias
    (
        valor: 3,
        nome: "Linguística e Lógico-matemática",
        descricao: "Linguística:\nRefere-se à capacidade de um indivíduo de se expressar, seja por meio da linguagem ou de gestos..."
    );

    public readonly int valor;
    public readonly string nome;
    public readonly string descricao;
    // Quando o jogador seleciona este quando aperta sobre o ícone que
    // representa ele, o ícone salva seu sprite nesta propriedade
    // para que o jogo possa apresentá-la depois em outras cenas
    public Sprite sprite;

    private Inteligencias(int valor, string nome, string descricao)
    {
        this.valor = valor;
        this.nome = nome;
        this.descricao = descricao;
    }

    public static Inteligencias[] TodosOsParesDeInteligencias()
    {
        Inteligencias[] todosOsPares =
        {
            CorporalCinestesicaComNaturalista,
            IntrapessoalComEspacialVisual,
            InterpessoalComMusical,
            LinguisticaComLogicoMatematica
        };
        return todosOsPares;
    }

    public static Inteligencias Get(int valor)
    {
        foreach (var par in TodosOsParesDeInteligencias())
        {
            if (valor == par.valor)
                return par;
        }
        return null;
    }

    public static Inteligencias Get(string nome)
    {
        foreach (var par in TodosOsParesDeInteligencias())
        {
            if (nome.Equals(par.nome))
                return par;
        }
        return null;
    }

    public override string ToString()
    {
        return nome;
    }
}
