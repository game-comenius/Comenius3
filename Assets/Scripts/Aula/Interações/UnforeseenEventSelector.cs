using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(InteractionManager))]
public class UnforeseenEventSelector : MonoBehaviour
{
    public UnityEvent OnSelectionEvent;

    // TODO: Trocar as listas por arrays
    [SerializeField] private List<MomentoInteracao> unforeseenEventsInfantil;
    [SerializeField] private List<MomentoInteracao> UnforeseenEventsFundamental;
    [SerializeField] private List<MomentoInteracao> UnforeseenEventsMedio;
    [SerializeField] private List<MomentoInteracao> UnforeseenEventsSuperior;
    [SerializeField] private InteractionManager interactionManager;
    [SerializeField] private StateMachineController stateMachine;

    public void SelectUnforeseenEvent()
    {
       int num = Random.Range(0, 2);
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

        if(num == 1 && SceneManager.GetActiveScene().name == "CidadeFuncional")
        {
            int random1 = Random.Range(14, 18);
            interactionManager.Interaction = unforeseenEvents[random1];
        }
        else
        {
         

            for (int i = 0; i < unforeseenEvents.Count; i++)
            {
             
                if (unforeseenEvents[i].midias[0] == stateMachine.CurrentMedia().nomeMidia)
                {
                    interactionManager.Interaction = unforeseenEvents[i];
                    break;
                }
            }
        }
    

        OnSelectionEvent.Invoke();
    }
}
