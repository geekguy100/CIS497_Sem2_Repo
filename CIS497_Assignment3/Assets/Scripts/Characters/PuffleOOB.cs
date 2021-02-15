/*****************************************************************************
// File Name :         PuffleOOB.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : Unique action for puffles. Will be called before being destoyed out of bounds.
*****************************************************************************/
using UnityEngine;

public class PuffleOOB : DestroyOutOfBounds
{
    [Tooltip("How much lives losing this puffle should cost.")]
    [SerializeField] private int worth = 1;

    protected override void PerformAction()
    {
        EventManager.PuffleLost(worth);
    }
}
