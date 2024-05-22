using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
public class ConversationStarterMultiple : MonoBehaviour
{

    [SerializeField] NPCConversation[] Conversations;
    public int npcNumber;
    private bool[] ConvoDoneBools;
    void Start(){
        ConvoDoneBools = new bool[Conversations.Length];
    }
    private bool allHensCollected(){
        return GlobalVariables.hen_caught >= 3;
    }
    public void ConvoDone(int index){
       ConvoDoneBools[index] = true;
    }

    private void OnTriggerStay(Collider other){
        if(other.CompareTag("Player")){
            if(Input.GetAxis("Interact") != 0){
                switch (npcNumber){
                    case 1:
                        if(!ConvoDoneBools[0]) ConversationManager.Instance.StartConversation(Conversations[0]);
                        else if (!ConvoDoneBools[1]) ConversationManager.Instance.StartConversation(Conversations[1]);
                        else ConversationManager.Instance.StartConversation(Conversations[2]);
                        break;
                    case 2:
                        ConversationManager.Instance.StartConversation(Conversations[0]);
                        break;
                    case 3:
                        if(!ConvoDoneBools[0]){
                            ConversationManager.Instance.StartConversation(Conversations[0]);
                        }
                        else if(!allHensCollected()) ConversationManager.Instance.StartConversation(Conversations[1]);
                        else ConversationManager.Instance.StartConversation(Conversations[2]);
                        break;
                    case 4:
                        ConversationManager.Instance.StartConversation(Conversations[0]);
                        break;
                    case 5:
                        if(!GlobalVariables.tictac) ConversationManager.Instance.StartConversation(Conversations[0]);
                        else ConversationManager.Instance.StartConversation(Conversations[1]);
                    break;
                        
                }
                
            }
        }
    }
}
