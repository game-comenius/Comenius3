using UnityEngine;
using UnityEngine.UI;

public class AffirmationMultipleChoice : Affirmation
{
    [HideInInspector] public bool selected;
    [HideInInspector] public bool correct;
    [SerializeField] private GameObject selectionDot;

    private Sprite defaultSprite;

    private void Start()
    {
        selected = false;
        defaultSprite = gameObject.GetComponent<Image>().sprite;
    }

    public void Selection()
    {
        if (selected)
            gameObject.GetComponent<Image>().sprite = defaultSprite;
        else
            gameObject.GetComponent<Image>().sprite = selectedSprite;

        selected = !selected;
        selectionDot.SetActive(selected);
    }
}
