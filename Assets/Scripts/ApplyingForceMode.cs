using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyingForceMode : MonoBehaviour
{
    private Rigidbody rb;
    public float forceAmount = 5.0f;
    public ForceModes modes;
    
    public enum ForceModes
    {
        force,
        acceleration,
        impulse,
        velocityChange
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            switch (modes)
            {
                //Applies a gradual force on the Object, taking mass into account. This is a literal pushing 
                //motion where the bigger the mass of the Object, the slower it will speed up.
                case ForceModes.force:
                    rb.AddForce(Vector3.forward * forceAmount, ForceMode.Force);
                    break;
                //Same as ForceMode.Force except that it doesn't take mass into account. No matter 
                //how big the mass of the object, it will accelerate at a constant rate.
                case ForceModes.acceleration:
                    rb.AddForce(Vector3.forward * forceAmount, ForceMode.Acceleration);
                    break;
                //Applies an instant force on the Object, taking mass into account. This pushes the 
                //Object using the entire force in a single frame. Again, the bigger the mass of the Object, 
                //the less effect this will have. Great for recoil or jump functions.
                case ForceModes.impulse:
                    rb.AddForce(Vector3.forward * forceAmount, ForceMode.Impulse);
                    break;
                //ForceMode.VelocityChange - Same as ForceMode.Impulse and again, doesn't take mass into account. 
                //It will literally add the force to the Object's velocity in a single frame.
                case ForceModes.velocityChange:
                    rb.AddForce(Vector3.forward * forceAmount, ForceMode.VelocityChange);
                    break;

            }
        }
    }
}
