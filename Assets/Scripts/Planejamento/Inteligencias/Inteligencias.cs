// Representa um par de inteligências múltiplas
using UnityEngine;

public sealed class Inteligencias
{
    public static  Inteligencias CorporalCinestesicaComNaturalista = new Inteligencias
    (
        valor: 0,
        nome: "Corporal-cinestésica e Naturalista",
        descricao: "<b>Corporal-cinestésica</b>\n\nImplica o uso do próprio corpo para resolver problemas. Diz respeito à capacidade " +
                   "de controlar os movimentos corporais, ao equilíbrio, à coordenação e à expressão por meio do corpo.\n\n<b>Naturalista</b>\n\nRefere-se " +
                   "à capacidade de compreender o mundo natural, identificando e distinguindo entre diferentes tipos de plantas, animais e formações climáticas."
    );

    public static Inteligencias IntrapessoalComEspacialVisual = new Inteligencias
    (
        valor: 1,
        nome: "Intrapessoal e Espacial-visual",
        descricao: "<b>Intrapessoal</b>\n\nRefere-se à capacidade das pessoas de reconhecerem a si mesmas, percebendo seus sentimentos, motivações e desejos. Está " +
                   "ligada à capacidade de identificar seus hábitos inconscientes, transformar suas atitudes, controlar vícios e emoções.\n\n<b>Espacial-visual</b>\n\nLigada à percepção visual e espacial, à interpretação e criação de " +
                   "imagens visuais e à imaginação pictórica. Ela permite que as pessoas compreendam melhor informações gráficas, como mapas."
    );

    public static Inteligencias InterpessoalComMusical = new Inteligencias
    (
        valor: 2,
        nome: "Interpessoal e Musical",
        descricao: "<b>Musical</b>\n\nPermite aos indivíduos produzir, compreender e identificar os diferentes tipos de som, reconhecendo " +
                   "harmonias, melodias, padrões tonais, e rítmicos.\n\n<b>Interpessoal</b>\n\nRefere-se à capacidade de se relacionar com os outros, " +
                   "e o estilo de aprendizado ligado a esse tipo de inteligência envolve contato humano, trabalho em equipe e comunicação."
    );

    public static  Inteligencias LinguisticaComLogicoMatematica = new Inteligencias
    (
        valor: 3,
        nome: "Linguística e Lógico-matemática",
        descricao: "<b>Lógico-matemática</b>\n\nVoltado para conclusões baseadas na razão, e descreve a capacidade de resolver equações e " +
                   "provas, de ter pensamento lógico, detectar padrões, fazer cálculos e resolver problemas abstratos.\n\n<b>Linguística</b>\n\nRefere-se à " +
                   "capacidade de um indivíduo de se expressar, seja por meio da linguagem ou de gestos. Assim como a forma de analisar e interpretar ideias " +
                   "e informações, e produzir trabalhos envolvendo linguagem oral e escrita."
    );

    public readonly int valor;
    public string nome;
    public string descricao;
    // Quando o jogador seleciona este quando aperta sobre o ícone que
    // representa ele, o ícone salva seu sprite nesta propriedade
    // para que o jogo possa apresentá-la depois em outras cenas
    public Sprite sprite;

    private static string CorporalCinestesicaComNaturalistaPtbr =
    "<b>Corporal-cinestésica</b>\n\nImplica o uso do próprio corpo para resolver problemas. Diz respeito à capacidade " +
                   "de controlar os movimentos corporais, ao equilíbrio, à coordenação e à expressão por meio do corpo.\n\n<b>Naturalista</b>\n\nRefere-se " +
                   "à capacidade de compreender o mundo natural, identificando e distinguindo entre diferentes tipos de plantas, animais e formações climáticas.";

    private static string IntrapessoalComEspacialVisualPtbr =
"<b>Intrapessoal</b>\n\nRefere-se à capacidade das pessoas de reconhecerem a si mesmas, percebendo seus sentimentos, motivações e desejos. Está " +
                   "ligada à capacidade de identificar seus hábitos inconscientes, transformar suas atitudes, controlar vícios e emoções.\n\n<b>Espacial-visual</b>\n\nLigada à percepção visual e espacial, à interpretação e criação de " +
                   "imagens visuais e à imaginação pictórica. Ela permite que as pessoas compreendam melhor informações gráficas, como mapas.";

