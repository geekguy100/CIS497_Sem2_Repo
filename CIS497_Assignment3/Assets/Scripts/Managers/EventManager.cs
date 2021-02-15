/*****************************************************************************
// File Name :         EventManager.cs
// Author :            Kyle Grenier
// Creation Date :     02/13/2021
//
// Brief Description : Script that handles calling game events.
*****************************************************************************/
using System;

public static class EventManager
{
    public static event Action OnTutorialStart;
    public static event Action OnGameStart;
    public static event Action OnGameWin;
    public static event Action OnBucketTrigger;
    public static event Action<int> OnScoreChange; //Takes the score as the parameter.
    public static event Action<int> OnPuffleLost; //Takes the player's lives as the parameter.
    public static event Action OnGameLost;
    public static event Action<int> OnLoseLife; //Takes the player's lives as the parameter.

    public static void TutorialStart()
    {
        OnTutorialStart?.Invoke();
    }

    public static void GameStart()
    {
        OnGameStart?.Invoke();
    }

    public static void GameWin()
    {
        OnGameWin?.Invoke();
    }

    public static void BucketTrigger()
    {
        OnBucketTrigger?.Invoke();
    }

    public static void ScoreChange(int score)
    {
        OnScoreChange?.Invoke(score);
    }

    public static void PuffleLost(int lives)
    {
        OnPuffleLost?.Invoke(lives);
    }

    public static void GameLost()
    {
        OnGameLost?.Invoke();
    }

    public static void LoseLife(int lives)
    {
        OnLoseLife?.Invoke(lives);
    }
}
