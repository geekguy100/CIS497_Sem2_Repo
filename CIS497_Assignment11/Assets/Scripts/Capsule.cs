/*****************************************************************************
// File Name :         Capsule.cs
// Author :            Kyle Grenier
// Creation Date :     04/17/2021
//
// Brief Description : A colored capsule that rotates on the screen.
*****************************************************************************/
using System.Collections;
using UnityEngine;

public class Capsule : IShape
{
    [SerializeField] private float rotationSpeed;
    [SerializeField] private Vector3 rotationDirection;
    [SerializeField] private Color[] colors;

    protected override IEnumerator DrawEnumerator()
    {
        spriteRenderer.color = colors[Random.Range(0, colors.Length)];

        Vector3 dir = rotationDirection;
        dir = dir * (Random.Range(0, 2) == 0 ? 1 : -1);

        while(true)
        {
            transform.Rotate(dir * rotationSpeed * Time.deltaTime);
            yield return null;
        }
    }
}
