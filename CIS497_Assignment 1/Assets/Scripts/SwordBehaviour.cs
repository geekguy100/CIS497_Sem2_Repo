/*****************************************************************************
// File Name :         SwordBehaviour.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public class SwordBehaviour : MeleeWeapon
{
    public override void useWeapon()
    {
        Debug.Log("Used sword!");
    }
}