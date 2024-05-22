using System;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
[Serializable] //kept for ease of file conversion
public class PlayerSaveData
{
    public float playerPosX;
    public float playerPosY;
    public float playerPosZ; 
    public bool npc1Completed;
    public bool npc2Completed;
    public bool npc3Completed;
    public bool npc4Completed;
    public bool npc5Completed;
    public int cement;
    public int paint;
    public int wood;
    public int metal;
    public int stone;
    public bool house1Progress;
    public bool house2Progress;
    public bool house3Progress;
    public bool tictac;
    public string emotions;
    public string test_scores;
    public int currentIsland;
}

public class SaveGame : MonoBehaviour
{
    public void SavePlayerProgress()
    {
        PlayerSaveData data = new PlayerSaveData();
        // Set data from your game variables
        data.playerPosX = GlobalVariables.player.position.x;
        data.playerPosY = GlobalVariables.player.position.y;
        data.playerPosZ = GlobalVariables.player.position.z;
        data.npc1Completed = GlobalVariables.npcCompleted[0];
        data.npc2Completed = GlobalVariables.npcCompleted[1];
        data.npc3Completed = GlobalVariables.npcCompleted[2];
        data.npc4Completed = GlobalVariables.npcCompleted[3];
        data.npc5Completed = GlobalVariables.npcCompleted[4];
        data.wood = GlobalVariables.materials[0];
        data.metal = GlobalVariables.materials[1];
        data.stone = GlobalVariables.materials[2];
        data.paint = GlobalVariables.materials[3];
        data.cement = GlobalVariables.materials[4];
        data.house1Progress = GlobalVariables.houseProgress[0];
        data.house2Progress = GlobalVariables.houseProgress[1];
        data.house3Progress = GlobalVariables.houseProgress[2];
        data.tictac = GlobalVariables.tictac;
        data.emotions = JsonUtility.ToJson(GlobalVariables.emotionArray);
        data.test_scores = JsonUtility.ToJson(GlobalVariables.testScores);
        data.currentIsland = SceneManager.GetActiveScene().buildIndex;
        // Convert data to JSON...we can do txt too but JSON IS BETTER
        string jsonData = JsonUtility.ToJson(data);
        string playerName = PlayerNameManager.playerName;
        // Save to file
        string filePath =  "./" + playerName + ".json";
        File.WriteAllText(filePath, jsonData);
    }
    public void SaveQuit(){
        SavePlayerProgress();
        Application.Quit();
    }
    // variables for player transform, inventory, and progression here..all other data to be added
}