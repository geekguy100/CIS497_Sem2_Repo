/*****************************************************************************
// File Name :         BallGuyAnimationEvents.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : Updates the BallMover's canMove variable. Allows the ball to jump only when off the ground.
*****************************************************************************/
using UnityEngine;

public class BallGuyAnimationEvents : MonoBehaviour
{
    private BallMover mover;

    private void Awake()
    {
        mover = GetComponentInParent<BallMover>();
    }

    /// <summary>
    /// Updates the BallMover's ability to move.
    /// </summary>
    /// <param name="canMove">True if the ball is able to move.</param>
    public void UpdateMovement(int canMove)
    {
        mover.UpdateMovement(canMove);
    }
}
