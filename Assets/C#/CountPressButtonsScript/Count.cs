using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count : MonoBehaviour
{
    public static int count;
    public int NeedCount;
    public GameObject WinPlatform;

    private void Start()
    {
        count = 0;
    }

    private void Update()
    {
        if (count >= NeedCount)
        {
            Scene8AfterAllPress.AfterAllPressSc8(WinPlatform);
        }
    }
}
