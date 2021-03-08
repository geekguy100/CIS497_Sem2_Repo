/*****************************************************************************
// File Name :         Sword.cs
// Author :            Kyle Grenier
// Creation Date :     03/07/2021
//
// Brief Description : Defines a sword.
*****************************************************************************/
public class Sword : Weapon
{
    public override string Attack()
    {
        return "Player slashes " + WeaponStats.weaponName;
    }
}
