/*****************************************************************************
// File Name :         RedCoin.cs
// Author :            Kyle Grenier
// Creation Date :     02/26/2021
//
// Brief Description : Behvaiour for the Red Coin.
*****************************************************************************/

public sealed class RedCoin : Coin
{
    protected override void Awake()
    {
        base.Awake();
        worth = 10;
    }
}
