using UnityEngine;

public class LevelUpManager : MonoBehaviour
{
    private int skillPoints = 0; // Example: Skill points earned during level up

    private void Awake()
    {
        // Ensure that this GameObject persists across scenes
        DontDestroyOnLoad(transform.gameObject);
    }

    // Call this method when the player clicks the "Level Up" button
    public void IncreaseSkillPoints(int amount)
    {
        // Update skill points based on the player's action (e.g., leveling up)
        skillPoints += amount;
        Debug.Log($"Skill points increased! Current skill points: {skillPoints}");
    }

    // Example: You can call this method when the player completes a level
    public void LevelCompleted()
    {
        // Perform any other relevant actions (e.g., saving progress, unlocking abilities)
        Debug.Log("Level completed! Congratulations!");
    }
}
