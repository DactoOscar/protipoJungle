using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
using System;

public class DialogueManager : MonoBehaviour
{
    SpriteRenderer sr ;

    [Serializable]
    public struct ListTextDialogueManager
    {
        //public Sprite imgNpc;
        public string name;
        public Text dialogueText;
        public GameObject activateCanvas;
    }
    public ListTextDialogueManager[] listText;

    //public Text[] dialogueText;
    private Queue<string> sentences;


    void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
        sentences = new Queue<string>() ;
        //sr.sprite();
    }

    public void DisplayCanvas()
    {
        
        listText[0].activateCanvas.SetActive(true);
        //StartImageNpc(sprite);


    }
    public void StartImageNpc(Dialogue sprite)
    {
        Debug.Log(sprite.imgNPC.name);
        GameObject.Find("imgNPC").GetComponent<SpriteRenderer>().sprite = sprite.imgNPC;
    }

    public void StartDialogue(Dialogue dialogue)
    {
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
       listText[0].dialogueText.text = sentence;
    }

    void EndDialogue()
    {
        listText[0].activateCanvas.SetActive(false);

    }

}
