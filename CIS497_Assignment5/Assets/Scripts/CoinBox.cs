/*****************************************************************************
// File Name :         CoinBox.cs
// Author :            Kyle Grenier
// Creation Date :     02/26/2021
//
// Brief Description : Functionality for a coin box; spawns a coin when pressed.
*****************************************************************************/
using UnityEngine;

public class CoinBox : MonoBehaviour
{
    private SimpleCoinFactory coinFactory;

    [SerializeField] private SimpleCoinFactory.CoinType coinType;

    // The current color of the box.
    private Color currentColor;


    private void Awake()
    {
        coinFactory = new SimpleCoinFactory();
    }

    private void Start()
    {
        ChangeColor();
    }

    // Change the color of the coin box to match the color of the coin it spawns
    private void ChangeColor()
    {
        GetComponent<MeshRenderer>().material.color = coinFactory.GetColor(coinType);
    }

    /// <summary>
    /// Spawn a coin on mouse click.
    /// </summary>
    private void OnMouseDown()
    {
        SpawnCoin();
    }

    /// <summary>
    /// Spawns a coin above the box.
    /// </summary>
    private void SpawnCoin()
    {
        GameObject coin = coinFactory.CreateCoin(coinType);

        if (coin != null)
        {
            // This enables the box color to be changed at runtime!
            if (currentColor != coinFactory.GetColor(coinType))
                ChangeColor();

            Instantiate(coin, transform.position + transform.up * 2f, coin.transform.rotation);
        }
        else
            Debug.LogWarning(gameObject.name + ": Could not spawn coin of type " + coinType.ToString());
    }
}
