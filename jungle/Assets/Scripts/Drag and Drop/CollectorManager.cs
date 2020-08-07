using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorManager : MonoBehaviour
{
    public List<Transform> listContenedores;
    public List<GameObject> listCollectables;


    void Start()
    {
        Debug.Log(listContenedores[0].GetComponent<Container>().counter + " " + listContenedores[1].GetComponent<Container>().counter);
    }

    // Update is called once per frame
    void Update()
    {
       

        //RETO1 DRAG N DROP 
        if ((listContenedores[0].GetComponent<Container>().counter == listContenedores[0].GetComponent<Container>().maxCounter)
            && (listContenedores[1].GetComponent<Container>().counter == listContenedores[1].GetComponent<Container>().maxCounter) )
        {
            //listContenedores[0].GetComponent<Container>().isFull = true;
            listCollectables[0].gameObject.SetActive(true);
        }

        //RETO2 DRAG N DROP 

        if ((listContenedores[2].GetComponent<Container>().counter == listContenedores[2].GetComponent<Container>().maxCounter)
            && (listContenedores[3].GetComponent<Container>().counter == listContenedores[3].GetComponent<Container>().maxCounter))
        {
            //listContenedores[0].GetComponent<Container>().isFull = true;
            listCollectables[1].gameObject.SetActive(true);
        }

    }




}

