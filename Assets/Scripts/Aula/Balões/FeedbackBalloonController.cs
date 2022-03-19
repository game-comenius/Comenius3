using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class FeedbackBalloonController : MonoBehaviour
{
    [SerializeField] private SpriteRenderer mediaSriteRenderer;
    [SerializeField] private Sprite positiveFeedbackBalloon;
    [SerializeField] private Sprite negativeFeedbackBalloon;

    public void UpdateBalloon(bool positive, Sprite mediaIcon)
    {
        Debug.Log(positive);
        Debug.Log(mediaIcon);
        GetComponent<SpriteRenderer>().sprite = positive ? positiveFeedbackBalloon : negativeFeedbackBalloon;
        mediaSriteRenderer.sprite = mediaIcon;
    }
}
