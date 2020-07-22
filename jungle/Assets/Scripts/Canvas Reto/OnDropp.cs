using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;


public class OnDropp : MonoBehaviour, IDropHandler
{
    public bool isDrop;
    public int sendVariable;
    public string nameObject;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            isDrop = true;
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        nameObject = other.name;
        Debug.Log("Nombre: "+nameObject);

        Item controller = other.GetComponent<Item>();
        SpriteMovement controllerMove = other.GetComponent<SpriteMovement>();
        controllerMove.enabled = false;


        if (nameObject.Equals("Item1") || nameObject.Equals("Item3"))
        {
            if (controller != null)
            {
                controller.MostrarValor();
                sendVariable = controller.GetValor();
            }
        }
    }

    public int GetVariable()
    {
        return sendVariable;
    }
    public string GetObjectName()
    {
        return nameObject;
    }
}
