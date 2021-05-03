/*****************************************************************************
// File Name :         AllStatIncrease.cs
// Author :            Kyle Grenier
// Creation Date :     05/02/2021
//
// Brief Description : A composite powerup that is a collection of the Health, Mana, and Strength powerups.
*****************************************************************************/
using UnityEngine;

public class AllStatIncrease : PowerUpContainer
{
    public AllStatIncrease(float healthIncrease, float manaIncrease, float strengthIncrease)
    {
        Add(new HealthPowerUp(healthIncrease));
        Add(new ManaPowerUp(manaIncrease));
        Add(new StrengthPowerUp(strengthIncrease));
    }

    public override string GetName()
    {
        string result = string.Empty;
        foreach(PowerUpComponent c in powerUpComponents)
        {
            result += c.ToString() + "\n";
        }

        return result;
    }

    public override void Activate(Character character)
    {
        foreach (PowerUpComponent c in powerUpComponents)
            c.Activate(character);
    }

    public override void Remove<T>()
    {
        base.Remove<T>();
    }
}