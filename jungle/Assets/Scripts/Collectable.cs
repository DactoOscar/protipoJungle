using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public GameObject reto1;

    void OnTriggerEnter2D(Collider2D other)
    {
        reto1.SetActive(true);
        Time.timeScale = 0f;
        //Debug.Log("Object that entered the trigger : " + other);
        //Destroy(gameObject);
        //PlayerController controller = other.GetComponent<PlayerController>();

        //if (controller != null)
        //{
        //    if (controller.health < controller.maxHealth)
        //    {
        //        controller.ChangeHealth(1);
        //        Destroy(gameObject);
        //    }
        //}
    }

    
}
