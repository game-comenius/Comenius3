using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [System.Serializable] public class OnDragEndEvent : UnityEvent { }
    public OnDragEndEvent OnDragEnd;
    public Canvas canvas;

    private Vector2 initialPosition;

    private void Start()
    {
        // Gambiarra para obter a posição inicial em relação ao mundo
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform,
                                                                RectTransformUtility.WorldToScreenPoint(canvas.worldCamera, transform.position),
                                                                canvas.worldCamera,
                                                                out initialPosition);
    }

    public void OnBeginDrag(PointerEventData data)
    {
        // Sem implementação ainda
    }

    public void OnDrag(PointerEventData data)
    {
        Vector2 movePos;

        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform,
                                                                data.position,
                                                                canvas.worldCamera,
                                                                out movePos);

        movePos.x = initialPosition.x;
        transform.position = canvas.transform.TransformPoint(movePos);
    }

    public void OnEndDrag(PointerEventData data)
    {
        OnDragEnd.Invoke();
    }
}
