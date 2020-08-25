using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorManager : MonoBehaviour
{
    internal int xp;
   // public List<GameObject> listCollectables;
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
        GetExperience();

    }

    public void GetExperience()
    {
        if (contenedores[0].contenedor.isFull && contenedores[1].contenedor.isFull)
        {
            Debug.Log("Get XP");
            xp = listCollectables[0].experience + listCollectables[1].experience;
            listCollectables[0].collectable.SetActive(true);
            return;

        }
    }




}

