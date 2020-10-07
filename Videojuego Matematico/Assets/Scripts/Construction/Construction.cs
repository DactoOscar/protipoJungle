using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Construction : MonoBehaviour
{
    public int maxCounter;

    [Serializable]
    public struct ListPieces
    {
        public string name;
        public GameObject pieza;
    }
    public ListPieces[] piezas;

    public int counter { get { return piecesCounter; } }
    private int piecesCounter;
    public bool isFull;
    public bool isFullPoints;

    void Start()
    {
        isFull = false;
        isFullPoints = false;
    }

    public void ChangeCounter(int amount)
    {
        piecesCounter = Mathf.Clamp(piecesCounter + amount, 0, maxCounter);

        Debug.Log(piecesCounter + "/" + maxCounter + " piezas");

        if (piecesCounter == maxCounter)
        { 
            isFull = true;
            Debug.Log("CONSTRUISTE LA CASA!!");
        }
    }

    public int GetPointsCounter()
    {
        return piecesCounter;
    }
}
