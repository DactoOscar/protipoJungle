using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int valor ;
    public Transform moveSpot;
    public float speed;

    public void MostrarValor()
    {
        print(valor);
    }

    public int GetValor()
    {
        return valor;
    }
}
