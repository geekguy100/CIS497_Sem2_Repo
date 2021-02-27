/*****************************************************************************
// File Name :         YellowCoin.cs
// Author :            Kyle Grenier
// Creation Date :     02/26/2021
//
// Brief Description : Behvaiour for the Yellow Coin.
*****************************************************************************/

public sealed class YellowCoin : Coin
{
    protected override void Awake()
    {
        base.Awake();
        worth = 5;
    }
}
