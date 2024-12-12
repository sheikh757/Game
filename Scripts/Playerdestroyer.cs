using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Playerdestroyer : MonoBehaviour
{
    // This method is called when the collider enters another collider
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object has the tag "Player"
        if (collision.gameObject.CompareTag("Player"))
        {

            Destroy(collision.gameObject);

            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload the current scene
            
        }
    }
}
