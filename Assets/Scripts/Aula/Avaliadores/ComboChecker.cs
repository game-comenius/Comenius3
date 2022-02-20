public class ComboChecker
{
    public enum Combo
    {
        Nenhum,
        Ideal,
        Boa,
        Arriscada
    }

    private Combo CalcularCombo()
    {
        CategoriasDeMidia flagMidia1 = EstadoDoJogo.Instance.MidiasSelecionadas[0].nomeMidia.CategoriasDaMidia();
        CategoriasDeMidia flagMidia2 = EstadoDoJogo.Instance.MidiasSelecionadas[1].nomeMidia.CategoriasDaMidia();
        CategoriasDeMidia flagMidia3 = EstadoDoJogo.Instance.MidiasSelecionadas[2].nomeMidia.CategoriasDaMidia();
        CategoriasDeMidia flagMidia4 = EstadoDoJogo.Instance.MidiasSelecionadas[3].nomeMidia.CategoriasDaMidia();

        // Qualquer coisa
        // Combo arriscado 1
        if (flagMidia3.HasFlag(CategoriasDeMidia.Popular))
            return Combo.Arriscada;

        // Combo arriscado 3
        if (flagMidia3.HasFlag(CategoriasDeMidia.ConsultaRepositorio) &&
            flagMidia4.HasFlag(CategoriasDeMidia.ConsultaRepositorio))
            return Combo.Arriscada;

        // Duas digitais
        if (flagMidia1.HasFlag(CategoriasDeMidia.Digital) || flagMidia2.HasFlag(CategoriasDeMidia.Digital))
        {
            // Combo Ideal
            if (flagMidia3.HasFlag(CategoriasDeMidia.ProducaoArmazenamento) &&
                flagMidia4.HasFlag(CategoriasDeMidia.Exposicao))
                return Combo.Ideal;

            // Combo bom 2
            if ((flagMidia3.HasFlag(CategoriasDeMidia.ConsultaRepositorio) ||
                 flagMidia3.HasFlag(CategoriasDeMidia.Exposicao)) &&
                 flagMidia4.HasFlag(CategoriasDeMidia.Exposicao))
                return Combo.Boa;

            // Combo bom 3
            if (flagMidia3.HasFlag(CategoriasDeMidia.ProducaoArmazenamento) &&
                (flagMidia4.HasFlag(CategoriasDeMidia.ConsultaRepositorio) ||
                 flagMidia4.HasFlag(CategoriasDeMidia.Popular) ||
                 flagMidia4.HasFlag(CategoriasDeMidia.ProducaoArmazenamento)))
                return Combo.Boa;

            // Combo bom 4
            if (flagMidia3.HasFlag(CategoriasDeMidia.ConsultaRepositorio) &&
                (flagMidia4.HasFlag(CategoriasDeMidia.Popular) ||
                 flagMidia4.HasFlag(CategoriasDeMidia.ProducaoArmazenamento)))
                return Combo.Boa;
        }
        // Duas não digitais
        else if (!flagMidia1.HasFlag(CategoriasDeMidia.Digital) && !flagMidia2.HasFlag(CategoriasDeMidia.Digital))
        {
            // Combo bom 1
            if (flagMidia3.HasFlag(CategoriasDeMidia.ProducaoArmazenamento) &&
                flagMidia4.HasFlag(CategoriasDeMidia.Exposicao))
                return Combo.Boa;

            // Combo arriscado 2
            if ((flagMidia3.HasFlag(CategoriasDeMidia.ConsultaRepositorio) ||
                 flagMidia3.HasFlag(CategoriasDeMidia.Exposicao)) &&
                (flagMidia4.HasFlag(CategoriasDeMidia.Popular) ||
                 flagMidia4.HasFlag(CategoriasDeMidia.Exposicao) ||
                 flagMidia4.HasFlag(CategoriasDeMidia.ProducaoArmazenamento)))
                return Combo.Arriscada;
        }

        return Combo.Nenhum;
    }
}
