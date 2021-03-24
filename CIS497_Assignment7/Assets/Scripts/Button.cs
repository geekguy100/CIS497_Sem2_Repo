/*****************************************************************************
// File Name :         Button.cs
// Author :            Kyle Grenier
// Creation Date :     03/21/2021
//
// Brief Description : Defines the behaviour for pressing the in game control panel buttons.
*****************************************************************************/
using UnityEngine;
using TMPro;

public class Button : MonoBehaviour
{
    // This is the command that pressing this button will activate.
    private ICommand storedCommand;
    private int commandIndex = -1;

    [Tooltip("The text that displays above the button.")]
    [SerializeField] private TextMeshProUGUI commandText;

    public void UpdateCommand(ICommand command, int commandIndex)
    {
        if (command == null)
        {
            Debug.LogWarning(gameObject.name + ": Cannot update command because it does not exist.");
            return;
        }
        
        storedCommand = command;
        this.commandIndex = commandIndex;
        commandText.text = command.GetDescription();
    }

    private void OnMouseDown()
    {
        storedCommand?.Execute();
    }

    public int GetCommandIndex()
    {
        return commandIndex;
    }
}