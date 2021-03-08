/*****************************************************************************
// File Name :         EventManager.cs
// Author :            Kyle Grenier
// Creation Date :     03/07/2021
//
// Brief Description : EventManager class to handle assigning and invoking global events.
*****************************************************************************/
using System;

public static class EventManager
{
    public static event Action<Weapon> OnWeaponCreated;
    public static event Action<WeaponRace> OnWeaponRaceChanged;
    public static event Action<Weapon> OnPlayerAttack;

    /// <summary>
    /// Invokes the OnWeaponCreated event.
    /// </summary>
    /// <param name="weapon">The stats of the weapon created.</param>
    public static void WeaponCreated(Weapon weapon)
    {
        OnWeaponCreated?.Invoke(weapon);
    }

    /// <summary>
    /// Invokes the OnWeaponRaceChanged event.
    /// </summary>
    /// <param name="weaponRace">The race of the weapon to be created.</param>
    public static void WeaponRaceChanged(WeaponRace weaponRace)
    {
        OnWeaponRaceChanged?.Invoke(weaponRace);
    }

    public static void PlayerAttack(Weapon weapon)
    {
        OnPlayerAttack?.Invoke(weapon);
    }
}
