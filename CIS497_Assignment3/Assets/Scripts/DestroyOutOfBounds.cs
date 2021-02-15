/*****************************************************************************
// File Name :         DestroyOutOfBounds.cs
// Author :            Kyle Grenier
// Creation Date :     02/12/2021
//
// Brief Description : Will destroy the game object if it is outside of the given boundaries.
*****************************************************************************/
using UnityEngine;

public abstract class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] private Vector2 minBoundary;
    [SerializeField] private Vector2 maxBoundary;

    private void Update()
    {
        Vector2 pos = transform.position;

        if (OutsideMin(pos) || OutsideMax(pos))
        {
            PerformAction();
            Destroy(gameObject);
        }
    }

    /// <summary>
    /// Returns true if outside of the minimum boundary area.
    /// </summary>
    /// <returns>True if outside of the minimum boundary area.</returns>
    private bool OutsideMin(Vector2 pos)
    {
        return (pos.x < minBoundary.x || pos.y < minBoundary.y);
    }

    /// <summary>
    /// Returns true if outside of the maximum boundary area.
    /// </summary>
    /// <returns>True if outside of the maximum boundary area.</returns>
    private bool OutsideMax(Vector2 pos)
    {
        return (pos.x > maxBoundary.x || pos.y > maxBoundary.y);
    }

    /// <summary>
    /// Other actions to be performed outside of destroying the game object out of bounds.
    /// </summary>
    protected abstract void PerformAction();
}
