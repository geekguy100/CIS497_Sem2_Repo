/*****************************************************************************
// File Name :         BlueWeapon.cs
// Author :            Kyle Grenier
// Creation Date :     02/03/2021
//
// Brief Description : Defines behaviour for the blue weapon.
*****************************************************************************/
using UnityEngine;

public class BlueWeapon : WeaponBehaviour
{
    /// <summary>
    /// Changes the weapon to the blue weapon.
    /// </summary>
    protected override void ChangeColor()
    {
        GetComponentInChildren<SpriteRenderer>().color = Color.blue;
    }

    /// <summary>
    /// Shoots the blue laser.
    /// </summary>
    public override void Fire()
    {
        Debug.Log("Firing BLUE weapon!");
    }
}
