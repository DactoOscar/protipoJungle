using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int valor ;

    public float speed;
    //public float waitTime;
    //public float startWaitTime;
    public Transform moveSpot;

    

    public void MostrarValor()
    {
        print(valor);
    }

    public int GetValor()
    {
        return valor;
    }
}
