using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public TextMeshProUGUI scoreText;

    public GameObject gameOverText;

    public GameObject youWinText;

    public TextMeshProUGUI finalScoreText;

    private int score = 0;

    void Awake()
    {
        instance = this;
    }

    public void AddScore(int points)
    {
        score += points;

        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        gameOverText.SetActive(true);

        Time.timeScale = 0f;
    }

    public void WinGame()
    {
        youWinText.SetActive(true);

        finalScoreText.gameObject.SetActive(true);

        finalScoreText.text = "Final Score: " + score;

        Time.timeScale = 0f;
    }
}