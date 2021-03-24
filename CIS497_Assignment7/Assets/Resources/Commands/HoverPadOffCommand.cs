/*****************************************************************************
// File Name :         HoverPadOffCommand.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public class HoverPadOffCommand : ICommand
{
    private HoverPad hoverPad;
    private string descrption;

    public HoverPadOffCommand(HoverPad hoverPad)
    {
        this.hoverPad = hoverPad;
        descrption = "Hover Pad Off";
    }

    public void Execute()
    {
        hoverPad.TurnOff();
        descrption = "Hover Pad Off";
    }

    public void Undo()
    {
        hoverPad.TurnOn();
        descrption = "Hover Pad On";
    }

    public string GetDescription()
    {
        return descrption;
    }
}
