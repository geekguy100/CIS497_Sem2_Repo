/*****************************************************************************
// File Name :         PlayerWeaponHandler.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : Script that handles changing player input for weapons.
*****************************************************************************/
using UnityEngine;

public class PlayerWeaponHandler : MonoBehaviour
{
    private Weapon weapon;

    private void Awake()
    {
        weapon = GetComponentInChildren<Weapon>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
            weapon.SwapBehaviour(typeof(RedWeapon));
        else if (Input.GetKeyDown(KeyCode.X))
            weapon.SwapBehaviour(typeof(BlueWeapon));
        else if (Input.GetButtonDown("Jump"))
            weapon.Fire();
    }
}
