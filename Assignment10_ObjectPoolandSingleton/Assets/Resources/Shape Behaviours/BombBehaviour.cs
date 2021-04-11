/*****************************************************************************
// File Name :         BombBehaviour.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public class BombBehaviour : IShapeBehaviour
{
    protected override void PerformAction()
    {
        print("Clicked on da bomb!");
    }

    protected override Color GetColor()
    {
        return Color.black;
    }
}
