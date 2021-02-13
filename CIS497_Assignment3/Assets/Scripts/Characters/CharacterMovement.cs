/*****************************************************************************
// File Name :         CharacterMovement.cs
// Author :            Kyle Grenier
// Creation Date :     02/11/2021
//
// Brief Description : How a character in the game should move.
*****************************************************************************/
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CharacterMovement : MonoBehaviour
{
    [Tooltip("The force to apply to the rigidbody.")]
    [SerializeField] private float movementForce = 10f;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Moves the rigidbody by adding a force in the given direction.
    /// </summary>
    /// <param name="dir">The direction to add a force.</param>
    public void Move(Vector2 dir)
    {
        Vector2 force = dir * movementForce;

        rb.AddForce(force * Time.fixedDeltaTime);

        //rb.MovePosition(rb.position + dir * movementSpeed * Time.fixedDeltaTime);
        //transform.position += dir * movementSpeed * Time.deltaTime;
    }

    /// <summary>
    /// Sets the movement force to the given value.
    /// </summary>
    /// <param name="force">The movement force.</param>
    public void SetMovementForce(float force)
    {
        movementForce = force;
    }

    /// <summary>
    /// Returns the character's current direction of movement.
    /// </summary>
    /// <returns>The character's direction of movement.</returns>
    public Vector2 GetDirection()
    {
        return rb.velocity.normalized;
    }
}
