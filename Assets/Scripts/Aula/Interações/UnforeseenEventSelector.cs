using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(InteractionManager))]
public class UnforeseenEventSelector : MonoBehaviour
{
    public UnityEvent OnSelectionEvent;

    [SerializeField] private List<MomentoInteracao> unforeseenEventsInfantil;
    [SerializeField] private List<MomentoInteracao> UnforeseenEventsFundamental;
    [SerializeField] private List<MomentoInteracao> UnforeseenEventsMedio;
    [SerializeField] private List<MomentoInteracao> UnforeseenEventsSuperior;
    [SerializeField] private InteractionManager interactionManager;
    [SerializeField] private StateMachineController stateMachine;

    public void SelectUnforeseenEvent()
    {
        List<MomentoInteracao> unforeseenEvents;

        // (Switch não usado pois o nível de ensino não é constante)
        if (EstadoDoJogo.Instance.NivelDeEnsino == NivelDeEnsino.EducacaoInfantil)
            unforeseenEvents = unforeseenEventsInfantil;
        else if (EstadoDoJogo.Instance.NivelDeEnsino == NivelDeEnsino.EnsinoFundamental)
            unforeseenEvents = UnforeseenEventsFundamental;
        else if (EstadoDoJogo.Instance.NivelDeEnsino == NivelDeEnsino.EnsinoMedio)
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

        OnSelectionEvent.Invoke();
    }
}
