/*****************************************************************************
// File Name :         Health.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : Health system that can be assigned HP and receive damage.
*****************************************************************************/
using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    private float hp;
    private float decreaseMultiplier;

    public delegate void HealthChangeHandler();
    public event HealthChangeHandler OnHealthChange;

    /// <summary>
    /// Sets up the object's Health with hp and a decrease multiplier.
    /// </summary>
    /// <param name="hp">Number of hitpoints the object has.</param>
    /// <param name="decreaseMultiplier">How much faster the health will decrease.</param>
    public void Setup(float hp, float decreaseMultiplier = 1f)
    {
        this.hp = hp;
        this.decreaseMultiplier = decreaseMultiplier;

        OnHealthChange?.Invoke();
    }

    public float GetHP()
    {
        return hp;
    }

    /// <summary>
    /// Decrease object's hitpoints by d * Time.deltaTime.
    /// </summary>
    /// <param name="d">The damage to inflict.</param>
    public void TakeDamage(float d)
    {
        hp -= d * Time.deltaTime * decreaseMultiplier;
        OnHealthChange?.Invoke();

        if (hp <= 0)
            Die();
    }

    /// <summary>
    /// Inflict damage over the course of a single frame.
    /// </summary>
    /// <param name="d">The damage to inflict.</param>
    public void TakeInstantDamage(float d)
    {
        hp -= d;
        OnHealthChange?.Invoke();

        if (hp <= 0)
            Die();
    }

    /// <summary>
    /// Destroy the game object.
    /// </summary>
    public void Die()
    {
        Destroy(gameObject);
    }
}
