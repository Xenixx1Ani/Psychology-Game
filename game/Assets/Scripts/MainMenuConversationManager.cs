using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class MainMenuConversationManager : MonoBehaviour
{
    [SerializeField] private NPCConversation myConversation;
    void Start(){
        ConversationManager.Instance.StartConversation(myConversation);
    }
}
