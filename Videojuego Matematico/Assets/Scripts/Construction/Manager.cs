using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    internal int point;
    internal Boolean activate, activate2;
    public GameObject objetoCasa;

    [Serializable]
    public struct ListHouse
    {
        public string name;
        public Construction contenedor;
        public int experience;
    }
    public ListHouse[] house;

    [Serializable]
    public struct listPieces
    {
        public string name;
        public GameObject collectable;
        public int count;
    }
    public listPieces[] pieces;

    void Update()
    {
        if (house[0].contenedor.isFull)
        {
            point = pieces[0].count;
            point = house[0].experience;
            activate = true;
        }
    }

    public int points()
    {
        return point;
    }
}
