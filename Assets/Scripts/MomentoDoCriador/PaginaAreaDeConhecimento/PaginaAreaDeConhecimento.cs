using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaginaAreaDeConhecimento : Pagina
{
    [SerializeField] GrupoDeIconesAreaDeConhecimento iconesInfantil;
    [SerializeField] GrupoDeIconesAreaDeConhecimento iconesFundamental;
    [SerializeField] GrupoDeIconesAreaDeConhecimento iconesMedio;
    [SerializeField] GrupoDeIconesAreaDeConhecimento iconesSuperior;

    private Dictionary<NivelDeEnsino, GrupoDeIconesAreaDeConhecimento> IconesPorNivelDeEnsino;

    private GrupoDeIconesAreaDeConhecimento grupoAtual;

    // Start is called before the first frame update
    void Start()
    {
        // Criar mapeamento entre nível de ensino e os respectivos ícones
        IconesPorNivelDeEnsino = new Dictionary<NivelDeEnsino, GrupoDeIconesAreaDeConhecimento>();
        IconesPorNivelDeEnsino[NivelDeEnsino.EducacaoInfantil] = iconesInfantil;
        IconesPorNivelDeEnsino[NivelDeEnsino.EnsinoFundamental] = iconesFundamental;
        IconesPorNivelDeEnsino[NivelDeEnsino.EnsinoMedio] = iconesMedio;
        IconesPorNivelDeEnsino[NivelDeEnsino.EnsinoSuperior] = iconesSuperior;
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
        if (grupoAtual) grupoAtual.Esconder();
        grupoAtual = IconesPorNivelDeEnsino[nivelDeEnsino];
        grupoAtual.Mostrar();
    }
}
