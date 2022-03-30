using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube1 : MonoBehaviour
{
    public static Cube1 Instance { get; private set; }

    private float moveSpeed = 3.0f;
    Rigidbody rb;

    public bool moveToCube2 = false;
    public bool moveToCube3 = false;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(moveToCube2)
        {
            transform.position = Vector3.MoveTowards(transform.position, Cube2.Instance.transform.position, moveSpeed * Time.deltaTime);
        }

        if (moveToCube3)
        {
            transform.position = Vector3.MoveTowards(transform.position, Cube3.Instance.transform.position, moveSpeed * Time.deltaTime);
        }
    }
}
