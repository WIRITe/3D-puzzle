using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDead : MonoBehaviour
{
    public GameObject Sound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject.Find("WinnerCup").GetComponent<LizeWin>().PlayerTrigger();

            MoveSir.canMove = false;
        }
        else
        {
            if(Sound != null) Sound.SetActive(false);
        }
    }
}