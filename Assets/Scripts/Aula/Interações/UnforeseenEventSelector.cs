using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using System.Collections;


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
        int num = 0;
        if (SceneManager.GetActiveScene().name == "CidadeFuncional")
        {
            if (num == 0 && OrganizadorListas.instance.ConsultarQuantidadeMidias() == 0)
            {
                num = 1;
            }
        }

        List<MomentoInteracao> unforeseenEvents;
        // (Switch não usado pois o nível de ensino não é constante)
        if (EstadoDoJogo.Instance.NivelDeEnsino == NivelDeEnsino.EducacaoInfantil)
            unforeseenEvents = unforeseenEventsInfantil;
        else if (EstadoDoJogo.Instance.NivelDeEnsino == NivelDeEnsino.EnsinoFundamental())
            unforeseenEvents = UnforeseenEventsFundamental;
        else if (EstadoDoJogo.Instance.NivelDeEnsino == NivelDeEnsino.EnsinoMedio)
            unforeseenEvents = UnforeseenEventsMedio;
        else
            unforeseenEvents = UnforeseenEventsSuperior;

        if(num == 1 && SceneManager.GetActiveScene().name == "CidadeFuncional")
        {
 
            interactionManager.Interaction = unforeseenEvents[OrganizadorListas.instance.ObterNumeroListaCidade()];

        }
        else
        {
            if(SceneManager.GetActiveScene().name == "CidadeFuncional")
            PlayerPrefs.SetInt("valorMidia", OrganizadorListas.instance.ObterOpcoesMidia());

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
