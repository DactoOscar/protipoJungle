using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int valor ;
    public float speed;
    public bool inBasket;
    public Transform moveSpot;
    public string nameBasket;

    

    public void MostrarValor()
    {
        print(valor);
    }

    public int GetValor()
    {
        return valor;
    }
}
