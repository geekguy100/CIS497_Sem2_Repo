/*****************************************************************************
// File Name :         IMoveable.cs
// Author :            Kyle Grenier
// Creation Date :     1/28/2020
// CIS497 Assignment 1
// Brief Description : Interface for GameObjects that have the ability to move around.
*****************************************************************************/
using UnityEngine;
using System.Collections;

public interface IMoveable
{
    /// <summary>
    /// Move towards a destination over time.
    /// </summary>
    /// <param name="destination">The destination to move to.</param>
    IEnumerator moveTowards(Vector3 destination);
}