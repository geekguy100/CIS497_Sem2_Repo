/*****************************************************************************
// File Name :         WeaponSpawner.cs
// Author :            Kyle Grenier
// Creation Date :     03/07/2021
//
// Brief Description : Spawns in weapons based on player input.
*****************************************************************************/
using UnityEngine;

public class WeaponSpawner : MonoBehaviour
{
    private WeaponRace weaponRace;
    private WeaponCreator weaponCreator;

    private void Awake()
    {
        weaponRace = WeaponRace.Elvish;
        weaponCreator = new ElvishWeaponCreator();

        // Call this to update race UI.
        EventManager.WeaponRaceChanged(weaponRace);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
            SwapWeaponRace();
        else if (Input.GetKeyDown(KeyCode.Alpha1))
            Instantiate(weaponCreator.CreateWeaponPrefab(WeaponType.Sword));
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            Instantiate(weaponCreator.CreateWeaponPrefab(WeaponType.Bow));
    }

    private void SwapWeaponRace()
    {
        ++weaponRace;
        // If we can't increment the weapon race anymore, set it back to 1.
        if ((int)weaponRace > System.Enum.GetValues(typeof(WeaponRace)).Length - 1)
        {
            weaponRace = (WeaponRace) 1;
        }

        // Update the weapon creator to the appropriate type.
        switch(weaponRace)
        {
            case WeaponRace.Elvish:
                weaponCreator = new ElvishWeaponCreator();
                break;
            case WeaponRace.Dwarven:
                weaponCreator = new DwarvenWeaponCreator();
                break;
        }

        EventManager.WeaponRaceChanged(weaponRace);
    }
}