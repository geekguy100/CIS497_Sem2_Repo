/*****************************************************************************
// File Name :         HealthPowerUp.cs
// Author :            Kyle Grenier
// Creation Date :     05/02/2021
//
// Brief Description : A powerup that increases the character's max health.
*****************************************************************************/
using UnityEngine;

public class HealthPowerUp : PowerUpComponent
{
    private float healthIncrease;

    public HealthPowerUp(float healthIncrease)
    {
        this.healthIncrease = healthIncrease;
    }

    public override void Activate(Character character)
    {
        character.ModifyMaxHealth(healthIncrease);
    }

    public override string GetName()
    {
        return "Health Powerup " + healthIncrease;
    }
}
