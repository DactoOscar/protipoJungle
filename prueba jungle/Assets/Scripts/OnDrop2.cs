using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class OnDrop2 : MonoBehaviour, IDropHandler
{
    //public NewMangoScript draDro;

    public int SendVariable1 = 0;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Item2 controller = other.GetComponent<Item2>();

        if (controller != null)
        {
            controller.MostrarValor2();
            SendVariable1 = controller.getValor();
        }
    }
}
