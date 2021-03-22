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

    [Tooltip("The text that displays above the button.")]
    [SerializeField] private TextMeshProUGUI commandText;

    private void Start()
    {
        if (storedCommand == null)
            commandText.text = string.Empty;
    }

    public void UpdateCommand(ICommand command)
    {
        storedCommand = command;
        commandText.text = storedCommand.GetDescription();
    }

    private void OnMouseDown()
    {
        storedCommand?.Execute();
    }
}