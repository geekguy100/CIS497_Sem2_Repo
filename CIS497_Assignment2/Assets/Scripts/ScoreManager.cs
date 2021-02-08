/*****************************************************************************
// File Name :         ScoreManager.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : Handles updating and displaying the score.
*****************************************************************************/
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private float winningScore = 1000;

    public delegate void WinningScoreHandler();
    public event WinningScoreHandler OnWinningScoreAchieved;

    private float score = 0f;

    public void AddScore(float score)
    {
        this.score += score;
        UpdateScoreText();

        if (this.score >= winningScore)
            OnWinningScoreAchieved?.Invoke();
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + Mathf.FloorToInt(score);
    }
}
