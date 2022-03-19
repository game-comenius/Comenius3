using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalaDeAulaLaboratorio : SalaDeAula
{
    [SerializeField] SpriteRenderer backgroundSpriteRenderer;
    public Sprite SpriteLaboratorioInformatica;
    public Sprite SpriteLaboratorioFisica;
    public Sprite SpriteLaboratorioBiologia;
    public Sprite SpriteLaboratorioQuimica;

    public override IEnumerator Mostrar()
    {
        // Definir qual o tipo de laboratório que será usado
        Dictionary<AreaDeConhecimento, Sprite> spritesPorAreaDeConhecimento = ConstruirRelacaoSpritesPorAreaDeConhecimento();
        var spriteDoLaboratorio = spritesPorAreaDeConhecimento[EstadoDoJogo.Instance.AreaDeConhecimentoSelecionada];
        backgroundSpriteRenderer.sprite = spriteDoLaboratorio ? spriteDoLaboratorio : SpriteLaboratorioQuimica;

        return base.Mostrar();
    }

    private Dictionary<AreaDeConhecimento, Sprite> ConstruirRelacaoSpritesPorAreaDeConhecimento()
    {
        return new Dictionary<AreaDeConhecimento, Sprite>
        {
            // Ensino Infantil
            // O laboratório não deve ser utilizado para o ensino infantil

            // Ensino Fundamental
            { AreaDeConhecimento.Linguagens, SpriteLaboratorioInformatica },
            { AreaDeConhecimento.Matematica, SpriteLaboratorioFisica },
            { AreaDeConhecimento.CienciasDaNatureza, SpriteLaboratorioBiologia },
            { AreaDeConhecimento.CienciasHumanas, SpriteLaboratorioInformatica },
            { AreaDeConhecimento.EnsinoReligioso, SpriteLaboratorioInformatica },

            // Ensino Médio
            { AreaDeConhecimento.LinguagensESuasTecnologias, SpriteLaboratorioInformatica },
            { AreaDeConhecimento.MatematicaESuasTecnologias, SpriteLaboratorioFisica },
            { AreaDeConhecimento.CienciasDaNaturezaESuasTecnologias, SpriteLaboratorioQuimica },
            { AreaDeConhecimento.CienciasHumanasESociaisAplicadas, SpriteLaboratorioInformatica },

            // Ensino Superior
            { AreaDeConhecimento.CienciasAgrarias, SpriteLaboratorioBiologia },
            { AreaDeConhecimento.CienciasBiologicas, SpriteLaboratorioBiologia },
            { AreaDeConhecimento.CienciasExatasDaTerra, SpriteLaboratorioFisica },
            { AreaDeConhecimento.CienciasHumanasSuperior, SpriteLaboratorioInformatica },
            { AreaDeConhecimento.CienciasDaSaude, SpriteLaboratorioQuimica },
            { AreaDeConhecimento.CienciasSociaisAplicadas, SpriteLaboratorioInformatica },
            { AreaDeConhecimento.Engenharias, SpriteLaboratorioFisica },
            { AreaDeConhecimento.LinguisticaLetrasArtes, SpriteLaboratorioInformatica },
        };
    }
}
