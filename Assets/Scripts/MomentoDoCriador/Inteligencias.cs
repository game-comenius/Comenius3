// Representa um par de inteligências múltiplas
using UnityEngine;

public sealed class Inteligencias
{
    public static readonly Inteligencias CorporalCinestesicaComNaturalista = new Inteligencias
    (
        valor: 0,
        nome: "Corporal-cinestésica + Naturalista",
        descricao: ""
    );

    public static readonly Inteligencias IntrapessoalComEspacialVisual = new Inteligencias
    (
        valor: 1,
        nome: "Intrapessoal + Espacial-visual",
        descricao: ""
    );

    public static readonly Inteligencias InterpessoalComMusical = new Inteligencias
    (
        valor: 2,
        nome: "Interpessoal + Musical",
        descricao: ""
    );

    public static readonly Inteligencias LinguisticaComLogicoMatematica = new Inteligencias
    (
        valor: 3,
        nome: "Linguística + Lógico-matemática",
        descricao: ""
    );

    public readonly int Valor;
    public readonly string Nome;
    public readonly string Descricao;
    // Quando o jogador seleciona este quando aperta sobre o ícone que
    // representa ele, o ícone salva seu sprite nesta propriedade
    // para que o jogo possa apresentá-la depois em outras cenas
    public Sprite SpriteGrande;

    private Inteligencias(int valor, string nome, string descricao)
    {
        this.Valor = valor;
        this.Nome = nome;
        this.Descricao = descricao;
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
            if (valor == par.Valor)
                return par;
        }
        return null;
    }

    public static Inteligencias Get(string nome)
    {
        foreach (var par in TodosOsParesDeInteligencias())
        {
            if (nome.Equals(par.Nome))
                return par;
        }
        return null;
    }

    public override string ToString()
    {
        return Nome;
    }
}
