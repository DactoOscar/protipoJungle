using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public GameObject reto1;

    void OnTriggerEnter2D(Collider2D other)
    {
        //GameObject.Find("Canvas_Reto1").GetComponent<Canvas>().enabled = true;
       reto1.SetActive(true);
        
    }

    
}
