using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HouseManager : MonoBehaviour
{
    private int[] houseRequirements;
    private string[] dict = {"Small", "Medium", "Big"};
    // [SerializeField] public Animator anim;
    [SerializeField] public GameObject[] HousesUI;
    [SerializeField] public GameObject[] Houses;
    [SerializeField] public GameObject AlertPanel;
    [SerializeField] public TextMeshProUGUI alertMessage;

    void Start(){
        houseRequirements = new int[3] {6,12,18};
    }
    public void buildHouse(int HouseIndex){
        if(checkRequirements(HouseIndex)) SuccessfulResponse(HouseIndex);
        else FailureResponse(HouseIndex);
        AlertPanel.SetActive(true);
        
    }
    public void SuccessfulResponse(int index){
        HousesUI[index].SetActive(false);
        for(int i = 0; i<5; i++) GlobalVariables.materials[i] -= houseRequirements[index];
        alertMessage.text = "Congratulations you built the " + dict[index] + " house!!";
        Houses[index].SetActive(true);
        // anim.SetBool("isClapping", true);
        GlobalVariables.houseProgress[index] = true;
    }
    public void FailureResponse(int index){
        // insufficient funds
        alertMessage.text = "Oops, looks like you have insufficient material to build this house!";
    }
    bool checkRequirements(int index){
        for(int i = 0; i<5; i++) if(GlobalVariables.materials[i] < houseRequirements[index]) return false;
        return true; 
    }
}
