using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class FeedbackDosAlunos
{
    public static string ObterFeedback(EstadoDoJogo jogo)
    {
        if (jogo.MetodologiaSelecionada == Metodologia.ABJ)
        {
            // TODO
            return string.Empty;
        }
        else // jogo.MetodologiaSelecionada == Metodologia.ABP
        {
            var feedbacksPossiveis = new List<string>();

            var escolheuMidiaDeConsulta = jogo.MidiasSelecionadas.Any((midia) => midia.NomeMidia.CategoriasDaMidia().HasFlag(CategoriasDeMidia.ConsultaRepositorio));
            var escolheuMidiaDigital = jogo.MidiasSelecionadas.Any((midia) => midia.NomeMidia.CategoriasDaMidia().HasFlag(CategoriasDeMidia.Digital));

            if (jogo.NivelDeEnsinoSelecionado == NivelDeEnsino.EducacaoInfantil)
            {
                if (escolheuMidiaDeConsulta) feedbacksPossiveis.Add("Adorei descobrir sobre tudo isso!");
                if (escolheuMidiaDigital) feedbacksPossiveis.Add("É bem mais legal a aula com essas tecnologias.");
            }
            else if (jogo.NivelDeEnsinoSelecionado == NivelDeEnsino.EnsinoFundamental)
            {
                if (escolheuMidiaDeConsulta) feedbacksPossiveis.Add("Não imaginava que existia tanta coisa diferente sobre esse assunto!");
                if (escolheuMidiaDigital) feedbacksPossiveis.Add("Gostei de interagir desse jeito na aula!");
            }
            else if (jogo.NivelDeEnsinoSelecionado == NivelDeEnsino.EnsinoMedio)
            {
                if (escolheuMidiaDeConsulta) feedbacksPossiveis.Add("Gostei de poder fazer as pesquisas sozinho, só pedi ajuda quando precisei mesmo.");
                if (escolheuMidiaDigital) feedbacksPossiveis.Add("Usar essas ferramentas me ajudou na pesquisa e na apresentação!");
            }
            else // (jogo.NivelDeEnsinoSelecionado == NivelDeEnsino.EnsinoSuperior)
            {
                if (escolheuMidiaDeConsulta) feedbacksPossiveis.Add("O professor nos deu autonomia para pesquisar e encontrar nossas próprias soluções.");
                if (escolheuMidiaDigital) feedbacksPossiveis.Add("As mídias digitais permitem que a gente pesquise e se prepare muito mais.");
            }

            // Escolher um entre os feedbacks possíveis
            if (feedbacksPossiveis.Any())
            {
                var randomIndex = Random.Range(0, feedbacksPossiveis.Count);
                return feedbacksPossiveis.ElementAt(randomIndex);
            }
            else
                return string.Empty;
        }
    }
}
