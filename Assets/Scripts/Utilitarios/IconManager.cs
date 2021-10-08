using UnityEngine;
using UnityEngine.UI;

public class IconManager : MonoBehaviour
{
    public Image[] icons;

    private Sprite defaultSprite;

    private void Start()
    {
        if (icons.Length > 0)
        {
            defaultSprite = icons[0].sprite;
        }
    }

    public void SetIcon(int index, Sprite sprite)
    {
        icons[index].sprite = sprite;
    }

    public void ResetIcon(int index)
    {
        icons[index].sprite = defaultSprite;
    }
}
