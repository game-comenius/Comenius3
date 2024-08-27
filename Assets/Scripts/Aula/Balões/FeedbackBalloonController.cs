using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class FeedbackBalloonController : MonoBehaviour
{
    [SerializeField] private SpriteRenderer mediaSriteRenderer;
    [SerializeField] private Sprite positiveFeedbackBalloon;
    [SerializeField] private Sprite negativeFeedbackBalloon;
    [SerializeField] private Sprite teste;
    public void UpdateBalloon(bool positive, Sprite mediaIcon)
    {
        Debug.Log("Attballon");
        GetComponent<SpriteRenderer>().sprite = positive ? positiveFeedbackBalloon : negativeFeedbackBalloon;
        mediaSriteRenderer.sprite = mediaIcon;
        mediaSriteRenderer.transform.localScale = new Vector3(0.20F, 0.20F, 0.20F);
    }
}
