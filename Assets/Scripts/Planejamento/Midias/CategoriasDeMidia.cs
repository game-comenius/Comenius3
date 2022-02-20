using System;

// Lista de categorias de mídias para o jogo foi retirada deste documento:
// https://docs.google.com/spreadsheets/d/1sndl_nQUZNEWMg2jXrBp6sa1fAIk7xq5WFwrJDtTWHI/edit#gid=1166836280
// O enum CategoriaDeMidia é um enum com campos de bit. Permite que você defina
// algo que pertence a mais de uma categoria usando o operador bitwise "OR" |

[Flags]
public enum CategoriasDeMidia
{
    Nenhuma = 0b_0000_0000,
    Exposicao = 0b_0000_0001,
    ConsultaRepositorio = 0b_0000_0010,
    Popular = 0b_0000_0100,
    ProducaoArmazenamento = 0b_0000_1000,
    Impressa = 0b_0001_0000,
    AudioVisual = 0b_0010_0000,
    Digital = 0b_0100_0000,
}
