/*****************************************************************************
// File Name :         Bow.cs
// Author :            Kyle Grenier
// Creation Date :     03/07/2021
//
// Brief Description : Defines a bow.
*****************************************************************************/
public class Bow : Weapon
{
    public override string Attack()
    {
        return "Player shoots " + WeaponStats.weaponName;
    }
}
