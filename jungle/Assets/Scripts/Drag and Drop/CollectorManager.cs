using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorManager : MonoBehaviour
{
    public List<GameObject> listCollectables;
    [Serializable]
    public struct ListContainer
    {
        public string name;
        public Container contenedor;
    }
    public ListContainer[] contenedores;



    void Start()
    {
    }

    void Update()
    {

        if ( contenedores[0].contenedor.isFull && contenedores[1].contenedor.isFull)
        {
            listCollectables[0].gameObject.SetActive(true);
        }

    }




}

