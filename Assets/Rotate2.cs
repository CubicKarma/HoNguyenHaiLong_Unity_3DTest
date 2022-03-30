using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate2 : MonoBehaviour
{
    private float rotateSpeed = 5.0f;
    float yaw;
    bool drag = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            drag = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            drag = false;
        }

        if (drag)
        {
            yaw += Input.GetAxis("Mouse X");

            while (yaw < -45)
            {
                yaw = -45;
            }

            while (yaw > 45)
            {
                yaw = 45;
            }

        }

        transform.eulerAngles = new Vector3(0f, -yaw, 0f);


    }
}
