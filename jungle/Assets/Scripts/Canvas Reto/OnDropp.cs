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
    //[SerializeField]    string[] arrayItems = new string[10] { "Item1", "Item2", "Item3", "Item4", "Item5", "Item6", "Item7", "Item8", "Item9", "Item10" };


    //public Items items2;


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
        //Debug.Log("Nombre: " + nameObject);
        Item controller = other.GetComponent<Item>();

        if (!isFull)
        {
            controller.inBasket = true;
            controller.nameBasket = name;
            isFull = true;
        }

        if (controller != null)
        {
            sendVariable = controller.GetValor();
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
