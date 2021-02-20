/*****************************************************************************
// File Name :         Farm.cs
// Author :            Kyle Grenier
// Creation Date :     02/19/2021
//
// Brief Description : Manages creating crops on the farm and updating the crop list.
*****************************************************************************/
using UnityEngine;
using System;

public class Farm : MonoBehaviour
{
    [Tooltip("The list used to display all of the crops on the farm.")]
    [SerializeField] private CropList cropList;

    [Header("Boundaries of the Farm Enclosure")]
    [Tooltip("The minimum coordinates for spawning in crops. Y is ignored.")]
    [SerializeField] private Vector3 minBoundaries;

    [Tooltip("The maxmimum coordinates for spawning in crops. Y is ignored.")]
    [SerializeField] private Vector3 maxBoundaries;

    private FarmLand farmLand;

    private void Start()
    {
        farmLand = new WetFarmLand(minBoundaries, maxBoundaries);
        //farmLand = new DryFarmLand(minBoundaries, maxBoundaries);
    }

    /// <summary>
    /// Used to associate a particular keypress with 
    /// spawning a certain type of crop.
    /// </summary>
    private void OnGUI()
    {
        Event e = Event.current;
        if (e.type.Equals(EventType.KeyDown))
        {
            switch(e.keyCode)
            {
                case KeyCode.Alpha1:
                    AddCrop<Tomato>(farmLand);
                    break;
                case KeyCode.Alpha2:
                    AddCrop<Pumpkin>(farmLand);
                    break;
                case KeyCode.Alpha3:
                    AddCrop<Corn>(farmLand);
                    break;
                case KeyCode.Alpha4:
                    AddCrop<Eggplant>(farmLand);
                    break;
            }
        }
    }

    /// <summary>
    /// Adds a crop of type T to the farm and to the crop list.
    /// </summary>
    /// <typeparam name="T">The type of crop to add. T must subclass FarmTile.</typeparam>
    private void AddCrop<T>(FarmLand tile)
    {
        if (!typeof(T).IsSubclassOf(typeof(FarmLand)))
        {
            Debug.Log("Cannot add crop of type " + typeof(T));
            return;
        }

        farmLand = Activator.CreateInstance(typeof(T), tile) as FarmLand;
        cropList.AddToList<T>();

        Debug.Log(farmLand.GetDescription());
        Debug.Log("Crop Count: " + farmLand.GetCropCount());
    }
}