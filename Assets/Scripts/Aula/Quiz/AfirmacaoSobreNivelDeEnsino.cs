using System.Collections.Generic;

public class AfirmacaoSobreNivelDeEnsino : Afirmacao
{
    public NivelDeEnsino nivelDeEnsino;

    public static AfirmacaoSobreNivelDeEnsino[] ObterTodasAsAfirmacoes(NivelDeEnsino nivelDeEnsino)
    {
        var lista = new List<AfirmacaoSobreNivelDeEnsino>();

        if (nivelDeEnsino == NivelDeEnsino.EducacaoInfantil)
        {
            lista.AddRange(new AfirmacaoSobreNivelDeEnsino[]
            {
                // Afirmações verdadeiras
                new AfirmacaoSobreNivelDeEnsino(true, "É a primeira etapa da educação básica."),
                new AfirmacaoSobreNivelDeEnsino(true, "Educar e Cuidar são indissociáveis, pois a Educação Infantil tem como objetivo ampliar o universo de experiências, conhecimentos e habilidades de bebês e crianças através da parceria com a família."),
                new AfirmacaoSobreNivelDeEnsino(true, "A oferta é feita até os 3 anos de idade, se tornando obrigatória a partir dos 4 anos."),
                new AfirmacaoSobreNivelDeEnsino(true, "Tem como eixos estruturantes das práticas pedagógicas as interações e a brincadeira."),
                new AfirmacaoSobreNivelDeEnsino(true, "A intencionalidade educativa é importante para a garantia de direitos fundamentais de aprendizagem e desenvolvimento."),
                new AfirmacaoSobreNivelDeEnsino(true, "Os cinco campos da experiência são divididos em: O eu, o outro e o nós; Corpo, gestos e movimentos; Traços, sons, cores e formas; Escuta, fala, pensamento e imaginação e; Espaços, tempos, quantidades, relações e transformações."),
                // Afirmações falsas
                new AfirmacaoSobreNivelDeEnsino(false, "A brincadeira não deve estar associado às atividades didáticas."),
                new AfirmacaoSobreNivelDeEnsino(false, "Educar e cuidar devem estar dissociados, pois não há relação entre eles."),
                new AfirmacaoSobreNivelDeEnsino(false, "Todo o período da Educação Infantil, desde a creche ao pré-escolar, possui obrigatoriedade de matrícula."),
                new AfirmacaoSobreNivelDeEnsino(false, "A Educação Infantil pode ser entendida como uma preparação para o Ensino Fundamental."),
                new AfirmacaoSobreNivelDeEnsino(false, "No contexto da Educação Infantil, o planejamento pode ser dispensado por ser burocrático e raramente executado."),
                new AfirmacaoSobreNivelDeEnsino(false, "É preciso que o professor tenha consciência que a brincadeira das crianças é apenas um momento recreativo."),
            });
        }
        else if (nivelDeEnsino == NivelDeEnsino.EnsinoFundamental)
        {
            lista.AddRange(new AfirmacaoSobreNivelDeEnsino[]
            {
                // Afirmações verdadeiras
                new AfirmacaoSobreNivelDeEnsino(true, "O Ensino Fundamental é uma etapa da educação obrigatória, com nove anos de duração, atendendo estudantes entre 6 e 14 anos."),
                new AfirmacaoSobreNivelDeEnsino(true, "O Ensino Fundamental tem como objetivo a formação básica do cidadão."),
                new AfirmacaoSobreNivelDeEnsino(true, "É dividido em duas fases: Anos Iniciais (1º ao 5º ano) e Anos Finais (6º ao 9º ano), que se inicia em torno dos interesses manifestados pelas crianças até desafios de maior complexidade."),
                new AfirmacaoSobreNivelDeEnsino(true, "Nos Anos Iniciais devem-se valorizar as situações lúdicas de aprendizagem e a necessária articulação com as experiências vivenciadas na Educação Infantil."),
                new AfirmacaoSobreNivelDeEnsino(true, "Nos dois primeiros anos do Ensino Fundamental, a ação pedagógica deve ter como foco a alfabetização."),
                new AfirmacaoSobreNivelDeEnsino(true, "Está dividido em cinco áreas de conhecimento: Linguagens, Matemática, Ciências da Natureza, Ciências Humanas e Ensino Religioso."),
                // Afirmações falsas
                new AfirmacaoSobreNivelDeEnsino(false, "O Ensino Fundamental tem oito anos de duração."),
                new AfirmacaoSobreNivelDeEnsino(false, "O Ensino Fundamental é uma etapa que não é obrigatória na Educação Básica."),
                new AfirmacaoSobreNivelDeEnsino(false, "O Ensino Fundamental está separado em três fases: Anos Iniciais, Anos Finais e Ensino Médio."),
                new AfirmacaoSobreNivelDeEnsino(false, "Está dividido em três áreas de conhecimento: Engenharias, Ciências da Saúde, Ciências Exatas e da Terra."),
                new AfirmacaoSobreNivelDeEnsino(false, "Tanto no 5º como no 6º ano, não são necessárias adaptações e articulações, para apoiar os alunos nesse processo de transição."),
                new AfirmacaoSobreNivelDeEnsino(false, "O Ensino Fundamental atende estudantes entre 11 e 14 anos."),
            });
        }
        else if (nivelDeEnsino == NivelDeEnsino.EnsinoMedio)
        {
            lista.AddRange(new AfirmacaoSobreNivelDeEnsino[]
            {
                // Afirmações verdadeiras
                new AfirmacaoSobreNivelDeEnsino(true, "O Ensino Médio é a etapa final da Educação Básica."),
                new AfirmacaoSobreNivelDeEnsino(true, "O Ensino Médio tem como finalidades: a preparação básica para o trabalho e a cidadania, a formação ética e o aprimoramento do pensamento crítico."),
                new AfirmacaoSobreNivelDeEnsino(true, "O Ensino Médio busca relacionar a teoria com a prática através de 4 grandes áreas do conhecimento."),
                new AfirmacaoSobreNivelDeEnsino(true, "Produzir múltiplas culturas juvenis promovendo uma educação integral no que concerne os aspectos físicos, cognitivos e socioemocionais é uma das características do Ensino Médio."),
                new AfirmacaoSobreNivelDeEnsino(true, "Uma das caracterísitcas do Ensino Médio é a compreensão dos fundamentos científico-tecnológicos dos processos produtivo."),
                new AfirmacaoSobreNivelDeEnsino(true, "O Ensino Médio pode ser integrado com o Ensino Profissional podendo ser cursado concomitantemente."),
                // Afirmações falsas
                new AfirmacaoSobreNivelDeEnsino(false, "O Ensino Médio é uma etapa que não é obrigatória na Educação Básica."),
                new AfirmacaoSobreNivelDeEnsino(false, "A matrícula no Ensino Médio para alunos de 14 a 17 anos é facultativa."),
                new AfirmacaoSobreNivelDeEnsino(false, "Busca uma intencionalidade educativa e a garantia de seis direitos de aprendizagem e desenvolvimento que permeiam cinco campos de experiências."),
                new AfirmacaoSobreNivelDeEnsino(false, "É o nível que busca o desejo de aperfeiçoamento cultural e profissional estimulando o conhecimento dos problemas do mundo presente, buscando prestar serviços especializados à comunidade."),
                new AfirmacaoSobreNivelDeEnsino(false, "O Ensino Média é uma etapa obrigária tendo como objetivo a formação básica do cidadão."),
                new AfirmacaoSobreNivelDeEnsino(false, " Inicia-se em torno dos interesses manifestados pelos jovens até desafios de maior complexidade sendo importante buscar o fortalecimento da autonomia dos estudantes."),
            });
        }
        else if (nivelDeEnsino == NivelDeEnsino.EnsinoSuperior)
        {
            lista.AddRange(new AfirmacaoSobreNivelDeEnsino[]
            {
                // Afirmações verdadeiras
                new AfirmacaoSobreNivelDeEnsino(true, "No nível superior a pessoa procura atender o desejo de aperfeiçoamento cultural e profissional."),
                new AfirmacaoSobreNivelDeEnsino(true, "O estudo no nível superior estimula o conhecimento dos problemas do mundo presente, buscando prestar serviços especializados à comunidade através da pesquisa científica e tecnológica."),
                new AfirmacaoSobreNivelDeEnsino(true, "No ensino superior busca-se o aprimoramento da educação básica mediante a formação e a capacitação de profissionais através da pesquisa e extensão."),
                new AfirmacaoSobreNivelDeEnsino(true, "Existem três tipos de graduação no ensino superior: bacharelado, licenciatura e graduação tecnológica."),
                new AfirmacaoSobreNivelDeEnsino(true, "Atualmente existem três modalidades de ensino superior: Ensino Presencial, a Distância e Semipresencial."),
                new AfirmacaoSobreNivelDeEnsino(true, "As universidades possuem três pilares indissociáveis para o ensino superior: Ensino, Pesquisa e Extensão."),
                // Afirmações falsas
                new AfirmacaoSobreNivelDeEnsino(false, "Atualmente existem três modalidades de formação superior: Magistério, Licenciatura e Bacharelado."),
                new AfirmacaoSobreNivelDeEnsino(false, "Existem três tipos de graduação no ensino superior: bacharelado, especialização e MBA."),
                new AfirmacaoSobreNivelDeEnsino(false, "O estudo no nível superior estimula a resolução de problemas científicos, buscando criar um conhecimento superior ao da comunidade através da pesquisa acadêmica."),
                new AfirmacaoSobreNivelDeEnsino(false, "Para se matricular no ensino superior o estudante deve ter terminado a educação básica e ter mais de 18 anos."),
            });
        }

        foreach (var afirmacao in lista)
            afirmacao.nivelDeEnsino = nivelDeEnsino;

        return lista.ToArray();
    }

    private AfirmacaoSobreNivelDeEnsino(bool verdadeira, string texto) : base(verdadeira, texto) { }
}
