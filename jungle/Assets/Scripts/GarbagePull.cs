using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbagePull : MonoBehaviour
{
	public float defaultMass;
	public float imovableMass;
	public bool beingPushed;
<<<<<<< Updated upstream:prueba jungle/Assets/Scripts/GarbagePull.cs
	float xPos;

=======
	float xPos = 0;
	float yPos = 0;

	internal bool grabX = false;
	internal bool grabY = false;
>>>>>>> Stashed changes:jungle/Assets/Scripts/GarbagePull.cs
	public Vector3 lastPos;

	public int mode;
	public int colliding;
	// Use this for initialization
	void Start()
	{
		xPos = transform.position.x;
		yPos = transform.position.y;
		lastPos = transform.position;
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		// if (mode == 0)
		//	{
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
		//else if (mode == 1)
		//{

		if (beingPushed == false)
		{


			GetComponent<Rigidbody2D>().mass = imovableMass;

		}
		else
		{
			GetComponent<Rigidbody2D>().mass = defaultMass;
			//	GetComponent<Rigidbody2D> ().isKinematic = false;
			//}

		}
	}

}