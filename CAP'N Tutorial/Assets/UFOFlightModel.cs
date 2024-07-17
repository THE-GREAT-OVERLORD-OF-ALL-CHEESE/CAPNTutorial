using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOFlightModel : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 targetVelocity;
    public float force;

    private void FixedUpdate()
    {
        rb.AddForce((targetVelocity - rb.velocity) * force);
    }

    public void SetTargetVelocity(Vector3 targetVelocity)
    {
        this.targetVelocity = targetVelocity;
    }
}
