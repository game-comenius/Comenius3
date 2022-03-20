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
        abpIdeal,
        abpBoa1,
        abpBoa2,
        abpBoa3,
        abpArriscada1,
        abpArriscada2,
        abpArriscada3,
        abpArriscada4,
        abpArriscada5,
        abpArriscada6,
        abpArriscada7,
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
        CategoriasDeMidia flagMidia1 = EstadoDoJogo.Instance.Midias[0].nomeMidia.CategoriasDaMidia();
        CategoriasDeMidia flagMidia2 = EstadoDoJogo.Instance.Midias[1].nomeMidia.CategoriasDaMidia();
        CategoriasDeMidia flagMidia3 = EstadoDoJogo.Instance.Midias[2].nomeMidia.CategoriasDaMidia();
        CategoriasDeMidia flagMidia4 = EstadoDoJogo.Instance.Midias[3].nomeMidia.CategoriasDaMidia();

        if (EstadoDoJogo.Instance.Metodologia.nome == "Aprendizagem Baseada em Problemas")
        {
            // Pelo menos uma é digital
            if (flagMidia1.HasFlag(CategoriasDeMidia.Digital) || flagMidia2.HasFlag(CategoriasDeMidia.Digital))
            {
                // Combo ideal
                if (flagMidia1.HasFlag(CategoriasDeMidia.ConsultaRepositorio) &&
                    flagMidia2.HasFlag(CategoriasDeMidia.ProducaoArmazenamento))
                {
                    return Combo.abpIdeal;
                }

                // Combo bom 1
                if (flagMidia1.HasFlag(CategoriasDeMidia.ConsultaRepositorio) &&
                    (flagMidia2.HasFlag(CategoriasDeMidia.Popular) ||
                     flagMidia2.HasFlag(CategoriasDeMidia.Exposicao)))
                {
                    return Combo.abpBoa1;
                }

                // Combo bom 2
                if ((flagMidia1.HasFlag(CategoriasDeMidia.ProducaoArmazenamento) ||
                     flagMidia1.HasFlag(CategoriasDeMidia.Exposicao)) &&
                    flagMidia2.HasFlag(CategoriasDeMidia.ProducaoArmazenamento))
                {
                    return Combo.abpBoa2;
                }

                // Combo bom 3
                if (flagMidia1.HasFlag(CategoriasDeMidia.ProducaoArmazenamento) &&
                    flagMidia2.HasFlag(CategoriasDeMidia.Exposicao))
                {
                    return Combo.abpBoa3;
                }

                // Combo arriscado 1
                if (flagMidia1.HasFlag(CategoriasDeMidia.ProducaoArmazenamento) &&
                    flagMidia2.HasFlag(CategoriasDeMidia.ConsultaRepositorio))
                {
                    return Combo.abpArriscada1;
                }

                // Combo arriscado 3
                if (flagMidia1.HasFlag(CategoriasDeMidia.Popular))
                {
                    return Combo.abpArriscada3;
                }

                // Combo arriscado 4
                if (flagMidia1.HasFlag(CategoriasDeMidia.Exposicao) &&
                    flagMidia2.HasFlag(CategoriasDeMidia.Exposicao))
                {
                    return Combo.abpArriscada4;
                }

                // Combo arriscado 5
                if (flagMidia1.HasFlag(CategoriasDeMidia.ConsultaRepositorio) &&
                    flagMidia2.HasFlag(CategoriasDeMidia.ConsultaRepositorio))
                {
                    return Combo.abpArriscada5;
                }

                // Combo arriscado 6
                if (flagMidia1.HasFlag(CategoriasDeMidia.ProducaoArmazenamento) &&
                    flagMidia2.HasFlag(CategoriasDeMidia.Popular))
                {
                    return Combo.abpArriscada6;
                }

                if (flagMidia1.HasFlag(CategoriasDeMidia.Exposicao) &&
                    (flagMidia2.HasFlag(CategoriasDeMidia.Popular) ||
                     flagMidia2.HasFlag(CategoriasDeMidia.ConsultaRepositorio)))
                {
                    return Combo.abpArriscada7;
                }
            }
            else
            {
                // Combo arriscado 2
                return Combo.abpArriscada2;
            }
        }
        else if (EstadoDoJogo.Instance.Metodologia.nome == "Sala de Aula Invertida")
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

            // Pelo menos uma é digital
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
            else
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
            case Combo.abpIdeal:
            case Combo.saiIdeal:
                return ComboClassification.Ideal;
            case Combo.abpBoa1:
            case Combo.abpBoa2:
            case Combo.abpBoa3:
            case Combo.saiBoa1:
            case Combo.saiBoa2:
            case Combo.saiBoa3:
            case Combo.saiBoa4:
                return ComboClassification.Boa;
            case Combo.abpArriscada1:
            case Combo.abpArriscada2:
            case Combo.abpArriscada3:
            case Combo.abpArriscada4:
            case Combo.abpArriscada5:
            case Combo.abpArriscada6:
            case Combo.abpArriscada7:
            case Combo.saiArriscada1:
            case Combo.saiArriscada2:
            case Combo.saiArriscada3:
                return ComboClassification.Arriscada;
            default:
                return ComboClassification.Null;
        }
    }
}
