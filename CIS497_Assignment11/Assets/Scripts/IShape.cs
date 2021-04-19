/*****************************************************************************
// File Name :         IShape.cs
// Author :            Kyle Grenier
// Creation Date :     04/17/2021
//
// Brief Description : Defines the interface for creating a shape.
*****************************************************************************/
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public abstract class IShape : MonoBehaviour
{
    protected SpriteRenderer spriteRenderer;

    protected virtual void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Draw()
    {
        StartCoroutine(DrawEnumerator());
    }

    protected abstract IEnumerator DrawEnumerator();
}