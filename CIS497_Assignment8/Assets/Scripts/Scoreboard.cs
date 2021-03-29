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


    #region --- Event Stuff ---
    private void OnEnable()
    {
        EventManager.OnKickOff += UpdateKickData;
        EventManager.OnUpdateScore += UpdateScore;
        EventManager.OnUpdateLives += UpdateLives;
        EventManager.OnGameOver += GameOver;
    }

    private void OnDisable()
    {
        EventManager.OnKickOff -= UpdateKickData;
        EventManager.OnUpdateScore -= UpdateScore;
        EventManager.OnUpdateLives -= UpdateLives;
        EventManager.OnGameOver -= GameOver;
    }

    #endregion

    private void UpdateKickData(KickData data)
    {
        ballText.text = "BALL: " + data.BallName.ToUpper();
        forceText.text = "FORCE: " + System.Math.Round(data.KickForce.magnitude, 2);
    }

    private void UpdateScore(int score)
    {
        scoreText.text = "SCORE: " + score;
    }

    private void UpdateLives(int lives)
    {
        livesText.text = "LIVES: " + lives;
    }

    private void GameOver()
    {
        for(int i = 0; i < scorePanel.transform.childCount; ++i)
        {
            scorePanel.transform.GetChild(i).gameObject.SetActive(false);
        }

        gameOverText.gameObject.SetActive(true);
    }
}