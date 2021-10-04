using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Funcionamento similar ao do OnHoverCursoChange

public class OnHoverPopUp : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject popUp;
    public Text text;
    public Vector3 popUpOffset;  // Offset a partir do centro do objeto selecionado
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
