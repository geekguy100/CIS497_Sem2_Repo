/*****************************************************************************
// File Name :         Circle.cs
// Author :            Kyle Grenier
// Creation Date :     04/17/2021
//
// Brief Description : A circle that is expands and shrinks in an appealing fashion.
*****************************************************************************/
using System.Collections;
using UnityEngine;

public class Circle : IShape
{
    [SerializeField] private Circle circleChild;
    [SerializeField] private float fillTime;
    private float currentFillTime;

    private bool finishedSizeChange = false;

    private Vector3 initialScale;

    protected override void Awake()
    {
        base.Awake();
        initialScale = transform.localScale;
    }

    protected override IEnumerator DrawEnumerator()
    {
        if (circleChild == null)
        {
            Debug.Log("Cannot draw this circle since it has no child!");
            yield break;
        }

        while (true)
        {
            // Display the child on top and expand it.
            circleChild.SetScale(Vector3.zero);
            circleChild.SetSortingOrder(1);
            StartCoroutine(circleChild.Expand(initialScale));

            while (!circleChild.finishedSizeChange)
                yield return null;

            // Put the child back below the parent.
            circleChild.SetSortingOrder(0);

            // Put the parent on top and shrink it.
            transform.localScale = Vector3.zero;
            SetSortingOrder(1);
            StartCoroutine(Expand(initialScale));

            while (!finishedSizeChange)
                yield return null;

            // Set the parent back below the child.
            SetSortingOrder(0);

            yield return null;
        }
    }

    private IEnumerator Expand(Vector3 finalScale)
    {
        finishedSizeChange = false;

        currentFillTime = 0f;
        Vector3 initialScale = transform.localScale;

        while (currentFillTime < fillTime)
        {
            currentFillTime += Time.deltaTime;
            transform.localScale = Vector3.Lerp(initialScale, finalScale, currentFillTime / fillTime);
            yield return null;
        }

        finishedSizeChange = true;
    }

    private void SetScale(Vector3 localScale)
    {
        transform.localScale = localScale;
    }

    private void SetSortingOrder(int sortingOrder)
    {
        spriteRenderer.sortingOrder = sortingOrder;
    }
}
