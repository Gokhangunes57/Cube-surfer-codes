using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveInput : MonoBehaviour
{

    private float velocity = 0.5f;

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            if (Input.mousePosition.x > Screen.width / 2)
            {
              
                transform.position  -= new Vector3(-velocity, 0, 0);

            }
            else
            {
              
               transform.position  -= new Vector3(velocity, 0, 0);
            }
        }
    }
}
