/*****************************************************************************
// File Name :         SimpleCoinFactory.cs
// Author :            Kyle Grenier
// Creation Date :     02/26/2021
//
// Brief Description : A simple coin factory that returns the prefab of the given coin type.
*****************************************************************************/
using UnityEngine;

public class SimpleCoinFactory
{
    public enum CoinType { YELLOW, RED }

    /// <summary>
    /// Get the prefab of the coin to spawn.
    /// </summary>
    /// <param name="coinType">The type of coin to get.</param>
    /// <returns>The coin prefab.</returns>
    public GameObject CreateCoin(CoinType coinType)
    {
        switch (coinType)
        {
            case CoinType.YELLOW:
                return Resources.Load("Prefabs/Yellow Coin") as GameObject;
            case CoinType.RED:
                return Resources.Load("Prefabs/Red Coin") as GameObject;
            default:
                return null;
        }
    }

    /// <summary>
    /// Gets the color of a type of coin.
    /// </summary>
    /// <param name="coinType">The type of coin to get the color of.</param>
    /// <returns>The color of a type of coin.</returns>
    public Color GetColor(CoinType coinType)
    {
        switch (coinType)
        {
            case CoinType.YELLOW:
                return Color.yellow;
            case CoinType.RED:
                return Color.red;
            default:
                return Color.white;
        }
    }
}