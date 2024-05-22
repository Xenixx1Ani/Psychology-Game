using System.Collections.Generic;
using UnityEngine;
using TMPro; // Import TextMeshPro namespace
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public Transform contentPanel;
    public Transform player;
    public Button loadButtonPrefab;

    void Start()
    {
        LoadSavedGames();
    }

    void LoadSavedGames()
    {
        string[] saveFiles = Directory.GetFiles(Application.persistentDataPath, "*.json");

        if (saveFiles.Length == 0)
        {
            Debug.Log("No files found");
        }

        foreach (string filePath in saveFiles)
        {   
            string playerName = Path.GetFileNameWithoutExtension(filePath);
           // if (playerName!="Game ID: 001"){    
                Debug.Log(playerName);
                CreateLoadButton(playerName);
              //  Debug.Log("Button created for "+ playerName);
             //}
        }
    }

void CreateLoadButton(string playerName)
{
    Button loadButton = Instantiate(loadButtonPrefab, contentPanel);
    TMP_Text buttonText = loadButton.GetComponentInChildren<TMP_Text>();
    buttonText.text = playerName;
    Debug.Log("Button Onclick for "+playerName);
    loadButton.onClick.AddListener(() => LoadSelectedGame(playerName));
    loadButton.interactable = true;

    CanvasGroup canvasGroup = loadButton.GetComponent<CanvasGroup>();
   /* if (canvasGroup != null)
    {
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
        canvasGroup.alpha = 1f; // Set alpha to fully visible
    }*/
}

    void LoadSelectedGame(string playerName)
    {
        Debug.Log("Entered LoadSelectedGame()");
        // Load the selected player's save data
        string filePath = Application.persistentDataPath + "/" + playerName + ".json";
        string jsonData = File.ReadAllText(filePath);

        // Deserialize JSON data
        PlayerSaveData data = JsonUtility.FromJson<PlayerSaveData>(jsonData);
        Debug.Log(data.npc1Completed+"data.npc1Completed"+data.playerPosX+"data.npc1Completed");
        GlobalVariables.npcCompleted[0] = data.npc1Completed;
        GlobalVariables.npcCompleted[1] = data.npc2Completed;
        GlobalVariables.npcCompleted[2] = data.npc3Completed;
        GlobalVariables.npcCompleted[3] = data.npc4Completed;
        GlobalVariables.npcCompleted[4] = data.npc5Completed;
        GlobalVariables.materials[0] = data.wood;
        GlobalVariables.materials[1] = data.metal;
        GlobalVariables.materials[2] = data.stone;
        GlobalVariables.materials[3] = data.paint;
        GlobalVariables.materials[4] = data.cement;
        GlobalVariables.houseProgress[0] = data.house1Progress;
        GlobalVariables.houseProgress[1] = data.house2Progress;
        GlobalVariables.houseProgress[2] = data.house3Progress;
        GlobalVariables.tictac = data.tictac;
        GlobalVariables.player = GameObject.FindGameObjectWithTag("Player").transform;
        TeleportPlayer(data.playerPosX, data.playerPosY, data.playerPosZ, data.currentIsland);

    }

    void TeleportPlayer(float x, float y, float z, int currentIsland)
    {
        int currentIslandSceneName = currentIsland; // Assuming scene names are in the format "1", "2", etc.
        UnityEngine.SceneManagement.SceneManager.LoadScene(currentIslandSceneName);
        GlobalVariables.player.position = new Vector3(x, y, z);
        Debug.Log("Player teleported to Island: " + currentIslandSceneName);
    }
}
