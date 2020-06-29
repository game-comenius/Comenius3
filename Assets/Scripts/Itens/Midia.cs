using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Midia
{
    public NomeMidias NomeMidia { get; private set; }
    public Sprite Sprite { get; private set; }

    public string NomeApresentavel { get; private set; }
    public string Descricao { get; private set; }

    public Midia (NomeMidias nomeMidia)
    {
        NomeMidia = nomeMidia;

        switch (NomeMidia)
        {
            case NomeMidias.QuadroNegro:
                NomeApresentavel = "Quadro Negro";
                Descricao = "É um quadro negro.";
                break;
            case NomeMidias.Caderno:
                NomeApresentavel = "Caderno";
                Descricao = "É um caderno";
                break;
            default:
                NomeApresentavel = "Sem nome";
                Descricao = "Sem texto";
                break;
        }
    }
}
