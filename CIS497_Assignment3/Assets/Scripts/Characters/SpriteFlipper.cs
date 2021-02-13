/*****************************************************************************
// File Name :         SpriteFlipper.cs
// Author :            Kyle Grenier
// Creation Date :     02/12/2021
//
// Brief Description : Flips a sprite based on its direction of movement.
*****************************************************************************/
using UnityEngine;

[RequireComponent(typeof(CharacterMovement))]
public class SpriteFlipper : MonoBehaviour
{
    //The directions the character can face.
    private enum Direction {TOP, RIGHT, BOTTOM, LEFT};
    private Direction directionFacing;

    private CharacterMovement characterMovement;

    [Tooltip("The Animators to use for sprite flipping. Some character may have multiple animators.")]
    [SerializeField] private Animator[] anim;

    private void Awake()
    {
        characterMovement = GetComponent<CharacterMovement>();
    }

    private void Start()
    {
        ChangeDirection(Direction.RIGHT); //Default to facing right.
    }

    private void Update()
    {
        Vector2 dir = characterMovement.GetDirection();

        if (dir.x > 0 && directionFacing != Direction.RIGHT)
            ChangeDirection(Direction.RIGHT);
        else if (dir.x < 0 && directionFacing != Direction.LEFT)
            ChangeDirection(Direction.LEFT);
        
    }

    /// <summary>
    /// Changes the character's sprite based on character's direction of movement.
    /// </summary>
    /// <param name="direction">The direction the character is moving.</param>
    private void ChangeDirection(Direction direction)
    {
        directionFacing = direction;

        foreach (Animator a in anim)
        {
            a.Play(direction.ToString(), 0, a.GetCurrentAnimatorStateInfo(0).normalizedTime);
        }
    }
}
