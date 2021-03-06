/*****************************************************************************
// File Name :         RedWeapon.cs
// Author :            Kyle Grenier
// Creation Date :     02/03/2021
//
// Brief Description : Defines behaviour for the red weapon.
*****************************************************************************/
using System;
using UnityEngine;

public class RedWeapon : WeaponBehaviour
{
    protected override void Awake()
    {
        base.Awake();
        ChangeColor(Color.red);
    }

    public override void Fire(System.Type b)
    {
        base.Fire(typeof(RedBlock));
    }
}
