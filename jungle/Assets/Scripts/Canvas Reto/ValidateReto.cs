using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ValidateReto : MonoBehaviour
{
    public GameObject canvasReto;
    public GameObject musicMain;
    public GameObject item;

    public GameObject Notifications;
    public float displayTime = 4.0f;
    float timerDisplay;

    public int experience;
    int variable1 = 0;
    int variable12 = 0;

    OnDropp controller;
    OnDropp controller2;
    GameObject drop;
    GameObject drop2;
    public bool activate;
    
    
    Boolean notificationPush = false;

    public enum Valor { Uno = 1, Dos = 2, Tres = 3, Cuatro = 4, Cinco = 5, Seis = 6, Siete = 7, Ocho = 8, Nueve = 9, Diez = 10 }
    public Valor items1;
    public Valor items2;

    public enum Operacion {suma,resta,multiplicacion,division}
    public Operacion operacion;


    void Start()
    {
        drop = GameObject.Find("Drop1");
        drop2 = GameObject.Find("Drop2");
        Notifications.SetActive(false);
        timerDisplay = -1.0f;

        controller = drop.GetComponent<OnDropp>();
        controller2 = drop2.GetComponent<OnDropp>();
        activate = false;
    }

    void Update()
    {
        if (timerDisplay >= 0)
        {
            timerDisplay -= Time.deltaTime;
            if (timerDisplay < 0)
            {
                Notifications.SetActive(false);
                canvasReto.SetActive(false);
                item.SetActive(false);
                musicMain.SetActive(true);
            }
        }
    }

    public int GetVariable()
    {
        if (activate == true) {
            return experience;
        }
      return 0;
    }

    public void DisplayDialog()
    {
        timerDisplay = displayTime;
        Notifications.SetActive(true);
    }

    public void Validacion()
    {
        variable1 = controller.GetVariable();
        variable12 = controller2.GetVariable();

        if ((variable1 == (int)items1 || variable1 == (int)items2) && (variable12 == (int)items1 || variable12 == (int)items2))
        {
            activate = true;
            print(Calculate(operacion, variable1, variable12));
            notificationPush = true;

            if (notificationPush == true) {
                DisplayDialog();
                //Debug.Log("Obtuviste " + experience + " de experiencia");
            }
        }
    }

    public static int Calculate(Operacion operacion, int variable1, int variable12)
    {
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
