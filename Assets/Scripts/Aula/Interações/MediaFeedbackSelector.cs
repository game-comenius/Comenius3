using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(InteractionManager))]
public class MediaFeedbackSelector : MonoBehaviour
{
    [System.Serializable] public class SelectionEvent : UnityEvent<bool, Sprite> { }
    public SelectionEvent OnSelectionEvent;

    [SerializeField] private List<MomentoInteracao> feedbacksInfantil;
    [SerializeField] private List<MomentoInteracao> feedbacksFundamental;
    [SerializeField] private List<MomentoInteracao> feedbacksMedio;
    [SerializeField] private List<MomentoInteracao> feedbacksSuperior;
    [SerializeField] private InteractionManager interactionManager;
    [SerializeField] private StateMachineController stateMachineController;

    public void SelectFeedback()
    {
        List<MomentoInteracao> feedbacks;

        // (Switch não usado pois o nível de ensino não é constante)
        if (EstadoDoJogo.Instance.NivelDeEnsino == NivelDeEnsino.EducacaoInfantil)
            feedbacks = feedbacksInfantil;
        else if (EstadoDoJogo.Instance.NivelDeEnsino == NivelDeEnsino.EnsinoFundamental)
            feedbacks = feedbacksFundamental;
        else if (EstadoDoJogo.Instance.NivelDeEnsino == NivelDeEnsino.EnsinoMedio)
            feedbacks = feedbacksFundamental;
        else
            feedbacks = feedbacksSuperior;

        bool positive = ComboChecker.ComboClassification.Arriscada != ComboChecker.EvaluateComboClassification();

        for (int i = 0; i < feedbacks.Count; i++)
        {
            if (feedbacks[i].midias[0] == stateMachineController.CurrentMedia().nomeMidia &&
                positive == feedbacks[i].alunoFeliz)
            {
                interactionManager.Interaction = feedbacks[i];
                break;
            }
        }

        OnSelectionEvent.Invoke(positive, stateMachineController.CurrentMedia().sprite);
    }
}