    private static string InterpessoalComMusicalPtbr =
"<b>Musical</b>\n\nPermite aos indivíduos produzir, compreender e identificar os diferentes tipos de som, reconhecendo " +
                   "harmonias, melodias, padrões tonais, e rítmicos.\n\n<b>Interpessoal</b>\n\nRefere-se à capacidade de se relacionar com os outros, " +
                   "e o estilo de aprendizado ligado a esse tipo de inteligência envolve contato humano, trabalho em equipe e comunicação.";

    private static string LinguisticaComLogicoMatematicaPtbr =
"<b>Lógico-matemática</b>\n\nVoltado para conclusões baseadas na razão, e descreve a capacidade de resolver equações e " +
                   "provas, de ter pensamento lógico, detectar padrões, fazer cálculos e resolver problemas abstratos.\n\n<b>Linguística</b>\n\nRefere-se à " +
                   "capacidade de um indivíduo de se expressar, seja por meio da linguagem ou de gestos. Assim como a forma de analisar e interpretar ideias " +
                   "e informações, e produzir trabalhos envolvendo linguagem oral e escrita.";

    private static string CorporalCinestesicaComNaturalistaEua =
"<b>Bodily-kinesthetic</b>\n\nIt implies the use of one's own body to solve problems. It concerns the ability " +
               "from controlling body movements, balance, coordination and expression through the body.\n\n<b>Naturalist</b>\n\nRefers to " +
               "the ability to understand the natural world, identifying and distinguishing between different types of plants, animals and climatic formations.";

    private static string IntrapessoalComEspacialVisualEua =
"<b>Intrapersonal</b>\n\nRefers to people's ability to recognize themselves, realizing their feelings, motivations and desires. It is " +
                   "linked to the ability to identify your unconscious habits, transform your attitudes, control addictions and emotions.\n\n<b>Spatial-visual</b>\n\nLinked to visual and spatial perception, the interpretation and creation of " +
                   "visual images and pictorial imagination. It allows people to better understand graphic information such as maps.";

    private static string InterpessoalComMusicalEua =
"<b>Musical</b>\n\nAllows individuals to produce, understand and identify different types of sound, recognizing " +
                   "harmonies, melodies, tonal, and rhythmic patterns.\n\n<b>Interpersonal</b>\n\nRefers to the ability to relate to others, " +
                   "and the learning style linked to this type of intelligence involves human contact, teamwork and communication.";

    private static string LinguisticaComLogicoMatematicaEua =
"<b>Logical-mathematical</b>\n\nAimed at conclusions based on reason, and describes the ability to solve equations and " +
                   "tests, to have logical thinking, detect patterns, make calculations and solve abstract problems.\n\n<b>Linguistics</b>\n\nRefers to " +
                   "an individual's ability to express themselves, whether through language or gestures. As well as the way of analyzing and interpreting ideas" +
                   "and information, and produce work involving oral and written language.";


    private static string CorporalCinestesicaComNaturalistaEspanhol =
"<b>Cinestésico corporal</b>\n\nImplica el uso del propio cuerpo para resolver problemas. Se trata de la capacidad " +
               "desde controlar los movimientos corporales, el equilibrio, la coordinación y la expresión a través del cuerpo.\n\n<b>Naturalista</b>\n\nSe refiere a " +
               "la capacidad de comprender el mundo natural, identificando y distinguiendo entre diferentes tipos de plantas, animales y formaciones climáticas";

    private static string IntrapessoalComEspacialVisualEspanhol =
"<b>Intrapersonal</b>\n\nSe refiere a la capacidad que tienen las personas de reconocerse a sí mismas, dándose cuenta de sus sentimientos, motivaciones y deseos. Es " +
                   "vinculado a la capacidad de identificar tus hábitos inconscientes, transformar tus actitudes, controlar adicciones y emociones.\n\n<b>Espacial-visual</b>\n\nVinculado a la percepción visual y espacial, a la interpretación y creación de " +
                   "Imágenes visuales e imaginación pictórica. Permite a las personas comprender mejor la información gráfica, como los mapas";

