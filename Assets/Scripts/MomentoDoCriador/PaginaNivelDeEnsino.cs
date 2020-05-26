using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaginaNivelDeEnsino : Pagina
{
    public NivelDeEnsino NivelDeEnsinoSelecionado { get; private set; }

    public override bool Validar()
    {
        return (NivelDeEnsinoSelecionado != null);
    }
}
