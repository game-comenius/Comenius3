using UnityEngine;
using UnityEngine.UI;

public class AffirmationMultipleChoice : Affirmation
{
    [HideInInspector] public bool selected;
    [HideInInspector] public bool correct;

    private void Start()
    {
        selected = false;
    }

    public void Selection()
    {
        if (selected)
            gameObject.GetComponent<Image>().color = Color.white;
        else
            gameObject.GetComponent<Image>().color = selectedColor;

        selected = !selected;
    }
}
