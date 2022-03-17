using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AffirmationSorted : Affirmation
{
    public TextMeshProUGUI OrderText;

    [HideInInspector] public int correctPosition;
    [HideInInspector] public Vector2 lockedPosition;

    [SerializeField] private Image numberSlot;

    private void Start()
    {
        lockedPosition = GetComponent<RectTransform>().anchoredPosition;
        OrderText.text = "";
    }

    public void ShowCorrectPosition()
    {
        OrderText.text = (correctPosition + 1).ToString();
    }

    public override void UpdateResultColor(bool correct)
    {
        base.UpdateResultColor(correct);

        if (correct)
            numberSlot.color = correctColor;
        else
            numberSlot.color = wrongColor;
    }
}
