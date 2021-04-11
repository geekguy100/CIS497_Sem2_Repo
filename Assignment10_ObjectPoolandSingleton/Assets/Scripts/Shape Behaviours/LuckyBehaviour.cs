/*****************************************************************************
// File Name :         LuckyBehaviour.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public class LuckyBehaviour : IShapeBehaviour
{
    private const int SCORE_MODIFIER = 1;

    protected override Color GetColor()
    {
        return Color.yellow;
    }

    protected override void PerformAction()
    {
        ScoreManager.Instance.Score += SCORE_MODIFIER;
    }
}