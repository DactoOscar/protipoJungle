using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class Dialogue
{
    public string namee;
    public Sprite imgNPC;

    [TextArea(3,10)]
    public string[] sentences;
}
