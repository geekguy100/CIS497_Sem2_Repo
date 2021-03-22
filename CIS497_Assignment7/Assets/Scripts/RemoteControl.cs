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

    private void Awake()
    {
        buttons = GetComponentsInChildren<Button>();
    }

    public void UpdateCommand(int buttonIndex, ICommand command)
    {
        buttons[buttonIndex].UpdateCommand(command);
    }
}