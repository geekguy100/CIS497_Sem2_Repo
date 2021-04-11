/*****************************************************************************
// File Name :         ScoreManager.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public class ScoreManager : Singleton<ScoreManager>
{
    [SerializeField] private int maxScore;

    private int score;
    public int Score
    {
        get { return score; }
        set
        {
            score = value;
            if (score >= maxScore)
            {
                // GAME WIN.
            }
        }
    }

    protected override void Awake()
    {
        base.Awake();
        score = 0;
    }
}
