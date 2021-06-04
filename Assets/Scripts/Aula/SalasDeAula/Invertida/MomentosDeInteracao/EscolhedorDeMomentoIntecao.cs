using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

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

        estadoDaAula.OnStateChange.AddListener(AtualizarMomento);
        var assets = AssetDatabase.LoadAllAssetsAtPath("Assets/Resources/MomentosInteracao/GeradosPelaPlanilha");
    }

    private void OnDisable()
    {
        estadoDaAula.OnStateChange.RemoveListener(AtualizarMomento);
    }

    public void AtualizarMomento()
    {
        //Pega um momento gerado pela da planilha
        controlador.Momento = GeradorDeMomentosDaPlanilha.momentos[Random.Range(0, GeradorDeMomentosDaPlanilha.momentos.Count)];
    }
}
