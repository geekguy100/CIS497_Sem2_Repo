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
    protected override void Awake()
    {
        base.Awake();
        ChangeColor(Color.red);
    }
}
