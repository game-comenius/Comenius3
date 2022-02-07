using System.Linq;

public static class FeedbackDosAlunos
{
    // Feedback padrão para quando não há feedback definido para uma situação
    private const string SemFeedback = "Nenhum aluno comentou sobre a aula.";

    // Retorna uma dupla de strings, a primeira é o que o aluno falou e a segunda
    // é a assinatura do aluno, por exemplo "Nicole - Aluna do Ensino Fundamental"
    // Se ninguém assinou, a string assinatura == null
    public static (string feedback, string assinatura) ObterFeedback(EstadoDoJogo jogo)
    {
        if (jogo.MetodologiaSelecionada == Metodologia.ABJ)
        {
            // TODO
            return (SemFeedback, null);
        }
        else // jogo.MetodologiaSelecionada == Metodologia.ABP
        {
            // Escolher um entre os feedbacks possíveis,
            // dar prioridade a feedbacks sobre mídia de consulta
            var escolheuMidiaDeConsulta = jogo.MidiasSelecionadas.Any((midia) => midia.nomeMidia.CategoriasDaMidia().HasFlag(CategoriasDeMidia.ConsultaRepositorio));
            var escolheuMidiaDigital = jogo.MidiasSelecionadas.Any((midia) => midia.nomeMidia.CategoriasDaMidia().HasFlag(CategoriasDeMidia.Digital));
            if (jogo.NivelDeEnsinoSelecionado == NivelDeEnsino.EducacaoInfantil)
            {
                if (escolheuMidiaDeConsulta) return ("Adorei descobrir sobre tudo isso!", $"Ricardo - {jogo.NivelDeEnsinoSelecionado.nome}");
                if (escolheuMidiaDigital) return ("É bem mais legal a aula com essas tecnologias.", $"Denise - {jogo.NivelDeEnsinoSelecionado.nome}");
            }
            else if (jogo.NivelDeEnsinoSelecionado == NivelDeEnsino.EnsinoFundamental)
            {
                if (escolheuMidiaDeConsulta) return ("Não imaginava que existia tanta coisa diferente sobre esse assunto!", $"Nicole - {jogo.NivelDeEnsinoSelecionado.nome}");
                if (escolheuMidiaDigital) return ("Gostei de interagir desse jeito na aula!", $"Fábio - {jogo.NivelDeEnsinoSelecionado.nome}");
            }
            else if (jogo.NivelDeEnsinoSelecionado == NivelDeEnsino.EnsinoMedio)
            {
                if (escolheuMidiaDeConsulta) return ("Gostei de poder fazer as pesquisas sozinha, só pedi ajuda quando precisei mesmo.", $"Maria - {jogo.NivelDeEnsinoSelecionado.nome}");
                if (escolheuMidiaDigital) return ("Usar essas ferramentas me ajudou na pesquisa e na apresentação!", $"Alexis - {jogo.NivelDeEnsinoSelecionado.nome}");
            }
            else // (jogo.NivelDeEnsinoSelecionado == NivelDeEnsino.EnsinoSuperior)
            {
                if (escolheuMidiaDeConsulta) return ("O professor nos deu autonomia para pesquisar e encontrar nossas próprias soluções.", $"Natan - {jogo.NivelDeEnsinoSelecionado.nome}");
                if (escolheuMidiaDigital) return ("As mídias digitais permitem que a gente pesquise e se prepare muito mais.", $"Indra - {jogo.NivelDeEnsinoSelecionado.nome}");
            }

            return (SemFeedback, null);
        }
    }
}
