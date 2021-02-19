/*****************************************************************************
// File Name :         FarmTileDecorator.cs
// Author :            Kyle Grenier
// Creation Date :     02/28/2021
//
// Brief Description : Decorator class for a FarmTile.
*****************************************************************************/
using UnityEngine;

public abstract class FarmLandDecorator : FarmLand
{
    public FarmLandDecorator(Vector3 minBoundary, Vector3 maxBoundary) : base(minBoundary, maxBoundary)
    {
    }

    public override abstract string GetDescription();
    public abstract override void AddCrop(GameObject crop);
}
