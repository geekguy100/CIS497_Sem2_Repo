/*****************************************************************************
// File Name :         WetFarmland.cs
// Author :            Kyle Grenier
// Creation Date :     02/19/2021
//
// Brief Description : Defines a chunk of wet farmland.
*****************************************************************************/
using UnityEngine;

public class WetFarmLand : FarmLand
{
    public WetFarmLand(Vector3 minBoundary, Vector3 maxBoundary) : base(minBoundary, maxBoundary)
    {
        description = "Wet Farmland";
    }
}
