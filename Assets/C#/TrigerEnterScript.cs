using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerEnterScript : MonoBehaviour
{
    public GameObject Pl;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            Debug.Log("fdgbdfgb");
            Pl.SetActive(true);
            MoveSir.canMove = false;
        }
    }
}
