/*****************************************************************************
// File Name :         Weapon.cs
// Author :            Kyle Grenier
// Creation Date :     03/07/2021
//
// Brief Description : Defines functionality for a weapon.
*****************************************************************************/
using UnityEngine;

public struct WeaponStats
{
    public string weaponName { get; private set; }
    public float durability { get; private set; }
    public float damage { get; private set; }
    public WeaponRace weaponRace { get; private set; }
    public WeaponType weaponType { get; private set; }

    public WeaponStats(string weaponName, float durability, float damage, WeaponRace weaponRace, WeaponType weaponType)
    {
        this.weaponName = weaponName;
        this.durability = durability;
        this.damage = damage;
        this.weaponRace = weaponRace;
        this.weaponType = weaponType;
    }
}

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private string weaponName = "UNDEFINED";
    [SerializeField] private float durability = 0;
    [SerializeField] private float damage = 0;
    [SerializeField] private WeaponRace weaponRace = WeaponRace.UNDEFINED;
    [SerializeField] private WeaponType weaponType = WeaponType.UNDEFINED;

    public WeaponStats WeaponStats { get { return GetStats(); } }

    public void Init(WeaponType weaponType, float durability, float damage, WeaponRace weaponRace)
    {
        this.weaponType = weaponType;
        this.durability = durability;
        this.damage = damage;
        this.weaponRace = weaponRace;
        weaponName = this.weaponRace.ToString() + " " + weaponType.ToString();

        gameObject.name = weaponName;
    }

    public WeaponStats GetStats()
    {
        return new WeaponStats(weaponName, durability, damage, weaponRace, weaponType);
    }

    public abstract string Attack();
}