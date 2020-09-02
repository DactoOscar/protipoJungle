using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pieces : MonoBehaviour
{
    public Construction objectHouse;
	public GameObject objectPieces;

    void Update()
    {
		//activate();
	}

	public void activate() {

		//objectHouse = gameObject.GetComponent<Construction>();

		if (objectHouse != null)
		{
			if (objectHouse.counter < objectHouse.maxCounter)
			{
				objectHouse.ChangeCounter(1);
				Destroy(gameObject);
			}
			else
			{
			}
		}
		objectPieces.SetActive(false);
	}
}
