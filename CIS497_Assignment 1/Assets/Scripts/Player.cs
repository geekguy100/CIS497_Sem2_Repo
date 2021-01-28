/*****************************************************************************
// File Name :         Player.cs
// Author :            Kyle Grenier
// Creation Date :     1/28/2020
//
// Brief Description : Player functionality
*****************************************************************************/
using UnityEngine;

public class Player : Entity, IDamageable, IMoveable, ICanAttack
{
    public bool attack(IDamageable target, float damageDealt)
    {
        throw new System.NotImplementedException();
    }

    public override void die()
    {
        Debug.Log("Player died!");
        Destroy(gameObject);
    }

    public void moveTowards(Entity target)
    {
        throw new System.NotImplementedException();
    }

    public void moveTowards(Vector3 destination)
    {
        throw new System.NotImplementedException();
    }

    public void takeDamage(float amnt)
    {
        throw new System.NotImplementedException();
    }
}