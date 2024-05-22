using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerNameManager : MonoBehaviour
{
    // Non-static variable to store the player name...
    public static string playerName;
    public InputField playerNameInputField;

    // Awake is called before any Start function
    private void Awake()
    {
        // Ensure there's only one instance of this object in the scene
        if (FindObjectsOfType<PlayerNameManager>().Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            // Make this object persist across scenes...this should help share all its data....
            DontDestroyOnLoad(gameObject);
        }
    }

    // Function to set and save the player name
    public void SetPlayerName()
    {
        // Ensure the input field is not null and not empty
        if (playerNameInputField != null && !string.IsNullOrEmpty(playerNameInputField.text))
        {
            playerName = playerNameInputField.text;
            Debug.Log("Player Name Set: " + playerName);
        }
        else
        {
            Debug.LogWarning("Player Name is null or empty. Please enter a valid name.");
        }
    }

    // Function to get the player name from any scene...use this instead of just a public playername string...
    public string GetPlayerName()
    {
        return playerName;
    }
}

