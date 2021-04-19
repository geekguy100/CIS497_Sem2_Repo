/*****************************************************************************
// File Name :         Square.cs
// Author :            Kyle Grenier
// Creation Date :     04/17/2021
//
// Brief Description : A square whose color lerps between the colors of the rainbow.
*****************************************************************************/
using System.Collections;
using UnityEngine;

public class Square : IShape
{
    [SerializeField] private float lerpTime;
    private float currentTime;

    [SerializeField] private Color[] colors;
    private Color initialColor;

    protected override void Awake()
    {
        base.Awake();
        initialColor = spriteRenderer.color;
    }

    protected override IEnumerator DrawEnumerator()
    {
        int index = -1;

        while (true)
        {
            currentTime = 0f;
            Color currentColor = spriteRenderer.color;

            ++index;
            if (index >= colors.Length)
                index = 0;

            Color nextColor = colors[index];

            while (currentTime < lerpTime)
            {
                currentTime += Time.deltaTime;
                spriteRenderer.color = Color.Lerp(currentColor, nextColor, currentTime / lerpTime);
                yield return null;
            }

            yield return null;
        }
    }
}
