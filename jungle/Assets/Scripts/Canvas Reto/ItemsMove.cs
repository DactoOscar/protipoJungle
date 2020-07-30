using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsMove : MonoBehaviour
{
    public int size;
    public Item[] GO;

    public float minX;
    public float minY;
    public float maxX;
    public float maxY;

    private float waitTime;
    public float startWaitTime;

    //public OnDropp canasta1;
    //public OnDropp canasta2;

    // Start is called before the first frame update
    void Start()
    {
        //GO = new Item[size];
        for (int i = 0; i < GO.Length; i++)
        {
            //GO[i].speed = speed;
            //GO[i].startWaitTime = startWaitTime;
            waitTime = startWaitTime;
            GO[i].moveSpot.position = new Vector2(Random.Range(minX, maxX), Random.Range(maxY, minY));
            GO[i].inBasket = false;
        }

        
    }

    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < GO.Length; i++)
        {
            if (!GO[i].inBasket)
            {
                GO[i].transform.position = Vector2.MoveTowards(GO[i].transform.position, GO[i].moveSpot.position, GO[i].speed * Time.deltaTime);

            }
            else
            {
                GO[i].speed = 0;
            }
            if (Vector2.Distance(GO[i].transform.position, GO[i].moveSpot.position) < 0.2f)
            {
                if (waitTime <= 0)
                {
                    GO[i].moveSpot.position = new Vector2(Random.Range(minX, maxX), Random.Range(maxY, minY));
                    waitTime = startWaitTime;
                }
                else
                {
                    waitTime -= Time.deltaTime;
                }
            }
        }
    }
}
