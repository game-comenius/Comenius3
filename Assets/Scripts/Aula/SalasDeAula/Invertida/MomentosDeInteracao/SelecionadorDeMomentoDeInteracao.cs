using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ControladorDisplayMomentoInteracao))]
public class SelecionadorDeMomentoDeInteracao : MonoBehaviour
{
    [SerializeField] List<MomentoInteracao> momentos;
    [SerializeField] List<MomentoInteracao> momentosInfantil;
    [SerializeField] ControladorDisplayMomentoInteracao controlador;

    private void OnEnable()
    {
        controlador = gameObject.GetComponent<ControladorDisplayMomentoInteracao>();
        SelecionarMomento();
    }

   private void SelecionarMomento()
   {
        NivelDeEnsino nivel = EstadoDoJogo.Instance.NivelDeEnsinoSelecionado;
        if(nivel == NivelDeEnsino.EducacaoInfantil)
            controlador.Momento = momentosInfantil[Random.Range(0, momentosInfantil.Count)];
        else
            controlador.Momento = momentos[Random.Range(0, momentos.Count)];
   }

}
