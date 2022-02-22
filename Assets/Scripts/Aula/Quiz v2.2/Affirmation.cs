using UnityEngine;
using UnityEngine.UI;

public class Affirmation : MonoBehaviour
{
    [SerializeReference] public Text text;
    [SerializeReference] protected Color selectedColor;
    [SerializeReference] protected Color correctColor;
    [SerializeReference] protected Color wrongColor;

    public void UpdateResultColor(bool correct)
    {
        if (correct)
            gameObject.GetComponent<Image>().color = correctColor;
        else
            gameObject.GetComponent<Image>().color = wrongColor;
    }
}
