using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectWithMouse : MonoBehaviour
{
    //Vector3 mPrevPos = Vector3.zero;
    //Vector3 mPosDelta = Vector3.zero;
    //private void Update()
    //{
    //    if(Input.GetMouseButton(0))
    //    {
    //        mPosDelta = Input.mousePosition - mPrevPos;
    //        transform.Rotate(Camera.main.transform.forward, -Vector3.Dot(mPosDelta, Camera.main.transform.up), Space.World);
    //    }

    //    mPrevPos = Input.mousePosition;
    //}

    private Camera myCam;
    private Vector3 screenPos;
    private float angleOffset;
    private Collider2D col;

    private void Start()
    {
        myCam = Camera.main;
        col = GetComponent<Collider2D>();
    }

    private void Update()
    {
        Vector3 mousePos = myCam.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            if(col == Physics2D.OverlapPoint(mousePos))
            {
                screenPos = myCam.WorldToScreenPoint(transform.position);
                Vector3 vec3 = Input.mousePosition - screenPos;
                angleOffset = (Mathf.Atan2(transform.right.y, transform.right.x) - Mathf.Atan2(vec3.y, vec3.x)) * Mathf.Rad2Deg;
            }
        }

        if(Input.GetMouseButton(0))
        {
            if(col == Physics2D.OverlapPoint(mousePos))
            {
                Vector3 vec3 = Input.mousePosition - screenPos;
                float angle = Mathf.Atan2(vec3.y, vec3.x) * Mathf.Rad2Deg;
                transform.eulerAngles = new Vector3(0, 0, angle + angleOffset);
            }
        }
    }
}
