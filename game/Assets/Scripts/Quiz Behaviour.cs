using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizBehaviour : MonoBehaviour
{
    public static int[] wrongAttempts = new int[10] {0,0,0,0,0,0,0,0,0,0};
    public static int[] unitValues = new int[4] {10,8,5,3};
    GameObject[] Sprites;
    public GameObject WoodSprite;
    public GameObject MetalSprite;
    public GameObject StoneSprite;
    public GameObject PaintBucketSprite;
    public GameObject CementSprite;
    void Start(){
        Sprites = new GameObject[5] { WoodSprite, MetalSprite, StoneSprite, PaintBucketSprite, CementSprite };
    }
    public void IncreaseWrongAttempts(int quesIndex){
        wrongAttempts[quesIndex-1]++;
    }
     /*  0 - wood, 1 - metal, 2 - stone, 3 - paintbuckets, 4 - cement */
    public void GetReward(int quesIndex){
        int itemToGive = (quesIndex - 1) % 5;
        int unitsToGive = wrongAttempts[quesIndex-1];
        if(unitsToGive > 3) unitsToGive = 3;
        GlobalVariables.materials[itemToGive] += unitValues[unitsToGive];
        Debug.Log("Global var: " +  itemToGive + " value : " + GlobalVariables.materials[itemToGive]+ " units added : " + unitValues[unitsToGive]);
        Debug.Log("item to give "+ itemToGive + "  units to give " + unitValues[unitsToGive]+ " index "+ unitsToGive);
        GameObject child =  Sprites[itemToGive].transform.GetChild(unitsToGive).gameObject;
        StartCoroutine(FadeInOut(child));
    }
    public IEnumerator FadeInOut(GameObject child){
        child.SetActive(true);
        yield return new WaitForSeconds(2);
        child.SetActive(false);
    }

}
