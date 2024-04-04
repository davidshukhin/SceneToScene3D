using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSkybox : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed = 200.0f;
   

    // Update is called once per frame
    void Update()
    {
    transform.Rotate(Vector3.right * Time.deltaTime * rotationSpeed); 
    }
}
