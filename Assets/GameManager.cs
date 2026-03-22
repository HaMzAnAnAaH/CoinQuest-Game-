using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score = 0;

    public TextMeshProUGUI scoreText;

    public int totalCoins;
    public GameObject winText;

    public GameObject restartButton;

    public GameObject loseText;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreText.text = "Score: 0";
    }

    public void AddScore()
    {
        score++;
        scoreText.text = "Score: " + score;

        if (score >= totalCoins)
        {
            winText.SetActive(true);
            restartButton.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void LoseGame()
    {
        loseText.SetActive(true);
        restartButton.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}