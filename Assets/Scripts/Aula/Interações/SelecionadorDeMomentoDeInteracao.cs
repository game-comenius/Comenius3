using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ControladorDisplayMomentoInteracao))]
public class SelecionadorDeMomentoDeInteracao : MonoBehaviour
{
    [SerializeField] private List<MomentoInteracao> imprevistos;
    [SerializeField] private List<MomentoInteracao> feedbacks;
    [SerializeField] private ControladorDisplayMomentoInteracao controlador;
    [SerializeField] private bool updateOnEnable = true;
    [SerializeField] private EstadoDeAulaInvertida controladorDaAula;
    [SerializeField] private bool cannotRepeat;
    private List<MomentoInteracao> momentosDisponiveis;
    private bool inicializarMomentosDisponiveis = true;

    public void SelecionarImprevisto()
    {
        controlador.Momento = imprevistos[Random.Range(0, imprevistos.Count)];
    }

    public void SelecionarFeedback()
    {
        controlador.Momento = feedbacks[Random.Range(0, feedbacks.Count)];
    }
}
