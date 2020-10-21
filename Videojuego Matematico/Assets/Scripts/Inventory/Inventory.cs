using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private bool inventoryEnable;

    public GameObject inventory;

    private int allSlots;

    private GameObject[] slot;

    public GameObject slotHolder;

    [HideInInspector]
    public GameObject Gema;
    public bool playerItemUse;

    void Start()
    {
        allSlots = slotHolder.transform.childCount;

        slot = new GameObject[allSlots];

        for (int i = 0; i < allSlots; i++) {
            slot[i] = slotHolder.transform.GetChild(i).gameObject;

            if (slot[i].GetComponent<Slot>().item == null)
            {
                slot[i].GetComponent<Slot>().empty = true;  
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)) {
            inventoryEnable = !inventoryEnable;
        }

        if (inventoryEnable == true) {
            inventory.SetActive(true); 
        }
        else {
            inventory.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        for (int i = 0; i < allSlots; i++)
        {
            if (collision.tag == "ItemInventory")
            {
                GameObject itemPickedUp = collision.gameObject;

                ItemInventory item = itemPickedUp.GetComponent<ItemInventory>();

                AddItem(itemPickedUp, item.ID, item.type, item.description, item.icon);

            }
        }
    }

    public void AddItem(GameObject itemObject, int itemId, string itemType, string Description, Sprite itemIcon){
        for (int i = 0; i < allSlots; i++) {
            if (slot[i].GetComponent<Slot>().empty) {
                itemObject.GetComponent<ItemInventory>().pickedUp = true;
                slot[i].GetComponent<Slot>().item = itemObject;
                slot[i].GetComponent<Slot>().ID = itemId;
                slot[i].GetComponent<Slot>().type = itemType;
                slot[i].GetComponent<Slot>().description = Description;
                slot[i].GetComponent<Slot>().icon = itemIcon;
                itemObject.transform.parent = slot[i].transform;
                itemObject.SetActive(false);
                slot[i].GetComponent<Slot>().UpdateSlot();
                slot[i].GetComponent<Slot>().empty = false;
            }
            return;
        }
    }

}
