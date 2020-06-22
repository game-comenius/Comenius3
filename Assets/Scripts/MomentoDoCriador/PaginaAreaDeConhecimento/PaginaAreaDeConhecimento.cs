using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaginaAreaDeConhecimento : Pagina
{
    [SerializeField] GrupoDeIconesAreaDeConhecimento iconesInfantil;
    [SerializeField] GrupoDeIconesAreaDeConhecimento iconesFundamental;
    [SerializeField] GrupoDeIconesAreaDeConhecimento iconesMedio;
    [SerializeField] GrupoDeIconesAreaDeConhecimento iconesSuperior;

    private Dictionary<NivelDeEnsino, GrupoDeIconesAreaDeConhecimento> iconesPorNivelDeEnsino;
    private Dictionary<NivelDeEnsino, GrupoDeIconesAreaDeConhecimento> IconesPorNivelDeEnsino
    {
        get
        {
            if (iconesPorNivelDeEnsino != null) return iconesPorNivelDeEnsino;

            // Criar mapeamento entre nível de ensino e os respectivos ícones
            var d = new Dictionary<NivelDeEnsino, GrupoDeIconesAreaDeConhecimento>();
            d[NivelDeEnsino.EducacaoInfantil] = iconesInfantil;
            d[NivelDeEnsino.EnsinoFundamental] = iconesFundamental;
            d[NivelDeEnsino.EnsinoMedio] = iconesMedio;
            d[NivelDeEnsino.EnsinoSuperior] = iconesSuperior;

            return iconesPorNivelDeEnsino = d;
        }
    }

    public override void Mostrar()
    {
        base.Mostrar();

        ApresentarGrupoDeIcones(EstadoDoJogo.Instance.NivelDeEnsinoSelecionado);
    }

    public override bool Validar()
    {
        return base.Validar();
    }

    private void ApresentarGrupoDeIcones(NivelDeEnsino nivelDeEnsino)
    {
        // Primeiro, esconder os grupos de ícones
        foreach (var grupo in IconesPorNivelDeEnsino.Values) grupo.Esconder();
        // Segundo, mostrar apenas o grupo de ícones do nível de ensino selecionado
        var grupoAtual = IconesPorNivelDeEnsino[nivelDeEnsino];
        grupoAtual.Mostrar();
    }
}
