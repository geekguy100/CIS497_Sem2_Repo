/*****************************************************************************
// File Name :         ScoreManager.cs
// Author :            Kyle Grenier
// Creation Date :     03/28/2021
//
// Brief Description : Keeps track of the player's score.
*****************************************************************************/

public static class ScoreManager
{
    private static int score = 0;
    public static int Score
    {
        get { return score; }
        set { score = value; }
    }
}
