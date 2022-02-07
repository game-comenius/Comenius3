using UnityEngine;

// (¬_¬ ) E aí?

public class DropdownMenu : MonoBehaviour
{
    [SerializeField] private GameObject dropdownMenu;
    [SerializeField] private Vector2 offset;

    private RectTransform rect;
    private RectTransform dropdownMenuRect;
    private Vector3 dropdownMenuPosition;
    private Vector3[] worldCorners;
    private Vector3[] dropdownWorldCorners;
    private bool open;

    void Start()
    {
        open = false;

        rect = GetComponent<RectTransform>();
        dropdownMenuRect = dropdownMenu.GetComponent<RectTransform>();

        // Obtém a partir do canto inferior esquerdo e vai até o canto inferior direito.
        worldCorners = new Vector3[4];
        dropdownWorldCorners = new Vector3[4];
        rect.GetWorldCorners(worldCorners);
        dropdownMenuRect.GetWorldCorners(dropdownWorldCorners);

        float xPos = worldCorners[2].x - (dropdownWorldCorners[3].x - dropdownWorldCorners[0].x) / 2f + offset.x;
        float yPos = worldCorners[2].y - (dropdownWorldCorners[1].y - dropdownWorldCorners[0].y) / 2f + offset.y;

        dropdownMenuPosition = new Vector3(xPos, yPos, 0f);
    }

    private void OnDisable()
    {
        if (open)
        {
            ButtonPress();
        }
    }

    public void ButtonPress()
    {
        dropdownMenu.SetActive(!open);

        if (!open)
        {
            dropdownMenuRect.position = dropdownMenuPosition;
        }

        open = !open;
    }
}
