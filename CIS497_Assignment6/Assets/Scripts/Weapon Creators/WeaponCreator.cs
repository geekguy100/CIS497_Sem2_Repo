/*****************************************************************************
// File Name :         WeaponCreator.cs
// Author :            Kyle Grenier
// Creation Date :     03/07/2021
//
// Brief Description : Abstract class for creating weapons.
*****************************************************************************/
using UnityEngine;

public abstract class WeaponCreator
{
    public abstract GameObject CreateWeaponPrefab(WeaponType weaponType);
}
