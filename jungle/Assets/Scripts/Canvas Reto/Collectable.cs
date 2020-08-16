using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public GameObject canvasReto;
    public GameObject ChallengeMusic;

    void OnTriggerEnter2D(Collider2D other)
    {
        //GameObject.Find("Canvas_Reto1").GetComponent<Canvas>().enabled = true;
        canvasReto.SetActive(true);
        ChallengeMusic.SetActive(false);
        
    }

    
}
