using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{
    public int maxCounter;
    public int counter { get { return garbageCounter; } }
    private int garbageCounter;

    public bool isFull;

    // Start is called before the first frame update
    void Start()
    {
        isFull = false;
    }

    public void ChangeCounter(int amount)
    {
        garbageCounter = Mathf.Clamp(garbageCounter + amount, 0, maxCounter);
        //Debug.Log("Basura: " + garbageCounter + "/" + maxCounter);
        if(garbageCounter == maxCounter)
        {
            isFull = true;
        }
    }
   
}