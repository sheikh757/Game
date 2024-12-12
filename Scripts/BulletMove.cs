using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    // Speed of the bullet
    public float speed;

    void Start()
    {
        speed = 6f; // Set a default speed
    }

    void Update()
    {
        // Move the bullet to the right
        Vector2 pos = transform.position;
        pos.x = pos.x + speed * Time.deltaTime; // Change x-position (left-to-right movement)

        // Update the bullet's position
        transform.position = pos;

        // Get the screen bounds (right edge)
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        // Destroy the bullet if it goes off-screen (right side)
        if (transform.position.x > max.x)
        {
            Destroy(gameObject);
        }
    }
}
