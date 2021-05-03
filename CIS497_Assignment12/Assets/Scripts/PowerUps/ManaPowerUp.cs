/*****************************************************************************
// File Name :         ManaPowerUp.cs
// Author :            Kyle Grenier
// Creation Date :     05/02/2021
//
// Brief Description : Increases the character's max mana
*****************************************************************************/
using UnityEngine;

public class ManaPowerUp : PowerUpComponent
{
    private float manaIncrease;

    public ManaPowerUp(float manaIncrease)
    {
        this.manaIncrease = manaIncrease;
    }

    public override string GetName()
    {
        return "Mana Powerup " + manaIncrease;
    }

    public override void Activate(Character character)
    {
        character.ModifyMaxMana(manaIncrease);
    }
}
