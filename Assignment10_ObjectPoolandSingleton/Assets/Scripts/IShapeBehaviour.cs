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

    protected string poolTag = string.Empty;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        SetColor();
    }

    private void SetColor()
    {
        sr.color = GetColor();
    }

    protected void SetColor(Color c)
    {
        sr.color = c;
    }

    protected abstract void PerformAction();

    protected abstract Color GetColor();

    public void SetPoolTag(string poolTag)
    {
        this.poolTag = poolTag;
    }

    public void OnMouseClick()
    {
        PerformAction();
    }
}
