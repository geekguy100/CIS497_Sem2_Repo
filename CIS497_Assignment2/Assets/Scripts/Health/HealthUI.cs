/*****************************************************************************
// File Name :         HealthUI.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : Adds UI behaviour to an object's Health component.
*****************************************************************************/
using UnityEngine;
using TMPro;

public class HealthUI : MonoBehaviour
{
    [SerializeField] private Health health;
    [SerializeField] private TextMeshProUGUI healthText;

    private void Awake()
    {
        if (health == null)
        {
            Debug.LogWarning(gameObject.name + " has no Health script to reference for HealthUI!");
            return;
        }

        health.OnHealthChange += UpdateText;
    }

    private void OnDestroy()
    {
        if (health != null)
            health.OnHealthChange -= UpdateText;
    }

    void UpdateText(float h)
    {
        healthText.text = Mathf.FloorToInt(h).ToString();
    }
}
