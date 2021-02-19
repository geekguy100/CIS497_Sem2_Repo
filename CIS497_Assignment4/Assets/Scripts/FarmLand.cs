/*****************************************************************************
// File Name :         FarmLand.cs
// Author :            Kyle Grenier
// Creation Date :     02/19/2021
//
// Brief Description : A class to handle creating farm tiles.
*****************************************************************************/
using UnityEngine;

public class FarmLand
{
    private Vector3 minBoundary;
    private Vector3 maxBoundary;

    public FarmLand(Vector3 minBoundary, Vector3 maxBoundary)
    {
        this.minBoundary = minBoundary;
        this.maxBoundary = maxBoundary;
    }

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
        return "Farm tile with ";
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
