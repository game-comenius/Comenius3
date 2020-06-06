using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class PaginaNivelDeEnsino : Pagina
{
    [SerializeField] GrupoDeBotoesNivelDeEnsino grupoDeBotoes;

    public override bool Validar()
    {
        return (grupoDeBotoes.BotaoSelecionado != null);
    }
}
