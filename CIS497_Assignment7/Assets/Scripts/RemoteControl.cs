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
        foreach (Button b in buttons)
            b.UpdateCommand(new LightOnCommand(room.GetLight()));
    }

    public void UpdateCommand(int buttonIndex, ICommand command)
    {
        buttons[buttonIndex].UpdateCommand(command);
    }

    public ICommand GetButtonCommand(int buttonIndex)
    {
        return buttons[buttonIndex].GetCommand();
    }

    /// <summary>
    /// Rotates the button's command to the next one in line.
    /// </summary>
    /// <param name="buttonIndex">The index of the button to update.</param>
    public void NextCommand(int buttonIndex)
    {
        ICommand command;
        string previousCommand = buttons[buttonIndex].GetCommand().ToString();
        print(previousCommand);

        switch (previousCommand)
        {
            case "HoverPadOnCommand":
                command = new LightOnCommand(room.GetLight());
                break;
            case "LightOnCommand":
                command = new HoverPadOnCommand(room.GetHoverPad());
                break;
            default:
                command = null;
                break;
        }

        buttons[buttonIndex].UpdateCommand(command);
    }
}