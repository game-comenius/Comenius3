using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public static class FeedbackDaLurdinha
{
    // Obter feedback da Lurdinha para o jogador de acordo com as escolhas de metodologia e de mídias
    // É uma lista de strings pois a Lurdinha pode trazer múltiplos feedbacks para o jogador
    // Fonte: https://docs.google.com/spreadsheets/d/1L1-BTr9iV8cBK-1nssccfwQVfkWrLKnsqK4fABewKmg/edit#gid=0
    public static List<string> ObterFeedback(EstadoDoJogo jogo)
    {
        var listaDeFeedbacks = new List<string>();

        if (jogo.MetodologiaSelecionada == Metodologia.ABJ)
        {
            // TODO
        }
        else // jogo.MetodologiaSelecionada == Metodologia.ABP
        {
            var escolheuMidiaDeConsulta = jogo.MidiasSelecionadas.Any((midia) => midia.nomeMidia.CategoriasDaMidia().HasFlag(CategoriasDeMidia.ConsultaRepositorio));
            var escolheuMidiaDigital = jogo.MidiasSelecionadas.Any((midia) => midia.nomeMidia.CategoriasDaMidia().HasFlag(CategoriasDeMidia.Digital));
            var escolheuMidiaPopular = jogo.MidiasSelecionadas.Any((midia) => midia.nomeMidia.CategoriasDaMidia().HasFlag(CategoriasDeMidia.Popular));

            if (escolheuMidiaDeConsulta && escolheuMidiaDigital)
                listaDeFeedbacks.Add("Parabéns! Você oportunizou pesquisas de qualidade e discussões intensas para os alunos sobre o assunto abordado!");
            else if (escolheuMidiaDeConsulta)
                listaDeFeedbacks.Add("Muito bem! Os alunos puderam pesquisar ótimos conteúdos sobre o assunto.");
            else if (escolheuMidiaDigital)
                listaDeFeedbacks.Add("Muito bem! A diversidade de conteúdos e ferramentas ajudou os alunos.");

            if (escolheuMidiaPopular)
                listaDeFeedbacks.Add("Cuidado com as Fake News! Buscar conteúdos e discussões em locais sem controle sobre as fontes pode gerar interpretações erradas.");

            // Feedback padrão da Lurdinha caso nenhum dos if's anteriores tenham sido satisfeitos
            if (listaDeFeedbacks.Count == 0)
                listaDeFeedbacks.Add("Boa aula prof.! Pense na escolha de mídias que ajudem os alunos a pesquisar e dêem acesso a diversas fontes.");
        }

        // Adicionar feedback para quando o jogador seleciona mídias repetidas
        var quantidadeMidiasDistintas = jogo.MidiasSelecionadas
            .GroupBy((midia) => midia.nomeMidia)
            .Select((grupo) => grupo.First())
            .Count();
        if (jogo.MidiasSelecionadas.Length > quantidadeMidiasDistintas)
            listaDeFeedbacks.Add("Procure oportunizar aos alunos o contato com diferentes mídias.");

        return listaDeFeedbacks;
    }
}
