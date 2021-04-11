/*****************************************************************************
// File Name :         UIManager.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;
using TMPro;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI gameStatusText;

    private void Start()
    {
        UpdateScoreText(0);
    }

    public void UpdateScoreText(int score)
    {
        scoreText.text = "Score: " + score;
    }

    public void GameWin()
    {
        gameStatusText.text = "GAME WIN";
        gameStatusText.gameObject.SetActive(true);
    }

    public void GameLost()
    {
        gameStatusText.text = "GAME LOST";
        gameStatusText.gameObject.SetActive(true);
    }
}