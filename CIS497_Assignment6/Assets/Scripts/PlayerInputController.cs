/*****************************************************************************
// File Name :         PlayerInputController.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInputController : MonoBehaviour
{
    private Weapon weapon;

    private void OnEnable()
    {
        EventManager.OnWeaponCreated += EquipWeapon;
    }

    private void EquipWeapon(Weapon weapon)
    {
        this.weapon = weapon;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (weapon != null)
                EventManager.PlayerAttack(weapon);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
