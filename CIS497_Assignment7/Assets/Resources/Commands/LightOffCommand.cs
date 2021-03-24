/*****************************************************************************
// File Name :         LightOffCommand.cs
// Author :            Kyle Grenier
// Creation Date :     03/23/2021
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public class LightOffCommand : ICommand
{
    private Light light;
    private string description;

    public LightOffCommand(Light light)
    {
        this.light = light;
        description = "Light Off";
    }

    public void Execute()
    {
        light.enabled = false;
        description = "Light Off";
    }

    public void Undo()
    {
        light.enabled = true;
        description = "Light On";
    }

    public string GetDescription()
    {
        return description;
    }
}
