using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InteractionManager))]
public class UnforeseenEventSelector : MonoBehaviour
{
    [SerializeField] private List<MomentoInteracao> unforeseenEventsInfantil;
    [SerializeField] private List<MomentoInteracao> UnforeseenEventsFundamental;
    [SerializeField] private List<MomentoInteracao> UnforeseenEventsMedio;
    [SerializeField] private List<MomentoInteracao> UnforeseenEventsSuperior;
    [SerializeField] private InteractionManager interactionManager;
    [SerializeField] private StateMachineController stateMachine;

    public void SelectUnforeseenEvent()
    {
        List<MomentoInteracao> unforeseenEvents;

        if (EstadoDoJogo.Instance.NivelDeEnsinoSelecionado == NivelDeEnsino.EducacaoInfantil)
            unforeseenEvents = unforeseenEventsInfantil;
        else if (EstadoDoJogo.Instance.NivelDeEnsinoSelecionado == NivelDeEnsino.EnsinoFundamental)
            unforeseenEvents = UnforeseenEventsFundamental;
        else if (EstadoDoJogo.Instance.NivelDeEnsinoSelecionado == NivelDeEnsino.EnsinoMedio)
            unforeseenEvents = UnforeseenEventsMedio;
        else
            unforeseenEvents = UnforeseenEventsSuperior;

        for (int i = 0; i < unforeseenEvents.Count; i++)
        {
            if (unforeseenEvents[i].midias[0] == stateMachine.CurrentMedia().nomeMidia)
            {
                interactionManager.Interaction = unforeseenEvents[i];
                break;
            }
        }
    }
}
