using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public abstract class Affirmation : MonoBehaviour
{
    [SerializeReference] public Text text;
    [SerializeReference] protected Sprite selectedSprite;
    [SerializeReference] protected Sprite correctSprite;
    [SerializeReference] protected Sprite wrongSprite;

    public virtual void UpdateResultColor(bool correct)
    {
        if (correct)
            gameObject.GetComponent<Image>().sprite = correctSprite;
        else
            gameObject.GetComponent<Image>().sprite = wrongSprite;
    }
}
