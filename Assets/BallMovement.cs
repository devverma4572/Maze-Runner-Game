using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float moveSpeed = 200f;
    public float maxSpeed = 30f;

    public Transform cameraPivot;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Camera forward direction
        Vector3 forward = cameraPivot.forward;

        // Remove vertical tilt influence
        forward.y = 0f;

        forward.Normalize();

        // Move forward
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(forward * moveSpeed);
        }

        // Move backward
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-forward * moveSpeed);
        }

        // Limit horizontal speed
        Vector3 horizontalVelocity =
            new Vector3(
                rb.linearVelocity.x,
                0f,
                rb.linearVelocity.z
            );

        if (horizontalVelocity.magnitude > maxSpeed)
        {
            horizontalVelocity =
                horizontalVelocity.normalized * maxSpeed;

            rb.linearVelocity = new Vector3(
                horizontalVelocity.x,
                rb.linearVelocity.y,
                horizontalVelocity.z
            );
        }
    }
}