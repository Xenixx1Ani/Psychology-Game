using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GlobalVariables : MonoBehaviour
{
    public static int hen_caught;
    public static int emotionIndexCounter;
    public static bool tictac;
    public static Vector3 playerPosition;
    public static bool[] npcCompleted;
    public static bool[] houseProgress;
    public static int[] materials; 
    public static string[] emotionArray;
    public static int[] testScores;
    public static int testIndex;
    public static Transform player; 

    public static string[] datesForQuizes;

    void Start()
    {
        emotionIndexCounter = 0;
        hen_caught = 0;
        tictac = false;
        materials = new int[5] {0,0,0,0,0};
        houseProgress = new bool[3] {false, false, false};
        emotionArray = new string[10];
        testScores = new int[10]{0,0,0,0,0,0,0,0,0,0};
        datesForQuizes = new string[10];
        testIndex = -1; // stores on which date the test was made
        npcCompleted = new bool[5] {false, false, false, false, false};
        GameObject temp = GameObject.FindGameObjectsWithTag("Player")[0];
        player = temp.GetComponent<Transform>();
    }
    public void IncreaseAsset(int itemIndex, int quantity){
        materials[itemIndex] += quantity;
    }
    public void updateHouseProgress(int houseIndex){
        houseProgress[houseIndex] = true;
    }
    public void updateNPCProgress(int NPCIndex){
        npcCompleted[NPCIndex] = true;
    }
    public void AddEmotion(string e){
        emotionArray[emotionIndexCounter] = e;
        emotionIndexCounter++;
    }
    public void incrementTestIndex(){ // increment every time a new test is taken
        testIndex++;
        datesForQuizes[testIndex] = System.DateTime.Now.ToString();
        Debug.Log(System.DateTime.Now.ToString());
    }    public void AddTestScoreValue(int value){
        testScores[testIndex] += value;
    }
}
