/*****************************************************************************
// File Name :         PumpkinTile.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : Farmland that contains a pumpkin.
*****************************************************************************/
using UnityEngine;

public class Pumpkin : FarmLandDecorator
{
    public FarmLand tile;

    public Pumpkin(FarmLand tile) : base(tile.GetBoundaries()[0], tile.GetBoundaries()[1])
    {
        this.tile = tile;
        GameObject prefab = Resources.Load("Pumpkin") as GameObject;

        AddCrop(prefab);
    }

    /// <summary>
    /// Returns the tile's description.
    /// </summary>
    /// <returns>The tile's description.</returns>
    public override string GetDescription()
    {
        return tile.GetDescription() + "Pumpkin, ";
    }

    /// <summary>
    /// Instantiates a crop prefab onto the farm.
    /// </summary>
    /// <param name="crop">The crop prefab to instantiate.</param>
    public override void AddCrop(GameObject crop)
    {
        tile.AddCrop(crop);
    }
}