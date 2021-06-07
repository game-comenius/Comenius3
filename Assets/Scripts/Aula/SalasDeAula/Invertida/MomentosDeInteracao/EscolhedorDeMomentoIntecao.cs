using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ControladorDisplayMomentoInteracao))]
public class EscolhedorDeMomentoIntecao : MonoBehaviour
{
    [SerializeField] ControladorDisplayMomentoInteracao controlador;
    [SerializeField] EstadoDeAulaInvertida estadoDaAula;

    MomentoInteracao[] momentos;

    private void OnEnable()
    {
        if (controlador == null)
            controlador = GetComponent<ControladorDisplayMomentoInteracao>();
        momentos = Resources.LoadAll<MomentoInteracao>("MomentosInteracao/GeradosPelaPlanilha");

        estadoDaAula.OnStateChange.AddListener(AtualizarMomento);
        AtualizarMomento();
    }

    private void OnDisable()
    {
        estadoDaAula.OnStateChange.RemoveListener(AtualizarMomento);
    }

    public void AtualizarMomento()
    {
        //Pega um momento gerado pela da planilha
        controlador.Momento = momentos[Random.Range(0, momentos.Length)];
    }
}
