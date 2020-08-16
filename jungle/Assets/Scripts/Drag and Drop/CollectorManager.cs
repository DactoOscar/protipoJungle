using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorManager : MonoBehaviour
{
    //public List<Transform> listContenedores;
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
        //Debug.Log(listContenedores[0].GetComponent<Container>().counter + " " + listContenedores[1].GetComponent<Container>().counter);
    }

    // Update is called once per frame
    void Update()
    {
        //RETO1 DRAG N DROP 
        //if ((listContenedores[0].GetComponent<Container>().counter == listContenedores[0].GetComponent<Container>().maxCounter)
        //    && (listContenedores[1].GetComponent<Container>().counter == listContenedores[1].GetComponent<Container>().maxCounter) )
        //{
        //    listCollectables[0].gameObject.SetActive(true);
        //}

        //RETO2 DRAG N DROP 

        if ( contenedores[0].contenedor.isFull && contenedores[1].contenedor.isFull)
        {
            listCollectables[0].gameObject.SetActive(true);
        }

    }




}

