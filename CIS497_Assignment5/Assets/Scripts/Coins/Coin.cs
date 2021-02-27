/*****************************************************************************
// File Name :         Coin.cs
// Author :            Kyle Grenier
// Creation Date :     02/26/2021
//
// Brief Description : Coin functionality.
*****************************************************************************/
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public abstract class Coin : MonoBehaviour
{
    // How many points this coin worth collecting.
    protected int worth = 0;

    private Rigidbody rb;

    [Tooltip("How much inital upward force should be applied on spawn.")]
    [SerializeField] private float upwardForce;

    protected virtual void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    protected virtual void Start()
    {
        rb.AddForce(transform.up * upwardForce, ForceMode.Impulse);
        PlayerStats.Score += worth;
    }
}
