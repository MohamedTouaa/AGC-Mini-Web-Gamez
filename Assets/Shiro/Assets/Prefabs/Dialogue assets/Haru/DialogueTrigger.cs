using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public ObjectDialogue dialogue;

   public void triggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger entered by: " + other.gameObject.name);
        if (other.CompareTag("Player")) // You can adjust the tag as needed
        {
            // Trigger the dialogue
            triggerDialogue();
        }
    }

    void TriggerDialogue()
    {
        // Find the DialogueManager and start the dialogue
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}



