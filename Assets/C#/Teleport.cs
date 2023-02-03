using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Teleport : MonoBehaviour
{
    public GameObject Pl;
    public GameObject Pos;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Pl.SetActive(true);
            Pl.GetComponent<Teleport1>().PosTo = Pos;
            Debug.Log("fvfd");
        }
    }
    public static void Telepor(GameObject Player, GameObject Pos)
    {
        Player.transform.position = Pos.transform.position;
    }
}
