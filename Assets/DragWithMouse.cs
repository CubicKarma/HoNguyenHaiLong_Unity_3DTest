using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragWithMouse : MonoBehaviour
{
    Vector3 clickPos = -Vector3.one;

    private Vector3 GetMouseWorldPos()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            clickPos = hit.point;
        }
        clickPos.y = 0.2500001f;
        return clickPos;
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos();
    }
}
