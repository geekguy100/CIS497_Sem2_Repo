/*****************************************************************************
// File Name :         BombBehaviour.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public class BombBehaviour : IShapeBehaviour
{
    private const int SCORE_MODIFIER = -2;

    protected override void PerformAction()
    {
        // Play a sound, instantitate a particle effect, etc.
        ScoreManager.Instance.Score += SCORE_MODIFIER;
    }

    protected override Color GetColor()
    {
        return Color.black;
    }
}