/*****************************************************************************
// File Name :         TileBackground.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : Tiles a background sprite by gradually increasing it's SpriteRendere's tiled width over time.
*****************************************************************************/
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class TileBackground : MonoBehaviour
{
    [SerializeField] private float tileSpeed = 2f;
    private SpriteRenderer spriteRenderer;

    private Vector3 startPos;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        Vector2 size = spriteRenderer.size;
        size.x += tileSpeed * Time.deltaTime;

        spriteRenderer.size = size;
    }
}
