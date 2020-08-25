using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Container : MonoBehaviour
{
    public int maxCounter;
    public int counter { get { return garbageCounter; } }
    private int garbageCounter;
    public bool isFull;
    public bool isFullPoints;


    public int counterPoints { get { return pointCounter; } }
    private int pointCounter;
    public int maxCounterPoints ;


    void Start()
    {
        isFull = false;
        isFullPoints = false;
    }

    public void ChangeCounter(int amount)
    {
        garbageCounter = Mathf.Clamp(garbageCounter + amount, 0, maxCounter);
        

        Debug.Log(garbageCounter + "/" + maxCounter);
        if (garbageCounter == maxCounter)
        {
            isFull = true;
        }
    }

    public void Points(int experience)
    {
        pointCounter = Mathf.Clamp(pointCounter + experience, 0, maxCounter);
        if (pointCounter == maxCounter)
        {
            isFullPoints = true;
        }

    }

    public int GetPointsCounter()
    {
        return pointCounter;
    }
}