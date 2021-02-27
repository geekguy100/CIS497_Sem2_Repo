/*****************************************************************************
// File Name :         CoinSpin.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public sealed class CoinSpin : MonoBehaviour
{
    [Tooltip("The rotation speed of the coin.")]
    [SerializeField] private float rotationSpeed;

    private void Update()
    {
        transform.Rotate(transform.up * rotationSpeed * Time.deltaTime);
    }
}
