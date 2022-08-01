using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(InteractionManager))]
public class LocationCommentSelector : MonoBehaviour
{
    public UnityEvent OnSelectionEvent;

    [SerializeField] private MomentoInteracao[] locationCharacteristicComment;
    [SerializeField] private MomentoInteracao[] locationDefinitionComments;
    [SerializeField] private InteractionManager interactionManager;

    public void SelectComment(bool isDefinitionComment)
    {
        EstadoDoJogo gameState = EstadoDoJogo.Instance;

        MomentoInteracao[] comments;

        if (isDefinitionComment)
            comments = locationDefinitionComments;
        else
            comments = locationCharacteristicComment;

        for (int i = 0; i < comments.Length; i++)
        {
            if (comments[i].lugar == gameState.Lugar)
            {
                interactionManager.Interaction = comments[i];
                break;
            }
        }

        OnSelectionEvent.Invoke();
    }
}
