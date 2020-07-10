using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnDrop1 : MonoBehaviour, IDropHandler
{

   // public Mango1Script draDro;
    public int sendVariable1 ;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if(eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Item1 controller = other.GetComponent<Item1>();

        if (controller != null)
        {
            controller.MostrarValor();
            sendVariable1 = controller.GetValor();
        }
    }

    public int getVariable1()
    {
        return sendVariable1;
    }
 }
