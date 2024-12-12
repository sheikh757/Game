using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // For TextMeshPro UI

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance; // Singleton instance
    private int score = 0;               // Player's score
    public TextMeshProUGUI scoreText;    // Reference to UI TextMeshPro element

    private void Awake()
    {
        // Ensure there's only one instance of the ScoreManager
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        UpdateScoreText();
    }

    // Method to add to the score
    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    // Method to update the score text in the UI
    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
}
