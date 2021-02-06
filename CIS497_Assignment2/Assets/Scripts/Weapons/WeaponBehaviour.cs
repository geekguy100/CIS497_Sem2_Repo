/*****************************************************************************
// File Name :         WeaponBehaviour.cs
// Author :            Kyle Grenier
// Creation Date :     02/03/2021
//
// Brief Description : Defines the requirements for creating a new WeaponBehaviour.
*****************************************************************************/
using UnityEngine;

public abstract class WeaponBehaviour : MonoBehaviour
{
    private float laserDistance = 100f;
    private Transform laserPoint; //Origin of the laser.
    [SerializeField] protected int damage = 5; //The damage of the laser.

    protected LineRenderer lineRenderer;
    private SpriteRenderer spriteRenderer;




    protected virtual void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.enabled = false;

        spriteRenderer = transform.parent.GetComponentInChildren<SpriteRenderer>(); //Gets the SpriteRenderer in the 'Model' child.
        laserPoint = transform.GetChild(0);
    }

    /// <summary>
    /// Fires the laser.
    /// </summary>
    public virtual void Fire(System.Type b = null)
    {
        if (!lineRenderer.enabled)
            lineRenderer.enabled = true;



        RaycastHit2D hit = Physics2D.Raycast(laserPoint.position, Vector2.right, laserDistance);

        //If there is an object in front of us, stop the laser at the hit point.
        if (hit)
            lineRenderer.SetPosition(0, hit.point);
        //If not, let the laser travel the full distance.
        else
            lineRenderer.SetPosition(0, laserPoint.position + (Vector3.right * laserDistance));

        lineRenderer.SetPosition(1, laserPoint.position);

        ////Log warning if an invalid type is passed through.
        //if (b.BaseType != typeof(DestroyableBlock))
        //{
        //    Debug.LogWarning("Weapon is trying to break a non-DestroyableBlock!");
        //    return;
        //}

        //If we didn't hit anything, return.
        if (!hit)
            return;

        //If we hit something, check to see if it is the DestroyableBlock we are trying to destroy.
        DestroyableBlock block = hit.transform.GetComponent(b) as DestroyableBlock;
        if (block != null)
            block.BlockHealth.TakeDamage(damage);
    }

    /// <summary>
    /// Changes the color of the rocket ship and laser.
    /// </summary>
    /// <param name="color">The color to change to.</param>
    protected void ChangeColor(Color color)
    {
        spriteRenderer.color = color;
        lineRenderer.startColor = color;
        lineRenderer.endColor = color;
    }

    /// <summary>
    /// Sets the laser's max distance.
    /// </summary>
    /// <param name="laserDistance">The laser's new max distance.</param>
    public void SetLaserDistance(float laserDistance)
    {
        this.laserDistance = laserDistance;
    }
}
