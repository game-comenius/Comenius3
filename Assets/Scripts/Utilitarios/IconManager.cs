using UnityEngine;
using UnityEngine.UI;

public class IconManager : MonoBehaviour
{
    [SerializeField] private GameObject[] icons;
    [SerializeField] private Sprite defaultIcon;

    public void SetIcon(int index, Sprite sprite)
    {
        icons[index].GetComponent<Image>().sprite = sprite;
        icons[index].GetComponent<Animator>().Play("PopStart", 0);
    }

    public Sprite GetIconSprite(int index)
    {
        return icons[index].GetComponent<Image>().sprite;
    }

    public void ResetIcon(int index)
    {
        icons[index].GetComponent<Image>().sprite = defaultIcon;
    }

    public void HideIcon(int index)
    {
        icons[index].GetComponent<Image>().enabled = false;
    }

    public void ShowIcon(int index)
    {
        icons[index].GetComponent<Image>().enabled = true;
    }
}
