using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ControladorDisplayMomentoInteracao))]
public class SelecionadorDeMomentoDeInteracao : MonoBehaviour
{
    [SerializeField] List<MomentoInteracao> momentos;
    [SerializeField] List<MomentoInteracao> momentosInfantil;
    [SerializeField] ControladorDisplayMomentoInteracao controlador;
    [SerializeField] bool updateOnEnable = true;
    [SerializeField] EstadoDeAulaInvertida controladorDaAula;

    private void OnEnable()
    {
        controlador = gameObject.GetComponent<ControladorDisplayMomentoInteracao>();
        if(updateOnEnable)
            SelecionarMomento();
    }

   public void SelecionarMomento()
   {
        NivelDeEnsino nivel = EstadoDoJogo.Instance.NivelDeEnsinoSelecionado;
        if(nivel == NivelDeEnsino.EducacaoInfantil)
            controlador.Momento = momentosInfantil[Random.Range(0, momentosInfantil.Count)];
        else
            controlador.Momento = momentos[Random.Range(0, momentos.Count)];
   }

    public void SelecionarMomentoBaseadoEmMidia()
    {
        NomeDeMidia midia =  controladorDaAula.midiaAtual.NomeMidia;
        NivelDeEnsino nivel = EstadoDoJogo.Instance.NivelDeEnsinoSelecionado;

        List<MomentoInteracao> possiveisMomentos = new List<MomentoInteracao>();
        List<MomentoInteracao> _momentos;
        if(nivel == NivelDeEnsino.EducacaoInfantil)
            _momentos = momentosInfantil;
        else
            _momentos = momentos;

        foreach(MomentoInteracao momento in _momentos)
        {
            foreach(NomeDeMidia _midia in momento.midias)
            {
                if(_midia == midia)
                    possiveisMomentos.Add(momento);
            }
        }

        if(possiveisMomentos.Count == 0)
            possiveisMomentos = _momentos;
        controlador.Momento = possiveisMomentos[Random.Range(0, possiveisMomentos.Count)];
    }

}
