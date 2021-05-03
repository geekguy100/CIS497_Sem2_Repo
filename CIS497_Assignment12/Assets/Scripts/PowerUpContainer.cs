/*****************************************************************************
// File Name :         PowerUpContainer.cs
// Author :            Kyle Grenier
// Creation Date :     05/02/2021
//
// Brief Description : A PowerUpContainer is a PowerUpComponent that holds other power ups.
*****************************************************************************/
using UnityEngine;
using System.Collections.Generic;

public abstract class PowerUpContainer : PowerUpComponent
{
    protected List<PowerUpComponent> powerUpComponents = new List<PowerUpComponent>();

    public override void Add(PowerUpComponent component)
    {
        powerUpComponents.Add(component);
    }

    public override void Remove(PowerUpComponent component)
    {
        powerUpComponents.Remove(component);
    }
}