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

    protected void OnMouseDown()
    {
        PerformAction();
        ObjectPooler.Instance.ReturnObjectToPool(poolTag, gameObject);
    }

    protected abstract void PerformAction();

    protected abstract Color GetColor();

    public void SetPoolTag(string poolTag)
    {
        this.poolTag = poolTag;
    }
}
