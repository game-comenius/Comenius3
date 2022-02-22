using UnityEngine;
using UnityEngine.UI;

public class Affirmation : MonoBehaviour
{
    [HideInInspector] public bool selected;

    [SerializeReference] public Text text;
    [SerializeReference] protected Color selectedColor;
    [SerializeReference] protected Color correctColor;
    [SerializeReference] protected Color wrongColor;

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

    public void UpdateResultColor(bool correct)
    {
        if (correct)
            gameObject.GetComponent<Image>().color = correctColor;
        else
            gameObject.GetComponent<Image>().color = wrongColor;
    }
}
