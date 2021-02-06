/*****************************************************************************
// File Name :         DestroyableBlock.cs
// Author :            Kyle Grenier
// Creation Date :     02/05/2021
//
// Brief Description : Base class for the game's destroyable blocks.
*****************************************************************************/
using UnityEngine;

[RequireComponent(typeof(Health))]
[RequireComponent(typeof(SpriteRenderer))]
public abstract class DestroyableBlock : Obstacle
{
    [Header("DestroyableBlock fields")]
    [SerializeField] private float minHP = 20;
    [SerializeField] private float maxHP = 141;

    [Tooltip("Multiplier to adjust how much faster health should decrease when damage is inflicted.")]
    [SerializeField] private float decreaseMultiplier = 5f;

    private Health health;
    public Health BlockHealth { get { return health; } }

    private SpriteRenderer spriteRenderer;




    protected virtual void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        health = GetComponent<Health>();
    }

    protected override void Start()
    {
        base.Start();
        health.Setup((int)Random.Range(minHP, maxHP), decreaseMultiplier);
    }



    /// <summary>
    /// Changes the block's color.
    /// </summary>
    /// <param name="c">The color to change the block to.</param>
    protected void ChangeColor(Color c)
    {
        spriteRenderer.color = c;
    }
}
