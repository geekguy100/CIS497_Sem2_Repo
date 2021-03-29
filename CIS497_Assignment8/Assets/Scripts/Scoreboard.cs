/*****************************************************************************
// File Name :         Scoreboard.cs
// Author :            Kyle Grenier
// Creation Date :     03/28/2021
//
// Brief Description : A scoreboard that updates based on the player's score and in-game actions.
*****************************************************************************/
using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    [SerializeField] private GameObject scorePanel;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI ballText;
    [SerializeField] private TextMeshProUGUI forceText;
    [SerializeField] private TextMeshProUGUI livesText;
    [SerializeField] private TextMeshProUGUI gameOverText;
    [SerializeField] private TextMeshProUGUI winText;


    #region --- Event Stuff ---
    private void OnEnable()
    {
        EventManager.OnKickOff += UpdateKickData;
        EventManager.OnUpdateScore += UpdateScore;
        EventManager.OnUpdateLives += UpdateLives;
        EventManager.OnGameOver += GameOver;
        EventManager.OnGameWin += Win;
    }

    private void OnDisable()
    {
        EventManager.OnKickOff -= UpdateKickData;
        EventManager.OnUpdateScore -= UpdateScore;
        EventManager.OnUpdateLives -= UpdateLives;
        EventManager.OnGameOver -= GameOver;
        EventManager.OnGameWin -= Win;
    }

    #endregion

    private void UpdateKickData(KickData data)
    {
        ballText.text = "BALL: " + data.BallName.ToUpper();
        forceText.text = "FORCE: " + System.Math.Round(data.KickForce.magnitude, 2);
    }

    private void UpdateScore(int score)
    {
        scoreText.text = "SCORE: " + score.ToString("X3");
    }

    private void UpdateLives(int lives)
    {
        livesText.text = "LIVES: " + lives.ToString("X3");
    }

    private void GameOver()
    {
        for(int i = 0; i < scorePanel.transform.childCount; ++i)
        {
            scorePanel.transform.GetChild(i).gameObject.SetActive(false);
        }

        gameOverText.gameObject.SetActive(true);
    }

    private void Win()
    {
        for (int i = 0; i < scorePanel.transform.childCount; ++i)
        {
            scorePanel.transform.GetChild(i).gameObject.SetActive(false);
        }

        winText.gameObject.SetActive(true);
    }
}