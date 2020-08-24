using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    //public Text nameText;
    public Text dialogueText;
    private Queue<string> sentences;
    DialogueTrigger canvasActive;


    void Start()
    {
        sentences = new Queue<string>() ;
        //canvasActive = gameObject.GetComponent<DialogueTrigger>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        //Debug.Log("Instrucciones ");

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text=  sentence;
    }

    void EndDialogue()
    {
        //Debug.Log("Termina");
        canvasActive.canvasInstructions[0].SetActive(false);
    }

}
