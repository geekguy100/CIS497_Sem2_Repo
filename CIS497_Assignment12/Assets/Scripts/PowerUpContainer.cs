/*****************************************************************************
// File Name :         PowerUpContainer.cs
// Author :            Kyle Grenier
// Creation Date :     05/02/2021
//
// Brief Description : A PowerUpContainer is a PowerUpComponent that holds other power ups.
*****************************************************************************/
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class PowerUpContainer : PowerUpComponent
{
    protected List<PowerUpComponent> powerUpComponents = new List<PowerUpComponent>();

    public override void Add(PowerUpComponent component)
    {
        powerUpComponents.Add(component);
    }

    public override void Remove<T>()
    {
        powerUpComponents.Remove(powerUpComponents.Where(t => t is T).FirstOrDefault());
    }

    public override void Activate(Character character)
    {
        foreach (PowerUpComponent c in powerUpComponents)
            c.Activate(character);
    }

    public override string GetName()
    {
        return "Power Up Container";
    }

}