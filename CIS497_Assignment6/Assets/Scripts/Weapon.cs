/*****************************************************************************
// File Name :         Weapon.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public struct WeaponData
{
    private string weaponName;
    private float durability;
    private float damage;
    private WeaponRace weaponRace;
    private WeaponType weaponType;

    public WeaponData(string weaponName, float durability, float damage, WeaponRace weaponRace, WeaponType weaponType)
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
    private string weaponName;
    private float durability;
    private float damage;
    private WeaponRace weaponRace;
    protected WeaponType weaponType;

    private void Awake()
    {
        weaponName = "Undefined Weapon";
        durability = 0;
        damage = 0;
        weaponRace = WeaponRace.UNDEFINED;
        weaponType = WeaponType.UNDEFINED;
    }

    public void Init(float durability, float damage, WeaponRace weaponRace)
    {
        this.durability = durability;
        this.damage = damage;
        this.weaponRace = weaponRace;
        this.weaponName = this.weaponRace.ToString() + " " + this.weaponType.ToString();
    }

    public WeaponData GetData()
    {
        return new WeaponData(weaponName, durability, damage, weaponRace, weaponType);
    }
}