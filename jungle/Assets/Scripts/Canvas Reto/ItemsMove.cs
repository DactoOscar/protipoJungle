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
    //public float speed;



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

        }

    }

    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < GO.Length; i++)
        {
            GO[i].transform.position = Vector2.MoveTowards(GO[i].transform.position, GO[i].moveSpot.position, GO[i].speed * Time.deltaTime);

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
