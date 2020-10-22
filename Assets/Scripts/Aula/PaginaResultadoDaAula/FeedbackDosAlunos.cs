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
            // Escolher um entre os feedbacks possíveis,
            // dar prioridade a feedbacks sobre mídia de consulta
            var escolheuMidiaDeConsulta = jogo.MidiasSelecionadas.Any((midia) => midia.NomeMidia.CategoriasDaMidia().HasFlag(CategoriasDeMidia.ConsultaRepositorio));
            var escolheuMidiaDigital = jogo.MidiasSelecionadas.Any((midia) => midia.NomeMidia.CategoriasDaMidia().HasFlag(CategoriasDeMidia.Digital));
            if (jogo.NivelDeEnsinoSelecionado == NivelDeEnsino.EducacaoInfantil)
            {
                if (escolheuMidiaDeConsulta) return "Adorei descobrir sobre tudo isso!";
                if (escolheuMidiaDigital) return "É bem mais legal a aula com essas tecnologias.";
            }
            else if (jogo.NivelDeEnsinoSelecionado == NivelDeEnsino.EnsinoFundamental)
            {
                if (escolheuMidiaDeConsulta) return "Não imaginava que existia tanta coisa diferente sobre esse assunto!";
                if (escolheuMidiaDigital) return "Gostei de interagir desse jeito na aula!";
            }
            else if (jogo.NivelDeEnsinoSelecionado == NivelDeEnsino.EnsinoMedio)
            {
                if (escolheuMidiaDeConsulta) return "Gostei de poder fazer as pesquisas sozinho, só pedi ajuda quando precisei mesmo.";
                if (escolheuMidiaDigital) return "Usar essas ferramentas me ajudou na pesquisa e na apresentação!";
            }
            else // (jogo.NivelDeEnsinoSelecionado == NivelDeEnsino.EnsinoSuperior)
            {
                if (escolheuMidiaDeConsulta) return "O professor nos deu autonomia para pesquisar e encontrar nossas próprias soluções.";
                if (escolheuMidiaDigital) return "As mídias digitais permitem que a gente pesquise e se prepare muito mais.";
            }

            return string.Empty;
        }
    }
}
