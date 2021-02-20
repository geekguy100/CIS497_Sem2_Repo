/*****************************************************************************
// File Name :         CornTile.cs
// Author :            Kyle Grenier
// Creation Date :     02/19/2021
//
// Brief Description : Farmland that contains corn.
*****************************************************************************/
using UnityEngine;

public class Corn : FarmLandDecorator
{
    public FarmLand tile;

    public Corn(FarmLand tile) : base(tile.GetBoundaries()[0], tile.GetBoundaries()[1])
    {
        this.tile = tile;
        GameObject prefab = Resources.Load("Corn") as GameObject;

        AddCrop(prefab);
    }

    /// <summary>
    /// Returns the tile's description.
    /// </summary>
    /// <returns>The tile's description.</returns>
    public override string GetDescription()
    {
        return tile.GetDescription() + "Corn, ";
    }

    /// <summary>
    /// Instantiates a crop prefab onto the farm.
    /// </summary>
    /// <param name="crop">The crop prefab to instantiate.</param>
    public override void AddCrop(GameObject crop)
    {
        tile.AddCrop(crop);
    }

    public override int GetCropCount()
    {
        return tile.GetCropCount() + 1;
    }
}