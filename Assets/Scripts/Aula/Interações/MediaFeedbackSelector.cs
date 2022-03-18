using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InteractionManager))]
public class MediaFeedbackSelector : MonoBehaviour
{
    [SerializeField] private List<MomentoInteracao> feedbacksInfantil;
    [SerializeField] private List<MomentoInteracao> feedbacksFundamental;
    [SerializeField] private List<MomentoInteracao> feedbacksMedio;
    [SerializeField] private List<MomentoInteracao> feedbacksSuperior;
    [SerializeField] private InteractionManager interactionManager;
    [SerializeField] private StateMachineController stateMachineController;

    public void SelectFeedback()
    {
        // (Switch não usado pois o nível de ensino não é constante)

        List<MomentoInteracao> feedbacks;

        if (EstadoDoJogo.Instance.NivelDeEnsinoSelecionado == NivelDeEnsino.EducacaoInfantil)
            feedbacks = feedbacksInfantil;
        else if (EstadoDoJogo.Instance.NivelDeEnsinoSelecionado == NivelDeEnsino.EnsinoFundamental)
            feedbacks = feedbacksFundamental;
        else if (EstadoDoJogo.Instance.NivelDeEnsinoSelecionado == NivelDeEnsino.EnsinoMedio)
            feedbacks = feedbacksFundamental;
        else
            feedbacks = feedbacksSuperior;

        bool positive = ComboChecker.Combo.Arriscada != ComboChecker.EvaluateCombo();

        for (int i = 0; i < feedbacks.Count; i++)
        {
            if (feedbacks[i].midias[0] == stateMachineController.CurrentMedia().nomeMidia &&
                positive == feedbacks[i].alunoFeliz)
            {
                interactionManager.Interaction = feedbacks[i];
                break;
            }
        }
    }
}
