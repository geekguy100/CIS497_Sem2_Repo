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
    [Header("Text Fields")]
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI manaText;
    [SerializeField] private TextMeshProUGUI strengthText;

    [Header("Popup")]
    [SerializeField] private Popup popup;

    [Header("Images")]
    [SerializeField] private GameObject heart;
    [SerializeField] private GameObject mana;
    [SerializeField] private GameObject strength;

    [Header("Children")]
    [SerializeField] private GameObject healthHolder;
    [SerializeField] private GameObject manaHolder;
    [SerializeField] private GameObject strengthHolder;

    public static UIManager instance;

    public void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void InstantiatePopUp(string valueName, float value)
    {
        Popup popupInstance = Instantiate(popup);
        popupInstance.Display(valueName + " +" + value);
    }


    public void UpdateStatsText(CharacterStats stats)
    {
        nameText.text = stats.name;
        healthText.text = "Health: " + stats.currentHealth + " / " + stats.maxHealth;
        manaText.text = "Mana: " + stats.currentMana + " / " + stats.maxMana;
        strengthText.text = "Strength: " + stats.currentStrength + " / " + stats.maxStrength;
    }

    public void AddHealthImage()
    {
        Instantiate(heart, healthHolder.transform);
    }

    public void AddManaImage()
    {
        Instantiate(mana, manaHolder.transform);
    }

    public void AddStrengthImage()
    {
        Instantiate(strength, strengthHolder.transform);
    }
}