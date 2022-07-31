using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(InteractionManager))]
public class LocationCommentSelector : MonoBehaviour
{
    public UnityEvent OnSelectionEvent;

    [SerializeField] private MomentoInteracao[] commentsInfantil;
    [SerializeField] private MomentoInteracao[] commentsFundamental;
    [SerializeField] private MomentoInteracao[] commentsMedio;
    [SerializeField] private MomentoInteracao[] commentsSuperior;
    [SerializeField] private InteractionManager interactionManager;
    [SerializeField] private StateMachineController stateMachine;

    public void SelectUnforeseenEvent()
    {
        MomentoInteracao[] comments;

        // (Switch não usado pois o nível de ensino não é constante)
        if (EstadoDoJogo.Instance.NivelDeEnsino == NivelDeEnsino.EducacaoInfantil)
            comments = commentsInfantil;
        else if (EstadoDoJogo.Instance.NivelDeEnsino == NivelDeEnsino.EnsinoFundamental)
            comments = commentsFundamental;
        else if (EstadoDoJogo.Instance.NivelDeEnsino == NivelDeEnsino.EnsinoMedio)
            comments = commentsMedio;
        else
            comments = commentsSuperior;

        for (int i = 0; i < comments.Length; i++)
        {
            if (comments[i].midias[0] == stateMachine.CurrentMedia().nomeMidia)
            {
                interactionManager.Interaction = comments[i];
                break;
            }
        }

        OnSelectionEvent.Invoke();
    }
}
