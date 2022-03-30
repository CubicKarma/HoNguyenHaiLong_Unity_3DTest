using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2 : MonoBehaviour
{
    public static Cube2 Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        Cube1.Instance.moveToCube2 = true;
    }

    private void OnMouseUp()
    {
        Cube1.Instance.moveToCube2 = false;
    }
}
