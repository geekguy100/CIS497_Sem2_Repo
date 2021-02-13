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
    public static event Action OnGameStart;
    public static event Action OnGameWin;
    public static event Action OnBucketTrigger;
    public static event Action<int> OnScoreChange; //Takes the score as an parameter.

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
}
