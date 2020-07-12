using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item1 : MonoBehaviour
{

    public int valor = 5;

    public void MostrarValor()
    {
        print(valor);
    }

    public int GetValor()
    {
       return valor;
    }

    
}
