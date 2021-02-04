/*****************************************************************************
// File Name :         PlayerMovementHandler.cs
// Author :            Kyle Grenier
// Creation Date :     02/04/2021
//
// Brief Description : Script that handles gathering input from the player.
*****************************************************************************/
using UnityEngine;

[RequireComponent(typeof(RocketMovement))]
public class PlayerMovementHandler : MonoBehaviour
{
    private RocketMovement movement;

    private Vector3 dir;

    private void Awake()
    {
        movement = GetComponent<RocketMovement>();
    }

    private void Update()
    {
        //Get player input.
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        dir.x = h;
        dir.y = v;
    }

    private void FixedUpdate()
    {
        //Apply the movement to the rocket.
        movement.Move(dir);
    }
}
