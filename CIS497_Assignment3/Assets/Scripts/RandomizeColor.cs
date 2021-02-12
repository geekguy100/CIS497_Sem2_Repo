/*****************************************************************************
// File Name :         RandomizeColor.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : Get's the sprite renderer and assigns a random color.
*****************************************************************************/
using UnityEngine;

public class RandomizeColor : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        spriteRenderer.color = Random.ColorHSV(0, 1);
    }
}
