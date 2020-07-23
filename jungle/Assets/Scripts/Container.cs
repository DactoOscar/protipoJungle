using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{

    public int garbageCounter = 0;
    public int maxCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeHealth(int amount)
    {
        garbageCounter = Mathf.Clamp(garbageCounter + amount, 0, maxCounter);
        Debug.Log(garbageCounter + "/" + maxCounter);
    }
}
