/*****************************************************************************
// File Name :         PowerUpManager.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : Manages adding, removing, and activating powerups from a character.
*****************************************************************************/
using UnityEngine;
using System.Collections.Generic;

public class PowerUpManager : MonoBehaviour
{
    private List<PowerUpComponent> powerUps;

    private void Awake()
    {
        powerUps = new List<PowerUpComponent>();
    }
}
