/*****************************************************************************
// File Name :         CharacterMovement.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
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

    public void Move(Vector2 dir)
    {
        Vector2 force = dir * movementForce;

        rb.AddForce(force * Time.fixedDeltaTime);

        //rb.MovePosition(rb.position + dir * movementSpeed * Time.fixedDeltaTime);
        //transform.position += dir * movementSpeed * Time.deltaTime;
    }
}
