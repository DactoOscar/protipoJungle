using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reto : MonoBehaviour
{
    int variable = 0;
    // OnDrop1 var = new OnDrop1();
    OnDrop1 controller;
    GameObject drop;


    public void Start()
    {
        controller = new OnDrop1();
        drop = GameObject.Find("Drop");
        controller = drop.GetComponent<OnDrop1>();

    }

    //void ButtonClicked(int buttonNo)
    //{
    //    //Output this to console when the Button3 is clicked
    //    Debug.Log("Button clicked = " + buttonNo);
    //}

    public void Validacion()
    {
        variable = controller.getVariable1();
        Debug.Log("valor del ondrop 1: "+variable);

    }
    
}
