/*****************************************************************************
// File Name :         ICanAttack.cs
// Author :            Kyle Grenier
// Creation Date :     1/28/21
//
// Brief Description : Interface for GameObjects that can attack.
*****************************************************************************/
public interface ICanAttack
{
    /// <summary>
    /// Attack a damageable target.
    /// </summary>
    /// <param name="target">The target to deal damage to.</param>
    /// <param name="damageDealt">The amount of damage to deal to the target.</param>
    void attack(IDamageable target, float damageDealt);
}