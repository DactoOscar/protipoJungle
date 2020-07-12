using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reto : MonoBehaviour
{
    int variable = 0;
    int variable2 = 0;
    // OnDrop1 var = new OnDrop1();
    OnDrop1 controller;
    OnDrop2 controller2;
    GameObject drop;
    GameObject drop2;



    public void Start()
    {
        controller = gameObject.AddComponent<OnDrop1>();
        controller2 = gameObject.AddComponent<OnDrop2>();

        drop = GameObject.Find("Drop1");
        drop2 = GameObject.Find("Drop2");

        controller = drop.GetComponent<OnDrop1>();
        controller2 = drop2.GetComponent<OnDrop2>();


    }

    public void Validacion()
    {
        variable = controller.getVariable1();
        variable2 = controller2.getVariable2();
        int oper = variable * variable2;
        // Debug.Log(oper);

        Debug.Log("Valor final: " + (oper) + " Resultado Correcto!!");

    }
}
