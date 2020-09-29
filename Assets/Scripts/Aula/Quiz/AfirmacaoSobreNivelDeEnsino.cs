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

        foreach (var afirmacao in lista)
            afirmacao.nivelDeEnsino = nivelDeEnsino;

        return lista.ToArray();
    }

    private AfirmacaoSobreNivelDeEnsino(bool verdadeira, string texto) : base(verdadeira, texto) { }
}
