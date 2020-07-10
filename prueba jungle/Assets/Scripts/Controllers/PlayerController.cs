using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    Rigidbody2D rigidbody2d;

    float horizontal;
    float vertical;

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

    // Update is called once per frame
    void Update()
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

        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit2D hit = Physics2D.Raycast(rigidbody2d.position + Vector2.up * 0.2f, lookDirection, 0.5f, LayerMask.GetMask("Kids"));
            if (hit.collider != null)
            {
                NonPlayerCharacter character = hit.collider.GetComponent<NonPlayerCharacter>();
                if (character != null)
                {
                    character.DisplayDialog();
                }
            }
        }

        Physics2D.queriesStartInColliders = false;

        if (Input.GetKeyDown(KeyCode.C))
        {
          RaycastHit2D hit = Physics2D.Raycast(rigidbody2d.position + Vector2.right * 0.2f, lookDirection, 1.5f, LayerMask.GetMask("NPC"));
         if (hit.collider != null)
        {
          box = hit.collider.gameObject;
         box.GetComponent<FixedJoint2D>().connectedBody = this.GetComponent<Rigidbody2D>();
         box.GetComponent<FixedJoint2D>().enabled = true;
         box.GetComponent<GarbagePull>().beingPushed = true;
         transportGarbage = true;
          }
        }
        else if (Input.GetKeyUp(KeyCode.X) && transportGarbage)
        {

          box.GetComponent<FixedJoint2D>().enabled = false;
         box.GetComponent<GarbagePull>().beingPushed = false;
         box = null;
         transportGarbage = false;
        }
        else { 
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, (Vector2)transform.position + Vector2.right * transform.localScale.x * distance);

    }

    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;

        rigidbody2d.MovePosition(position);

    }

}
