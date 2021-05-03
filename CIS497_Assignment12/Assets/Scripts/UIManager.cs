/*****************************************************************************
// File Name :         UIManager.cs
// Author :            Kyle Grenier
// Creation Date :     05/03/2021
//
// Brief Description : Class to manage updating UI elements.
*****************************************************************************/
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI manaText;
    [SerializeField] private TextMeshProUGUI strengthText;

    private Character player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Character>();
    }

    private void OnEnable()
    {
        player.OnStatsChanged += UpdateStatsText;
    }

    private void OnDisable()
    {
        player.OnStatsChanged -= UpdateStatsText;
    }

    private void UpdateStatsText(CharacterStats stats)
    {
        nameText.text = stats.name;
        healthText.text = "Health: " + stats.currentHealth + " / " + stats.maxHealth;
        manaText.text = "Mana: " + stats.currentMana + " / " + stats.maxMana;
        strengthText.text = "Strength: " + stats.currentStrength + " / " + stats.maxStrength;
    }
}