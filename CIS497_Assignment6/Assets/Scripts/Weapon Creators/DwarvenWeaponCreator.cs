/*****************************************************************************
// File Name :         DwarvenWeaponCreator.cs
// Author :            Kyle Grenier
// Creation Date :     03/07/2021
//
// Brief Description : Creates dwarven weapons with stats of an dwarven weapon.
*****************************************************************************/
using UnityEngine;

public class DwarvenWeaponCreator : WeaponCreator
{
    public override GameObject CreateWeaponPrefab(WeaponType weaponType)
    {
        GameObject prefab = Resources.Load("Weapons/Dwarven/" + weaponType.ToString()) as GameObject;
        if (prefab == null)
        {
            Debug.LogWarning("DwarvenWeaponCreator: could not load from resources.");
            return null;
        }

        Weapon weapon = prefab.GetComponent<Weapon>();

        switch (weaponType)
        {
            case WeaponType.Axe:
                weapon.Init(durability: 100f, damage: 55f, WeaponRace.Dwarven);
                break;
            case WeaponType.Sword:
                weapon.Init(durability: 100f, damage: 20f, WeaponRace.Dwarven);
                break;
            case WeaponType.Bow:
                weapon.Init(durability: 100f, damage: 10f, WeaponRace.Dwarven);
                break;
            case WeaponType.Staff:
                weapon.Init(durability: 100f, damage: 30f, WeaponRace.Dwarven);
                break;
            default:
                Debug.LogWarning("DwarvenWeaponCreator: invalid WeaponType passed. Returning null...");
                return null;
        }

        return prefab;
    }
}
