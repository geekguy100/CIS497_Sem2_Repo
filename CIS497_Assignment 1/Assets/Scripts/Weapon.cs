/*****************************************************************************
// File Name :         Weapon.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public abstract class Weapon : MonoBehaviour, IWeaponBehaviour
{
    [SerializeField]
    private string weaponName;
    public void setName(string name) { weaponName = name; }
    public string getName() { return weaponName; }

    private float damage;
    public void setDamage(float d) { damage = d; }
    public float getDamage() { return damage; }

    public abstract void useWeapon();

    void Awake()
    {
        if (weaponName == string.Empty)
            Debug.LogWarning("GameObject \'" + gameObject.name + "\' is missing a formal weapon name!");
    }

}