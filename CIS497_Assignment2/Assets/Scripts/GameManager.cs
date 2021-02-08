/*****************************************************************************
// File Name :         GameManager.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : Handles managing the game state and updating game state text.
*****************************************************************************/
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(ScoreManager))]
public class GameManager : MonoBehaviour
{
    private ScoreManager scoreManager;

    public delegate void GameOverHandler();
    public event GameOverHandler OnGameOver;
    public event GameOverHandler OnGameWin;

    private void Awake()
    {
        //Subscribe to the ScoreManager's OnWinningScoreAchieved event so we know when we get the winning score.
        scoreManager = GetComponent<ScoreManager>();
        scoreManager.OnWinningScoreAchieved += GameWin;

        //Subscribe to the player's OnDeath event, so our GameOver function will be called when the player dies.
        GameObject.FindGameObjectWithTag("Player").GetComponent<Health>().OnDeath += GameOver;
    }

    public void GameOver()
    {
        OnGameOver?.Invoke();
    }

    public void GameWin()
    {
        OnGameWin?.Invoke();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            RestartScene();

        if (Input.GetKeyDown(KeyCode.Escape))
            QuitGame();

    }

    private void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void QuitGame()
    {
        Application.Quit();
    }
}
