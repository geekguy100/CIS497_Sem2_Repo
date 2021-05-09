/*****************************************************************************
// File Name :         IDamageable.cs
// Author :            Kyle Grenier
// Creation Date :     1/28/2020
// CIS497 Assignment 1
// Brief Description : Interface for GameObject's that are damageable.
*****************************************************************************/

public interface IDamageable
{
    /// <summary>
    /// Take a specified amount of damage.
    /// </summary>
    /// <param name="amnt">The amount of damage to take.</param>
    void takeDamage(float amnt);

    float health { get; set; }
}