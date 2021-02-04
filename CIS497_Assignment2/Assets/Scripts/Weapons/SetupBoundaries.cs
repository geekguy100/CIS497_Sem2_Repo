/*****************************************************************************
// File Name :         SetupBoundaries.cs
// Author :            Kyle Grenier
// Creation Date :     02/04/2021
//
// Brief Description : Sets up the boundaries to conform to the screen's size.
*****************************************************************************/
using UnityEngine;

public class SetupBoundaries : MonoBehaviour
{
    [Header("Boundary Transforms")]
    [SerializeField] private Transform topBoundary;
    [SerializeField] private Transform rightBoundary;
    [SerializeField] private Transform bottomBoundary;
    [SerializeField] private Transform leftBoundary;

    [Header("Boundary Offsets")]
    [SerializeField] private Vector2 topOffset;
    [SerializeField] private Vector2 rightOffset;
    [SerializeField] private Vector2 bottomOffset;
    [SerializeField] private Vector2 leftOffset;


    /// <summary>
    /// Initally places the boundaries at the screen's corners, then adjusts positions with offsets.
    /// </summary>
    private void Start()
    {
        Vector3 minPos = Camera.main.ViewportToWorldPoint(Vector3.zero);
        Vector3 maxPos = Camera.main.ViewportToWorldPoint(Vector3.one);

        Vector3 topPos = new Vector3(minPos.x + topOffset.x, maxPos.y + topOffset.y);
        Vector3 rightPos = new Vector3(maxPos.x + rightOffset.x, maxPos.y + rightOffset.y);
        Vector3 bottomPos = new Vector3(minPos.x + bottomOffset.x, minPos.y + bottomOffset.y);
        Vector3 leftPos = new Vector3(minPos.x + leftOffset.x, minPos.y + leftOffset.y);

        topBoundary.position = topPos;
        rightBoundary.position = rightPos;
        bottomBoundary.position = bottomPos;
        leftBoundary.position = leftPos;
    }

}
