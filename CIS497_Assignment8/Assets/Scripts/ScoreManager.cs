/*****************************************************************************
// File Name :         ScoreManager.cs
// Author :            Kyle Grenier
// Creation Date :     03/28/2021
//
// Brief Description : Keeps track of the player's score and lives.
*****************************************************************************/
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score = 0;
    private int maxLives = 3;
    private int lives;

    #region --- Events ---
    private void OnEnable()
    {
        EventManager.OnTargetHit += IncrementScore;

        EventManager.OnMissTarget += DecrementLives;
    }

    private void OnDisable()
    {
        EventManager.OnTargetHit -= IncrementScore;

        EventManager.OnMissTarget -= DecrementLives;
    }

    #endregion

    private void Awake()
    {
        lives = maxLives;
    }

    private void IncrementScore()
    {
        score += 1;
        EventManager.UpdateScore(score);
    }

    private void DecrementLives()
    {
        lives -= 1;
        EventManager.UpdateLives(lives);
        if (lives <= 0)
            EventManager.GameOver();
    }
}