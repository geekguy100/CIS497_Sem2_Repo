/*****************************************************************************
// File Name :         PlayerStats.cs
// Author :            Kyle Grenier
// Creation Date :     02/26/2021
//
// Brief Description : Manages the player's stats.
*****************************************************************************/
using System;

public static class PlayerStats
{
    // An event that takes the score as a parameter.
    public static event Action<int> OnScoreChange;

    private static int score = 0;
    public static int Score
    {
        get { return score; }
        set
        {
            score = value;
            OnScoreChange?.Invoke(score);
        }
    }
}
