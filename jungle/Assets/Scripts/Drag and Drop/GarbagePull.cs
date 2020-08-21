using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GarbagePull : MonoBehaviour
{
	public GameObject GarbagePoint;
	public float defaultMass;
	public float imovableMass;
	public bool beingPushed;
	float xPos = 0;
	public Vector3 lastPos;
	float yPos = 0;

	internal bool grabX = false;
	internal bool grabY = false;

	public int mode;
	public int colliding;
	

	void Start()
	{
		xPos = transform.position.x;
		yPos = transform.position.y;
		lastPos = transform.position;
	}

	void FixedUpdate()
	{
		
		if (beingPushed == false)
		{
			transform.position = new Vector3(xPos, transform.position.y);
			if (grabY)
			{
				Debug.Log("Arrastrando en Y");
				transform.position = new Vector3(xPos, transform.position.y);
			}

			if (grabX)
			{
				Debug.Log("Arrastrando en X");
				transform.position = new Vector3(transform.position.x, yPos);
			}
		}
		else
		{
			Debug.Log("Bolsa soltada");
			xPos = transform.position.x;
			yPos = transform.position.y;
		}
	
		if (beingPushed == false)
		{


			GetComponent<Rigidbody2D>().mass = imovableMass;

		}
		else
		{
			GetComponent<Rigidbody2D>().mass = defaultMass;
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Container controller = other.gameObject.GetComponent<Container>();

		if (controller != null)
		{

			if (controller.counter < controller.maxCounter)
			{
				controller.ChangeCounter(1);
				GarbagePoint.SetActive(true);
				Instantiate(GarbagePoint);
				Destroy(gameObject);
			}
			else {
				GarbagePoint.SetActive(false);
			}
			 controller.Points(1);
		}
	}
}

