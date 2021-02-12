/*****************************************************************************
// File Name :         CharacterMovement.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 10f;

    public void Move(Vector3 dir)
    {
        transform.position += dir * movementSpeed * Time.deltaTime;
    }
}
