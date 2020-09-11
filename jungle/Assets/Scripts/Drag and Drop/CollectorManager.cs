using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorManager : MonoBehaviour
{
    internal int xp;
    internal Boolean activate, activate2;
    //public String nameReto;
  
    [Serializable]
    public struct ListContainer
    {
        public string name;
        public Container contenedor;
    }
    public ListContainer[] contenedores;

    [Serializable]
    public struct ListCollectable
    {
        public string name;
        public GameObject collectable;
        public int experience;
    }
    public ListCollectable[] listCollectables;

    public void Start()
    {
        for (int i = 0; i < contenedores.Length; i++)
        {
            print(i+"contenedores: " + contenedores[i].name);

        }

    }

    void Update()
    {

        if (!activate)
        {
            if (contenedores[0].contenedor.isFull && contenedores[1].contenedor.isFull)
            {
                listCollectables[0].collectable.SetActive(true);
                xp = listCollectables[0].experience;
                Debug.Log("Get XP: " + xp);
            }
            //if (contenedores[2].contenedor.isFull && contenedores[3].contenedor.isFull)
            //{
            //    listCollectables[1].collectable.SetActive(true);
            //    xp = listCollectables[1].experience;
            //    Debug.Log("Get XP: " + xp);
            //}
            //if (contenedores[4].contenedor.isFull)
            //{
            //    listCollectables[2].collectable.SetActive(true);
            //    xp = listCollectables[2].experience;
            //    Debug.Log("Get XP: " + xp);
            //}
            //if (contenedores[5].contenedor.isFull)
            //{
            //    listCollectables[3].collectable.SetActive(true);
            //    xp = listCollectables[3].experience;
            //    Debug.Log("Get XP: " + xp);
            //}
            //if (contenedores[6].contenedor.isFull)
            //{
            //    listCollectables[4].collectable.SetActive(true);
            //    xp = listCollectables[4].experience;
            //    Debug.Log("Get XP: " + xp);
            //}
            //if (contenedores[7].contenedor.isFull)
            //{
            //    listCollectables[5].collectable.SetActive(true);
            //    xp = listCollectables[5].experience;
            //    Debug.Log("Get XP: " + xp);
            //}

        }

        if (xp!= 0 && activate)
        {
            listCollectables[0].collectable.SetActive(false);
        }

    }

    public int points()
    {
        return xp;
    }


}

