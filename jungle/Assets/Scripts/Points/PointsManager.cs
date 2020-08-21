using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class PointsManager : MonoBehaviour
{
    public int maxCounterPoints = 300;
    public Text texto;
    public int calculo;

    [Serializable]
    public struct ListContainer
    {
        public string name;
        public Container contenedor;
    }
    public ListContainer[] puntosBasuras;


    [Serializable]
    public struct ListContainer2
    {
        public string name;
        public ValidateReto reto;
    }
    public ListContainer2[] puntosChallenge;


    void Start()
    {
    }

    void Update()
    {
        PointsPrint();
        texto.text = calculo + " Puntos";
        Debug.Log(calculo + "/" + maxCounterPoints);
    }


    public void PointsPrint()
    {
        int var1 = puntosBasuras[0].contenedor.GetVariable();
        int var2 = puntosBasuras[1].contenedor.GetVariable();
        int var3 = puntosBasuras[2].contenedor.GetVariable();
        int var4 = puntosBasuras[3].contenedor.GetVariable();
        int var5 = puntosChallenge[0].reto.GetVariable();
        int var6 = puntosChallenge[1].reto.GetVariable();
        int var7 = puntosChallenge[2].reto.GetVariable();
        calculo = var1 + var2 + var3 + var4 + var5 + var6 + var7;
    }

}