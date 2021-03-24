/*****************************************************************************
// File Name :         LightOnCommand.cs
// Author :            Kyle Grenier
// Creation Date :     03/21/2021
//
// Brief Description : A command that turns a light on and off.
*****************************************************************************/
using UnityEngine;

public class LightOnCommand : ICommand
{
    private Light light;
    private string description;

    public LightOnCommand(Light light)
    {
        this.light = light;
        description = "Light On";
    }

    /// <summary>
    /// Turns the light on or off.
    /// </summary>
    public void Execute()
    {
        light.enabled = true;
        description = "Light On";
    }

    public void Undo()
    {
        light.enabled = false;
        description = "Light Off";
    }

    public string GetDescription()
    {
        return description;
    }

}
