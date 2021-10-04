using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Funcionamento similar ao do OnHoverCursoChange

public class OnHoverPopUp : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject popUp;
    public Text text;
    public Orientation orientation;
    [TextArea]
    public string content;

    public enum Orientation
    {
        Top,
        Bottom,
        Right,
        Left
    }

    private RectTransform rect;
    private RectTransform popUpRect;
    private Vector3 popUpPosition;
    private Vector3[] worldCorners;
    private Vector3[] popUpWorldCorners;

    void Start()
    {
        rect = GetComponent<RectTransform>();
        popUpRect = popUp.GetComponent<RectTransform>();

        // Obtém a partir do canto inferior esquerdo e vai até o canto inferior direito.
        worldCorners = new Vector3[4];
        popUpWorldCorners = new Vector3[4];
        rect.GetWorldCorners(worldCorners);
        popUpRect.GetWorldCorners(popUpWorldCorners);

        float halfHeight = Mathf.Abs(rect.position.y - worldCorners[0].y);
        float halfWidth = Mathf.Abs(rect.position.x - worldCorners[0].x);

        float halfPopUpHeight = Mathf.Abs(popUpRect.position.y - popUpWorldCorners[0].y);
        float halfPopUpWidth = Mathf.Abs(popUpRect.position.x - popUpWorldCorners[0].x);

        switch (orientation)
        {
            case Orientation.Top:
                popUpPosition = new Vector3(rect.position.x, rect.position.y + halfHeight + halfPopUpHeight, 0f);
                break;
            case Orientation.Bottom:
                popUpPosition = new Vector3(rect.position.x, rect.position.y - (halfHeight + halfPopUpHeight), 0f);
                break;
            case Orientation.Right:
                popUpPosition = new Vector3(rect.position.x + halfWidth + halfPopUpWidth, rect.position.y, 0f);
                break;
            case Orientation.Left:
                popUpPosition = new Vector3(rect.position.x - (halfWidth + halfPopUpWidth), rect.position.y, 0f);
                break;
            default:
                break;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        popUpRect.position = popUpPosition;
        popUp.SetActive(true);
        text.text = content;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        popUp.SetActive(false);
        text.text = "";
    }
}
