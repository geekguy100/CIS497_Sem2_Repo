/*****************************************************************************
// File Name :         RedWeapon.cs
// Author :            Kyle Grenier
// Creation Date :     02/03/2021
//
// Brief Description : Defines behaviour for the red weapon.
*****************************************************************************/
using UnityEngine;

public class RedWeapon : WeaponBehaviour
{
    /// <summary>
    /// Changes the weapon to the red weapon.
    /// </summary>
    protected override void ChangeColor()
    {
        GetComponentInChildren<SpriteRenderer>().color = Color.red;
    }

    /// <summary>
    /// Shoots the red weapon.
    /// </summary>
    public override void Fire()
    {
        Debug.Log("Firing RED weapon!");
    }
}
