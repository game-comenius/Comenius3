using UnityEngine;
using System.Collections.Generic;

public class AfirmacaoSobreMidia : Afirmacao
{
    public NomeMidias NomeDaMidia;

    public static AfirmacaoSobreMidia[] ObterTodasAsAfirmacoes(NomeMidias midia)
    {
        var lista = new List<AfirmacaoSobreMidia>();
        switch (midia)
        {
            case NomeMidias.CadernosECartazes:
                lista.AddRange(new AfirmacaoSobreMidia[]
                {
                    new AfirmacaoSobreMidia(true, "São mídias utilizadas para produção e armazenamento de informações por uso da escrita ou imagens, geralmente utilizadas pelos alunos."),
                    new AfirmacaoSobreMidia(true, "Com uma dessas mídias os alunos podem apresentar e socializar o que foi produzido com o grupo escolar, produzir textos que permitem a pesquisa, produção textual, produção artística e expressar opiniões."),
                    new AfirmacaoSobreMidia(false, "É uma mídia composta de exercícios, textos e imagens do conteúdo estudado em sala que acompanha o currículo escolar."),
                    new AfirmacaoSobreMidia(false, "São mídias de circulação social, que podem ser utilizadas para trabalhar a leitura e interpretação de diversos temas de forma mais aprofundada."),
                });
                break;
            default:
                Debug.LogWarning("Não há nenhuma afirmação definida para a mídia '" + midia.ToString() + "'");
                return null;
        }
        var afirmacoes = lista.ToArray();
        for (var i = 0; i < afirmacoes.Length; i++)
        {
            afirmacoes[i].NomeDaMidia = midia;
        }
        return afirmacoes;
    }

    private AfirmacaoSobreMidia(bool verdadeira, string texto) : base(verdadeira, texto) { }
}
