/*****************************************************************************
// File Name :         GameManager.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    private bool gameOver;
    private bool gameWon;
    public bool GameOver { get { return gameOver; } }
    public bool GameWon { get { return gameWon; } }

    public void GameWin()
    {
        gameOver = true;
        gameWon = true;

        UIManager.Instance.GameWin();
    }

    public void GameLost()
    {
        gameOver = true;
        UIManager.Instance.GameLost();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
