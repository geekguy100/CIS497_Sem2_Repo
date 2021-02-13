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
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        spriteRenderer.color = new Color(r, g, b);
    }
}
