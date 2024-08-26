using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

[RequireComponent(typeof(InteractionManager))]
public class MediaFeedbackSelector : MonoBehaviour
{
    [System.Serializable] public class SelectionEvent : UnityEvent<bool, Sprite> { }
    public SelectionEvent OnSelectionEvent;
    private List<int> listaMidiasPossiveis;
    // TODO: Trocar as listas por arrays
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
            feedbacks = feedbacksMedio;
        else
            feedbacks = feedbacksSuperior;

        bool positive = ComboChecker.ComboClassification.Arriscada != ComboChecker.EvaluateComboClassification();
        int sorteio = Random.Range(0, 5);
        if(SceneManager.GetActiveScene().name == "Sala de Aula ABProj 1-3")
        {
            sorteio = OrganizadorListas.instance.ObterOpcoesMidia();
        }
        int calculador = 0;
        if(positive == true)
        {
            calculador = 15;
        }
        Debug.Log(EstadoDoJogo.Instance.Midias[sorteio].nomeMidia);
        Debug.Log(EstadoDoJogo.Instance.NivelDeEnsino.nome);
        for (int i = calculador; i < feedbacks.Count; i++)
            {
                if (feedbacks[i].midias[0] == EstadoDoJogo.Instance.Midias[sorteio].nomeMidia)
                {
                
            
                    interactionManager.Interaction = feedbacks[i];
                    break;
                }

            }
        OnSelectionEvent.Invoke(positive, stateMachineController.CurrentMedia().sprite);
    }
}
