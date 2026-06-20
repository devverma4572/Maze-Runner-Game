using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverText;
    public GameObject replayButton;

    public void GameOver()
    {
        gameOverText.SetActive(true);

        replayButton.SetActive(true);

        Time.timeScale = 0f;
    }
    public void ReplayGame()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(
            SceneManager.GetActiveScene().buildIndex
        );
    }
}