using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHeads : MonoBehaviour
{
     public Transform centerPoint;   // The point to rotate around
    public Vector3 axis = Vector3.up; // Axis of rotation (default is Y-axis)
    public float rotationSpeed = 45.0f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(centerPoint.position, axis, rotationSpeed * Time.deltaTime);
    }
}
