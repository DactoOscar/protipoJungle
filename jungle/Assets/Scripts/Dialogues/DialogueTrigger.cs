using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    //public GameObject[] canvasInstructions;


    void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        FindObjectOfType<DialogueManager>().DisplayCanvas();
        FindObjectOfType<DialogueManager>().StartImageNpc(dialogue);

    }
}
