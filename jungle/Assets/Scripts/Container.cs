using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{
    public int maxCounter = 3;
    public int health { get { return garbageCounter; } }
    int garbageCounter;

    // Start is called before the first frame update
    void Start()
    {
        // garbageCounter = maxCounter;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeHealth(int amount)
    {
        garbageCounter = Mathf.Clamp(garbageCounter + amount, 0, maxCounter);
        Debug.Log("Basura: " + garbageCounter + "/" + maxCounter);
    }
}