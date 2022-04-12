using UnityEngine;

// (¬_¬ ) E aí?

public class DropdownMenu : MonoBehaviour
{
    [SerializeField] private GameObject dropdownMenu;
    [SerializeField] private Vector2 offset;
    [SerializeField] private bool useWorldPosition;
    [SerializeField] private Vector2 worldOffset;

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

        float xPos;
        float yPos;

        if (!useWorldPosition)
        {
            // Obtém a partir do canto inferior esquerdo e vai até o canto inferior direito.
            worldCorners = new Vector3[4];
            dropdownWorldCorners = new Vector3[4];
            rect.GetWorldCorners(worldCorners);
            dropdownMenuRect.GetWorldCorners(dropdownWorldCorners);

            xPos = worldCorners[2].x - (dropdownWorldCorners[3].x - dropdownWorldCorners[0].x) / 2f + offset.x;
            yPos = worldCorners[2].y - (dropdownWorldCorners[1].y - dropdownWorldCorners[0].y) / 2f + offset.y;
        }
        else
        {
            xPos = transform.position.x + worldOffset.x;
            yPos = transform.position.y + worldOffset.y;
        }

        dropdownMenuPosition = new Vector3(xPos, yPos, 0f);
    }

    private void OnDisable()
    {
        Disable();
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

    public void Disable()
    {
        if (open)
        {
            ButtonPress();
        }
    }
}
