using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValidateReto : MonoBehaviour
{
    public GameObject canvasReto;

    int variable = 0;
    int variable2 = 0;

    OnDropp controller;
    OnDropp controller2;
    GameObject drop;
    GameObject drop2;



    public void Start()
    {
        //controller = gameObject.AddComponent<OnDrop1>();
        //controller2 = gameObject.AddComponent<OnDrop2>();

        drop = GameObject.Find("Drop1");
        drop2 = GameObject.Find("Drop2");

        controller = drop.GetComponent<OnDropp>();
        controller2 = drop2.GetComponent<OnDropp>();
    }

    public void Validacion()
    {
        variable = controller.GetVariable();
        variable2 = controller2.GetVariable();
        Debug.Log(variable+" "+ variable2);

        int oper = variable * variable2;
        // Debug.Log(oper);

        Debug.Log("Valor final: " + (oper) + " Resultado Correcto!!");
    }

    public void Salir()
    {
        canvasReto.SetActive(false);
    }


}
