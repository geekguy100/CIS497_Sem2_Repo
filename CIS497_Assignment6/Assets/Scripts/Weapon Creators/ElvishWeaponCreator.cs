/*****************************************************************************
// File Name :         ElvishWeaponCreator.cs
// Author :            Kyle Grenier
// Creation Date :     03/07/2021
//
// Brief Description : Creates elvish weapons with stats of an elvish weapon.
*****************************************************************************/
using UnityEngine;

public class ElvishWeaponCreator : WeaponCreator
{
    public override GameObject CreateWeaponPrefab(WeaponType weaponType)
    {
        GameObject prefab = Resources.Load("Weapons/Elvish/" + weaponType.ToString()) as GameObject;
        if (prefab == null)
        {
            Debug.LogWarning("ElvishWeaponCreator: could not load from resources.");
            return null;
        }

        Weapon weapon = prefab.GetComponent<Weapon>();

        switch (weaponType)
        {
            case WeaponType.Sword:
                weapon.Init(weaponType: weaponType, durability: 20f, damage: 30f, WeaponRace.Elvish);
                break;
            case WeaponType.Bow:
                weapon.Init(weaponType: weaponType, durability: 100f, damage: 20f, WeaponRace.Elvish);
                break;
            default:
                Debug.LogWarning("ElvishWeaponCreator: invalid WeaponType passed. Returning null...");
                return null;     
        }

        EventManager.WeaponCreated(weapon);
        return prefab;
    }
}