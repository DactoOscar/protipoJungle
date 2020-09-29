using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    public Text miText;
    ValidateReto controllerValidarReto;
    private int xp;

    void Start()
    {
        controllerValidarReto = gameObject.GetComponent<ValidateReto>();
    }

    public void Notification() {
        xp = controllerValidarReto.experience;
        miText.text = "¡Ganaste " + xp + " puntos!";
        //Debug.Log(xp);
    }
}
