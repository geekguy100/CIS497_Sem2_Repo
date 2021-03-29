/*****************************************************************************
// File Name :         EventManager.cs
// Author :            Kyle Grenier
// Creation Date :     03/28/2021
//
// Brief Description : Class to handle subscribing to / unsubscribing from and invoking game events.
*****************************************************************************/
using System;

public static class EventManager
{
    public static event Action<KickData> OnKickOff;
    public static event Action OnTargetHit;
    public static event Action<int> OnUpdateScore;
    public static event Action OnBallDestroyed;
    public static event Action OnMissTarget;
    public static event Action OnGameOver;
    public static event Action<int> OnUpdateLives;
    public static event Action OnGameWin;

    public static void KickOff(KickData kickData)
    {
        OnKickOff?.Invoke(kickData);
    }

    public static void TargetHit()
    {
        OnTargetHit?.Invoke();
    }

    public static void MissTarget()
    {
        OnMissTarget?.Invoke();
    }

    public static void UpdateScore(int score)
    {
        OnUpdateScore?.Invoke(score);
    }

    public static void BallDestroyed()
    {
        OnBallDestroyed?.Invoke();
    }

    public static void GameOver()
    {
        OnGameOver?.Invoke();
    }

    public static void UpdateLives(int lives)
    {
        OnUpdateLives?.Invoke(lives);
    }

    public static void GameWin()
    {
        OnGameWin?.Invoke();
    }
}