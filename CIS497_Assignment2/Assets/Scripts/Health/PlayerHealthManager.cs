/*****************************************************************************
// File Name :         PlayerHealthManager.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
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
    }

    private void Start()
    {
        playerHealth.Setup(health);
    }
}
