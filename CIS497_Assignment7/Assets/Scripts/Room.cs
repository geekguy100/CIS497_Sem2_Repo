/*****************************************************************************
// File Name :         Room.cs
// Author :            Kyle Grenier
// Creation Date :     03/22/2021
//
// Brief Description : Stores all of the objects that are used in the current level.
*****************************************************************************/
using UnityEngine;

public class Room : MonoBehaviour
{
    [SerializeField] private new Light light;
    [SerializeField] private HoverPad hoverPad;

    public Light GetLight()
    {
        return light;
    }

    public HoverPad GetHoverPad()
    {
        return hoverPad;
    }
}
