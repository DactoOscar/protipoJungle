using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pieces : MonoBehaviour
{
    public Construction objectHouse;
	public GameObject objectPieces;
	public GameObject syncPiece;
	public bool state = false;

	void Update()
    {
		
	}

	public void activate() {

		if (objectHouse != null)
		{
			if (objectHouse.counter < objectHouse.maxCounter)
			{
				if (syncPiece.activeInHierarchy == false) {
					if (state == true) {
						PiecesChallenge pie = GetComponent<PiecesChallenge>();
						pie.pressButton();
					}
						objectHouse.ChangeCounter(1);
						syncPiece.SetActive(true);
						Destroy(gameObject);
				}
			}
		}
		objectPieces.SetActive(false);
	}
}
