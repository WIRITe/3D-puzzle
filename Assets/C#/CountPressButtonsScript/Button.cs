using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public Text Buttontext;
    public bool pressed;
    public Material DeadMaterial;


    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if (!pressed)
            {
                gameObject.GetComponent<MeshRenderer>().material = DeadMaterial;
                pressed = true;
                Buttontext.text = "Pressed!!!";
                Count.count += 1;
            }
        }
    }
}
