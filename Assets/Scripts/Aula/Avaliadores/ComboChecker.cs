public class ComboChecker
{
    public enum ComboClassification
    {
        Null,
        Ideal,
        Boa,
        Arriscada
    }

    public enum Combo
    {
        Null,
        saiIdeal,
        saiBoa1,
        saiBoa2,
        saiBoa3,
        saiBoa4,
        saiArriscada1,
        saiArriscada2,
        saiArriscada3
    }

    public static Combo EvaluateCombo()
    {
        CategoriasDeMidia flagMidia1 = EstadoDoJogo.Instance.MidiasSelecionadas[0].nomeMidia.CategoriasDaMidia();
        CategoriasDeMidia flagMidia2 = EstadoDoJogo.Instance.MidiasSelecionadas[1].nomeMidia.CategoriasDaMidia();
        CategoriasDeMidia flagMidia3 = EstadoDoJogo.Instance.MidiasSelecionadas[2].nomeMidia.CategoriasDaMidia();
        CategoriasDeMidia flagMidia4 = EstadoDoJogo.Instance.MidiasSelecionadas[3].nomeMidia.CategoriasDaMidia();

        if (EstadoDoJogo.Instance.MetodologiaSelecionada.nome == "Aprendizagem Baseada em Problemas")
        {
            // TODO: Implementar os combos
        }
        else if (EstadoDoJogo.Instance.MetodologiaSelecionada.nome == "Sala de Aula Invertida")
        {
            // Qualquer coisa
            // Combo arriscado 1
            if (flagMidia3.HasFlag(CategoriasDeMidia.Popular))
                return Combo.saiArriscada1;

            // Combo arriscado 3
            if ((flagMidia3.HasFlag(CategoriasDeMidia.ConsultaRepositorio) ||
                 flagMidia3.HasFlag(CategoriasDeMidia.Exposicao)) &&
                flagMidia4.HasFlag(CategoriasDeMidia.ConsultaRepositorio))
                return Combo.saiArriscada3;

            // Duas digitais
            if (flagMidia1.HasFlag(CategoriasDeMidia.Digital) || flagMidia2.HasFlag(CategoriasDeMidia.Digital))
            {
                // Combo Ideal
                if (flagMidia3.HasFlag(CategoriasDeMidia.ProducaoArmazenamento) &&
                    flagMidia4.HasFlag(CategoriasDeMidia.Exposicao))
                    return Combo.saiIdeal;

                // Combo bom 2
                if ((flagMidia3.HasFlag(CategoriasDeMidia.ConsultaRepositorio) ||
                     flagMidia3.HasFlag(CategoriasDeMidia.Exposicao)) &&
                    flagMidia4.HasFlag(CategoriasDeMidia.Exposicao))
                    return Combo.saiBoa2;

                // Combo bom 4
                if ((flagMidia3.HasFlag(CategoriasDeMidia.ConsultaRepositorio) ||
                     flagMidia4.HasFlag(CategoriasDeMidia.Exposicao)) &&
                    (flagMidia4.HasFlag(CategoriasDeMidia.Popular) ||
                     flagMidia4.HasFlag(CategoriasDeMidia.ProducaoArmazenamento)))
                    return Combo.saiBoa4;
            }
            // Duas não digitais
            else if (!flagMidia1.HasFlag(CategoriasDeMidia.Digital) && !flagMidia2.HasFlag(CategoriasDeMidia.Digital))
            {
                // Combo bom 1
                if (flagMidia3.HasFlag(CategoriasDeMidia.ProducaoArmazenamento) &&
                    flagMidia4.HasFlag(CategoriasDeMidia.Exposicao))
                    return Combo.saiBoa1;

                // Combo bom 3
                if (flagMidia3.HasFlag(CategoriasDeMidia.ProducaoArmazenamento) &&
                    (flagMidia4.HasFlag(CategoriasDeMidia.ConsultaRepositorio) ||
                     flagMidia4.HasFlag(CategoriasDeMidia.Popular) ||
                     flagMidia4.HasFlag(CategoriasDeMidia.ProducaoArmazenamento)))
                    return Combo.saiBoa3;

                // Combo arriscado 2
                if ((flagMidia3.HasFlag(CategoriasDeMidia.ConsultaRepositorio) ||
                     flagMidia3.HasFlag(CategoriasDeMidia.Exposicao)) &&
                    (flagMidia4.HasFlag(CategoriasDeMidia.Popular) ||
                     flagMidia4.HasFlag(CategoriasDeMidia.Exposicao) ||
                     flagMidia4.HasFlag(CategoriasDeMidia.ProducaoArmazenamento)))
                    return Combo.saiArriscada2;
            }
        }

        return Combo.Null;
    }

    public static ComboClassification EvaluateComboClassification()
    {
        Combo combo = EvaluateCombo();

        // casos sem retorno ou break agem como "ou"
        switch (combo)
        {
            case Combo.saiIdeal:
                return ComboClassification.Ideal;
            case Combo.saiBoa1:
            case Combo.saiBoa2:
            case Combo.saiBoa3:
            case Combo.saiBoa4:
                return ComboClassification.Boa;
            case Combo.saiArriscada1:
            case Combo.saiArriscada2:
            case Combo.saiArriscada3:
                return ComboClassification.Arriscada;
            default:
                return ComboClassification.Null;
        }
    }
}
