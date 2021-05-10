/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaginaPreviewDaSalaInvertida : MonoBehaviour
{
    [SerializeField] GameObject salaInvertida;
    [SerializeField] GameObject salaInfantil;

    private void Start()
    {
        var salaEscolhida = SelecionarSalaQueSeraUsada();
        Ligar(salaEscolhida);
        Debug.Log(salaEscolhida);
    }

    private GameObject SelecionarSalaQueSeraUsada()
    {
        // Sala padrão é a sala Invertida
        var sala = salaInvertida;
        var nivelDeEnsino = EstadoDoJogo.Instance.NivelDeEnsinoSelecionado;
        var metodologiaSelecionada = EstadoDoJogo.Instance.MetodologiaSelecionada;

        if (nivelDeEnsino == NivelDeEnsino.EducacaoInfantil)
        {
            sala = salaInfantil;
        }
        else
        {
            if (metodologiaSelecionada == Metodologia.Invertida)
                sala = salaInvertida;
        }
        return sala;
    }
    
    private void Ligar(GameObject sala)
    {
        sala.SetActive(true);
        
    }

}
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaginaPreviewDaSalaInvertida : Pagina
{
    [SerializeField] SalaDeAula salaInvertida;
    [SerializeField] SalaDeAula salaInfantil;

    private void Start()
    {
        var salaEscolhida = SelecionarSalaQueSeraUsada();
        StartCoroutine(salaEscolhida.Mostrar());
        Debug.Log(salaEscolhida);
    }

    private SalaDeAula SelecionarSalaQueSeraUsada()
    {
        // Sala padrão é a sala da metodologia ABP
        var sala = salaInvertida;
        var nivelDeEnsino = EstadoDoJogo.Instance.NivelDeEnsinoSelecionado;
        var metodologiaSelecionada = EstadoDoJogo.Instance.MetodologiaSelecionada;

        if (nivelDeEnsino == NivelDeEnsino.EducacaoInfantil)
        {
            sala = salaInfantil;
        }
        else
        {
            if (metodologiaSelecionada == Metodologia.ABP)
                sala = salaInvertida;
        }
        return sala;
    }
}