    private static string InterpessoalComMusicalEspanhol =
"<b>Musical</b>\n\nPermite a los individuos producir, comprender e identificar diferentes tipos de sonido, reconociendo " +
                   "armonías, melodías, patrones tonales y rítmicos.\n\n<b>Interpersonal</b>\n\nSe refiere a la capacidad de relacionarse con los demás, " +
                   "Y el estilo de aprendizaje vinculado a este tipo de inteligencia implica el contacto humano, el trabajo en equipo y la comunicación";

    private static string LinguisticaComLogicoMatematicaEspanhol =
"<b>Lógico-matemático</b>\n\nDirigido a conclusiones basadas en la razón, y describe la capacidad de resolver ecuaciones y " +
                   "exámenes, para tener pensamiento lógico, detectar patrones, hacer cálculos y resolver problemas abstractos.\n\n<b>Lingüística</b>\n\nSe refiere a " +
                   "la capacidad de un individuo para expresarse, ya sea a través del lenguaje o de los gestos. Así como la forma de analizar e interpretar las ideas" +
                   "e información, y producir trabajos que involucren el lenguaje oral y escrito";

    public static void AtualizarTextosLinguas()
    {
        switch (Textos.GetIdiomaSelecionado())
        {

            case Idiomas.PORTUGUES:
                Inteligencias.CorporalCinestesicaComNaturalista.descricao = CorporalCinestesicaComNaturalistaPtbr;
                Inteligencias.IntrapessoalComEspacialVisual.descricao = IntrapessoalComEspacialVisualPtbr;
                Inteligencias.InterpessoalComMusical.descricao = InterpessoalComMusicalPtbr;
                Inteligencias.LinguisticaComLogicoMatematica.descricao = LinguisticaComLogicoMatematicaPtbr;

                Inteligencias.CorporalCinestesicaComNaturalista.nome = "Corporal-cinestésica e Naturalista";
                Inteligencias.IntrapessoalComEspacialVisual.nome = "Intrapessoal e Espacial-visual";
                Inteligencias.InterpessoalComMusical.nome = "Interpessoal e Musical";
                Inteligencias.LinguisticaComLogicoMatematica.nome = "Linguística e Lógico-matemática";
                break;

            case Idiomas.INGLES:
                Inteligencias.CorporalCinestesicaComNaturalista.descricao = CorporalCinestesicaComNaturalistaEua;
                Inteligencias.IntrapessoalComEspacialVisual.descricao = IntrapessoalComEspacialVisualEua;
                Inteligencias.InterpessoalComMusical.descricao = InterpessoalComMusicalEua;
                Inteligencias.LinguisticaComLogicoMatematica.descricao = LinguisticaComLogicoMatematicaEua;

                Inteligencias.CorporalCinestesicaComNaturalista.nome = "Bodily-kinesthetic and Naturalist";
                Inteligencias.IntrapessoalComEspacialVisual.nome = "Intrapersonal and Spatial-Visual";
                Inteligencias.InterpessoalComMusical.nome = "Interpersonal and Musical";
                Inteligencias.LinguisticaComLogicoMatematica.nome = "Linguistics and Logical-Mathematics";

                break;
            case Idiomas.ESPANHOL:
                Inteligencias.CorporalCinestesicaComNaturalista.descricao = CorporalCinestesicaComNaturalistaEspanhol;
                Inteligencias.IntrapessoalComEspacialVisual.descricao = IntrapessoalComEspacialVisualEspanhol;
                Inteligencias.InterpessoalComMusical.descricao = InterpessoalComMusicalEspanhol;
                Inteligencias.LinguisticaComLogicoMatematica.descricao = LinguisticaComLogicoMatematicaEspanhol;

                Inteligencias.CorporalCinestesicaComNaturalista.nome = "Corporal-kinestésico y naturalista";
                Inteligencias.IntrapessoalComEspacialVisual.nome = "Intrapersonal y Espacial-Visual";
                Inteligencias.InterpessoalComMusical.nome = "Interpersonal y Musical";
                Inteligencias.LinguisticaComLogicoMatematica.nome = "Lingüística y Lógico-Matemática";
                break;
        }
    }
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
