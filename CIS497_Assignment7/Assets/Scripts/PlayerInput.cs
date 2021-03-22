/*****************************************************************************
// File Name :         PlayerInput.cs
// Author :            Kyle Grenier
// Creation Date :     03/22/2021
//
// Brief Description : Manages exeuting behaviours based on player input.
*****************************************************************************/
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private RemoteControl remoteControl;

    private void Awake()
    {
        remoteControl = FindObjectOfType<RemoteControl>();
    }

    private void Update()
    {
        // Getting player input.
        if (Input.GetKeyDown(KeyCode.Alpha1))
            remoteControl.NextCommand(0);
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            remoteControl.NextCommand(1);
        else if (Input.GetKeyDown(KeyCode.Alpha3))
            remoteControl.NextCommand(2);
    }
}