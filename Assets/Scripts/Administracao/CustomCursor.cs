using UnityEngine;

public class CustomCursor : Singleton<CustomCursor>
{
    public Texture2D textureImage;
    public Vector2 hotSpot = Vector2.zero;

    [HideInInspector] public readonly CursorMode cursorMode = CursorMode.Auto;

    // Start is called before the first frame update
    void Start()
    {
        if (textureImage == null)
            Debug.LogWarning("Texture2D para CustomCursor não está definida, defina no inspector para alterar sprite do cursor.");
        else
            Cursor.SetCursor(textureImage, hotSpot, cursorMode);
    }
}
