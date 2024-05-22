using UnityEngine;
using UnityEngine.UI;

public class NPCDialogue : MonoBehaviour
{
    public string[] dialogueLines;
    public float interactionRadius = 1f;//distance between player ands the NPC where you can talk

    private bool isPlayerInRange = false;
    private int currentLineIndex = 0;
    private Canvas dialogueCanvas;
    private Text dialogueText;

    void Start()
    {
        dialogueCanvas = FindObjectOfType<Canvas>();
        dialogueText = dialogueCanvas.GetComponentInChildren<Text>();
        dialogueCanvas.gameObject.SetActive(false);
    }

    void Update()
    {
        // Check if the player is in range
        isPlayerInRange = Vector3.Distance(transform.position, PlayerMovement.Instance.transform.position) <= interactionRadius;

        // Check for player input
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.F))
        {
            StartDialogue();
        }

        // Continue dialogue on Enter or Space press
        if (dialogueCanvas.gameObject.activeSelf && (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space)))
        {
            ContinueDialogue();
        }
    }

    void StartDialogue()
    {
        currentLineIndex = 0;
        DisplayNextLine();
    }

    void ContinueDialogue()
    {
        if (currentLineIndex < dialogueLines.Length - 1)
        {
            currentLineIndex++;
            DisplayNextLine();
        }
        else
        {
            EndDialogue();
        }
    }

    void DisplayNextLine()
    {
        if (currentLineIndex < dialogueLines.Length)
        {
            dialogueText.text = dialogueLines[currentLineIndex];
        }
    }

    void EndDialogue()
    {
        dialogueCanvas.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
            EndDialogue();
        }
    }
}
/*
Attach a Canvas to your scene and create a Text UI element as a child of the Canvas. The dialogue will be displayed in this Text element.

Tag your player GameObject with the tag "Player" so that the script knows when the player is in range.

Assign the NPC's dialogue lines in the inspector.

ChatGPTs advice on how to add dialogue...the script works fine
*/