/*****************************************************************************
// File Name :         CropList.cs
// Author :            Kyle Grenier
// Creation Date :     02/19/2021
//
// Brief Description : Manages adding crops to the on-screen list.
*****************************************************************************/
using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class CropList : MonoBehaviour
{
    [Tooltip("The GameObject holding the item text.")]
    [SerializeField] private GameObject itemText;

    // The crops currently stored on the list.
    private List<CropItem> crops;

    // All of the item texts we have created.
    // Used in parallel with the crops list.
    private List<TextMeshProUGUI> itemTextList;


    /// <summary>
    /// CropItem class used to store data on crops on the list.
    /// </summary>
    private class CropItem
    {
        public CropItem(string name)
        {
            this.name = name;
            count = 1;
        }

        public string name;
        public int count;
    }



    private void Awake()
    {
        crops = new List<CropItem>();

        itemTextList = new List<TextMeshProUGUI>();
        itemTextList.Add(itemText.GetComponent<TextMeshProUGUI>());
    }

    /// <summary>
    /// Adds an item to the list.
    /// </summary>
    /// <typeparam name="T">The type of crop to add. T must subclass FarmTile.</typeparam>
    public void AddToList<T>()
    {
        if (!typeof(T).IsSubclassOf(typeof(FarmLand)))
        {
            Debug.Log("Cannot add crop of type " + typeof(T) + " to list.");
            return;
        }

        // Check to see if we already have this specific type of crop on the list.
        // If so, update that text.
        for (int i = 0; i < crops.Count; ++i)
        {
            // We found a matching type already on the list, so let's update that text!
            if (string.Compare(crops[i].name, typeof(T).ToString()) == 0)
            {
                ++crops[i].count;
                itemTextList[i].text = crops[i].name + " x" + crops[i].count;
                return;
            }

        }

        // If we get to this point, it means we are trying to add a new type of crop to the list.
        CropItem crop = new CropItem(typeof(T).ToString());
        crops.Add(crop);

        // Changing the name so we don't get a bunch of (Clone) concatenations in the Hierarchy.
        itemText.name = crop.name;

        // Clone the blank text GameObject for later use,
        // then update the text in the current itemText.
        GameObject temp = Instantiate(itemText, transform);

        // Set the text to the crop's name.
        itemText.GetComponent<TextMeshProUGUI>().text = crop.name;

        // Set the itemText field we've been referencing to temp so we start with a 
        // clean slate for the next crop.
        itemText = temp;

        // Add the newly instantiated itemText to the list so we can update
        // crop counts properly.
        itemTextList.Add(itemText.GetComponent<TextMeshProUGUI>());
    }
}
