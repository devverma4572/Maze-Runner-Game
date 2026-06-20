using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameOverManager gameManager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameManager.GameOver();
        }
    }
}