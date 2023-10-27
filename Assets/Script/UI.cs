using UnityEngine;

public class UISceneController : MonoBehaviour
{
    public RectTransform[] backgrounds;
    public float speed = 5.0f;
    public float backgroundWidth = 871.8356f; // Set this value based on your background image's width

    void Update()
    {
        // Move each background
        for (int i = 0; i < backgrounds.Length; i++)
        {
            MoveBackground(backgrounds[i]);
        }
    }

    void MoveBackground(RectTransform background)
    {
        // Calculate the new position
        float newX = background.anchoredPosition.x - (speed * Time.deltaTime);
        background.anchoredPosition = new Vector2(newX, background.anchoredPosition.y);

        // If the background is fully off the screen to the left, move it to the right
        if (background.anchoredPosition.x <= -backgroundWidth)
        {
            Vector2 newPosition = new Vector2(
                background.anchoredPosition.x + 2 * backgroundWidth,
                background.anchoredPosition.y
            );
            background.anchoredPosition = newPosition;
        }
    }
}
