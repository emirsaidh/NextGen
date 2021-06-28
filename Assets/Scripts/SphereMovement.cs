using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float force;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 direction = Vector3.zero;

        direction.x = Input.GetAxis("Horizontal"); //forward-backward
        direction.z = Input.GetAxis("Vertical");//right-left
        direction.y = Input.GetAxis("Fire1");//up and down Positive button: "e", negative button: "q" 
        rb.AddForce(direction * force);
    }
}
