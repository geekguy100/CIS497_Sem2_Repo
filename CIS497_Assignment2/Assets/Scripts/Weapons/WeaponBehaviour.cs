/*****************************************************************************
// File Name :         WeaponBehaviour.cs
// Author :            Kyle Grenier
// Creation Date :     02/03/2021
//
// Brief Description : Defines the requirements for creating a new WeaponBehaviour.
*****************************************************************************/
using System;
using UnityEngine;

public abstract class WeaponBehaviour : MonoBehaviour
{
    private float laserDistance = 100f;
    private Transform laserPoint; //Origin of the laser.

    protected LineRenderer lineRenderer;
    private SpriteRenderer spriteRenderer;




    protected virtual void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.enabled = false;

        spriteRenderer = transform.parent.GetComponentInChildren<SpriteRenderer>(); //Gets the SpriteRenderer in the 'Model' child.
        laserPoint = transform.GetChild(0);
    }

    public void Fire()
    {
        if (!lineRenderer.enabled)
            lineRenderer.enabled = true;

        lineRenderer.SetPosition(0, laserPoint.position + (Vector3.right * laserDistance));
        lineRenderer.SetPosition(1, laserPoint.position);
    }

    protected void ChangeColor(Color color)
    {
        spriteRenderer.color = color;
        lineRenderer.startColor = color;
        lineRenderer.endColor = color;
    }

    public void SetLaserDistance(float laserDistance)
    {
        this.laserDistance = laserDistance;
    }
}
