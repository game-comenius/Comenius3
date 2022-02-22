using UnityEngine;

public class AffirmationSorted : Affirmation
{
    [HideInInspector] public int correctPosition;
    [HideInInspector] public Vector2 lockedPosition;

    private void Start()
    {
        lockedPosition = GetComponent<RectTransform>().anchoredPosition;
    }
}
