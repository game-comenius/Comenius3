using UnityEngine;
using UnityEngine.UI;

public class MediaPageViewManager : MonoBehaviour
{
    [SerializeField] private GameObject firstView;
    [SerializeField] private GameObject secondView;

    [SerializeField] [TextArea] private string firstMediaDefaultDescription;
    [SerializeField] private GameObject[] firstMediaPages;
    [SerializeField] private Button firstMediaNextButton;
    [SerializeField] private Button firstMediaBackButton;

    [SerializeField] [TextArea] private string secondMediaDefaultDescription;
    [SerializeField] private GameObject[] secondMediaPages;
    [SerializeField] private Button secondMediaNextButton;
    [SerializeField] private Button secondMediaBackButton;

    public void SetFirstMediaView(PaginaMidias mediaPage)
    {
        firstView.SetActive(true);
        secondView.SetActive(false);
        mediaPage.UpdateViewData(firstMediaDefaultDescription, firstMediaPages, firstMediaNextButton, firstMediaBackButton);
    }

    public void SetSecondsMediaView(PaginaMidias mediaPage)
    {
        firstView.SetActive(false);
        secondView.SetActive(true);
        mediaPage.UpdateViewData(secondMediaDefaultDescription, secondMediaPages, secondMediaNextButton, secondMediaBackButton);
    }
}
