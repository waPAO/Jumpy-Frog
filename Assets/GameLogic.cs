using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
  public int userScore;
  public Text scoreText;
  public Text highScoreText;
  public Text newHighScoreText;
  public GameObject gameOverScreen;
  public GameObject newHighScoreScreen;
  public AudioSource ribbitSFX;

  [ContextMenu("Increment Score")]
  public void addScore(int scoreToAdd)
  {
    userScore += scoreToAdd;
    scoreText.text = userScore.ToString();
    ribbitSFX.Play();
  }

  public void gameRestart()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }

  public void updateHighScore()
  {
    highScoreText.text = $"High Score: {PlayerPrefs.GetInt("HighScore", 0)}" ;
  }

  public void gameOver()
  {
    gameOverScreen.SetActive(true);

    if (userScore > PlayerPrefs.GetInt("HighScore", 0)) {
      PlayerPrefs.SetInt("HighScore", userScore);
      newHighScoreText.text = $"New High Score: {PlayerPrefs.GetInt("HighScore", 0)}";
      newHighScoreScreen.SetActive(true);
      updateHighScore();
    }
  }
}
