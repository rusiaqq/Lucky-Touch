using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text LivesText;
    public Text ScoreText;
    public Text LevelText;
    public Text GameOverText;

    public int Lives = 3;
    public int Score = 0;
    public int Level = 1;

    public int HowOftenLevelUp = 10; // Every 10 enemies.

    void Start()
    {
        LivesText.text = string.Format("Lives: {0}", Lives);
        ScoreText.text = string.Format("Score: {0}", Score);
        LevelText.text = string.Format("Level: {0}", Level);
        GameOverText.text = string.Empty;
    }

    void Update() { }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            PlusScore();
            LevelUuIfNeeded();
        }
    }

    public void MinusLife()
    {
        Lives--;
        LivesText.text = string.Format("Lives: {0}", Lives);

        GameOverIfNeeded();
    }

    public void GameOverIfNeeded()
    {
        if (IsDead())
        {
            GameOverText.text = "Game Over";
            Time.timeScale = 0; // Stop the Game.
        }
    }

    private void PlusScore()
    {
        Score++;
        ScoreText.text = string.Format("Score: {0}", Score);
    }

    public bool IsDead()
    {
        return Lives <= 0;
    }

    private void LevelUuIfNeeded()
    {
        if (Score % HowOftenLevelUp == 0)
        {
            Level++;
            LevelText.text = string.Format("Level: {0}", Level);
        }
    }
}
