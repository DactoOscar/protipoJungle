using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pieces : MonoBehaviour
{
    public Construction objectHouse;
	public GameObject objectPieces;
	public GameObject syncPiece;

    void Update()
    {
		
	}

	public void activate() {

		if (objectHouse != null)
		{
			if (objectHouse.counter < objectHouse.maxCounter)
			{
				if (syncPiece.activeInHierarchy == false) {
					objectHouse.ChangeCounter(1);
					syncPiece.SetActive(true);
					Destroy(gameObject);
				}
			}
		}
		objectPieces.SetActive(false);
	}
}
