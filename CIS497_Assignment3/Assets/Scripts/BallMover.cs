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

    private void Awake()
    {
        movement = GetComponent<CharacterMovement>();
    }

    private void Update()
    {
        movement.Move(Vector2.right);
    }
}