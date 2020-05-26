using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PainelResumoDoCriador : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI nivelDeEnsino;
    [SerializeField] TextMeshProUGUI areaDeConhecimento;

    void Start()
    {
        var estadoDoJogo = EstadoDoJogo.Instance;

        nivelDeEnsino.text = estadoDoJogo.NivelDeEnsinoSelecionado.nome;
        areaDeConhecimento.text = estadoDoJogo.AreaDeConhecimentoSelecionada.nome;
    }
}
