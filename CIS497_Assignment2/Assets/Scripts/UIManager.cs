/*****************************************************************************
// File Name :         UIManager.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : Handles updating game state text.
*****************************************************************************/
using UnityEngine;
using TMPro;

[RequireComponent(typeof(GameManager))]
public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject gameStateUI;
    [SerializeField] private GameObject tutorialUI;
    [SerializeField] private float hideTutorialTime = 7f;
    private TextMeshProUGUI gameStateText;

    private GameManager gm;

    private void Awake()
    {
        gameStateText = gameStateUI.GetComponentInChildren<TextMeshProUGUI>();

        gm = GetComponent<GameManager>();
        gm.OnGameOver += GameOver;
        gm.OnGameWin += GameWin;
    }

    private void OnDisable()
    {
        gm.OnGameOver -= GameOver;
        gm.OnGameWin -= GameWin;
    }

    private void Start()
    {
        Invoke("HideTutorial", hideTutorialTime);
    }

    private void HideTutorial()
    {
        tutorialUI.SetActive(false);
    }

    private void GameOver()
    {
        gameStateText.text = "GAME OVER!\nPress'R' to Retry\nPress 'ESC' to Quit";
        gameStateUI.SetActive(true);
    }

    private void GameWin()
    {
        gameStateText.text = "WINNER!\nPress'R' to Retry\nPress 'ESC' to Quit";
        gameStateUI.SetActive(true);
    }
}
