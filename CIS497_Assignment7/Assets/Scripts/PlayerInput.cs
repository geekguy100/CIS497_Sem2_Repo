/*****************************************************************************
// File Name :         PlayerInput.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private RemoteControl remoteControl;

    private void Start()
    {
        remoteControl = FindObjectOfType<RemoteControl>();
        print(remoteControl == null);
    }

    private void Update()
    {
        
    }
}
