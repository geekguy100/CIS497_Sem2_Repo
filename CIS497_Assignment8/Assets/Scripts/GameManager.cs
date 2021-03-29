/*****************************************************************************
// File Name :         GameManager.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{
    private bool gameOver = false;
    public bool GameOver { get { return gameOver; } }

    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    #region --- Events ---
    private void OnEnable()
    {
        EventManager.OnGameOver += SetGameOver;
        EventManager.OnGameOver += Restart;
    }

    private void OnDisable()
    {
        EventManager.OnGameOver -= SetGameOver;
        EventManager.OnGameOver -= Restart;
    }
    #endregion

    private void SetGameOver()
    {
        print("game over");
        gameOver = true;
    }

    private void Restart()
    {
        StartCoroutine(RestartAfterTime());
    }

    private IEnumerator RestartAfterTime()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}