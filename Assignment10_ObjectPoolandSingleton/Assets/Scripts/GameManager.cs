/*****************************************************************************
// File Name :         GameManager.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

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

        StartCoroutine(WaitThenReload());
    }

    public void GameLost()
    {
        gameOver = true;
        UIManager.Instance.GameLost();

        StartCoroutine(WaitThenReload());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            ReloadScene();
    }

    private IEnumerator WaitThenReload()
    {
        yield return new WaitForSeconds(3f);
        ReloadScene();
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
