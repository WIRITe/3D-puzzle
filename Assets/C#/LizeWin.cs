using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LizeWin : MonoBehaviour
{
    public GameObject Cube;

    public GameObject Canv;

    public GameObject DeadScreen;

    public GameObject WinPlatform;

    public Transform PosSpawn;

    public void OnTriggerEnter()
    {
        Instantiate(Cube, PosSpawn);
        Canv.SetActive(false);
        WinPlatform.SetActive(true);
    }

    public void PlayerTrigger()
    {

        DeadScreen.SetActive(true);    
    }
}
