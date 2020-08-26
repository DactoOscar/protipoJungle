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
    public struct ListCollectable
    {
        public string name;
        public CollectorManager collectorManager;
    }
    public ListCollectable[] puntosBasuras;

    [Serializable]
    public struct ListContainer2
    {
        public string name;
        public ValidateReto reto;
    }
    public ListContainer2[] puntosRetosCanvas;

    void Update()
    {
        PointsPrint();
        texto.text = calculo + " Puntos";
        Debug.Log(calculo + "/" + maxCounterPoints);
    }


    public void PointsPrint()
    {
        int var1 = puntosBasuras[0].collectorManager.points();
        int var2 = puntosBasuras[1].collectorManager.points();
        int var5 = puntosRetosCanvas[0].reto.GetExperience();
        int var6 = puntosRetosCanvas[1].reto.GetExperience();
        calculo = var1 + var2 + var5 + var6;

        UIexperienceBar.instance.SetValue(calculo / (float) maxCounterPoints);
    }

}