using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDestroyerPlayer : MonoBehaviour
{
    public GameObject explosionPrefab; // Reference to the explosion prefab

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object has the tag "Destroyable"
        if (collision.gameObject.CompareTag("Destroyable"))
        {
            // Create explosion at the enemy's position
            if (explosionPrefab != null)
            {
                // Instantiate explosion at the enemy's position and with the same rotation
                GameObject explosion = Instantiate(explosionPrefab, collision.transform.position, collision.transform.rotation);

                // Destroy the explosion object after 1 second
                Destroy(explosion, 0.5f);
            }

            // Destroy the enemy
            Destroy(collision.gameObject);

            // Increase the score by 5 using the ScoreManager
            if (ScoreManager.Instance != null)
            {
                ScoreManager.Instance.AddScore(5);
            }
        }
    }
}
