/*****************************************************************************
// File Name :         ScoreManager.cs
// Author :            Kyle Grenier
// Creation Date :     02/12/2021
//
// Brief Description : Script that manages changes in score.
*****************************************************************************/
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score = 0;
    public int Score { get { return score; } }

    [Tooltip("The score required to win the game.")]
    [SerializeField] private int winningScore = 15;

    private void Awake()
    {
        //Add score when something enters the bucket.
        EventManager.OnBucketTrigger += AddScore;
    }

    private void OnDisable()
    {
        EventManager.OnBucketTrigger -= AddScore;   
    }

    /// <summary>
    /// Adds a point to the current score. If winning score is achieved, GameWin is called on EventManager.
    /// </summary>
    public void AddScore()
    {
        ++score;
        EventManager.ScoreChange(score);
        if (score >= winningScore)
            EventManager.GameWin();
    }
}
