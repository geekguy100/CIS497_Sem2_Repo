/*****************************************************************************
// File Name :         Weapon.cs
// Author :            Kyle Grenier
// Creation Date :     02/03/2021
//
// Brief Description : Defines behaviour for the physical weapon the player will be using.
*****************************************************************************/
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private WeaponBehaviour weaponBehaviour;

    private void Awake()
    {
        weaponBehaviour = GetComponent<WeaponBehaviour>();

        //If the weapon does not have a WeaponBehaviour already attached, add the RedWeapon as a default.
        if (weaponBehaviour == null)
            SwapBehaviour(typeof(RedWeapon));
    }

    /// <summary>
    /// Swaps the weapons behaviour to the given type.
    /// </summary>
    /// <param name="w">The type of WeaponBehaviour to swap to. Must be of type WeaponBehaviour.</param>
    public void SwapBehaviour(System.Type w)
    {
        //Log warning if an invalid type is passed through.
        if (w.BaseType != typeof(WeaponBehaviour))
        {
            Debug.LogWarning("Player weapon is trying to swap to an invalid type!");
            return;
        }

        //Destroy the pre-existing WeaponBehaviour (BlueWeapon, RedWeapon, etc.) and add the new one that was passed in.
        Destroy(GetComponent<WeaponBehaviour>());
        weaponBehaviour = gameObject.AddComponent(w) as WeaponBehaviour;
    }

    public void Fire()
    {
        weaponBehaviour.Fire();
    }
}
