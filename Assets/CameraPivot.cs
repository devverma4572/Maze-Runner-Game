using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    public float rotationSpeed = 100f;

    private float currentYRotation = 0f;

    void LateUpdate()
    {
        // Follow player position
        transform.position = player.position;

        // Rotate left
        if (Input.GetKey(KeyCode.A))
        {
            currentYRotation -= rotationSpeed * Time.deltaTime;
        }

        // Rotate right
        if (Input.GetKey(KeyCode.D))
        {
            currentYRotation += rotationSpeed * Time.deltaTime;
        }

        // Apply rotation
        transform.rotation =
            Quaternion.Euler(0f, currentYRotation, 0f);
    }
}