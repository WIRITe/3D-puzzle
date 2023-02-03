using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        MoveSir.canMove = false;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }
}
