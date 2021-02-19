/*****************************************************************************
// File Name :         TomatoTile.cs
// Author :            Kyle Grenier
// Creation Date :     02/18/2021
//
// Brief Description : Farmland that contains a tomato.
*****************************************************************************/
using UnityEngine;

public class Tomato : FarmLandDecorator
{
    public FarmLand tile;

    public Tomato(FarmLand tile) : base(tile.GetBoundaries()[0], tile.GetBoundaries()[1])
    {
        this.tile = tile;
        GameObject prefab = Resources.Load("Tomato") as GameObject;

        AddCrop(prefab);
    }

    /// <summary>
    /// Returns the tile's description.
    /// </summary>
    /// <returns>The tile's description.</returns>
    public override string GetDescription()
    {
        return tile.GetDescription() + "Tomato, ";
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