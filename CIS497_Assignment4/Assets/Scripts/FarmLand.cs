/*****************************************************************************
// File Name :         FarmLand.cs
// Author :            Kyle Grenier
// Creation Date :     02/19/2021
//
// Brief Description : A class to handle creating farm tiles.
*****************************************************************************/
using UnityEngine;

public abstract class FarmLand
{
    private Vector3 minBoundary;
    private Vector3 maxBoundary;

    protected string description;

    private int cropCount;

    /// <summary>
    /// FarmLand constructor requiring a min bounadry and max boundary.
    /// </summary>
    /// <param name="minBoundary">The minimum boundary of the farm.</param>
    /// <param name="maxBoundary">The maximum boundary of the farm.</param>
    public FarmLand(Vector3 minBoundary, Vector3 maxBoundary)
    {
        this.minBoundary = minBoundary;
        this.maxBoundary = maxBoundary;
        description = string.Empty;
        cropCount = 0;
    }

    /// <summary>
    /// How many crops are on the farm land.
    /// </summary>
    /// <returns>The number of crops on the farm land.</returns>
    public virtual int GetCropCount()
    {
        return cropCount;
    }

    /// <summary>
    /// Gets the min boundaries and max boundaries of the farm enclosure in that order.
    /// </summary>
    /// <returns>The min and max boundaries of the farm enclosure.</returns>
    public Vector3[] GetBoundaries()
    {
        Vector3[] array = new Vector3[] { minBoundary, maxBoundary};
        return array;
    }

    /// <summary>
    /// Get the farm tile's description.
    /// </summary>
    /// <returns>The farm tile's description.</returns>
    public virtual string GetDescription()
    {
        return description + " with ";
    }

    /// <summary>
    /// Instantiates a crop prefab onto the farm.
    /// </summary>
    /// <param name="crop">The crop prefab to instantiate.</param>
    public virtual void AddCrop(GameObject crop)
    {
        // Spawn the crop in a random location within the following set boundaries (the farm enclosure's boundaries).
        Vector3 pos = new Vector3(Random.Range(minBoundary.x,maxBoundary.x), 1, Random.Range(minBoundary.z,maxBoundary.z));
        Object.Instantiate(crop, pos, crop.transform.rotation);
    }
}
