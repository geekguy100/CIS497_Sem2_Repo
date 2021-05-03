/*****************************************************************************
// File Name :         Character.cs
// Author :            Kyle Grenier
// Creation Date :     05/02/2021
//
// Brief Description : A basic character with health, mana, and strength attributes.
*****************************************************************************/
using UnityEngine;
using System;

[Serializable]
public struct CharacterStats
{
    public string name;

    public float maxHealth;
    [HideInInspector] public float currentHealth;

    public float maxMana;
    [HideInInspector] public float currentMana;

    public float maxStrength;
    [HideInInspector] public float currentStrength;

    public void Init()
    {
        currentHealth = maxHealth;
        currentMana = maxMana;
        currentStrength = maxStrength;
    }
}

public class Character : MonoBehaviour
{
    [SerializeField] private CharacterStats stats;
    public Action<CharacterStats> OnStatsChanged;

    private void Start()
    {
        stats.Init();
        OnStatsChanged?.Invoke(stats);
    }

    public void ModifyMaxHealth(float value)
    {
        stats.maxHealth += value;
        OnStatsChanged.Invoke(stats);
    }

    public void ModifyMaxMana(float value)
    {
        stats.maxMana += value;
        OnStatsChanged.Invoke(stats);
    }

    public void ModifyMaxStrength(float value)
    {
        stats.maxStrength += value;
        OnStatsChanged.Invoke(stats);
    }
}