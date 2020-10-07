using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiecesChallenge : MonoBehaviour
{
    public GameObject canvasReto;
    public GameObject ChallengeMusic;

   public void pressButton()
    {
        canvasReto.SetActive(true);
        ChallengeMusic.SetActive(false);
    }
}
