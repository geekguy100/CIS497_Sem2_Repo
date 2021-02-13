/*****************************************************************************
// File Name :         GameManager.cs
// Author :            Kyle Grenier
// Creation Date :     02/13/2021
//
// Brief Description : Script to manage game state.
*****************************************************************************/
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool gameStarted = false;

    private void Update()
    {
        if (Input.GetButtonDown("Submit") && !gameStarted)
        {
            gameStarted = true;
            EventManager.GameStart();
        }
    }
}
