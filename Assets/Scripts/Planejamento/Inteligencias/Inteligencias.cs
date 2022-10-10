// Representa um par de inteligências múltiplas
using UnityEngine;

public sealed class Inteligencias
{
    public static readonly Inteligencias CorporalCinestesicaComNaturalista = new Inteligencias
    (
        valor: 0,
        nome: "Corporal-cinestésica e Naturalista",
        descricao: "<b>Corporal-cinestésica</b>\n\nImplica o uso do próprio corpo para resolver problemas. Diz respeito à capacidade " +
                   "de controlar os movimentos corporais, ao equilíbrio, à coordenação e à expressão por meio do corpo.\n\n<b>Naturalista</b>\n\nRefere-se " +
                   "à capacidade de compreender o mundo natural, identificando e distinguindo entre diferentes tipos de plantas, animais e formações climáticas."
    );

    public static readonly Inteligencias IntrapessoalComEspacialVisual = new Inteligencias
    (
        valor: 1,
        nome: "Intrapessoal e Espacial-visual",
        descricao: "<b>Intrapessoal</b>\n\nRefere-se à capacidade das pessoas de reconhecerem a si mesmas, percebendo seus sentimentos, motivações e desejos. Está " +
                   "ligada à capacidade de identificar seus hábitos inconscientes, transformar suas atitudes, controlar vícios e emoções.\n\n<b>Espacial-visual</b>\n\nLigada à percepção visual e espacial, à interpretação e criação de " +
                   "imagens visuais e à imaginação pictórica. Ela permite que as pessoas compreendam melhor informações gráficas, como mapas."
    );

    public static readonly Inteligencias InterpessoalComMusical = new Inteligencias
    (
        valor: 2,
        nome: "Interpessoal e Musical",
        descricao: "<b>Musical</b>\n\nPermite aos indivíduos produzir, compreender e identificar os diferentes tipos de som, reconhecendo " +
                   "harmonias, melodias, padrões tonais, e rítmicos.\n\n<b>Interpessoal</b>\n\nRefere-se à capacidade de se relacionar com os outros, " +
                   "e o estilo de aprendizado ligado a esse tipo de inteligência envolve contato humano, trabalho em equipe e comunicação."
    );

    public static readonly Inteligencias LinguisticaComLogicoMatematica = new Inteligencias
    (
        valor: 3,
        nome: "Linguística e Lógico-matemática",
        descricao: "<b>Lógico-matemática</b>\n\nVoltado para conclusões baseadas na razão, e descreve a capacidade de resolver equações e " +
                   "provas, de ter pensamento lógico, detectar padrões, fazer cálculos e resolver problemas abstratos.\n\n<b>Linguística</b>\n\nRefere-se à " +
                   "capacidade de um indivíduo de se expressar, seja por meio da linguagem ou de gestos. Assim como a forma de analisar e interpretar ideias " +
                   "e informações, e produzir trabalhos envolvendo linguagem oral e escrita."
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
