/*****************************************************************************
// File Name :         StrengthPowerUp.cs
// Author :            Kyle Grenier
// Creation Date :     05/02/2021
//
// Brief Description : Increases the character's max strength.
*****************************************************************************/
using UnityEngine;

public class StrengthPowerUp : PowerUpComponent
{
    private float strengthIncrease;

    public StrengthPowerUp(float strengthIncrease)
    {
        this.strengthIncrease = strengthIncrease;
    }

    public override string GetName()
    {
        return "Strength Increase " + strengthIncrease;
    }

    public override void Activate(Character character)
    {
        character.ModifyMaxStrength(strengthIncrease);
    }
}
