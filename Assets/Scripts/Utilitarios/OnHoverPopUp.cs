using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Funcionamento similar ao do OnHoverCursoChange

public class OnHoverPopUp : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string Content;
    public string ContentPt;
     public string ContentEua;
     public string ContentSpanish;

    public enum Orientation
    {
        Top,
        Bottom,
        Right,
        Left
    }

    [SerializeField] private GameObject popUp;
    [SerializeField] private GameObject popUpArrow;    
    [SerializeField] private Text text;
    [SerializeField] private Orientation orientation;

    private RectTransform rect;
    private RectTransform popUpRect;
    private RectTransform popUpArrowRect;
    private Vector3 popUpPosition;
    private Vector3[] worldCorners;
    private Vector3[] popUpWorldCorners;
    private Vector3[] popUpArrowRectWorldCorners;

    void Start()
    {
        rect = GetComponent<RectTransform>();
        popUpRect = popUp.GetComponent<RectTransform>();
        popUpArrowRect = popUpArrow.GetComponent<RectTransform>();

        worldCorners = new Vector3[4];
        popUpWorldCorners = new Vector3[4];
        popUpArrowRectWorldCorners = new Vector3[4];
        rect.GetWorldCorners(worldCorners);
        popUpRect.GetWorldCorners(popUpWorldCorners);
        popUpArrowRect.GetWorldCorners(popUpArrowRectWorldCorners);

        float halfHeight = Mathf.Abs(rect.position.y - worldCorners[0].y);
        float halfWidth = Mathf.Abs(rect.position.x - worldCorners[0].x);

        float halfPopUpHeight = Mathf.Abs(popUpRect.position.y - popUpWorldCorners[0].y);
        float halfPopUpWidth = Mathf.Abs(popUpRect.position.x - popUpWorldCorners[0].x);

        float arrowHeight = popUpArrowRectWorldCorners[1].y - popUpArrowRectWorldCorners[0].y;
        float arrowWidth = popUpArrowRectWorldCorners[3].x - popUpArrowRectWorldCorners[0].x;

        switch (orientation)
        {
            case Orientation.Top:
                popUpPosition = new Vector3(rect.position.x, rect.position.y + halfHeight + halfPopUpHeight + arrowHeight, 0f);
                break;
            case Orientation.Bottom:
                popUpPosition = new Vector3(rect.position.x, rect.position.y - (halfHeight + halfPopUpHeight + arrowHeight), 0f);
                break;
            case Orientation.Right:
                popUpPosition = new Vector3(rect.position.x + halfWidth + halfPopUpWidth + arrowWidth, rect.position.y, 0f);
                break;
            case Orientation.Left:
                popUpPosition = new Vector3(rect.position.x - (halfWidth + halfPopUpWidth + arrowWidth), rect.position.y, 0f);
                break;
            default:
                break;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        popUpRect.position = popUpPosition;
        if(Textos.GetIdiomaSelecionado() == Idiomas.PORTUGUES)
        {
            text.text = ContentPt;
        }
        else if(Textos.GetIdiomaSelecionado() == Idiomas.INGLES)
        {
            text.text = ContentEua;
        }
        else
            text.text = ContentSpanish;
        popUp.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        popUp.SetActive(false);
        text.text = "";
    }
}
