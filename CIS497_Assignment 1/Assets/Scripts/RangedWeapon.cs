/*****************************************************************************
// File Name :         RangedWeapon.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public abstract class RangedWeapon : Weapon
{
    protected int maxAmmo;
    protected int currentAmmo;

    protected void reload()
    {
        if (currentAmmo < maxAmmo)
            currentAmmo = maxAmmo;

    }
}