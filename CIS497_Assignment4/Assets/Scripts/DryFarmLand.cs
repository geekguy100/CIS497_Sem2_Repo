/*****************************************************************************
// File Name :         DryFarmLand.cs
// Author :            Kyle Grenier
// Creation Date :     02/19/2021
//
// Brief Description : Defines a chunk of dry farmland.
*****************************************************************************/
using UnityEngine;

public class DryFarmLand : FarmLand
{
    public DryFarmLand(Vector3 minBoundary, Vector3 maxBoundary) : base(minBoundary, maxBoundary)
    {
        description = "Dry Farmland";
    }
}
