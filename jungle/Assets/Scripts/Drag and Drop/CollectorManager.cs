using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorManager : MonoBehaviour
{
    internal int xp;
    internal Boolean activate, activate2;
  
    [Serializable]
    public struct ListContainer
    {
        public string name;
        public Container contenedor;
    }
    public ListContainer[] contenedores;

    [Serializable]
    public struct listCollectable
    {
        public string name;
        public GameObject collectable;
        public int experience;
    }
    public listCollectable[] listCollectables;


    void Update()
    {
        if (!activate) {
            if (contenedores[0].contenedor.isFull && contenedores[1].contenedor.isFull)
            {
                listCollectables[0].collectable.SetActive(true);
                xp = listCollectables[0].experience;
                Debug.Log("Get XP: " + xp);
            }
        }

        if (xp != 0 && activate == true)
        {
            listCollectables[0].collectable.SetActive(false);
        }

    }

    public int points()
    {
        return xp;
    }


}

