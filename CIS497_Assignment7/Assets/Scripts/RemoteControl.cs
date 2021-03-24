/*****************************************************************************
// File Name :         RemoteControl.cs
// Author :            Kyle Grenier
// Creation Date :     03/21/2021
//
// Brief Description : Behaviour for the remote control - executes commands via button presses.
*****************************************************************************/
using UnityEngine;

public class RemoteControl : MonoBehaviour
{
    private Button[] buttons;
    private Room room;

    private void Awake()
    {
        buttons = GetComponentsInChildren<Button>();
        room = FindObjectOfType<Room>();
    }

    private void Start()
    {
        for (int i = 0; i < buttons.Length; ++i)
        {
            NextCommand(i);
        }
    }

    /// <summary>
    /// Rotates the button's command to the next one in line.
    /// </summary>
    /// <param name="buttonIndex">The index of the button to update.</param>
    public void NextCommand(int buttonIndex)
    {
        int index = buttons[buttonIndex].GetCommandIndex();
        string commandName = CommandFactory.GetNextCommandName(ref index);

        // The argument that will be passed into the command.
        Object[] args = new Object[1];

        if (commandName.Contains("Light"))
            args[0] = room.GetLight();
        else if (commandName.Contains("HoverPad"))
            args[0] = room.GetHoverPad();
        else
            Debug.LogWarning("RemoteControl: arg is null! Command name improper??");

        ICommand command = CommandFactory.GetCommand(commandName, args);

        buttons[buttonIndex].UpdateCommand(command, index);
    }
}