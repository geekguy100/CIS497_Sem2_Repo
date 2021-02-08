/*****************************************************************************
// File Name :         PlayerHealthManager.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : Manages setting up the player's health.
*****************************************************************************/
using UnityEngine;

[RequireComponent(typeof(Health))]
public class PlayerHealthManager : MonoBehaviour
{
    private Health playerHealth;
    [SerializeField] private float health = 1f;

    private void Awake()
    {
        playerHealth = GetComponent<Health>();
        playerHealth.OnDeath += FindObjectOfType<GameManager>().GameOver;
    }

    private void Start()
    {
        playerHealth.Setup(health);
    }
}
