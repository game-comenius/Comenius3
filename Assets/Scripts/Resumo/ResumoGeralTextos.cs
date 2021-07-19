using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResumoGeralTextos : MonoBehaviour
{
    [SerializeField] bool atualizaOnStart;
    [SerializeField] ControladorFeedbackAulaInvertida controlador;


    [Header("Referencia dos textos")]
    [SerializeField] Text campoDeAprendizagem;
    [SerializeField] Text inteligenciaMultipla;
    [SerializeField] Text metodologia;
    [SerializeField] Text midiaSala1;
    [SerializeField] Text midiaSala2;
    [SerializeField] Text midiaQuarto1;
    [SerializeField] Text midiaQuarto2;
    [SerializeField] Text agrupamento1;
    [SerializeField] Text agrupamento2;

    private void Start()
    {
        if(atualizaOnStart)
            Atualizar();
    }

    void Atualizar()
    {
        var estadoDoJogo = EstadoDoJogo.Instance;
        controlador.Atualizar();

        campoDeAprendizagem.text = EstadoDoJogo.Instance.AreaDeConhecimentoSelecionada.nome;
        inteligenciaMultipla.text = EstadoDoJogo.Instance.InteligenciasSelecionadas.Nome;
        metodologia.text = EstadoDoJogo.Instance.MetodologiaSelecionada.nome;
        midiaSala1.text = EstadoDoJogo.Instance.MidiasSelecionadas[2].NomeApresentavel;
        midiaSala2.text = EstadoDoJogo.Instance.MidiasSelecionadas[3].NomeApresentavel;
        midiaQuarto1.text = EstadoDoJogo.Instance.MidiasSelecionadas[0].NomeApresentavel;
        midiaQuarto2.text = EstadoDoJogo.Instance.MidiasSelecionadas[1].NomeApresentavel;
        agrupamento1.text = EstadoDoJogo.Instance.MidiasSelecionadas[2].agrupamento.ToString();
        agrupamento2.text = EstadoDoJogo.Instance.MidiasSelecionadas[3].agrupamento.ToString();

    }
}
