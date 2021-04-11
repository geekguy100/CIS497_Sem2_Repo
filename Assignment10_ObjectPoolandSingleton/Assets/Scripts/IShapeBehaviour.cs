/*****************************************************************************
// File Name :         IShapeBehaviour.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public abstract class IShapeBehaviour : MonoBehaviour
{
    private SpriteRenderer sr;

    protected Color color;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        SetColor();
    }

    protected void OnMouseDown()
    {
        PerformAction();
    }

    protected abstract void PerformAction();

    protected abstract Color GetColor();

    private void SetColor()
    {
        sr.color = GetColor();
    }
}
