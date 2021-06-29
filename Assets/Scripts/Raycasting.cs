using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasting : MonoBehaviour
{
    public float distance = 5.0f;

    private void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward) * distance;
        Debug.DrawRay(transform.position, forward, Color.green);
    }
}
