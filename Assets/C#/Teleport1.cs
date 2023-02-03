using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport1 : MonoBehaviour
{
    public float TimeTo;
    public float TimeToTeleport;
    public GameObject Player;
    public GameObject PosTo;
    public bool Teleported = false;
    public float Timer;

    private void FixedUpdate()
    {
        Timer += Time.deltaTime;

        if (Timer > TimeTo)
        {
            Timer = 0;
            Teleported = false;
            gameObject.SetActive(false);    
        }

        if(Timer > TimeToTeleport && !Teleported) 
        {
            Teleport.Telepor(Player, PosTo);
            Teleported = true;
        }
    }
}
