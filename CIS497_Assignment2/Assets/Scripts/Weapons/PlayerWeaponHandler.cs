/*****************************************************************************
// File Name :         PlayerWeaponHandler.cs
// Author :            Kyle Grenier
// Creation Date :     02/04/2021
//
// Brief Description : Script that handles changing player's weapons based on input.
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
