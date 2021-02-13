/*****************************************************************************
// File Name :         BallMover.cs
// Author :            Kyle Grenier
// Creation Date :     02/11/2021
//
// Brief Description :  Handles how the ball should move and when.
*****************************************************************************/
using UnityEngine;

[RequireComponent(typeof(CharacterMovement))]
public class BallMover : MonoBehaviour
{
    private CharacterMovement movement;
    private Vector2 movementDirection = Vector2.zero;

    //Can the ball move? Ball can only move when it is not on the ground.
    private bool canMove = false;

    private void Awake()
    {
        movement = GetComponent<CharacterMovement>();
    }

    private void Start()
    {
        movementDirection = (Vector3.zero - transform.position).normalized;
    }

    private void FixedUpdate()
    {
        print(canMove);
        if (canMove)
            movement.Move(movementDirection);
    }

    /// <summary>
    /// Updates the BallMover's ability to move.
    /// </summary>
    /// <param name="canMove">True if the ball is able to move.</param>
    public void UpdateMovement(int canMove)
    {
        this.canMove = (canMove <= 0 ? false : true);
    }
}