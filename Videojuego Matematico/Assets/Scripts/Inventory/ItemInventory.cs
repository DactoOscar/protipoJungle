using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInventory : MonoBehaviour
{

    public int ID;
    public string type;
    public string description;
    public Sprite icon;
    [HideInInspector]
    public bool pickedUp;

    [HideInInspector]
    public GameObject ItemManager;

    [HideInInspector]
    public GameObject item;

    [HideInInspector]
    public bool equipped;

    public bool playerEquipped;

    private void Start()
    {
        ItemManager = GameObject.FindWithTag("ItemUse");

        if(!playerEquipped){
            int allItems = ItemManager.transform.childCount;
            for(int i = 0; i < allItems; i++){
                if(ItemManager.transform.GetChild(i).gameObject.GetComponent<ItemInventory>().ID == ID){
                    item = ItemManager.transform.GetChild(i).gameObject; 
                }
            }
        }
    }

    private void Update()
    {
        if(equipped){
            if(Input.GetKeyDown(KeyCode.E)){
                equipped = false;
            }
            if(equipped == false){
                gameObject.SetActive(false);
            }
        }
    }

    public void ItemUsage(){

        if(type=="Gema Azul"){
            item.SetActive(true);
            item.GetComponent<ItemInventory>().equipped = true;
        }
    }
}
