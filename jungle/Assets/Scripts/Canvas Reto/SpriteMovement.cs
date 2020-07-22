using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMovement : MonoBehaviour
{
    public float speed;
    private float waitTime;
    public float startWaitTime;
    public Transform moveSpot;

    public float minX = -50f;
    public float minY = -50f;
    public float maxX = 230f;
    public float maxY = 300f;


    void Start()
    {
        waitTime = startWaitTime;
        moveSpot.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpot.position, speed * Time.deltaTime);
        if(Vector2.Distance(transform.position,moveSpot.position)< 0.2f)
        {
            if(waitTime <= 0)
            {
                moveSpot.position = new Vector2(Random.Range(minX, maxX), Random.Range(minX, maxX));
                waitTime = startWaitTime;
            }else
            {
                waitTime -= Time.time;
            }
        }

    }
}
