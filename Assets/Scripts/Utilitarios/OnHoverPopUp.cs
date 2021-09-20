using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OnHoverPopUp : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // Funcionamento similar ao do OnHoverCursoChange

    public GameObject popUp;
    public Text text;
    public Vector3 popUpOffset;
    [TextArea]
    public string content;

    private RectTransform rect;
    private RectTransform popUpRect;

    void Start()
    {
        rect = GetComponent<RectTransform>();
        popUpRect = popUp.GetComponent<RectTransform>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        popUpRect.position = rect.position + popUpOffset;
        popUp.SetActive(true);
        text.text = content;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        popUp.SetActive(false);
        text.text = "";
    }
}
