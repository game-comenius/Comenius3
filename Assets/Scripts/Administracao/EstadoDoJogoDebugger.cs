using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoDoJogoDebugger : MonoBehaviour
{


    [SerializeField] NivelDeEnsino nivelDeEnsinoSelecionado;

    [SerializeField] AreaDeConhecimento areaDeConhecimentoSelecionada;

    [SerializeField] Inteligencias inteligenciasSelecionadas;

    [SerializeField] Metodologia metodologiaSelecionada;

    [SerializeField] Midia[] midiasSelecionadas;

    public void OnEnable()
    {
        UpdateData();
    }

    public void UpdateData()
    {
        EstadoDoJogo jogo = EstadoDoJogo.Instance;
        nivelDeEnsinoSelecionado = jogo.NivelDeEnsinoSelecionado;
        areaDeConhecimentoSelecionada = jogo.AreaDeConhecimentoSelecionada;
        inteligenciasSelecionadas = jogo.InteligenciasSelecionadas;
        metodologiaSelecionada = jogo.MetodologiaSelecionada;
        midiasSelecionadas = jogo.MidiasSelecionadas;
    }
    // Características da personagem selecionada, observar se estes valores != null
    //public Sprite SpriteCorpoPersonagem { get; set; }
    //public Sprite SpriteCabeloPersonagem { get; set; }
    //public Sprite SpriteRoupaPersonagem { get; set; }
    //public Sprite SpriteIconePersonagem { get; set; }
}
