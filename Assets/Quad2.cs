using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]

public class Quad2 : MonoBehaviour
{
    Mesh mesh;
    Vector3[] vertices;
    int[] indeces;
    MeshFilter mf;

    // Start is called before the first frame update
    void Start()
    {
        mesh = new Mesh();
        mesh.name = "Quad2";
        vertices = new Vector3[] { new Vector3(-0.5f, -0.5f, 0), new Vector3(-0.5f, 0.5f, 0), new Vector3(0.5f, 0.5f, 0), new Vector3(0.5f, -0.5f, 0) };
        indeces = new int[] { 0, 1, 3, 1, 2, 3 };
        mesh.vertices = vertices;
        mesh.triangles = indeces;

        mf = GetComponent<MeshFilter>();
        mf.sharedMesh = mesh;
    }

    // Update is called once per frame
    void Update()
    {

    }
}