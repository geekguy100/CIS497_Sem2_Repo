/*****************************************************************************
// File Name :         UIManager.cs
// Author :            Kyle Grenier
// Creation Date :     03/07/2021
//
// Brief Description : Handles updating UI.
*****************************************************************************/
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [Header("Weapon Stats")]
    [SerializeField] private TextMeshProUGUI weaponNameText;
    [SerializeField] private TextMeshProUGUI weaponRaceText;
    [SerializeField] private TextMeshProUGUI weaponDamageText;
    [SerializeField] private TextMeshProUGUI weaponDurabilityText;

    [Header("Player Log")]
    [SerializeField] private TextMeshProUGUI playerLogText;

    private void OnEnable()
    {
        EventManager.OnWeaponCreated += UpdateUI;
        EventManager.OnWeaponCreated += (Weapon weapon) => { playerLogText.text = ""; };
        EventManager.OnWeaponRaceChanged += SetRace;
        EventManager.OnPlayerAttack += UpdatePlayerLog;
    }

    private void OnDisable()
    {
        EventManager.OnWeaponCreated -= UpdateUI;
        EventManager.OnWeaponRaceChanged -= SetRace;
        EventManager.OnPlayerAttack -= UpdatePlayerLog;
    }

    private void UpdateUI(Weapon weapon)
    {
        WeaponStats weaponStats = weapon.GetStats();
        weaponNameText.text = "Weapon Name: " + weaponStats.weaponName;
        weaponDamageText.text = "Weapon Damage: " + weaponStats.damage;
        weaponDurabilityText.text = "Weapon Durability: " + weaponStats.durability;
    }

    private void SetRace(WeaponRace weaponRace)
    {
        weaponRaceText.text = "Weapon Class: " + weaponRace.ToString();
    }

    private void UpdatePlayerLog(Weapon weapon)
    {
        playerLogText.text = weapon.Attack();
    }
}
