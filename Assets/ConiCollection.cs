using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public AudioClip coinSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.AddScore(1);

            AudioSource.PlayClipAtPoint(
                coinSound,
                transform.position
                );

            Destroy(gameObject);
        }
    }
}