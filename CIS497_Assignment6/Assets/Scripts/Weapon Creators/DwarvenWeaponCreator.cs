/*****************************************************************************
// File Name :         DwarvenWeaponCreator.cs
// Author :            Kyle Grenier
// Creation Date :     03/07/2021
//
// Brief Description : Creates dwarven weapons with stats of a dwarven weapon.
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
            case WeaponType.Sword:
                weapon.Init(weaponType: weaponType, durability: 96f, damage: 23f, WeaponRace.Dwarven);
                break;
            case WeaponType.Bow:
                weapon.Init(weaponType: weaponType, durability: 60f, damage: 10f, WeaponRace.Dwarven);
                break;
            default:
                Debug.LogWarning("DwarvenWeaponCreator: invalid WeaponType passed. Returning null...");
                return null;
        }

        EventManager.WeaponCreated(weapon);
        return prefab;
    }
}
