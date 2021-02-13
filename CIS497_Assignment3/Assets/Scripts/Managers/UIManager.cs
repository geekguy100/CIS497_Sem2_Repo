/*****************************************************************************
// File Name :         UIManager.cs
// Author :            Kyle Grenier
// Creation Date :     02/13/2021
//
// Brief Description : Script that manages updating UI.
*****************************************************************************/
using UnityEngine;
using TMPro;
using System.Collections;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI titleText;
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Awake()
    {
        EventManager.OnScoreChange += UpdateScoreText;
    }

    public void UpdateScoreText(int score)
    {
        scoreText.text = "Score: " + score;
    }
}
