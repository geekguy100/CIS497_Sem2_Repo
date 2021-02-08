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
        if (weapon == null)
            Debug.LogWarning("PlayerWeaponHandler has no weapon!");
    }

    private void Update()
    {
        if (weapon == null)
            return;

        if (Input.GetKeyDown(KeyCode.Z))
            weapon.SwapBehaviour(typeof(RedWeapon));
        else if (Input.GetKeyDown(KeyCode.X))
            weapon.SwapBehaviour(typeof(BlueWeapon));
        else if (Input.GetButton("Jump"))
            weapon.Fire();

        if (Input.GetButtonUp("Jump"))
            weapon.PowerOff();
    }
}
