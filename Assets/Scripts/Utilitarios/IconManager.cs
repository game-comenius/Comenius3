using UnityEngine;
using UnityEngine.UI;

public class IconManager : MonoBehaviour
{
    [SerializeField] private Image[] icons;

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

    public Sprite GetIconSprite(int index)
    {
        return icons[index].sprite;
    }

    public void ResetIcon(int index)
    {
        icons[index].sprite = defaultSprite;
    }

    public void HideIcon(int index)
    {
        icons[index].enabled = false;
    }

    public void ShowIcon(int index)
    {
        icons[index].enabled = true;
    }
}
