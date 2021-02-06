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
    private WeaponBehaviour weaponBehaviour;
    [SerializeField] private float laserDistance = 100f;

    private void Awake()
    {
        weaponBehaviour = GetComponent<WeaponBehaviour>();

        //If the weapon does not have a WeaponBehaviour already attached, add the RedWeapon as a default.
        if (weaponBehaviour == null)
            SwapBehaviour(typeof(RedWeapon));
    }

    /// <summary>
    /// Swaps the weapons behaviour to the given type. Must be of type WeaponBehaviour.
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
        weaponBehaviour.SetLaserDistance(laserDistance);
    }

    /// <summary>
    /// Fires the current WeaponBehaviour's laser.
    /// </summary>
    public void Fire()
    {
        weaponBehaviour.Fire();
    }
}
