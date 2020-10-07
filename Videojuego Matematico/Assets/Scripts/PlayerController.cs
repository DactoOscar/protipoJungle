using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    Rigidbody2D rigidbody2d;
    public GameObject optionsScreen;
    //public GameObject Notification;
    float horizontal;
    float vertical;

    //Para los efectos de sonido del menu pausa
    public GameObject pausa;
    public GameObject bolsa;
    public GameObject pieza;
    public GameObject dialog;

    
    GameObject box;
    public LayerMask boxMask;
    public float distance = 1f;
    bool transportGarbage = false;

    Animator animator;
    Vector2 lookDirection = new Vector2(1, 0);

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        MovementPlayer();
        DragAndDrop();
        Menu();
        ConstructionHouse();
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, (Vector2)transform.position + lookDirection /* Vector2.right * transform.localScale.x */ * distance);
    }

    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;
        rigidbody2d.MovePosition(position);

    }
    void MovementPlayer()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(horizontal, vertical);

        if (!Mathf.Approximately(move.x, 0.0f) || !Mathf.Approximately(move.y, 0.0f))
        {
            lookDirection.Set(move.x, move.y);
            lookDirection.Normalize();
        }

        animator.SetFloat("Look X", lookDirection.x);
        animator.SetFloat("Look Y", lookDirection.y);
        animator.SetFloat("Speed", move.magnitude);
    }

    void DragAndDrop()
    {
        Physics2D.queriesStartInColliders = false;

        if (Input.GetKeyDown(KeyCode.C))
        {
            RaycastHit2D hit = Physics2D.Raycast(rigidbody2d.position /* + Vector2.right * 0.2f */, lookDirection, 3.0f, LayerMask.GetMask("NPC"));
            if (hit.collider != null)
            {
                box = hit.collider.gameObject;
                box.GetComponent<FixedJoint2D>().connectedBody = this.GetComponent<Rigidbody2D>();
                box.GetComponent<FixedJoint2D>().enabled = true;
                box.GetComponent<GarbagePull>().beingPushed = true;
                transportGarbage = true;
                bolsa.SetActive(true);
                Instantiate(bolsa);
            }
            else
            {
                bolsa.SetActive(false);
            }
            if (lookDirection.x == 1 || lookDirection.x == -1)
            {
                Debug.Log("Mirando de lado");
                box.GetComponent<GarbagePull>().grabX = true;

            }
            else if (lookDirection.y == 1 || lookDirection.y == -1)
            {
                Debug.Log("Arrastrando arriba/abajo");
                box.GetComponent<GarbagePull>().grabY = true;
            }
        }
        else if (Input.GetKeyUp(KeyCode.X) && (transportGarbage))
        {

            box.GetComponent<FixedJoint2D>().enabled = false;
            box.GetComponent<GarbagePull>().beingPushed = false;
            box.GetComponent<GarbagePull>().grabX = false;
            box.GetComponent<GarbagePull>().grabY = false;
            box = null;
            transportGarbage = false;
        }
        else
        {
        }
    }

    void Menu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            optionsScreen.SetActive(true);
            pausa.SetActive(true);
            Instantiate(pausa);
        }
        else
        {
            pausa.SetActive(false);
        }
    }


    void ConstructionHouse()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            RaycastHit2D hit = Physics2D.Raycast(rigidbody2d.position + Vector2.up * 0.2f, lookDirection, 0.5f, LayerMask.GetMask("Pieces"));

            //SI SE ACTIVA UNA PIEZA COMÚN 

            if (hit.collider != null)
            {
                Pieces part = hit.collider.GetComponent<Pieces>();
                part.activate();
                pieza.SetActive(true);
                Instantiate(pieza);
            }
            else
            {
                pieza.SetActive(false);
            }
        }
    }
}

