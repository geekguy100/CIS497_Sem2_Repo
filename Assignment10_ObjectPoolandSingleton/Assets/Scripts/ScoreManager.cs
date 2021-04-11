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
    [SerializeField] private int minScore;

    private int score;
    public int Score
    {
        get { return score; }
        set
        {
            score = value;
            UIManager.Instance.UpdateScoreText(score);

            if (score >= maxScore)
                GameManager.Instance.GameWin();
            else if (score <= minScore)
                GameManager.Instance.GameLost();
        }
    }

    protected override void Awake()
    {
        base.Awake();
        score = 0;
    }
}