using UnityEngine;
using TMPro;

public class AffirmationSorted : Affirmation
{
    public TextMeshProUGUI OrderText;

    [HideInInspector] public int correctPosition;
    [HideInInspector] public Vector2 lockedPosition;

    private void Start()
    {
        lockedPosition = GetComponent<RectTransform>().anchoredPosition;
        OrderText.text = "";
    }

    public void ShowCorrectPosition()
    {
        OrderText.text = (correctPosition + 1).ToString();
    }
}
