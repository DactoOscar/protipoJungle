using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    //public GameObject[] canvasInstructions;


    void OnTriggerEnter2D(Collider2D collision)
    {
        //canvasInstructions[0].SetActive(true);
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
