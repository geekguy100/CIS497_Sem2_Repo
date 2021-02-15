/*****************************************************************************
// File Name :         GameManager.cs
// Author :            Kyle Grenier
// Creation Date :     02/13/2021
//
// Brief Description : Script to manage game state.
*****************************************************************************/
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameStarted = false;
    private bool tutorialStarted = false;

    private float loadSceneTime = 3f; //Time to wait before loading the scene on game end.




    private void Awake()
    {
        EventManager.OnGameLost += OnGameEnd;
        EventManager.OnGameWin += OnGameEnd;
    }

    private void OnDisable()
    {
        EventManager.OnGameLost -= OnGameEnd;
        EventManager.OnGameWin -= OnGameEnd;
    }




    private void Update()
    {
        //Display the tutorial if it has not been shown.
        if (Input.GetButtonDown("Submit") && !tutorialStarted)
        {
            tutorialStarted = true;
            EventManager.TutorialStart();
        }
        //Start the game after the tutorial is shown and player presses ENTER.
        else if (Input.GetButtonDown("Submit") && !gameStarted)
        {
            gameStarted = true;
            EventManager.GameStart();
        }
    }

    /// <summary>
    /// Reloads the scene on game win or loss.
    /// </summary>
    private void OnGameEnd()
    {
        StartCoroutine(LoadSceneAfterTime(SceneManager.GetActiveScene().name, loadSceneTime));
    }

    /// <summary>
    /// Loads a scene after the given amount of time.
    /// </summary>
    /// <param name="sceneName">The name of the scene to load.</param>
    /// <param name="time">he time to wait before the scene loads.</param>
    private IEnumerator LoadSceneAfterTime(string sceneName, float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(sceneName);
    }
}