/*****************************************************************************
// File Name :         HoverPadOnCommand.cs
// Author :            Kyle Grenier
// Creation Date :     03/21/2021
//
// Brief Description : A command that enables or disables the hover pad.
*****************************************************************************/

public class HoverPadOnCommand : ICommand
{
    private HoverPad hoverPad;
    private string description;

    public HoverPadOnCommand(HoverPad hoverPad)
    {
        this.hoverPad = hoverPad;
        description = "Hover Pad Off";
    }

    public void Execute()
    {
        hoverPad.Execute();

        if (hoverPad.Enabled)
            description = "Hover Pad On";
        else
            description = "Hover Pad Off";
    }

    public string GetDescription()
    {
        return description;
    }
}
