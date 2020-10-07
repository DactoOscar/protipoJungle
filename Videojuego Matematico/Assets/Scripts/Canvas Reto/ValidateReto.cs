using System;
using UnityEngine;
using UnityEngine.UI;



public class ValidateReto : MonoBehaviour
{
    public GameObject canvasReto;
    public GameObject musicMain;

    public GameObject collectable;

    public GameObject Notifications;
    public GameObject NotificationError;

    public float displayTime;
    float timerDisplay;

    public float displayTimeError;
    float timerDisplayError;


    public int experience;
    int variable1 = 0;
    int variable2 = 0;

    OnDropp controller;
    OnDropp controller2;
    GameObject drop;
    GameObject drop2;
    public bool activate;

    public int tries;
    public Text txtTries;

    //Boolean notificationPush = false;

    public enum Valor { Cero = 0, Uno = 1, Dos = 2, Tres = 3, Cuatro = 4, Cinco = 5, Seis = 6, Siete = 7, Ocho = 8, Nueve = 9, Diez = 10 }
    public Valor items1;
    public Valor items2;

    public enum Operacion { suma, resta, multiplicacion, division }
    public Operacion operacion;


    void Start()
    {
        txtTries.text = tries + " Intentos";
        drop = GameObject.Find("Drop1");
        drop2 = GameObject.Find("Drop2");
        //Notifications.SetActive(false);
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
                //canvasReto.SetActive(false);
                Salir();
                collectable.SetActive(false);
                musicMain.SetActive(true);
                //collecti.activate = true;
                Destroy(collectable);
            }
        }
        if (timerDisplayError >= 0)
        {
            timerDisplayError -= Time.deltaTime;


            if (timerDisplayError < 0)
            {
                NotificationError.SetActive(false);
                

                //musicMain.SetActive(true);

            }
        }
    }

    public int GetExperience()
    {
        if (activate == true)
        {
            return experience;
        }
        return 0;
    }

    public void DisplayDialog()
    {
        timerDisplay = displayTime;
        Notifications.SetActive(true);
        
    }
    public void DisplayError()
    {
        timerDisplayError = displayTimeError;
        NotificationError.SetActive(true);
    }


    public void ValidacionPrimaria()
    {
        variable1 = controller.GetVariableOnDrop();
        variable2 = controller2.GetVariableOnDrop();

        if ((variable1 == (int)items1 || variable1 == (int)items2) && (variable2 == (int)items1 || variable2 == (int)items2))
        {
            activate = true;
            print("El resultado es: " + Calculate(operacion, variable1, variable2));
            DisplayDialog();
        }
        else
        {
            DisplayError();
            tries -= 1;
            txtTries.text = tries + " Intentos";
            if (tries == 0)
            {
                Salir();
            }
        }
    }
    public void ValidacionSecundaria()
    {
        variable1 = controller.GetVariableOnDrop();
        //variable2 = controller2.GetVariableOnDrop();

        if (variable1 == (int)items1)
        {
            activate = true;
            //print(Calculate(operacion, variable1, variable2));
            //notificationPush = true;
            DisplayDialog();

        }
        else
        {
            DisplayError();
            tries -= 1;
            txtTries.text = tries + " Intentos";
            if (tries == 0)
            {
                Salir();
            }
        }
    }

    public static int Calculate(Operacion operacion, int variable1, int variable2)
    {
        switch (operacion.ToString())
        {
            case "suma": return variable1 + variable2;
            case "resta": return variable1 - variable2;
            case "multiplicacion": return variable1 * variable2;
            case "division": return variable1 / variable2;
            default: throw new Exception("invalid Calculate");
        }
    }
    public void Salir()
    {
        NotificationError.SetActive(false);
        canvasReto.SetActive(false);

    }


}
