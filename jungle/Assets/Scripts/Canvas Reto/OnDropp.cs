using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;


public class OnDropp : MonoBehaviour, IDropHandler
{
    public bool isDrop;
    public bool isFull;

    public int sendVariable;
    public string nameObject;
    private Vector3 posDrop;
    public string name;


    void Start()
    {
        isFull = false;
        name = " ";
    }

    public void OnDrop(PointerEventData eventData)
    {
        //Debug.Log("OnDrop");
        if (eventData.pointerDrag != null && !isFull)
        {

            isDrop = true;
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        nameObject = other.name;
        Debug.Log("Nombre: " + nameObject);

        Item controller = other.GetComponent<Item>();

        if (!isFull)
        {
            controller.inBasket = true;
            controller.nameBasket = name;
            isFull = true;
        }
        
        if (nameObject.Equals("Item5") || nameObject.Equals("Item7"))
        {
            if (controller != null)
            {
                controller.MostrarValor();
                sendVariable = controller.GetValor();
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Item controller = other.GetComponent<Item>();
        controller.inBasket = false;
        isFull = false;

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
