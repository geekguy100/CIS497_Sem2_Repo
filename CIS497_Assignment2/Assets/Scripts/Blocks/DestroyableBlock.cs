/*****************************************************************************
// File Name :         DestroyableBlock.cs
// Author :            Kyle Grenier
// Creation Date :     02/05/2021
//
// Brief Description : Base class for the game's destroyable blocks.
*****************************************************************************/
using UnityEngine;
using TMPro;

public abstract class DestroyableBlock : Obstacle
{
    private float hitPoints;

    private SpriteRenderer spriteRenderer;

    private TextMeshProUGUI hpText;
    private float hpDecreaseMultiplier = 5f; //Increases the speed of HP reduction upon taking damage.




    protected virtual void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        hpText = GetComponentInChildren<TextMeshProUGUI>();
    }

    protected override void Start()
    {
        base.Start();
        hitPoints = Random.Range(20, 141);
        UpdateHPText();
    }

    /// <summary>
    /// Decrease block's hitpoints by d * Time.deltaTime.
    /// </summary>
    /// <param name="d">The damage done to the block.</param>
    public void TakeDamage(int d)
    {
        hitPoints -= d * Time.deltaTime * hpDecreaseMultiplier;
        UpdateHPText();

        if (hitPoints < 0)
            Destroy(gameObject);
    }

    /// <summary>
    /// Sets the block's HP text to its current hp.
    /// </summary>
    private void UpdateHPText()
    {
        hpText.text = Mathf.FloorToInt(hitPoints).ToString();
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
