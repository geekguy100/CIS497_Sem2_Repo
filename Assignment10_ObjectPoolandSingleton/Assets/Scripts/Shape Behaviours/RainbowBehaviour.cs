/*****************************************************************************
// File Name :         RainbowBehaviour.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;
using System.Collections;

public class RainbowBehaviour : IShapeBehaviour
{
    private Color currentColor;

    protected override Color GetColor()
    {
        // This will set the inital color of the shape,
        // but we'll be controlling it through another method.
        return Color.white;
    }

    protected override void PerformAction()
    {
        if (currentColor == Color.red)
            ScoreManager.Instance.Score -= 1;
        else if (currentColor == Color.green)
            ScoreManager.Instance.Score += 3;
        else
            ScoreManager.Instance.Score += 2;
    }

    private void Start()
    {
        StartCoroutine(ChangeColor());
    }

    private IEnumerator ChangeColor()
    {
        while (true)
        {
            int num = Random.Range(1, 4);
            if (num == 1)
                currentColor = Color.red;
            else if (num == 2)
                currentColor = Color.green;
            else
                currentColor = Color.blue;

            SetColor(currentColor);
            yield return new WaitForSeconds(0.25f);
        }
    }
}