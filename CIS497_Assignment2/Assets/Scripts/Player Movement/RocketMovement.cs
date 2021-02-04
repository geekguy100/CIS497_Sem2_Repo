/*****************************************************************************
// File Name :         RocketMovement.cs
// Author :            Kyle Grenier
// Creation Date :     02/04/2021
//
// Brief Description : Script that handles the mecanics of moving the rocket game object.
*****************************************************************************/
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class RocketMovement : MonoBehaviour
{
    [Header("Movement Variables")]
    [SerializeField] private float movementForce = 1f;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float horizontalMovementMultiplier = 0.5f;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Applies a force to the rocket in the given direction.
    /// </summary>
    /// <param name="dir">The direction in which to apply the force to the rocket.</param>
    public void Move(Vector3 dir)
    {
        //Taking the horizontal movement multiplier into account.
        dir.x *= horizontalMovementMultiplier;
        rb.AddForce(dir * movementForce, ForceMode2D.Force);

        Vector2 vel = rb.velocity;
        vel = Vector2.ClampMagnitude(vel, maxSpeed);
        rb.velocity = vel;


       // print(rb.velocity);
    }
}
