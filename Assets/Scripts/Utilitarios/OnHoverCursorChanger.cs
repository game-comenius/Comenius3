using UnityEngine;
using UnityEngine.EventSystems;

public class OnHoverCursorChanger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // The PNG image of the cursor when it's hovering something is at
    // "Assets/Resources/Sprites/Cursores/OnHoverCursor32px.png"
    // We will load it using Resources.Load the first time the property is accessed
    private static Texture2D textureImageWhenHovering;
    public static Texture2D TextureImageWhenHovering
    {
        get
        {
            if (!textureImageWhenHovering)
                textureImageWhenHovering = Resources.Load<Texture2D>("Sprites/Cursores/OnHoverCursor32px");
            return textureImageWhenHovering;
        }
    }
    private static Vector2 hotSpot = Vector2.zero;
    private static CursorMode cursorMode = CursorMode.Auto;

    // Fields that represent the cursor when it is not hovering something
    // These values come from the Singleton instance of CustomCursor.cs
    // We will use these when we change the cursor back to its standard form,
    // for example, when it is no longer hovering this GameObject
    private Texture2D standardTextureImage;
    private Vector2 standardHotSpot;
    private CursorMode standardCursorMode;


    void Start()
    {
        var customCursor = CustomCursor.Instance;
        standardTextureImage = customCursor.textureImage;
        standardHotSpot = customCursor.hotSpot;
        standardCursorMode = customCursor.cursorMode;
    }

    private void ChangeCursorToOnHover()
    {
        Cursor.SetCursor(TextureImageWhenHovering, hotSpot, cursorMode);
    }

    private void ChangeCursorBackToStandard()
    {
        Cursor.SetCursor(standardTextureImage, standardHotSpot, standardCursorMode);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        ChangeCursorToOnHover();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ChangeCursorBackToStandard();
    }

    // Transforms cursor pointer back to its standard version when this
    // object is destroyed or disabled
    private void OnDestroy() { ChangeCursorBackToStandard(); }
    private void OnDisable() { ChangeCursorBackToStandard(); }
}
