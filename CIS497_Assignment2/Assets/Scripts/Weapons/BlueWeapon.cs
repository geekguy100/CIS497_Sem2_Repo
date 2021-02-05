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
    protected override void Awake()
    {
        base.Awake();
        ChangeColor(Color.blue);
    }
}
