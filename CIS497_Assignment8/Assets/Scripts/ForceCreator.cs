/*****************************************************************************
// File Name :         ForceCreator.cs
// Author :            Kyle Grenier
// Creation Date :     03/27/2021
//
// Brief Description : Enables a line renderer to determine the direction the ball will be shot in,
                       and returns the force upon deactivation.
*****************************************************************************/
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class ForceCreator : MonoBehaviour
{
    public static ForceCreator instance;

    private LineRenderer lineRenderer;

    private Vector3 startPos;
    private Vector3 endPos;


    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 2;
    }

    public void Activate(Transform ball, Vector3 mousePos)
    {
        if (!lineRenderer.enabled)
            lineRenderer.enabled = true;

        startPos = ball.position;
        lineRenderer.SetPosition(0, startPos);

        endPos = new Vector3(mousePos.x, ball.position.y, mousePos.z);
        lineRenderer.SetPosition(1, endPos);
    }

    public Vector3 DeactivateAndGetForce()
    {
        lineRenderer.enabled = false;

        float distance = Vector3.Distance(startPos, endPos);

        print(-(endPos - startPos).normalized * distance / 2);
        return -(endPos - startPos).normalized * distance / 2;
    }
}