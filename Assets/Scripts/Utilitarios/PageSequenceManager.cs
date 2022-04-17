using UnityEngine;
using UnityEngine.UI;

public class PageSequenceManager : MonoBehaviour
{
    [SerializeField] private GameObject[] pages;
    [SerializeField] private Button backButton;
    [SerializeField] private Button nextButton;

    private int currentPage;

    private void Start()
    {
        currentPage = 0;
        UpdateButtons();
    }

    public void Next()
    {
        pages[currentPage].SetActive(false);
        currentPage++;
        pages[currentPage].SetActive(true);

        UpdateButtons();
    }

    public void Back()
    {
        pages[currentPage].SetActive(false);
        currentPage--;
        pages[currentPage].SetActive(true);

        UpdateButtons();
    }

    private void UpdateButtons()
    {
        backButton.interactable = currentPage > 0;
        nextButton.interactable = currentPage < pages.Length - 1;
    }
}
