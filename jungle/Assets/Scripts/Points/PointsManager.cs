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

    //ESTRUCTURA DE LOS COLLECTABLES/CONTENEDORES
    [Serializable]
    public struct ListCollectable
    {
        public string name;
        public CollectorManager collectorManager;
    }
    public ListCollectable[] puntosBasuras;

    //ESTRUCTURA DE 1 CONTENEDOR
    [Serializable]
    public struct ListSingle
    {
        public string name;
        public SingleCollectorManager singleManager;
    }
    public ListSingle[] puntosBasurasSingle;


    //ESTRUCTURA DE LOS RETOS PRIMARIOS (MANGOS)
    [Serializable]
    public struct ListContainer2
    {
        public string name;
        public ValidateReto reto;
    }
    public ListContainer2[] puntosRetosCanvas;

    //ESTRUCTURA DE LOS RETOS SECUNDARIOS

    [Serializable]
    public struct ListChallengesCont
    {
        public string name;
        public ValidateReto reto;
    }
    public ListChallengesCont[] puntosChallenge;


    //ESTRUCTURA DE LOS RETOS PRIMARIOS (CONSTRUCCIÓN)

    [Serializable]
    public struct ListConstruction
    {
        public string name;
        public Manager retoCon;
    }
    public ListConstruction[] puntosHouse;

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
        int var3 = puntosChallenge[0].reto.GetExperience();
        int var4 = puntosChallenge[1].reto.GetExperience();
        int var5 = puntosChallenge[2].reto.GetExperience();
        int var6 = puntosChallenge[3].reto.GetExperience();
        int var7 = puntosChallenge[4].reto.GetExperience();
        int var8 = puntosChallenge[5].reto.GetExperience();
        int var9 = puntosHouse[0].retoCon.points();
        int var10 = puntosHouse[1].retoCon.points();
        int var11 = puntosRetosCanvas[0].reto.GetExperience();
        int var12 = puntosRetosCanvas[1].reto.GetExperience();
        int var13 = puntosBasurasSingle[0].singleManager.points();
        int var14 = puntosBasurasSingle[1].singleManager.points();
        int var15 = puntosBasurasSingle[2].singleManager.points();
        int var16 = puntosBasurasSingle[3].singleManager.points();

        calculo = var1 + var2 + var3 + var4 + var5 + var6 + var7 + var8 + var9 + var10 + var11
             + var12 + var13 + var14 + var15 + var16;

        UIexperienceBar.instance.SetValue(calculo / (float) maxCounterPoints);
    }

}