using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValidateReto : MonoBehaviour
{
    public GameObject canvasReto;

    int variable1 = 0;
    int variable12 = 0;

    OnDropp controller;
    OnDropp controller2;
    GameObject drop;
    GameObject drop2;

    public enum Valor { Uno = 1, Dos = 2, Tres = 3, Cuatro = 4, Cinco = 5, Seis = 6, Siete = 7, Ocho = 8, Nueve = 9, Diez = 10 }
    public Valor items1;
    public Valor items2;

    public enum Operacion {suma,resta,multiplicacion,division}
    public Operacion operacion;


    public void Start()
    {
        drop = GameObject.Find("Drop1");
        drop2 = GameObject.Find("Drop2");

        controller = drop.GetComponent<OnDropp>();
        controller2 = drop2.GetComponent<OnDropp>();
    }

    public void Validacion()
    {
        variable1 = controller.GetVariable();
        variable12 = controller2.GetVariable();

        //Debug.Log((int)items1 + " " + (int)items2);

        if ((variable1 == (int)items1 || variable1 == (int)items2) && (variable12 == (int)items1 || variable12 == (int)items2))
        {
            print(Calculate(operacion, variable1, variable12));
        }

    }

    public static int Calculate(Operacion operacion, int variable1, int variable12)
    {
        //Debug.Log("Funcion Calculate ");
        switch (operacion.ToString())
        {
            case "suma" : return variable1 + variable12;
            case "resta": return variable1 - variable12;
            case "multiplicacion": return variable1 * variable12;
            case "division": return variable1 / variable12;
            default: throw new Exception("invalid Calculate");
        }
    }

    public void Salir()
    {
        canvasReto.SetActive(false);
    }


}
