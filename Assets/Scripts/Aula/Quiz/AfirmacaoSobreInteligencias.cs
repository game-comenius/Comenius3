using System.Collections.Generic;

// Afirmações verdadeiras e falsas sobre cada um dos pares de inteligências presentes no jogo
// Afirmações retiradas deste arquivo do Drive: https://docs.google.com/spreadsheets/d/1uW2ZZz8BnagpY9qWkufsmtNI8Bl_A8T1srsZDmPxHM0/edit#gid=0
public class AfirmacaoSobreInteligencias : Afirmacao
{
    public Inteligencias inteligencias;

    public static AfirmacaoSobreInteligencias[] ObterTodasAsAfirmacoes(Inteligencias inteligencias)
    {
        var lista = new List<AfirmacaoSobreInteligencias>();

        if (inteligencias == Inteligencias.CorporalCinestesicaComNaturalista)
        {
            lista.AddRange(new AfirmacaoSobreInteligencias[]
            {
                // Afirmações verdadeiras
                new AfirmacaoSobreInteligencias(true, "O estilo de aprendizagem do aluno Corporal/Cinestésico geralmente está relacionado com a experiência física e movimento, sensações e toque."),
                new AfirmacaoSobreInteligencias(true, "O estilo de aprendizagem do aluno Naturalista geralmente  se dá por meio do contato com a natureza."),
                new AfirmacaoSobreInteligencias(true, "Os que possuem a inteligencia múltipla Naturalista geralmente são sensíveis em distinguir entre diferentes tipos de plantas, animais e formações climáticas."),
                new AfirmacaoSobreInteligencias(true, "Os Corporais/Cinestésicos geralmente possuem a capacidade de controlar os movimentos corporais, o equilíbrio, a coordenação e a expressão por meio do corpo."),
                new AfirmacaoSobreInteligencias(true, "Este grupo possui crianças que geralmente aprendem através de experiências multissensoriais, manipulação de materiais, uso do corpo e do movimento."),
                new AfirmacaoSobreInteligencias(true, "Naturalistas entendem o meio ambiente como ambiente de aprendizagem."),
                // Afirmações falsas
                new AfirmacaoSobreInteligencias(false, "Quem possui a inteligencia múltipla naturalista possui facilidade em matemática."),
                new AfirmacaoSobreInteligencias(false, "Educação Física provavelmente é a disciplina que mais chama a atenção de um aluno Naturalista."),
                new AfirmacaoSobreInteligencias(false, "Alunos que possuem a inteligencia múltipla Corporal Cinestésico possuem facilidade em aulas de música."),
                new AfirmacaoSobreInteligencias(false, "Brincar não é importante para crianças Naturalistas."),
                new AfirmacaoSobreInteligencias(false, "Somente crianças que possuem a inteligência múltipla Corporal/Cinestésico podem ser atletas no futuro."),
                new AfirmacaoSobreInteligencias(false, "Somente crianças que possuem a inteligência múltipla Naturalista podem ser biólogos no futuro."),
            });
        }
        else if (inteligencias == Inteligencias.IntrapessoalComEspacialVisual)
        {
            lista.AddRange(new AfirmacaoSobreInteligencias[]
            {
                // Afirmações verdadeiras
                new AfirmacaoSobreInteligencias(true, "A inteligência intrapessoal refere-se à capacidade das pessoas de reconhecerem a si mesmos, percebendo seus sentimentos, motivações e desejos."),
                new AfirmacaoSobreInteligencias(true, "Os estudantes que tem a inteligência intrapessoal tem capacidade de identificar seus hábitos inconscientes, transformar suas atitudes, controlar vícios e emoções."),
                new AfirmacaoSobreInteligencias(true, "A inteligência espacial-visual está ligada à percepção visual e espacial, à interpretação e criação de imagens visuais e à imaginação pictórica."),
                new AfirmacaoSobreInteligencias(true, "O estilo de aprendizado da inteligência espacial-visual permite que os estudantes compreendam melhor informações gráficas, como mapas."),
                new AfirmacaoSobreInteligencias(true, "Artista, arquiteto, fotógrafo, designer e escultor são profissões mais ligadas à inteligência espacial-visual."),
                new AfirmacaoSobreInteligencias(true, "A inteligência intrapessoal está ligada à autorreflexão, por esse motivo filósofos geralmente possuem essa inteligência aguçada."),
                // Afirmações falsas
                new AfirmacaoSobreInteligencias(false, "As pessoas com inteligência intrapessoal possuem a capacidade de controlar os movimentos corporais, ao equilíbrio, à coordenação e à expressão por meio do corpo."),
                new AfirmacaoSobreInteligencias(false, "A inteligência espacial-visual refere-se à capacidade de um indivíduo compreender e identificar os diferentes tipos de som, reconhecendo  harmonias, melodias, padrões tonais, e rítmicos."),
                new AfirmacaoSobreInteligencias(false, "A capacidade de resolver equações e provas, de ter pensamento lógico, detectar padrões, fazer cálculos e resolver problemas abstratos está mais ligado as pesssoas com a inteligência intrapessoal."),
                new AfirmacaoSobreInteligencias(false, "Quem apresenta maior facilidade em distinguir entre diferentes tipos de plantas, animais e formações climáticas apresenta mais a inteligência espacial-visual."),
                new AfirmacaoSobreInteligencias(false, "Biólogo, geólogo, engenheiro climático, jardineiro e meteorologista são profissões de interesse por parte de quem possui facilidade com a Inteligência Intrapessoal."),
                new AfirmacaoSobreInteligencias(false, "A inteligência espacial-visual está geralmente relacionada com os números e a lógica."),
            });
        }
        else if (inteligencias == Inteligencias.InterpessoalComMusical)
        {
            lista.AddRange(new AfirmacaoSobreInteligencias[]
            {
                // Afirmações verdadeiras
                new AfirmacaoSobreInteligencias(true, "A Inteligência Interpessoal refere-se a uma maior capacidade de se relacionar com os outros."),
                new AfirmacaoSobreInteligencias(true, "O estilo de aprendizado da Inteligência Interpessoal envolve maior contato humano, trabalho em equipe e comunicação."),
                new AfirmacaoSobreInteligencias(true, "A inteligência Musical permite aos indivíduos produzir, compreender e identificar os diferentes tipos de som, reconhecendo  harmonias, melodias, padrões tonais, e rítmicos."),
                new AfirmacaoSobreInteligencias(true, "Terapeuta, professor, psicólogo, médico, profissional de RH e político são mais relacionadas com a Inteligência Interpessoal."),
                new AfirmacaoSobreInteligencias(true, "Quem está mais voltado para a Inteligência Musical apresenta grande interesse nas carreiras de músico, compositor, DJ, cantor, produtor musical e engenheiro acústico."),
                new AfirmacaoSobreInteligencias(true, "O estilo de aprendizagem de quem tem a inteligência mais voltada para a Musical e Interpessoal está relacionado a aprendizagens em duplas, grupos, debates, além de estar relacionado com músicas, ritmos e sons."),
                // Afirmações falsas
                new AfirmacaoSobreInteligencias(false, "Dançarino, ator, esportista, profissional de artes marciais, mergulhador, bombeiro e motorista, são profissões de interesse por parte de quem possui facilidade com a Inteligência Interpessoal."),
                new AfirmacaoSobreInteligencias(false, "A Inteligência Interpessoal diz respeito à capacidade de controlar os movimentos corporais, ao equilíbrio, à coordenação e à expressão por meio do corpo."),
                new AfirmacaoSobreInteligencias(false, "A Inteligência Musical tem como características analisar e interpretar ideias e informações, e produzir trabalhos envolvendo linguagem oral e escrita."),
                new AfirmacaoSobreInteligencias(false, "Indivíduos que aprensentam uma maior Inteligência Musical estão mais ligados à percepção visual e espacial, à interpretação e criação de imagens visuais e à imaginação pictórica."),
                new AfirmacaoSobreInteligencias(false, "Quem possui uma maior facilidade com a Inteligência interpessoal apresenta maior capacidade de se reconhecerem a si mesmos, percebendo seus sentimentos, motivações e desejos."),
                new AfirmacaoSobreInteligencias(false, "O estilo de aprendizagem da Inteligência Musical e Interpessoal está mais elacionado a imagens, gravuras, formas e espaço tridimensiona e a autorreflexão."),
            });
        }
        else if (inteligencias == Inteligencias.LinguisticaComLogicoMatematica)
        {
            lista.AddRange(new AfirmacaoSobreInteligencias[]
            {
                // Afirmações verdadeiras
                new AfirmacaoSobreInteligencias(true, "O Inteligência Linguística refere-se à capacidade de um indivíduo de se expressar, seja por meio da linguagem ou de gestos."),
                new AfirmacaoSobreInteligencias(true, "A Inteligência Linguística diz respeito a forma de analisar e interpretar ideias e informações e produzir trabalhos envolvendo linguagem oral e escrita."),
                new AfirmacaoSobreInteligencias(true, "A pessoa com o maior desenvolvimento no Raciocínio Lógico-Matemático volta-se para conclusões baseadas na razão."),
                new AfirmacaoSobreInteligencias(true, "O Raciocínio Lógico-Matemático descreve a capacidade de resolver equações e provas, de ter pensamento lógico, detectar padrões, fazer cálculos e resolver problemas abstratos."),
                new AfirmacaoSobreInteligencias(true, "A combinação dessas inteligências favorece o aprendizado relacionado a linguagem e lógica, e as pessoas tem um grande interesse em atividades que envolvam abstração, análise, síntese e interpretação de textos."),
                new AfirmacaoSobreInteligencias(true, "Atividades de profissões como Engenharia, Contabilidade e Estatística são interessantes para pessoas com alta inteligência Lógico-Matemática."),
                // Afirmações falsas
                new AfirmacaoSobreInteligencias(false, "Dançarino, ator, esportista, profissional de artes marciais, mergulhador, bombeiro e motorista, são profissões de interesse por parte de quem possui facilidade com a Inteligência Linguística."),
                new AfirmacaoSobreInteligencias(false, "As pessoas com raciocínio lógico-matemático geralmente possuem uma excelente capacidade de controlar os movimentos, tendo equilíbrio, coordenação e expressão corporal acima da média."),
                new AfirmacaoSobreInteligencias(false, "A inteligência linguística descreve a capacidade de resolver equações e provas, de ter pensamento lógico, detectar padrões, fazer cálculos e resolver problemas abstratos."),
                new AfirmacaoSobreInteligencias(false, "Terapeuta, professor, psicólogo, médico, profissional de RH e político são mais relacionadas com a Inteligência Lógico-Matemática."),
            });
        }

        foreach (var afirmacao in lista)
            afirmacao.inteligencias = inteligencias;

        return lista.ToArray();
    }

    private AfirmacaoSobreInteligencias(bool verdadeira, string texto) : base(verdadeira, texto) { }
}
