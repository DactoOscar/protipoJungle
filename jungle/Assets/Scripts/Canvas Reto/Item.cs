using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int valor ;
    
    //public float speed;
    //private float waitTime;
    //public float startWaitTime;
    //public Transform moveSpot;
    //public float minX;
    //public float minY;
    //public float maxX;
    //public float maxY;

    //DragDrop dragController;
    //GameObject itemDrag;

    //OnDrop1 dropController;
    //GameObject itemDrop;




    //void Start()
    //{
    //    itemDrag = GameObject.Find("Item1");
    //    dragController = itemDrag.GetComponent<DragDrop>();

    //    itemDrop = GameObject.Find("Drop1");
    //    dropController = itemDrop.GetComponent<OnDrop1>();


    //    waitTime = startWaitTime;
    //    moveSpot.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));

    //}

    //void Update()
    //{

    //    if (!dragController.isDrag && !dropController.isDrop)
    //    {
    //        //&& dropController.isDrop

    //        transform.position = Vector2.MoveTowards(transform.position, moveSpot.position, speed * Time.deltaTime);

    //        if (Vector2.Distance(transform.position, moveSpot.position) < 0.2f)
    //        {
    //            if (waitTime <= 0)
    //            {
    //                moveSpot.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
    //                waitTime = startWaitTime;
    //            }
    //            else
    //            {
    //                waitTime -= Time.time;
    //            }
    //        }
    //    }

    //}


    public void MostrarValor()
    {
        print(valor);
    }

    public int GetValor()
    {
        return valor;
    }
}
