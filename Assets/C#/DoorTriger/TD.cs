using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TD : MonoBehaviour
{
    public int NumberLocation;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(NumberLocation);
    }
}