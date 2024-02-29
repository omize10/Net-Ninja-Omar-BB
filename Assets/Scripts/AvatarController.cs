using UnityEngine;

public class AvatarController : MonoBehaviour
{
    public Sprite[] jerseySprites; // Array to hold different jersey sprites
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // Get the SpriteRenderer component
    }

    void Update()
    {
        // Check for mouse or touch input
        if (Input.GetMouseButton(0)) // Check if left mouse button is pressed
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); // Get mouse position in world coordinates
            transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z); // Move the avatar to the mouse position
            // Add throwing animation here if needed
        }
    }

    // Function to change avatar's jersey
    public void ChangeJersey(int jerseyIndex)
    {
        if (jerseyIndex >= 0 && jerseyIndex < jerseySprites.Length) // Check if jerseyIndex is within bounds
        {
            spriteRenderer.sprite = jerseySprites[jerseyIndex]; // Change the avatar's sprite to the selected jersey
        }
    }

    // Example function to call when unlocking a new jersey
    public void UnlockNewJersey()
    {
        // Call this function whenever a new jersey is unlocked
        // Example usage: avatarController.UnlockNewJersey();
        int newJerseyIndex = Random.Range(0, jerseySprites.Length); // Generate a random index for the new jersey
        ChangeJersey(newJerseyIndex); // Change the avatar's jersey to the newly unlocked one
    }
}
