using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Texture2D cursorTexture;

    private void Start()
    {
        SetCursorIcon();
    }

    private void SetCursorIcon()
    {
        Cursor.SetCursor(
            cursorTexture, 
            new Vector2(cursorTexture.width / 2f, cursorTexture.height / 2f), 
            CursorMode.Auto);
    }
}
