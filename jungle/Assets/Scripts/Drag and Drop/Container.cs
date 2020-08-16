using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
using UnityEngine.UI;
=======
>>>>>>> master

public class Container : MonoBehaviour
{
    public int maxCounter;
    public int counter { get { return garbageCounter; } }
    private int garbageCounter;
<<<<<<< HEAD
    public bool isFull;
    public bool isFullPoints;


    public int counterPoints { get { return pointCounter; } }
    private int pointCounter;
    public int maxCounterPoints = 300;
    public Text texto;
    public int xp;
=======

    public bool isFull;
>>>>>>> master

    // Start is called before the first frame update
    void Start()
    {
        isFull = false;
<<<<<<< HEAD
        isFullPoints = false;
=======
>>>>>>> master
    }

    public void ChangeCounter(int amount)
    {
        garbageCounter = Mathf.Clamp(garbageCounter + amount, 0, maxCounter);
<<<<<<< HEAD
        Debug.Log(garbageCounter + "/" + maxCounter);
        if (garbageCounter == maxCounter)
=======
        //Debug.Log("Basura: " + garbageCounter + "/" + maxCounter);
        if(garbageCounter == maxCounter)
>>>>>>> master
        {
            isFull = true;
        }
    }
<<<<<<< HEAD

    public void Points(int experience)
    {
        pointCounter = Mathf.Clamp(pointCounter + experience, 0, maxCounter);
        texto.text = pointCounter + " Puntos";
        if (pointCounter == maxCounter)
        {
            pointCounter = pointCounter;
            isFullPoints = true;
        }

    }

    public int GetVariable()
    {
        return pointCounter;
    }
=======
   
>>>>>>> master
}