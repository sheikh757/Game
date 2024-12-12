using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemybullet : MonoBehaviour
{
    public float speed; // Bullet speed

    void Start()
    {
        speed = 3f; // Adjust speed as needed
    }

    void Update()
    {
        Vector2 pos = transform.position;

        // Move the bullet left
        pos.x = pos.x - speed * Time.deltaTime;

        // Update the bullet's position
        transform.position = pos;

        // Destroy the bullet if it goes off-screen (left side)
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0)); // Bottom-left corner of the viewport
        if (transform.position.x < min.x)
        {
            Destroy(gameObject);
        }
    }

    // Detect collision with the Player
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Destroy the bullet
            Destroy(gameObject);

            // Handle collision logic (e.g., reduce player health)
            Debug.Log("Bullet hit the Player!");
        }
    }
}
